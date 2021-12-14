using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraOefenen
{
    public partial class frmConnectHoofd: Form
    {
        public frmConnectHoofd()
        {
            InitializeComponent();
            frmConnectSub1 = new frmConnectSub(this);               //Maakt instantie en toont het 2de form
        }
        frmConnectSub frmConnectSub1;                               //globaliseren van de instantie
        public string tekstje = "NIEUW";                            //Publieke string aanmaken
        private void button1_Click(object sender, EventArgs e)      //Bij het drukken van de knop
        {
            frmConnectSub1.ShowDialog();                            //Sub form tonen in dialoog
        }               
        private void btnToonTekst_Click(object sender, EventArgs e) //Drukken op knop om tekst te tonen
        {
            this.Text = tekstje;                                    //Titel aanpassen 
        }
    }
}
