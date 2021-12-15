using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO6ICTStartProgramma
{
    public partial class frmBasis : Form
    {
        public string symbool;
        public frmBasis()
        {
            InitializeComponent();
            frmSymbool1 = new frmSymbool(this);
        }
        frmSymbool frmSymbool1;
        public void LabelMouseDoubleClick(Object sender, System.EventArgs e)
        {
            Label lbl = (Label)sender;
            if (pnlMand.Contains(lbl))
                lbl.Parent = pnlKast;
            else if (pnlKast.Contains(lbl))
                lbl.Parent = pnlMand;

        }
        //method om labels toe te voegen aan pnlKast
        private void AddLabels(int aantalLabels, string TypeSymbool, Color KleurSymbolen)
        {

            // Declaratie van array voor 10 labels
            System.Windows.Forms.Label[] lblArray = new System.Windows.Forms.Label[aantalLabels];
            // Creëer 10 labels: 
            for (int i = 0; i < aantalLabels; i++)
                lblArray[i] = new System.Windows.Forms.Label();

            int n = 0, xPos = 100, yPos = 100; //startpositie eerste label

            while (n < aantalLabels) //basisinstellingen van elk label uit de array instellen, zodat ze volgens de grootte van het panel in rijen naast elkaar worden gezet
            {
                lblArray[n].Tag = n + 1; // Tag van het label ins
                lblArray[n].Font = new Font("Webdings", 50, FontStyle.Bold );
                lblArray[n].Text = TypeSymbool;
                lblArray[n].AutoSize = true;
                lblArray[n].Parent = pnlKast; //pnlKast is container voor deze labels
                lblArray[n].ForeColor = KleurSymbolen;
                lblArray[n].BackColor = Color.Transparent;
                // Plaats van het label label: 
                lblArray[n].Left = xPos;
                lblArray[n].Top = yPos;
                // Volgende label-plaats instellen
                xPos += 10 + lblArray[n].Width;
                if (xPos >= pnlKast.Width - lblArray[n].Width - 100) // Kijken als er een nieuwe lijn nodig is
                {
                    xPos = 100;
                    yPos += lblArray[n].Height + 10;
                }
                n++;//volgende label
                lblArray[n-1].Click += new System.EventHandler(LabelMouseDoubleClick);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AddLabels(10, lblSymbool.Text, lblKleur.ForeColor);
        }

        private void frmBasis_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlKast.Width = pnlBoven.Width / 2;
        }
        Random random = new Random();
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlMand.Controls.Clear();
            pnlKast.Controls.Clear();
            AddLabels((int)numAantal.Value, lblSymbool.Text, lblKleur.ForeColor);
            int randomNumber = random.Next(0, 100);
            lblAantal.Text = (random.Next(0, (int)numAantal.Value)).ToString();
            lblResultaat.Text = "Vul de mand met " + lblAantal.Text + " objecten";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            int aantalMand = pnlMand.Controls.Count;
            int aantalNodig = int.Parse(lblAantal.Text);
            if (aantalMand == aantalNodig)
                lblResultaat.Text = "GOED GEDAAN";
            if (aantalMand > aantalNodig)
                lblResultaat.Text = "OEI, TE VEEL OBJECTEN IN DE MAND!";
            if (aantalMand < aantalNodig)
                lblResultaat.Text = "OEI, NOG NIET GENOEG OBJECTEN IN DE MAND!";
        }

        private void btnSymbool_Click(object sender, EventArgs e)
        {
            if (frmSymbool1.ShowDialog() == DialogResult.OK)
            {
                lblSymbool.Text = symbool;
            }
        }

        private void btnKleur_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblKleur.ForeColor = colorDialog1.Color;
            }
        }
    }
}
