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
    public partial class frmOptiesDialog : Form
    {
        public Color VoorgrondKleur { get; set; }
        public Color AchtergrondKleur { get; set; }
        public frmOptiesDialog()
        {
            InitializeComponent();
            VoorgrondKleur = Color.Black;
            AchtergrondKleur = SystemColors.Control;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbVoorRood.Checked) VoorgrondKleur = Color.Red;
            if (rdbVoorWit.Checked) VoorgrondKleur = Color.White;
            if (rdbVoorZwart.Checked) VoorgrondKleur = Color.Black;

            if (rdbAchterStandaard.Checked) AchtergrondKleur = SystemColors.Control;
            if (rdbAchterWit.Checked) AchtergrondKleur = Color.White;
            if (rdbAchterZwart.Checked) AchtergrondKleur = Color.Black;
        }

        private void frmOptiesDialog_Shown(object sender, EventArgs e)
        {
            if (this.VoorgrondKleur == Color.Red)
                rdbVoorRood.Checked = true;
            if (this.VoorgrondKleur == Color.White)
                rdbVoorWit.Checked = true;
            if (this.VoorgrondKleur == Color.Black)
                rdbVoorZwart.Checked = true;

            if (this.AchtergrondKleur == SystemColors.Control)
                rdbAchterStandaard.Checked = true;
            if (this.AchtergrondKleur == Color.White)
                rdbAchterWit.Checked = true;
            if (this.AchtergrondKleur == Color.Black)
                rdbAchterZwart.Checked = true;
        }
    }
}
