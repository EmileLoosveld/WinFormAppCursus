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
        int xas, yas;
        private void fmOpdrachtLabels_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (xas < ClientSize.Width-vrachtwagen.Width-10) xas += 10;
                    break;
                case Keys.Left:
                    if (xas > 0) xas -= 10;
                    break;
                case Keys.Up:
                    if (yas > 0) yas -= 10;
                    break;
                case Keys.Down:
                    if (yas < ClientSize.Height-vrachtwagen.Height-10) yas += 10;
                    break;
            }
            vrachtwagen.Left = xas;
            vrachtwagen.Top = yas;
            //cliensize, clienwidth
        }

        private void vrachtwagen_Click(object sender, EventArgs e)
        {

        }
    }
}
