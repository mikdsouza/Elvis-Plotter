using NyquistPlotter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
    }
}
