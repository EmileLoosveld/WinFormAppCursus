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
    public partial class Keuzelijsten : Form
    {
        public Keuzelijsten()
        {
            InitializeComponent();
        }

        private void btnnaarcmb_Click(object sender, EventArgs e)
        {
            //lstLijst is Selectionmode.multiextended = meerdere items selecteren
            //aantal initieel geselecteerdre items in lst bijhouden
            int count = lstLijst.SelectedItems.Count;
            if (count > 0) // als items zijn geselecteerd
            {
                //eerst items verplaatsen naar combobox
                foreach (object hulp in lstLijst.SelectedItems) cmbLijst.Items.Add(hulp);
                //nu items wisselen in listbox
                for (int i = 0; i < count; i++) //keer als initieel items geselecteerd
                {
                    object hulp = lstLijst.SelectedItems[0]; // eerste geselecteerde item
                    lstLijst.Items.Remove(hulp);
                }
            }
        }

        private void btnnaarList_Click(object sender, EventArgs e)
        {
            object hulp = cmbLijst.SelectedItem; //geselecteerde item
            if (hulp != null) // als iets geselecteerd is
            {
                lstLijst.Items.Add(hulp);
                cmbLijst.Items.Remove(hulp);
            }
            cmbLijst.Text = ""; // zodat bij laatste item wissen textbox blanco is.
        }

        private void btnWisSelectedLst_Click(object sender, EventArgs e)
        {
            lstLijst.SelectedItems.Clear(); //selectie wissen
        }

        private void btnWisSelectedCmb_Click(object sender, EventArgs e)
        {
            cmbLijst.SelectedIndex = -1; // niets geselecteerd
        }

        private void chkSortLst_CheckedChanged(object sender, EventArgs e)
        {
            lstLijst.Sorted = chkSortLst.Checked;
        }

        private void chkSortCmb_CheckedChanged(object sender, EventArgs e)
        {
            cmbLijst.Sorted = chkSortCmb.Checked;
        }
    }
}
