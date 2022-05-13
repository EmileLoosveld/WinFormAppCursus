using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibK8055;

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
            try
            {
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.projectenDataSet);
                comboBoxLaden();
                this.tableTableAdapter.FillBy(this.projectenDataSet.Table, projectComboBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxLaden()
        {
            projectComboBox.Items.Clear();
            this.tableTableAdapter.Fill(this.projectenDataSet.Table);
            foreach (DataRow rij in this.projectenDataSet.Table)
            {
                if (!projectComboBox.Items.Contains(rij["Project"].ToString()))
                    projectComboBox.Items.Add(rij["Project"].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectenDataSet.Table' table. You can move, or remove it, as needed.
            comboBoxLaden();
            K8055.OpenDevice(0);
            K8055.ClearAllDigital();
        }

        private void projectComboBox_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            K8055.ClearAllDigital();
            if (projectComboBox.Text != "")
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
        int tel = 0;
        private void btnAfspelen_Click(object sender, EventArgs e)
        {
            tel = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (this.projectenDataSet.Table.Rows.Count == tel)
            {
                K8055.ClearAllDigital();
                timer1.Stop();
            }
            else
            {
                
                DataRow rij = this.projectenDataSet.Table[tel];
                K8055.WriteAllDigital(Convert.ToInt32(rij["stuur"].ToString(), 2));
                timer1.Interval = (int)rij["Tijd"] * 1000;
                tel++;
            }
            
        }

        private void tableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                tableDataGridView.CurrentCell.Value = projectComboBox.Text;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
