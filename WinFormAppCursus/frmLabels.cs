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
    public partial class frmLabels : Form
    {
        public frmLabels()
        {
            InitializeComponent();
        }

        private void lblMuisTest_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "MouseEnter";
        }

        private void lblMuisTest_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "MouseLeave";
        }

        private void lblMuisTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left )
            {
                this.Text = "MouseMove Linkermuisknop";
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = "MouseMove Rechtermuisknop";
            }
        }

        private void lblMuisTest_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = e.Clicks.ToString();
        }

        private void frmLabels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) this.BackColor = Color.AliceBlue;
        }

        private void frmLabels_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 65) this.BackColor = Color.Blue;
        }

        private void frmLabels_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K) this.BackColor = Color.BurlyWood;
        }

        private void frmLabels_Load(object sender, EventArgs e)
        {

        }

        private void frmLabels_Load_1(object sender, EventArgs e)
        {

        }
    }
}
