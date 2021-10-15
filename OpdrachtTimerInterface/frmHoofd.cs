using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtTimerInterface
{
    public partial class frmHoofd : Form
    {

        SVLib_PIC18F24J50.SVPICAPI K8055 = new SVLib_PIC18F24J50.SVPICAPI();
        public frmHoofd()
        {
            InitializeComponent();
            K8055.K8055_legacy_mode = true;
            K8055.OpenDevice(0);
        }
        bool toggle = false;
        private void tmrKnipper_Tick(object sender, EventArgs e)
        {
            if (toggle == true) K8055.SetDigitalChannel(1);
            if (toggle == false) K8055.ClearDigitalChannel(1);
            toggle = !toggle;
        }

        private void chkKnipper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKnipper.Checked)
            {
                K8055.OpenDevice(0);
                tmrKnipper.Enabled = true;
            }
            else
            {
                K8055.CloseDevice();
                tmrKnipper.Enabled = false;
            }
        }

        private void rdbEen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEen.Checked) tmrKnipper.Interval = 1000;
            if (rdbVijf.Checked) tmrKnipper.Interval = 5000;
            if (rdbTien.Checked) tmrKnipper.Interval = 10000;
        }

        private void frmHoofd_FormClosing(object sender, FormClosingEventArgs e)
        {
            K8055.ClearDigitalChannel(1);
            K8055.Close();
        }
    }
}
