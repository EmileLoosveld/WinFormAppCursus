using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_fietscomptuer
{
    public partial class frminstellingen : Form
    {
        float ritAfstand = 10000, wiellengte = (float)2.175;
        float beweegLeft = 0, beweegTop = 0, ritAfgelegdeAfstand = 0;
        List<string> alleGegevens = new List<string>();
        public frminstellingen()
        {
            InitializeComponent();

            string exeLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string exePath = System.IO.Path.GetDirectoryName(exeLocation);
            string[] paths = { exePath, "instellingen", "coord.vti" };
            string projectDirectory = Path.Combine(paths);
            string[] pathsFoto = { exePath, "instellingen", "kaart.png" };
            string KaartDirectory = Path.Combine(pathsFoto);
            if (File.Exists(projectDirectory) == true)
            {
                Gegevens.BestandInlezen(projectDirectory, alleGegevens);
                string[] coordsStart = alleGegevens[0].Split(';');
                string[] coordsFinish = alleGegevens[1].Split(';');
                lblStart.Left = int.Parse(coordsStart[0]);
                lblStart.Top = int.Parse(coordsStart[1]);
                lblFinish.Left = int.Parse(coordsFinish[0]);
                lblFinish.Top = int.Parse(coordsFinish[1]);
                numAfstand.Value = decimal.Parse(alleGegevens[2]) / 1000;
                numWielLengte.Value = decimal.Parse(alleGegevens[3]);
            }
            if (File.Exists(KaartDirectory) == true)
            {
                picKaart.Image = Image.FromFile(KaartDirectory);
            }
        }

        private void frminstellingen_Load(object sender, EventArgs e)
        {
            pnlInfo.Height = 175;
            pnlKaart.Width = this.Width / 2;
            picFiets.Parent = picKaart;
            lblFinish.Parent = picKaart;
            lblStart.Parent = picKaart;

            //Serial ports zoeken en plaatsen in de list
            lstPoort.Items.Clear();
            //alle seriële poorten voor dit toestel opvragen
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
                lstPoort.Items.Add(poort);
        }

        private void Num_Increment(object sender, KeyEventArgs e)
        {
            if (sender == numWielLengte)
            {
                if (e.Control == true) numWielLengte.Increment = 0.01M;
                else if (e.Shift == true) numWielLengte.Increment = 0.1M;
                else if (e.Alt == true) numWielLengte.Increment = 1;
                else numWielLengte.Increment = 0.001M;
            }
            if (sender == numAfstand)
            {
                if (e.Control == true) numAfstand.Increment = 1;
                else if (e.Shift == true) numAfstand.Increment = 10;
                else if (e.Alt == true) numAfstand.Increment = 100;
                else numAfstand.Increment = 0.1M;
            }
        }

        private void btnTestRennerRit_Click(object sender, EventArgs e)
        {
            tmrSimuleerRit.Start();
        }

        private void btnSlaOp_Click(object sender, EventArgs e)
        {
            string exeLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string exePath = System.IO.Path.GetDirectoryName(exeLocation);
            string[] paths = { exePath, "instellingen", "coord.vti"};
            string fullPath = Path.Combine(paths);
            alleGegevens.Clear();
            alleGegevens.Add(lblStart.Left.ToString() + " ; " + lblStart.Top.ToString());
            alleGegevens.Add(lblFinish.Left.ToString() + " ; " + lblFinish.Top.ToString());
            alleGegevens.Add(ritAfstand.ToString());
            alleGegevens.Add(wiellengte.ToString());
            Gegevens.BestandOpslaan(fullPath, alleGegevens);
        }

        private void picKaart_MouseClick(object sender, MouseEventArgs e)
        {
            string exeLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string exePath = System.IO.Path.GetDirectoryName(exeLocation);
            string[] paths = { exePath, "instellingen", "kaart.png" };
            string afbeeldingLocatie = Path.Combine(paths);
            if (e.Button == MouseButtons.Right)
            {
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picKaart.Image.Dispose();
                    picKaart.Image = new Bitmap(openFileDialog1.FileName);
                    picKaart.Image.Save(afbeeldingLocatie, System.Drawing.Imaging.ImageFormat.Png);
                }

            }
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            if (sender == numAfstand)
            {
                ritAfstand = (float)numAfstand.Value * 1000;
            }
            if (sender == numWielLengte)
            {
                wiellengte = (float)numWielLengte.Value;
            }
            ritAfgelegdeAfstand = 0;
        }

        private void btnTestRenner_Click(object sender, EventArgs e)
        {
            //Fietser in de juiste richting laten kijken afhangelijk van zijn x-positie (=left)
            if (lblStart.Left < lblFinish.Left)
            {
                picFiets.Image = Properties.Resources.rennerL;
            }
            else
            {
                picFiets.Image = Properties.Resources.rennerR;
            }
            //fietster alleen bewegen als geheel getal bereikt werd
            //horizontale beweging
            //Zorgen dat je komma-getal bijhoudt
            beweegLeft += ((lblStart.Left - lblFinish.Left) / ritAfstand) * wiellengte;
            picFiets.Left -= (int)beweegLeft;       // alleen geheel gedeelte wordt aangepast
            //geheel getal verwijderen want dit werd bijgeteld
            if (beweegLeft >= 1 || beweegLeft <= -1)
            {
                beweegLeft -= (int)beweegLeft;
            }
            //verticale beweging
            //zorgen dat je komma getal bijhoudt
            beweegTop += ((lblStart.Top - lblFinish.Top) / ritAfstand) * wiellengte;
            picFiets.Top -= (int)beweegTop;         //alleen geheel gedeelte wordt aangepast
            //geheel getal verwijderen want dit werd bijgeteld
            if (beweegTop >= 1 || beweegTop <= -1)
            {
                beweegTop -= (int)beweegTop;
            }
            //kijken als finish reeds bereikt werd
            if (ritAfgelegdeAfstand == 0)
            {
                picFiets.Left = lblStart.Left;
                picFiets.Top = lblStart.Top;
                beweegTop = 0; beweegLeft = 0;
            }
            //afstand aanpassen
            if (ritAfgelegdeAfstand < ritAfstand)
            {
                //fietstersafstand bijhouden zodat je weet als hoe ver hij zit
                ritAfgelegdeAfstand += wiellengte;
            }
            else
            {
                //fietser op finsh zetten, hij gaat er niet over
                picFiets.Left = lblFinish.Left;
                picFiets.Top = lblFinish.Top;
                //af te leggen afstand terug op 0 om volgende keer terug te kunnen starten
                ritAfgelegdeAfstand = 0;
                tmrSimuleerRit.Stop();
            }
        }

        private void startFinish_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = picKaart.PointToClient(Cursor.Position);
            if (e.Button == MouseButtons.Left && point != lblStart.Location && sender == lblStart)
            {
                lblStart.Top = point.Y - Cursor.Size.Height / 2;
                lblStart.Left = point.X - Cursor.Size.Width / 2;
                ritAfgelegdeAfstand = 0;
            }
            if (e.Button == MouseButtons.Left && point != lblFinish.Location && sender == lblFinish)
            {
                lblFinish.Top = point.Y - Cursor.Size.Height / 2;
                lblFinish.Left = point.X - Cursor.Size.Width / 2;
                ritAfgelegdeAfstand = 0;
            }
        }
    }    
}
