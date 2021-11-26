
namespace WinFormAppCursus
{
    partial class frmBars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.statusLettertype = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.txtVoorbeeld = new System.Windows.Forms.RichTextBox();
            this.lettertypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSchuin = new System.Windows.Forms.ToolStripMenuItem();
            this.editerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKnippen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopiëren = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlakken = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lettertypeBalk = new System.Windows.Forms.ToolStrip();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBolt = new System.Windows.Forms.ToolStripButton();
            this.tsbtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tscmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.Arial = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSchuin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusVet = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip.SuspendLayout();
            this.statusLettertype.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.lettertypeBalk.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerenToolStripMenuItem,
            this.lettertypeToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // statusLettertype
            // 
            this.statusLettertype.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arial,
            this.statusSchuin,
            this.statusVet});
            this.statusLettertype.Location = new System.Drawing.Point(0, 428);
            this.statusLettertype.Name = "statusLettertype";
            this.statusLettertype.Size = new System.Drawing.Size(800, 22);
            this.statusLettertype.TabIndex = 1;
            this.statusLettertype.Text = "statusStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtVoorbeeld);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 379);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 404);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.lettertypeBalk);
            // 
            // txtVoorbeeld
            // 
            this.txtVoorbeeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoorbeeld.Location = new System.Drawing.Point(0, 0);
            this.txtVoorbeeld.Name = "txtVoorbeeld";
            this.txtVoorbeeld.Size = new System.Drawing.Size(800, 379);
            this.txtVoorbeeld.TabIndex = 0;
            this.txtVoorbeeld.Text = "";
            // 
            // lettertypeToolStripMenuItem
            // 
            this.lettertypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFont,
            this.menuVet,
            this.menuSchuin});
            this.lettertypeToolStripMenuItem.Name = "lettertypeToolStripMenuItem";
            this.lettertypeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.lettertypeToolStripMenuItem.Text = "&Lettertype";
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(174, 22);
            this.menuFont.Text = "&Font";
            this.menuFont.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.LettertypeKiezen_DropDownItemClicked);
            // 
            // menuVet
            // 
            this.menuVet.Name = "menuVet";
            this.menuVet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuVet.Size = new System.Drawing.Size(174, 22);
            this.menuVet.Text = "&Vetdruk";
            this.menuVet.Click += new System.EventHandler(this.menuVet_Click);
            // 
            // menuSchuin
            // 
            this.menuSchuin.Name = "menuSchuin";
            this.menuSchuin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuSchuin.Size = new System.Drawing.Size(174, 22);
            this.menuSchuin.Text = "&Schuindruk";
            this.menuSchuin.Click += new System.EventHandler(this.menuSchuin_Click);
            // 
            // editerenToolStripMenuItem
            // 
            this.editerenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKnippen,
            this.menuKopiëren,
            this.menuPlakken});
            this.editerenToolStripMenuItem.Name = "editerenToolStripMenuItem";
            this.editerenToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.editerenToolStripMenuItem.Text = "Editeren";
            // 
            // menuKnippen
            // 
            this.menuKnippen.Name = "menuKnippen";
            this.menuKnippen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKnippen.Size = new System.Drawing.Size(163, 22);
            this.menuKnippen.Text = "Knippen";
            this.menuKnippen.Click += new System.EventHandler(this.menuKnippen_Click);
            // 
            // menuKopiëren
            // 
            this.menuKopiëren.Name = "menuKopiëren";
            this.menuKopiëren.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopiëren.Size = new System.Drawing.Size(163, 22);
            this.menuKopiëren.Text = "Kopiëren";
            this.menuKopiëren.Click += new System.EventHandler(this.menuKopiëren_Click);
            // 
            // menuPlakken
            // 
            this.menuPlakken.Name = "menuPlakken";
            this.menuPlakken.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPlakken.Size = new System.Drawing.Size(163, 22);
            this.menuPlakken.Text = "Plakken";
            this.menuPlakken.Click += new System.EventHandler(this.menuPlakken_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCut,
            this.tsbtnCopy,
            this.tsbtnPaste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lettertypeBalk
            // 
            this.lettertypeBalk.Dock = System.Windows.Forms.DockStyle.None;
            this.lettertypeBalk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnBolt,
            this.tsbtnItalic,
            this.tscmbFont});
            this.lettertypeBalk.Location = new System.Drawing.Point(102, 0);
            this.lettertypeBalk.Name = "lettertypeBalk";
            this.lettertypeBalk.Size = new System.Drawing.Size(181, 25);
            this.lettertypeBalk.TabIndex = 0;
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCut.Image = global::WinFormAppCursus.Properties.Resources.cut;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCut.Text = "toolStripButton1";
            this.tsbtnCut.Click += new System.EventHandler(this.menuKnippen_Click);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCopy.Image = global::WinFormAppCursus.Properties.Resources.copy;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCopy.Text = "toolStripButton2";
            this.tsbtnCopy.Click += new System.EventHandler(this.menuKopiëren_Click);
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPaste.Image = global::WinFormAppCursus.Properties.Resources.paste;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPaste.Text = "toolStripButton1";
            this.tsbtnPaste.Click += new System.EventHandler(this.menuPlakken_Click);
            // 
            // tsbtnBolt
            // 
            this.tsbtnBolt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBolt.Image = global::WinFormAppCursus.Properties.Resources.bold;
            this.tsbtnBolt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBolt.Name = "tsbtnBolt";
            this.tsbtnBolt.Size = new System.Drawing.Size(23, 22);
            this.tsbtnBolt.Text = "toolStripButton1";
            // 
            // tsbtnItalic
            // 
            this.tsbtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnItalic.Image = global::WinFormAppCursus.Properties.Resources.italic;
            this.tsbtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnItalic.Name = "tsbtnItalic";
            this.tsbtnItalic.Size = new System.Drawing.Size(23, 22);
            this.tsbtnItalic.Text = "toolStripButton1";
            // 
            // tscmbFont
            // 
            this.tscmbFont.Name = "tscmbFont";
            this.tscmbFont.Size = new System.Drawing.Size(121, 25);
            this.tscmbFont.SelectedIndexChanged += new System.EventHandler(this.tscmbFont_SelectedIndexChanged);
            // 
            // Arial
            // 
            this.Arial.Name = "Arial";
            this.Arial.Size = new System.Drawing.Size(31, 17);
            this.Arial.Text = "Arial";
            // 
            // statusSchuin
            // 
            this.statusSchuin.Name = "statusSchuin";
            this.statusSchuin.Size = new System.Drawing.Size(43, 17);
            this.statusSchuin.Text = "Schuin";
            // 
            // statusVet
            // 
            this.statusVet.Name = "statusVet";
            this.statusVet.Size = new System.Drawing.Size(23, 17);
            this.statusVet.Text = "Vet";
            // 
            // frmBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusLettertype);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "frmBars";
            this.Text = "frmBars";
            this.Load += new System.EventHandler(this.frmBars_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.statusLettertype.ResumeLayout(false);
            this.statusLettertype.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.lettertypeBalk.ResumeLayout(false);
            this.lettertypeBalk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem lettertypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFont;
        private System.Windows.Forms.ToolStripMenuItem menuVet;
        private System.Windows.Forms.StatusStrip statusLettertype;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.RichTextBox txtVoorbeeld;
        private System.Windows.Forms.ToolStripMenuItem menuSchuin;
        private System.Windows.Forms.ToolStripMenuItem editerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuKnippen;
        private System.Windows.Forms.ToolStripMenuItem menuKopiëren;
        private System.Windows.Forms.ToolStripMenuItem menuPlakken;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip lettertypeBalk;
        private System.Windows.Forms.ToolStripButton tsbtnBolt;
        private System.Windows.Forms.ToolStripButton tsbtnItalic;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.ToolStripComboBox tscmbFont;
        private System.Windows.Forms.ToolStripStatusLabel Arial;
        private System.Windows.Forms.ToolStripStatusLabel statusSchuin;
        private System.Windows.Forms.ToolStripStatusLabel statusVet;
    }
}