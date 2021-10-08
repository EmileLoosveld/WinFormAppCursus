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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void chkStartStop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartStop.Checked)
            {
                tmrTekst.Start();
                chkStartStop.Text = "stop";
            }
            else
            {
                tmrTekst.Stop();
                chkStartStop.Text = "start";
                lblText.Text = "Timer gestopt.";
            }
        }
        bool toestand = false; //Variable om bij te houden wat vorige toestand tekst was
        private void tmrTekst_Tick(object sender, EventArgs e)
        {
            if (toestand) lblText.Text = "Hallo";
            else lblText.Text = "Tot later";
            toestand = !toestand;
        }
    }
}
