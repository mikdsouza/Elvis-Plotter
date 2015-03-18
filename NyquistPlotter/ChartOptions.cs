using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyquistPlotter
{
    public partial class ChartOptions : Form
    {
        public double MinX
        {
            get
            {
                return double.Parse(tbXMin.Text);
            }
            set
            {
                tbXMin.Text = value.ToString();
            }
        }

        public double MaxX
        {
            get
            {
                return double.Parse(tbXMax.Text);
            }
            set
            {
                tbXMax.Text = value.ToString();
            }
        }

        public double MinY
        {
            get
            {
                return double.Parse(tbYMin.Text);
            }
            set
            {
                tbYMin.Text = value.ToString();
            }
        }

        public double MaxY
        {
            get
            {
                return double.Parse(tbYMax.Text);
            }
            set
            {
                tbYMax.Text = value.ToString();
            }
        }

        public bool AutoX
        {
            get
            {
                return chkXAuto.Checked;
            }
            set
            {
                chkXAuto.Checked = value;
            }
        }

        public bool AutoY
        {
            get
            {
                return chkYAuto.Checked;
            }
            set
            {
                chkYAuto.Checked = value;
            }
        }

        public ChartOptions()
        {
            InitializeComponent();
        }

        private void chkXAuto_CheckedChanged(object sender, EventArgs e)
        {
            tbXMin.Enabled = !chkXAuto.Checked;
            tbXMax.Enabled = !chkXAuto.Checked;
        }

        private void chkYAuto_CheckedChanged(object sender, EventArgs e)
        {
            tbYMin.Enabled = !chkYAuto.Checked;
            tbYMax.Enabled = !chkYAuto.Checked;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (VerifyValues())
            {
                Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Values are now valid", "Check inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private bool VerifyValues()
        {
            return true;
        }
    }
}
