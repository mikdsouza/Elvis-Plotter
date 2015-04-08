namespace NyquistPlotter
{
    partial class ChartOptions
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
            this.gbX = new System.Windows.Forms.GroupBox();
            this.chkXAuto = new System.Windows.Forms.CheckBox();
            this.tbXMax = new System.Windows.Forms.TextBox();
            this.tbXMin = new System.Windows.Forms.TextBox();
            this.lXMax = new System.Windows.Forms.Label();
            this.lXMin = new System.Windows.Forms.Label();
            this.gbY = new System.Windows.Forms.GroupBox();
            this.chkYAuto = new System.Windows.Forms.CheckBox();
            this.tbYMax = new System.Windows.Forms.TextBox();
            this.tbYMin = new System.Windows.Forms.TextBox();
            this.lYMax = new System.Windows.Forms.Label();
            this.lYMin = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.gbX.SuspendLayout();
            this.gbY.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbX
            // 
            this.gbX.Controls.Add(this.chkXAuto);
            this.gbX.Controls.Add(this.tbXMax);
            this.gbX.Controls.Add(this.tbXMin);
            this.gbX.Controls.Add(this.lXMax);
            this.gbX.Controls.Add(this.lXMin);
            this.gbX.Location = new System.Drawing.Point(12, 12);
            this.gbX.Name = "gbX";
            this.gbX.Size = new System.Drawing.Size(136, 100);
            this.gbX.TabIndex = 0;
            this.gbX.TabStop = false;
            this.gbX.Text = "X-Axis";
            // 
            // chkXAuto
            // 
            this.chkXAuto.AutoSize = true;
            this.chkXAuto.Location = new System.Drawing.Point(52, 72);
            this.chkXAuto.Name = "chkXAuto";
            this.chkXAuto.Size = new System.Drawing.Size(78, 17);
            this.chkXAuto.TabIndex = 4;
            this.chkXAuto.Text = "Auto Scale";
            this.chkXAuto.UseVisualStyleBackColor = true;
            this.chkXAuto.CheckedChanged += new System.EventHandler(this.chkXAuto_CheckedChanged);
            // 
            // tbXMax
            // 
            this.tbXMax.Location = new System.Drawing.Point(60, 46);
            this.tbXMax.Name = "tbXMax";
            this.tbXMax.Size = new System.Drawing.Size(69, 20);
            this.tbXMax.TabIndex = 3;
            // 
            // tbXMin
            // 
            this.tbXMin.Location = new System.Drawing.Point(60, 20);
            this.tbXMin.Name = "tbXMin";
            this.tbXMin.Size = new System.Drawing.Size(69, 20);
            this.tbXMin.TabIndex = 2;
            // 
            // lXMax
            // 
            this.lXMax.AutoSize = true;
            this.lXMax.Location = new System.Drawing.Point(3, 49);
            this.lXMax.Name = "lXMax";
            this.lXMax.Size = new System.Drawing.Size(51, 13);
            this.lXMax.TabIndex = 1;
            this.lXMax.Text = "Maximum";
            // 
            // lXMin
            // 
            this.lXMin.AutoSize = true;
            this.lXMin.Location = new System.Drawing.Point(6, 23);
            this.lXMin.Name = "lXMin";
            this.lXMin.Size = new System.Drawing.Size(48, 13);
            this.lXMin.TabIndex = 0;
            this.lXMin.Text = "Minimum";
            // 
            // gbY
            // 
            this.gbY.Controls.Add(this.chkYAuto);
            this.gbY.Controls.Add(this.tbYMax);
            this.gbY.Controls.Add(this.tbYMin);
            this.gbY.Controls.Add(this.lYMax);
            this.gbY.Controls.Add(this.lYMin);
            this.gbY.Location = new System.Drawing.Point(154, 12);
            this.gbY.Name = "gbY";
            this.gbY.Size = new System.Drawing.Size(136, 100);
            this.gbY.TabIndex = 5;
            this.gbY.TabStop = false;
            this.gbY.Text = "Y-Axis";
            // 
            // chkYAuto
            // 
            this.chkYAuto.AutoSize = true;
            this.chkYAuto.Location = new System.Drawing.Point(52, 72);
            this.chkYAuto.Name = "chkYAuto";
            this.chkYAuto.Size = new System.Drawing.Size(78, 17);
            this.chkYAuto.TabIndex = 4;
            this.chkYAuto.Text = "Auto Scale";
            this.chkYAuto.UseVisualStyleBackColor = true;
            this.chkYAuto.CheckedChanged += new System.EventHandler(this.chkYAuto_CheckedChanged);
            // 
            // tbYMax
            // 
            this.tbYMax.Location = new System.Drawing.Point(60, 46);
            this.tbYMax.Name = "tbYMax";
            this.tbYMax.Size = new System.Drawing.Size(69, 20);
            this.tbYMax.TabIndex = 3;
            // 
            // tbYMin
            // 
            this.tbYMin.Location = new System.Drawing.Point(60, 20);
            this.tbYMin.Name = "tbYMin";
            this.tbYMin.Size = new System.Drawing.Size(69, 20);
            this.tbYMin.TabIndex = 2;
            // 
            // lYMax
            // 
            this.lYMax.AutoSize = true;
            this.lYMax.Location = new System.Drawing.Point(3, 49);
            this.lYMax.Name = "lYMax";
            this.lYMax.Size = new System.Drawing.Size(51, 13);
            this.lYMax.TabIndex = 1;
            this.lYMax.Text = "Maximum";
            // 
            // lYMin
            // 
            this.lYMin.AutoSize = true;
            this.lYMin.Location = new System.Drawing.Point(6, 23);
            this.lYMin.Name = "lYMin";
            this.lYMin.Size = new System.Drawing.Size(48, 13);
            this.lYMin.TabIndex = 0;
            this.lYMin.Text = "Minimum";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(134, 118);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 6;
            this.bOK.Text = "Okay";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(215, 118);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // ChartOptions
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(302, 148);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.gbY);
            this.Controls.Add(this.gbX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChartOptions";
            this.ShowInTaskbar = false;
            this.Text = "ChartOptions";
            this.gbX.ResumeLayout(false);
            this.gbX.PerformLayout();
            this.gbY.ResumeLayout(false);
            this.gbY.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbX;
        private System.Windows.Forms.TextBox tbXMax;
        private System.Windows.Forms.TextBox tbXMin;
        private System.Windows.Forms.Label lXMax;
        private System.Windows.Forms.Label lXMin;
        private System.Windows.Forms.CheckBox chkXAuto;
        private System.Windows.Forms.GroupBox gbY;
        private System.Windows.Forms.CheckBox chkYAuto;
        private System.Windows.Forms.TextBox tbYMax;
        private System.Windows.Forms.TextBox tbYMin;
        private System.Windows.Forms.Label lYMax;
        private System.Windows.Forms.Label lYMin;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
    }
}