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
        }

        private void rdbTien_EnabledChanged(object sender, EventArgs e)
        {
            if (rdbEen.Checked) tmrKnipper.Interval = 1000;
            if (rdbVijf.Checked) tmrKnipper.Interval = 5000;
            if (rdbTien.Checked) tmrKnipper.Interval = 10000;
        }
    }
}
