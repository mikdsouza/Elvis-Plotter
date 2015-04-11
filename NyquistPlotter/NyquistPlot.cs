using Microsoft.VisualBasic;
using NyquistPlotter.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NyquistPlotter
{
    public partial class NyquistPlot : Form
    {
        private Func<double, Complex> s = (double i) => new Complex(0, 2 * Math.PI * i);

        public NyquistPlot()
        {
            InitializeComponent();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdImportBode.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PlotBodePoints(ImportFile(ofdImportBode.FileName));
            }
        }

        private List<BodePoint> ImportFile(string filename)
        {
            List<string> lines = System.IO.File.ReadAllLines(filename).ToList();

            //First 3 lines are uninteresting
            lines.RemoveAt(0);
            lines.RemoveAt(0);
            lines.RemoveAt(0);

            //Check that there actually is some data in here
            if (lines.Count < 1)
                throw new ArgumentException("File doesn't contain any data");

            List<BodePoint> result = new List<BodePoint>();

            foreach(string line in lines)
            {
                //Get rid of spaces
                string parsedLine = Regex.Replace(line.Trim(), @"\s+", " ");

                string[] values = parsedLine.Split(' ');
                BodePoint point = new BodePoint 
                    { 
                        Frequency = double.Parse(values[0]), 
                        GainDB = double.Parse(values[1]), 
                        PhaseDeg = double.Parse(values[2]) 
                    };
                result.Add(point);
            }

            return result;
        }
        
        private void PlotBodePoints(List<BodePoint> points)
        {
            cChart.Series[0].Points.Clear();
            cChart.Series[2].Points.Clear();
            cChart.Series[4].Points.Clear();

            foreach(BodePoint point in points)
            {
                cChart.Series[0].Points.AddXY(point.Value.Real, point.Value.Imaginary);
                cChart.Series[2].Points.AddXY(point.Frequency, point.GainDB);
                cChart.Series[4].Points.AddXY(point.Frequency, point.PhaseDeg);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                cChart.SaveImage(ms, ChartImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdChart.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cChart.SaveImage(new FileStream(sfdChart.FileName, FileMode.Create), ChartImageFormat.Png);
            }
        }

        private void formatAxlisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartOptions options = new ChartOptions()
                {
                    MinX = cChart.ChartAreas[0].AxisX.Minimum,
                    MaxX = cChart.ChartAreas[0].AxisX.Maximum,
                    MinY = cChart.ChartAreas[0].AxisY.Minimum,
                    MaxY = cChart.ChartAreas[0].AxisY.Maximum
                };

            if (options.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cChart.ChartAreas[0].AxisX.Minimum = options.MinX;
                cChart.ChartAreas[0].AxisX.Maximum = options.MaxX;
                
                if (options.AutoX)
                {
                    cChart.ChartAreas[0].AxisX.Maximum = double.NaN;
                }

                cChart.ChartAreas[0].AxisY.Minimum = options.MinY;
                cChart.ChartAreas[0].AxisY.Maximum = options.MaxY;

                if (options.AutoY)
                {
                    cChart.ChartAreas[0].AxisY.Maximum = double.NaN;
                }
            }
        }

        private void MakeTheoNyquistPlot(Func<double, Complex> transferFunction)
        {
            cChart.Series[1].Points.Clear();

            foreach (double i in logspace(10, 1e6, 100))
            {
                Complex res = transferFunction(i);
                cChart.Series[1].Points.AddXY(res.Real, res.Imaginary);
            }
        }

        private void MakeTheoBode(Func<double, Complex> transferFunction)
        {
            cChart.Series[3].Points.Clear();
            cChart.Series[5].Points.Clear();

            foreach(double i in logspace(100, 1e6, 100))
            {
                Complex res = transferFunction(i);
                cChart.Series[3].Points.AddXY(i, 20 * Math.Log10(res.Magnitude));
                cChart.Series[5].Points.AddXY(i, res.Phase * 180 / Math.PI);
            }
        }

        private void MakePlots(Func<double, Complex> transferFunction)
        {
            MakeTheoNyquistPlot(transferFunction);
            MakeTheoBode(transferFunction);
        }

        private int DecadeStep(int step)
        {
            int power = (int)Math.Log10(step);
            int decade = (int)Math.Pow(10, power);

            return decade * (step / decade + 1);
        }

        private void filterAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakePlots(i => Complex.One / (Complex.One - new Complex(0, 5e+3 / (double)i)));
        }

        private void filterBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakePlots(i => Complex.One / (Complex.One + new Complex(0, (double)i / 5e+3)));
        }

        private void filterCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complex R2 = new Complex(301.1, 0);
            Complex omegaC = new Complex(2 * Math.PI * 25.2e-9, 0);
            Complex omegaL = new Complex(2 * Math.PI * 11.1e-3, 0);
            Complex Rp = new Complex(6724.32, 0);

            MakePlots((double i) => R2 / (R2 + (Rp / (Complex.One + new Complex(0, Rp.Real) * (omegaC * i - Complex.One / (omegaL * i))))));
        }

        private void filterDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complex R1 = new Complex(82, 0);
            Complex omegaC = new Complex(2 * Math.PI * 25.2e-9, 0);
            Complex omegaL = new Complex(2 * Math.PI * 11.1e-3, 0);
            Complex Rs = new Complex(52.72, 0);

            MakePlots((double i) => R1 / (R1 + (Rs * (Complex.One + Complex.ImaginaryOne * ((omegaL * i) / Rs - Complex.One / (omegaC * i * Rs))))));
        }

        private void nyquistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnablePlot("caNyquist", "Nyquist Plot");
            cChart.Legends[0].Enabled = false;
            cChart.Legends[1].Enabled = true;
        }

        private void EnablePlot(string name, string title)
        {
            cChart.Titles[0].Text = title;

            cChart.ChartAreas.ToList().ForEach(a => a.Visible = a.Name == name);
        }

        private void badeAmplitudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnablePlot("caBode", "Bode Plot");
            cChart.Legends[0].Enabled = true;
            cChart.Legends[1].Enabled = false;
        }

        // From http://stackoverflow.com/a/16491073/4332933
        public IEnumerable<double> logspace(double start, double end, int count)
        {
            double d = (double)count, p = end / start;
            return Enumerable.Range(0, count).Select(i => start * Math.Pow(p, i / d));
        }

        private void pLowPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double R = 56e3;
            double C = 4.7e-9;
            double oneOverRC = 1 / (R * C);

            MakePlots((double i) => oneOverRC / (s(i) + oneOverRC));
        }

        private void p1ZHighPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double R = 56e3;
            double C = 4.7e-9;

            MakePlots((double i) => s(i) / (s(i) + 1 / (R * C)));
        }

        private void z1PHighPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double R1 = 220e3;
            double R2 = 18e3;
            Complex omegaC = new Complex(0, 2 * Math.PI * 4.7e-9);
            Func<double, Complex> Rp = (double i) => (R1 * 1 / (omegaC * i)) / (R1 + 1 / (omegaC * i));

            MakePlots((double i) => 1 / (1 + Rp(i) / R2));
        }

        private void z1PLowPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double R1 = 18e3;
            double R2 = 220e3;
            Func<double, Complex> Xc = (double i) => 1 / new Complex(0, 2 * Math.PI * i * 4.7e-9);
            Func<double, Complex> Rs = (double i) => R1 + Xc(i);

            MakePlots((double i) => 1 / (1 + R2 / Rs(i)));
        }

        private static DialogResult ShowInputDialog(ref string input, string title)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ControlBox = false;
            inputBox.ClientSize = size;
            inputBox.Text = title;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void lowPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = "10000";

            if (ShowInputDialog(ref input, "R2 in Ohms") == DialogResult.Cancel)
                return;

            Func<double, Complex> s = (double i) => new Complex(0, 2 * Math.PI * i);
            double R = 56e3;
            double R1 = 47e3;
            double R2 = double.Parse(input);
            double C = 4.7e-9;

            MakePlots((double i) => ((1 / (R * R * C * C)) / (s(i) * s(i) + R1 * s(i) / (R2 * R * C) + 1 / (R * R * C * C))));
        }

        private void bandPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = "10000";

            if (ShowInputDialog(ref input, "R2 in Ohms") == DialogResult.Cancel)
                return;

            Func<double, Complex> s = (double i) => new Complex(0, 2 * Math.PI * i);
            double R = 56e3;
            double R1 = 47e3;
            double R2 = double.Parse(input);
            double C = 4.7e-9;

            MakePlots((double i) => ((s(i) / (R * C)) / (s(i) * s(i) + R1 * s(i) / (R2 * R * C) + 1 / (R * R * C * C))));
        }

        private void highPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = "10000";

            if (ShowInputDialog(ref input, "R2 in Ohms") == DialogResult.Cancel)
                return;

            Func<double, Complex> s = (double i) => new Complex(0, 2 * Math.PI * i);
            double R = 56e3;
            double R1 = 47e3;
            double R2 = double.Parse(input);
            double C = 4.7e-9;

            MakePlots((double i) => ((s(i) * s(i)) / (s(i) * s(i) + R1 * s(i) / (R2 * R * C) + 1 / (R * R * C * C))));
        }

        private void ClearBodePlots()
        {
            for (int i = 2; i <= 5; i++)
            {
                cChart.Series[i].Points.Clear();
            }
        }

        private void pLPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBodePlots();

            double pole1 = 600;

            // Magnitude
            cChart.Series[3].Points.AddXY(100, 0);
            cChart.Series[3].Points.AddXY(pole1, 0);
            double freq = pole1;
            double amp = 0;

            do
            {
                freq *= 10;
                amp -= 20;
                cChart.Series[3].Points.AddXY(freq, amp);
            } while (freq <= 1e6);

            // Phase

            cChart.Series[5].Points.AddXY(pole1 / 10, 0);
            cChart.Series[5].Points.AddXY(pole1, -45);
            cChart.Series[5].Points.AddXY(pole1 *10, -90);
            cChart.Series[5].Points.AddXY(1e6, -90);
        }

        private void p1ZHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBodePlots();

            double pole1 = 600;

            // Magnitude
            cChart.Series[3].Points.AddXY(1e6, 0);
            cChart.Series[3].Points.AddXY(pole1, 0);
            double freq = pole1;
            double amp = 0;

            do
            {
                freq /= 10;
                amp -= 20;
                cChart.Series[3].Points.AddXY(freq, amp);
            } while (freq > 100);

            // Phase

            cChart.Series[5].Points.AddXY(pole1 / 10, 90);
            cChart.Series[5].Points.AddXY(pole1, 45);
            cChart.Series[5].Points.AddXY(pole1 * 10, 0);
            cChart.Series[5].Points.AddXY(1e6, 0);
        }
    }
}
