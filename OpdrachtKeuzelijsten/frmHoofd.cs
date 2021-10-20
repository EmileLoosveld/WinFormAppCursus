using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OpdrachtKeuzelijsten
{
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            lstItems.Sorted = true;
            lstItems.Sorted = false;
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            lstItems.Sorted = true;
            lstItems.Sorted = false;
            int hoeveelheid = lstItems.Items.Count;
            for (int i = -1; i == lstItems.Items.Count / 2; i++)
            {
                hoeveelheid--;
                lstItems.Items[i] = lstItems.Items[hoeveelheid];
            }
        }
    }
}
