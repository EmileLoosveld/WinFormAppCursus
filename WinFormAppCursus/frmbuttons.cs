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
    public partial class frmbuttons : Form
    {
        public frmbuttons()
        {
            InitializeComponent();
        }

        private void btnUitlijnen_Click(object sender, EventArgs e)
        {
            Button btnHulp = sender as Button;
            if (btnHulp != null)
            {
                   switch(btnHulp.Name)
                {
                    case "btnRechts": txtTekst.TextAlign = HorizontalAlignment.Right;
                        break;
                    case "btnCentreer":
                        txtTekst.TextAlign = HorizontalAlignment.Center;
                        break;
                    case "btnLinks":
                        txtTekst.TextAlign = HorizontalAlignment.Left;
                        break;
                }
            }
        }
    }
}
