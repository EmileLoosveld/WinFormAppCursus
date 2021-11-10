using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OpdrachtKeuzelijsten
{
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            lstItems.Sorted = true;
            lstItems.Sorted = false;
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            int tellingOnder = lstItems.Items.Count - 1;
            lstItems.Sorted = true;
            lstItems.Sorted = false;
            for (int i = 0; i != lstItems.Items.Count / 2; i ++)
            {
                string oud = lstItems.Items[i].ToString();
                lstItems.Items[i] = lstItems.Items[tellingOnder];
                lstItems.Items[tellingOnder] = oud;
                tellingOnder--;
            }
        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            int count = lstItems.SelectedItems.Count;
            if (count > 0) 
            {
                for (int i = 0; i < count; i++) 
                {
                    object hulp = lstItems.SelectedItems[0];
                    lstItems.Items.Remove(hulp);
                }
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            bool contains = lstItems.Items.Contains(txtItem.Text);

            if (contains == false && txtItem.Text != "")
            {
                if (chkSelect.Checked && lstItems.SelectedIndex != -1) lstItems.Items.Insert(lstItems.SelectedIndex, txtItem.Text);
                else lstItems.Items.Add(txtItem.Text);
            }
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
