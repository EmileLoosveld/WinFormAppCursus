using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOFormulierenTimersKeuzelijsten
{
    public partial class frmToets : Form
    {
        public frmToets()
        {
            InitializeComponent();
            lstTijd.SelectedIndex = 1;
            lstTijd.Items.Contains(tmrTijd.Interval.ToString());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrTijd.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrTijd.Start();
            lblBeweeg.Left = 0;
            lblBeweeg.Top = 0;
            xas = 0;
            yas = 0;
        }

        private void btnVerder_Click(object sender, EventArgs e)
        {
            tmrTijd.Enabled = true;
        }
        int xas, yas, waarde = 0;

        private void btnVoegToe_MouseUp(object sender, MouseEventArgs e)
        {
            lstTijd.Sorted = false;
            bool contains = lstTijd.Items.Contains(txtVoegToe.Text);
            if (contains == false && txtVoegToe.Text != "")
            {
                lstTijd.Items.Add(txtVoegToe.Text);
            }
            lstTijd.Sorted = true;
        }

        private void frmToets_ClientSizeChanged(object sender, EventArgs e)
        {
            if (waarde == 1)
            {
                lblBeweeg.Left = this.Left;
            }
        }

        private void lstTijd_SelectedValueChanged(object sender, EventArgs e)
        {
            tmrTijd.Interval = int.Parse(lstTijd.SelectedItem.ToString());
        }

        private void tmrTijd_Tick(object sender, EventArgs e)
        {
            tmrTijd.Start();
            switch (waarde)
            {
                case 0:
                    if (xas < ClientSize.Width - lblBeweeg.Width - 10) xas += 10;
                    else waarde = 1;
                    break;
                case 1:
                    if (yas < ClientSize.Height - lblBeweeg.Height - 10) yas += 10;
                    else waarde = 2;
                    break;
                case 2:
                    if (xas > 0) xas -= 10;
                    else waarde = 3;
                    break;
                case 3:
                    if (yas > 0) yas -= 10;
                    else waarde = 0;
                    break;
            }
            lblBeweeg.Left = xas;
            lblBeweeg.Top = yas;
        }
    }
}
