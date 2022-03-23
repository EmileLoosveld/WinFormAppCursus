using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppPersoneelDBVoorbeeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tablePersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personeelsAdministratieDataSet.TablePost' table. You can move, or remove it, as needed.
            this.tablePostTableAdapter.Fill(this.personeelsAdministratieDataSet.TablePost);
            // TODO: This line of code loads data into the 'personeelsAdministratieDataSet.TablePers' table. You can move, or remove it, as needed.
            this.tablePersTableAdapter.Fill(this.personeelsAdministratieDataSet.TablePers);

        }

        private void tablePersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tablePersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personeelsAdministratieDataSet);

        }

        private void postIDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tablePostBindingSource.Filter = "PostID = " + postIDNumericUpDown.Value.ToString();
            tablePersBindingNavigatorSaveItem.Enabled = (postIDLabel2.Text != "");
        }
    }
}
