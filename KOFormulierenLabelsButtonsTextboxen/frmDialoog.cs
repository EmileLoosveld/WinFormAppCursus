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
    public partial class frmDialoog : Form
    {
        public frmDialoog()
        {
            InitializeComponent();

        }

        private void frmDialoog_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    this.Close();
                    break;
                case Keys.F10:
                    if (this.Opacity >= 50)
                    {
                        this.Opacity = this.Opacity - 10;
                    }
                    break;
                case Keys.F11:
                    if (this.Opacity < 90)
                    {
                        this.Opacity = this.Opacity + 10;
                    }
                    break;
            }
            
        }

        private void txtTitel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Text = txtTitel.Text;
            }
        }
    }
}
