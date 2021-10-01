using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_fietscomptuer
{
    public partial class frminstellingen : Form
    {
        public frminstellingen()
        {
            InitializeComponent();
        }

        private void frminstellingen_Load(object sender, EventArgs e)
        {
            pnlInfo.Height = 175;
            pnlKaart.Width = this.Width / 2;
            picFiets.Parent = picKaart;
            lblFinish.Parent = picKaart;
            lblStart.Parent = picKaart;
        }

        private void lblStart_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = picKaart.PointToClient(Cursor.Position);
            if (point != lblStart.Location)
            {
                lblStart.Location = point;
            }
        }
    }
}
