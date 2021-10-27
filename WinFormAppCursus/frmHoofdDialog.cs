using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppCursus
{
    public partial class frmHoofdDialog : Form
    {
        public frmHoofdDialog()
        {
            InitializeComponent();
        }
        private frmOptiesDialog frmOptions = new frmOptiesDialog();
        private void btnOpties_Click(object sender, EventArgs e)
        {
            if (frmOptions.ShowDialog() == DialogResult.OK)
            {
                lblTekst.BackColor = frmOptions.AchtergrondKleur;
                lblTekst.ForeColor = frmOptions.VoorgrondKleur;
            }
        }
    }
}
