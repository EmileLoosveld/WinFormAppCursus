using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectenDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectenDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.projectenDataSet.Table);
            foreach(DataRow rij in this.projectenDataSet.Table )
            {
                if (!projectComboBox.Items.Contains(rij["Project"].ToString()))
                    projectComboBox.Items.Add( rij["Project"].ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void projectComboBox_TextChanged(object sender, EventArgs e)
        {
            if (projectComboBox.SelectedIndex != -1)
            {
                this.tableTableAdapter.FillBy(this.projectenDataSet.Table, projectComboBox.Text);
                tableDataGridView.Visible = true;
                tableBindingNavigator.Enabled = true;
            }
            else
            {
                tableDataGridView.Visible = false;
                tableBindingNavigator.Enabled = false;
            }
            if (projectenDataSet.Table.Count < 1)           //Kijken hoeveel rijen aanwezig
            {
                btnAfspelen.Enabled = false;
            }
            else
            {
                btnAfspelen.Enabled = true;
            }
        }
    }
}
