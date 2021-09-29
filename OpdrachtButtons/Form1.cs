using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtButtons
{
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void uitlijning_ckeckedChanged(object sender, EventArgs e)
        {
            if (chkInvoervak.Checked)
            {
                if (rdbLinks.Checked) txtTekst.TextAlign = HorizontalAlignment.Left;
                if (rdbRechts.Checked) txtTekst.TextAlign = HorizontalAlignment.Right;
                if (rdbCenter.Checked) txtTekst.TextAlign = HorizontalAlignment.Center;
            }
            if (chkLabel.Checked)
            {
                if (rdbLinks.Checked) lblLabel.TextAlign = ContentAlignment.MiddleLeft;
                if (rdbCenter.Checked) lblLabel.TextAlign = ContentAlignment.MiddleCenter;
                if (rdbRechts.Checked) lblLabel.TextAlign = ContentAlignment.MiddleRight;
            }
        }

    }
}
