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
    public partial class fmOpdrachtLabels : Form
    {
        public fmOpdrachtLabels()
        {
            InitializeComponent();
        }

        private void fmOpdrachtLabels_KeyDown(object sender, KeyEventArgs e)
        {
            int rechts = 0;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    rechts = rechts + 10;
                    break;
            }
            this.vrachtwagen = vrachtwagen.LocationChanged(0, 0);
        }

        private void vrachtwagen_Click(object sender, EventArgs e)
        {

        }
    }

    private void fmOpdrachtLabels_Load(object sender, EventArgs e)
        {

        }
    }
