using NyquistPlotter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NyquistPlotter
{
    public partial class NyquistPlot : Form
    {
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
                string parsedLine = Regex.Replace(line, @"\s+", " ");

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

            foreach(BodePoint point in points)
            {
                cChart.Series[0].Points.AddXY(point.Value.Real, point.Value.Imaginary);
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

        private void filterAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakePlot(i => Complex.One / (Complex.One - new Complex(0, (double)i / 5e+3)));
        }

        private void MakePlot(Func<int, Complex> transferFunction)
        {
            cChart.Series[1].Points.Clear();

            for (int i = 100; i <= 1000000; i = DecadeStep(i))
            {
                Complex res = transferFunction(i);
                cChart.Series[1].Points.AddXY(res.Real, res.Imaginary);
            }
        }

        private int DecadeStep(int step)
        {
            int power = (int)Math.Log10(step);
            int decade = (int)Math.Pow(10, power);

            return decade * (step / decade + 1);
        }

        private void filterBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakePlot(i => Complex.One / (Complex.One + new Complex(0, (double)i / 5e+3)));
        }

        private void filterCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complex R2 = new Complex(301.1, 0);
            Complex omegaC = new Complex(0, 2 * Math.PI * 25.2e-9);
            Complex omegaL = new Complex(0, 2 * Math.PI * 11.1e-3);
            Complex Rp = new Complex(20.5, 0);
            
            MakePlot((int i) => R2 / (R2 + (Rp / (Complex.One + new Complex(0, Rp.Real) * (omegaC * i - Complex.One / (omegaL * i))))));
        }

        private void filterDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complex R1 = new Complex(82, 0);
            Complex omegaC = new Complex(0, 2 * Math.PI * 25.2e-9);
            Complex omegaL = new Complex(0, 2 * Math.PI * 11.1e-3);
            Complex Rs = new Complex(500, 0);

            MakePlot((int i) => R1 / (R1 + (Rs * (Complex.One + Complex.ImaginaryOne*((omegaL * i)/Rs - Complex.One/(omegaC * i * Rs))))));
        }
    }
}
