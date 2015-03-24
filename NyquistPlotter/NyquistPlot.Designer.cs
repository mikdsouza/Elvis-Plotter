namespace NyquistPlotter
{
    partial class NyquistPlot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ofdImportBode = new System.Windows.Forms.OpenFileDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTheoraticalPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmsChart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatAxlisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nyquistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badeAmplitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdChart = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChart)).BeginInit();
            this.cmsChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImportBode
            // 
            this.ofdImportBode.Title = "Open Bode Points";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(781, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.addTheoraticalPlotToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // addTheoraticalPlotToolStripMenuItem
            // 
            this.addTheoraticalPlotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAToolStripMenuItem,
            this.filterBToolStripMenuItem,
            this.filterCToolStripMenuItem,
            this.filterDToolStripMenuItem});
            this.addTheoraticalPlotToolStripMenuItem.Name = "addTheoraticalPlotToolStripMenuItem";
            this.addTheoraticalPlotToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addTheoraticalPlotToolStripMenuItem.Text = "Add Theoratical Plot";
            // 
            // filterAToolStripMenuItem
            // 
            this.filterAToolStripMenuItem.Name = "filterAToolStripMenuItem";
            this.filterAToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.filterAToolStripMenuItem.Text = "Filter A";
            this.filterAToolStripMenuItem.Click += new System.EventHandler(this.filterAToolStripMenuItem_Click);
            // 
            // filterBToolStripMenuItem
            // 
            this.filterBToolStripMenuItem.Name = "filterBToolStripMenuItem";
            this.filterBToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.filterBToolStripMenuItem.Text = "Filter B";
            this.filterBToolStripMenuItem.Click += new System.EventHandler(this.filterBToolStripMenuItem_Click);
            // 
            // filterCToolStripMenuItem
            // 
            this.filterCToolStripMenuItem.Name = "filterCToolStripMenuItem";
            this.filterCToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.filterCToolStripMenuItem.Text = "Filter C";
            this.filterCToolStripMenuItem.Click += new System.EventHandler(this.filterCToolStripMenuItem_Click);
            // 
            // filterDToolStripMenuItem
            // 
            this.filterDToolStripMenuItem.Name = "filterDToolStripMenuItem";
            this.filterDToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.filterDToolStripMenuItem.Text = "Filter D";
            this.filterDToolStripMenuItem.Click += new System.EventHandler(this.filterDToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cChart
            // 
            chartArea1.AxisX.Title = "Real(Gain)";
            chartArea1.AxisY.Title = "Im(Gain)";
            chartArea1.Name = "caNyquist";
            chartArea2.AxisX.IsLogarithmic = true;
            chartArea2.AxisX.Maximum = 1000000D;
            chartArea2.AxisX.Minimum = 100D;
            chartArea2.AxisX.Title = "Frequency (Hz)";
            chartArea2.AxisX2.IsLogarithmic = true;
            chartArea2.AxisX2.Maximum = 1000000D;
            chartArea2.AxisX2.Minimum = 100D;
            chartArea2.AxisY.Title = "Gain (dB)";
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY2.Title = "Phase (deg)";
            chartArea2.Name = "caBode";
            chartArea2.Visible = false;
            this.cChart.ChartAreas.Add(chartArea1);
            this.cChart.ChartAreas.Add(chartArea2);
            this.cChart.ContextMenuStrip = this.cmsChart;
            this.cChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend2.Name = "Legend2";
            this.cChart.Legends.Add(legend1);
            this.cChart.Legends.Add(legend2);
            this.cChart.Location = new System.Drawing.Point(0, 24);
            this.cChart.Name = "cChart";
            series1.ChartArea = "caNyquist";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend2";
            series1.LegendText = "Exp. Nyquist Plot";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "sPlot";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.BorderWidth = 3;
            series2.ChartArea = "caNyquist";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend2";
            series2.LegendText = "Theo. Nyquist Plot";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "sTheoPlot";
            series3.ChartArea = "caBode";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Exp. Bode Amplitude";
            series3.MarkerSize = 7;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "sBodeAmp";
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series4.ChartArea = "caBode";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Theo. Bode Amplitude";
            series4.MarkerSize = 7;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "sTheoBodeAmp";
            series5.ChartArea = "caBode";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "Exp. Bode Phase";
            series5.MarkerSize = 7;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series5.Name = "sBodePhase";
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series6.ChartArea = "caBode";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "Theo. Bode Phase";
            series6.MarkerSize = 7;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series6.Name = "sTheoBodePhase";
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.cChart.Series.Add(series1);
            this.cChart.Series.Add(series2);
            this.cChart.Series.Add(series3);
            this.cChart.Series.Add(series4);
            this.cChart.Series.Add(series5);
            this.cChart.Series.Add(series6);
            this.cChart.Size = new System.Drawing.Size(781, 552);
            this.cChart.TabIndex = 1;
            this.cChart.Text = "cChart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "title";
            title1.Text = "Nyquist Plot";
            this.cChart.Titles.Add(title1);
            // 
            // cmsChart
            // 
            this.cmsChart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.formatAxlisToolStripMenuItem,
            this.toolStripSeparator1,
            this.nyquistToolStripMenuItem,
            this.badeAmplitudeToolStripMenuItem});
            this.cmsChart.Name = "cmsChart";
            this.cmsChart.Size = new System.Drawing.Size(174, 120);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveToFileToolStripMenuItem.Text = "&Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // formatAxlisToolStripMenuItem
            // 
            this.formatAxlisToolStripMenuItem.Name = "formatAxlisToolStripMenuItem";
            this.formatAxlisToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.formatAxlisToolStripMenuItem.Text = "Format &Axis";
            this.formatAxlisToolStripMenuItem.Click += new System.EventHandler(this.formatAxlisToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // nyquistToolStripMenuItem
            // 
            this.nyquistToolStripMenuItem.Name = "nyquistToolStripMenuItem";
            this.nyquistToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nyquistToolStripMenuItem.Text = "Nyquist";
            this.nyquistToolStripMenuItem.Click += new System.EventHandler(this.nyquistToolStripMenuItem_Click);
            // 
            // badeAmplitudeToolStripMenuItem
            // 
            this.badeAmplitudeToolStripMenuItem.Name = "badeAmplitudeToolStripMenuItem";
            this.badeAmplitudeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.badeAmplitudeToolStripMenuItem.Text = "Bode";
            this.badeAmplitudeToolStripMenuItem.Click += new System.EventHandler(this.badeAmplitudeToolStripMenuItem_Click);
            // 
            // sfdChart
            // 
            this.sfdChart.DefaultExt = "png";
            this.sfdChart.Filter = "PNG Image (*.png)|*.png";
            this.sfdChart.Title = "Save Image";
            // 
            // NyquistPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 576);
            this.Controls.Add(this.cChart);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "NyquistPlot";
            this.Text = "Nyquist Plotter";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChart)).EndInit();
            this.cmsChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImportBode;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart cChart;
        private System.Windows.Forms.ContextMenuStrip cmsChart;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdChart;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatAxlisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTheoraticalPlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nyquistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badeAmplitudeToolStripMenuItem;

    }
}

