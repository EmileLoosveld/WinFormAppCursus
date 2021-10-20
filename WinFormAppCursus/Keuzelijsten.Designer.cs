
namespace WinFormAppCursus
{
    partial class Keuzelijsten
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
            this.lstLijst = new System.Windows.Forms.ListBox();
            this.cmbLijst = new System.Windows.Forms.ComboBox();
            this.btnnaarcmb = new System.Windows.Forms.Button();
            this.btnnaarList = new System.Windows.Forms.Button();
            this.btnWisSelectedLst = new System.Windows.Forms.Button();
            this.btnWisSelectedCmb = new System.Windows.Forms.Button();
            this.chkSortLst = new System.Windows.Forms.CheckBox();
            this.chkSortCmb = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstLijst
            // 
            this.lstLijst.FormattingEnabled = true;
            this.lstLijst.Items.AddRange(new object[] {
            "een",
            "twee",
            "drie",
            "vier",
            "vijf",
            "zes"});
            this.lstLijst.Location = new System.Drawing.Point(53, 93);
            this.lstLijst.Name = "lstLijst";
            this.lstLijst.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLijst.Size = new System.Drawing.Size(128, 160);
            this.lstLijst.TabIndex = 0;
            // 
            // cmbLijst
            // 
            this.cmbLijst.FormattingEnabled = true;
            this.cmbLijst.Location = new System.Drawing.Point(368, 93);
            this.cmbLijst.Name = "cmbLijst";
            this.cmbLijst.Size = new System.Drawing.Size(121, 21);
            this.cmbLijst.TabIndex = 1;
            // 
            // btnnaarcmb
            // 
            this.btnnaarcmb.Location = new System.Drawing.Point(240, 114);
            this.btnnaarcmb.Name = "btnnaarcmb";
            this.btnnaarcmb.Size = new System.Drawing.Size(75, 35);
            this.btnnaarcmb.TabIndex = 2;
            this.btnnaarcmb.Text = ">>";
            this.btnnaarcmb.UseVisualStyleBackColor = true;
            this.btnnaarcmb.Click += new System.EventHandler(this.btnnaarcmb_Click);
            // 
            // btnnaarList
            // 
            this.btnnaarList.Location = new System.Drawing.Point(240, 155);
            this.btnnaarList.Name = "btnnaarList";
            this.btnnaarList.Size = new System.Drawing.Size(75, 35);
            this.btnnaarList.TabIndex = 3;
            this.btnnaarList.Text = "<<";
            this.btnnaarList.UseVisualStyleBackColor = true;
            this.btnnaarList.Click += new System.EventHandler(this.btnnaarList_Click);
            // 
            // btnWisSelectedLst
            // 
            this.btnWisSelectedLst.Location = new System.Drawing.Point(53, 276);
            this.btnWisSelectedLst.Name = "btnWisSelectedLst";
            this.btnWisSelectedLst.Size = new System.Drawing.Size(128, 23);
            this.btnWisSelectedLst.TabIndex = 4;
            this.btnWisSelectedLst.Text = "Niets Selecteren";
            this.btnWisSelectedLst.UseVisualStyleBackColor = true;
            this.btnWisSelectedLst.Click += new System.EventHandler(this.btnWisSelectedLst_Click);
            // 
            // btnWisSelectedCmb
            // 
            this.btnWisSelectedCmb.Location = new System.Drawing.Point(368, 276);
            this.btnWisSelectedCmb.Name = "btnWisSelectedCmb";
            this.btnWisSelectedCmb.Size = new System.Drawing.Size(128, 23);
            this.btnWisSelectedCmb.TabIndex = 5;
            this.btnWisSelectedCmb.Text = "Niets Selecteren";
            this.btnWisSelectedCmb.UseVisualStyleBackColor = true;
            this.btnWisSelectedCmb.Click += new System.EventHandler(this.btnWisSelectedCmb_Click);
            // 
            // chkSortLst
            // 
            this.chkSortLst.AutoSize = true;
            this.chkSortLst.Location = new System.Drawing.Point(53, 39);
            this.chkSortLst.Name = "chkSortLst";
            this.chkSortLst.Size = new System.Drawing.Size(60, 17);
            this.chkSortLst.TabIndex = 6;
            this.chkSortLst.Text = "Sorteer";
            this.chkSortLst.UseVisualStyleBackColor = true;
            this.chkSortLst.CheckedChanged += new System.EventHandler(this.chkSortLst_CheckedChanged);
            // 
            // chkSortCmb
            // 
            this.chkSortCmb.AutoSize = true;
            this.chkSortCmb.Location = new System.Drawing.Point(368, 39);
            this.chkSortCmb.Name = "chkSortCmb";
            this.chkSortCmb.Size = new System.Drawing.Size(60, 17);
            this.chkSortCmb.TabIndex = 7;
            this.chkSortCmb.Text = "Sorteer";
            this.chkSortCmb.UseVisualStyleBackColor = true;
            this.chkSortCmb.CheckedChanged += new System.EventHandler(this.chkSortCmb_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(230, 235);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Keuzelijsten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 354);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkSortCmb);
            this.Controls.Add(this.chkSortLst);
            this.Controls.Add(this.btnWisSelectedCmb);
            this.Controls.Add(this.btnWisSelectedLst);
            this.Controls.Add(this.btnnaarList);
            this.Controls.Add(this.btnnaarcmb);
            this.Controls.Add(this.cmbLijst);
            this.Controls.Add(this.lstLijst);
            this.Name = "Keuzelijsten";
            this.Text = "Keuzelijsten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLijst;
        private System.Windows.Forms.ComboBox cmbLijst;
        private System.Windows.Forms.Button btnnaarcmb;
        private System.Windows.Forms.Button btnnaarList;
        private System.Windows.Forms.Button btnWisSelectedLst;
        private System.Windows.Forms.Button btnWisSelectedCmb;
        private System.Windows.Forms.CheckBox chkSortLst;
        private System.Windows.Forms.CheckBox chkSortCmb;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}