﻿namespace NyquistPlotter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ofdImportBode = new System.Windows.Forms.OpenFileDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTheoraticalPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pLowPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1ZHighPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.z1PHighPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.z1PLowPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.guidelinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1ZHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menu.Size = new System.Drawing.Size(604, 24);
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
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.addTheoraticalPlotToolStripMenuItem.Name = "addTheoraticalPlotToolStripMenuItem";
            this.addTheoraticalPlotToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addTheoraticalPlotToolStripMenuItem.Text = "Add Theoratical Plot";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAToolStripMenuItem,
            this.filterBToolStripMenuItem,
            this.filterCToolStripMenuItem,
            this.filterDToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "361";
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLowPassToolStripMenuItem,
            this.p1ZHighPassToolStripMenuItem,
            this.z1PHighPassToolStripMenuItem,
            this.z1PLowPassToolStripMenuItem,
            this.activeFilterToolStripMenuItem,
            this.guidelinesToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "363";
            // 
            // pLowPassToolStripMenuItem
            // 
            this.pLowPassToolStripMenuItem.Name = "pLowPassToolStripMenuItem";
            this.pLowPassToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pLowPassToolStripMenuItem.Text = "1P Low-Pass";
            this.pLowPassToolStripMenuItem.Click += new System.EventHandler(this.pLowPassToolStripMenuItem_Click);
            // 
            // p1ZHighPassToolStripMenuItem
            // 
            this.p1ZHighPassToolStripMenuItem.Name = "p1ZHighPassToolStripMenuItem";
            this.p1ZHighPassToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.p1ZHighPassToolStripMenuItem.Text = "1P1Z High-Pass";
            this.p1ZHighPassToolStripMenuItem.Click += new System.EventHandler(this.p1ZHighPassToolStripMenuItem_Click);
            // 
            // z1PHighPassToolStripMenuItem
            // 
            this.z1PHighPassToolStripMenuItem.Name = "z1PHighPassToolStripMenuItem";
            this.z1PHighPassToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.z1PHighPassToolStripMenuItem.Text = "1Z1P High-Pass";
            this.z1PHighPassToolStripMenuItem.Click += new System.EventHandler(this.z1PHighPassToolStripMenuItem_Click);
            // 
            // z1PLowPassToolStripMenuItem
            // 
            this.z1PLowPassToolStripMenuItem.Name = "z1PLowPassToolStripMenuItem";
            this.z1PLowPassToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.z1PLowPassToolStripMenuItem.Text = "1Z1P Low-Pass";
            this.z1PLowPassToolStripMenuItem.Click += new System.EventHandler(this.z1PLowPassToolStripMenuItem_Click);
            // 
            // activeFilterToolStripMenuItem
            // 
            this.activeFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowPassToolStripMenuItem,
            this.bandPassToolStripMenuItem,
            this.highPassToolStripMenuItem});
            this.activeFilterToolStripMenuItem.Name = "activeFilterToolStripMenuItem";
            this.activeFilterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.activeFilterToolStripMenuItem.Text = "Active Filters";
            // 
            // lowPassToolStripMenuItem
            // 
            this.lowPassToolStripMenuItem.Name = "lowPassToolStripMenuItem";
            this.lowPassToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.lowPassToolStripMenuItem.Text = "Low-Pass";
            this.lowPassToolStripMenuItem.Click += new System.EventHandler(this.lowPassToolStripMenuItem_Click);
            // 
            // bandPassToolStripMenuItem
            // 
            this.bandPassToolStripMenuItem.Name = "bandPassToolStripMenuItem";
            this.bandPassToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bandPassToolStripMenuItem.Text = "Band-Pass";
            this.bandPassToolStripMenuItem.Click += new System.EventHandler(this.bandPassToolStripMenuItem_Click);
            // 
            // highPassToolStripMenuItem
            // 
            this.highPassToolStripMenuItem.Name = "highPassToolStripMenuItem";
            this.highPassToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.highPassToolStripMenuItem.Text = "High-Pass";
            this.highPassToolStripMenuItem.Click += new System.EventHandler(this.highPassToolStripMenuItem_Click);
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
            chartArea3.AxisX.Title = "Real(Gain)";
            chartArea3.AxisY.Title = "Im(Gain)";
            chartArea3.Name = "caNyquist";
            chartArea4.AxisX.IsLogarithmic = true;
            chartArea4.AxisX.Maximum = 1000000D;
            chartArea4.AxisX.Minimum = 100D;
            chartArea4.AxisX.Title = "Frequency (Hz)";
            chartArea4.AxisX2.IsLogarithmic = true;
            chartArea4.AxisX2.Maximum = 1000000D;
            chartArea4.AxisX2.Minimum = 100D;
            chartArea4.AxisY.Title = "Gain (dB)";
            chartArea4.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY2.Title = "Phase (deg)";
            chartArea4.Name = "caBode";
            chartArea4.Visible = false;
            this.cChart.ChartAreas.Add(chartArea3);
            this.cChart.ChartAreas.Add(chartArea4);
            this.cChart.ContextMenuStrip = this.cmsChart;
            this.cChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Enabled = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend3.Name = "Legend1";
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend4.Name = "Legend2";
            this.cChart.Legends.Add(legend3);
            this.cChart.Legends.Add(legend4);
            this.cChart.Location = new System.Drawing.Point(0, 24);
            this.cChart.Name = "cChart";
            series7.ChartArea = "caNyquist";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend2";
            series7.LegendText = "Exp. Nyquist Plot";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series7.Name = "sPlot";
            series8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series8.BorderWidth = 3;
            series8.ChartArea = "caNyquist";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend2";
            series8.LegendText = "Theo. Nyquist Plot";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "sTheoPlot";
            series9.ChartArea = "caBode";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.LegendText = "Exp. Bode Amplitude";
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series9.Name = "sBodeAmp";
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series10.ChartArea = "caBode";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series10.Legend = "Legend1";
            series10.LegendText = "Theo. Bode Amplitude";
            series10.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "sTheoBodeAmp";
            series11.ChartArea = "caBode";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series11.Legend = "Legend1";
            series11.LegendText = "Exp. Bode Phase";
            series11.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series11.Name = "sBodePhase";
            series11.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series12.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series12.ChartArea = "caBode";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.LegendText = "Theo. Bode Phase";
            series12.MarkerColor = System.Drawing.Color.Blue;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series12.Name = "sTheoBodePhase";
            series12.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.cChart.Series.Add(series7);
            this.cChart.Series.Add(series8);
            this.cChart.Series.Add(series9);
            this.cChart.Series.Add(series10);
            this.cChart.Series.Add(series11);
            this.cChart.Series.Add(series12);
            this.cChart.Size = new System.Drawing.Size(604, 557);
            this.cChart.TabIndex = 1;
            this.cChart.Text = "cChart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "title";
            title2.Text = "Nyquist Plot";
            this.cChart.Titles.Add(title2);
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
            // guidelinesToolStripMenuItem
            // 
            this.guidelinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLPToolStripMenuItem,
            this.p1ZHPToolStripMenuItem});
            this.guidelinesToolStripMenuItem.Name = "guidelinesToolStripMenuItem";
            this.guidelinesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.guidelinesToolStripMenuItem.Text = "Guidelines";
            // 
            // pLPToolStripMenuItem
            // 
            this.pLPToolStripMenuItem.Name = "pLPToolStripMenuItem";
            this.pLPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pLPToolStripMenuItem.Text = "1PLP";
            this.pLPToolStripMenuItem.Click += new System.EventHandler(this.pLPToolStripMenuItem_Click);
            // 
            // p1ZHPToolStripMenuItem
            // 
            this.p1ZHPToolStripMenuItem.Name = "p1ZHPToolStripMenuItem";
            this.p1ZHPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.p1ZHPToolStripMenuItem.Text = "1P1ZHP";
            this.p1ZHPToolStripMenuItem.Click += new System.EventHandler(this.p1ZHPToolStripMenuItem_Click);
            // 
            // NyquistPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 581);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pLowPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p1ZHighPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem z1PHighPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem z1PLowPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guidelinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p1ZHPToolStripMenuItem;

    }
}

