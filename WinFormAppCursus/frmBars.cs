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
    public partial class frmBars : Form
    {
        public frmBars()
        {
            InitializeComponent();
        }

        private void menuVet_Click(object sender, EventArgs e)
        {
            FontStyle style = txtVoorbeeld.Font.Style;
            if (!txtVoorbeeld.Font.Bold)
            {
                style |= FontStyle.Bold;
                menuVet.Checked = true;
                tsbtnBolt.Checked = true;
                statusVet.Font = new Font(statusVet.Font, FontStyle.Bold);
            }
            else
            {
                style &= ~FontStyle.Bold;
                menuVet.Checked = false;
                tsbtnBolt.Checked = false;
                statusVet.Font = new Font(statusVet.Font, FontStyle.Regular);
            }
            txtVoorbeeld.Font = new Font(txtVoorbeeld.Font, style);
        }

        private void menuSchuin_Click(object sender, EventArgs e)
        {
            FontStyle style = txtVoorbeeld.Font.Style;
            if (!txtVoorbeeld.Font.Italic)
            {
                style |= FontStyle.Italic;
                menuSchuin.Checked = true;
                tsbtnItalic.Checked = true;
                statusSchuin.Font = new Font(statusSchuin.Font, FontStyle.Italic);
            }
            else
            {
                style &= ~FontStyle.Italic;
                menuSchuin.Checked = false;
                tsbtnItalic.Checked = false;
                statusSchuin.Font = new Font(statusSchuin.Font, FontStyle.Regular);
            }
            txtVoorbeeld.Font = new Font(txtVoorbeeld.Font, style);
        }
        private void Lettertype(object sender)
        {
            //Huidige style onthouden
            FontStyle style = txtVoorbeeld.Font.Style;
            ToolStripMenuItem hetLetterType = (ToolStripMenuItem)sender;
            //nieuw lettertype
            txtVoorbeeld.Font = new Font(hetLetterType.Text, txtVoorbeeld.Font.Size);
            //oude style erbij instellen
            txtVoorbeeld.Font = new Font(txtVoorbeeld.Font, style);
        }

        private void LettertypeKiezen_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Lettertype(e.ClickedItem);
            foreach (ToolStripMenuItem huidig in menuFont.DropDownItems)
            {
                huidig.Checked = false;
            }
            ((ToolStripMenuItem)e.ClickedItem).Checked = true;
            tscmbFont.SelectedText = ((ToolStripMenuItem)e.ClickedItem).Text;
        }

        private void frmBars_Load(object sender, EventArgs e)
        {
            //alle fonts toevoegen aan menu font en comboboxFont
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            int Arialindex = -1, count = -1;
            foreach (FontFamily family in fonts.Families)
            {
                menuFont.DropDown.Items.Add(family.Name);
                //index Arial onthouden
                count++;
                if (family.Name == "Arial")
                    Arialindex = count;
            }
            txtVoorbeeld.Font = new Font("Arial", 12);
            tscmbFont.SelectedItem = Arialindex;
            statusLettertype.Text = "Arial";
        }

        private void menuKnippen_Click(object sender, EventArgs e)
        {
            txtVoorbeeld.Cut();
        }

        private void menuKopiëren_Click(object sender, EventArgs e)
        {
            txtVoorbeeld.Copy();
        }

        private void menuPlakken_Click(object sender, EventArgs e)
        {
            txtVoorbeeld.Paste();
        }

        private void tscmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem huidig in menuFont.DropDownItems)
            {
                huidig.Checked = false;
            }
            ((ToolStripMenuItem)menuFont.DropDownItems[tscmbFont.SelectedIndex]).Checked = true;
            Lettertype((ToolStripMenuItem)menuFont.DropDownItems[tscmbFont.SelectedIndex]);
        }
    }
}
