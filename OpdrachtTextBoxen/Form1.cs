using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtTextBoxen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtGebruikersnaam.Text == "Administrator" && txtPaswoord.Text == "1234")
            {
                this.Text = "Administrator is ingelogd".ToString();
                panel1.Visible = false;
            }
            if (txtGebruikersnaam.TextLength > 0 && txtPaswoord.Text == "5678")
            {
                this.Text = txtGebruikersnaam.Text.ToString() + " is ingelogd";
                panel1.Visible = false;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
