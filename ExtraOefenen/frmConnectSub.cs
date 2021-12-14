using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraOefenen
{
    public partial class frmConnectSub : Form
    {
        frmConnectHoofd frmConnectHoofd1;                                               //Form als variable voor refernetie
        public frmConnectSub(frmConnectHoofd frmConnectHoofd)                           //Gewoon doen
        {
            InitializeComponent();
            this.frmConnectHoofd1 = frmConnectHoofd;                                    //Gewoon doen
        }
        int aantal = 0;

        private void frmConnectSub_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnWijzigTekstHoofdfrm_Click(object sender, EventArgs e)
        {
            aantal++;
            frmConnectHoofd1.tekstje = "wijzig" + aantal.ToString();
        }
    }
}
