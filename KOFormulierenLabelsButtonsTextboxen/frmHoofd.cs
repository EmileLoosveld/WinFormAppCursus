using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOFormulierenLabelsButtonsTextboxen
{
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }

        private void frmHoofd_Load(object sender, EventArgs e)
        {
        }

        private void frmHoofd_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    this.WindowState = FormWindowState.Maximized;
                    break;
                case MouseButtons.Right:
                    this.WindowState = FormWindowState.Normal;
                    break;
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btndialoogvenster_Click(object sender, EventArgs e)
        {
            frmDialoog dialoogvenster = new frmDialoog();
            dialoogvenster.ShowDialog();
        }

        private void lblBlauw_DragEnter(object sender, EventArgs e)
        {
            

        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            Label lblHulp = sender as Label;
            if (lblHulp != null)
            {
                switch (lblHulp.Name)
                {
                    case "lblBlauw":
                        this.BackColor = Color.Blue;
                        break;
                    case "lblGroen":
                        this.BackColor = Color.Lime;
                        break;
                    case "lblWit":
                        this.BackColor = Color.White;
                        break;
                }
            }
        }
    }
}
