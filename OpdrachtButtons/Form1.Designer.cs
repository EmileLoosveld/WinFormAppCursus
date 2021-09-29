
namespace OpdrachtButtons
{
    partial class frmHoofd
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRechts = new System.Windows.Forms.RadioButton();
            this.rdbCenter = new System.Windows.Forms.RadioButton();
            this.rdbLinks = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkInvoervak = new System.Windows.Forms.CheckBox();
            this.chkLabel = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.Location = new System.Drawing.Point(169, 160);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(990, 25);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "tekst";
            this.lblLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTekst
            // 
            this.txtTekst.AccessibleDescription = "";
            this.txtTekst.Location = new System.Drawing.Point(169, 273);
            this.txtTekst.Margin = new System.Windows.Forms.Padding(6);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(990, 29);
            this.txtTekst.TabIndex = 1;
            this.txtTekst.Text = "type hier iets";
            this.txtTekst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRechts);
            this.groupBox1.Controls.Add(this.rdbCenter);
            this.groupBox1.Controls.Add(this.rdbLinks);
            this.groupBox1.Location = new System.Drawing.Point(169, 404);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(367, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uitlijning";
            // 
            // rdbRechts
            // 
            this.rdbRechts.AutoSize = true;
            this.rdbRechts.Checked = true;
            this.rdbRechts.Location = new System.Drawing.Point(44, 227);
            this.rdbRechts.Margin = new System.Windows.Forms.Padding(6);
            this.rdbRechts.Name = "rdbRechts";
            this.rdbRechts.Size = new System.Drawing.Size(93, 29);
            this.rdbRechts.TabIndex = 2;
            this.rdbRechts.TabStop = true;
            this.rdbRechts.Text = "Rechts";
            this.rdbRechts.UseVisualStyleBackColor = true;
            this.rdbRechts.CheckedChanged += new System.EventHandler(this.uitlijning_ckeckedChanged);
            // 
            // rdbCenter
            // 
            this.rdbCenter.AutoSize = true;
            this.rdbCenter.Location = new System.Drawing.Point(44, 155);
            this.rdbCenter.Margin = new System.Windows.Forms.Padding(6);
            this.rdbCenter.Name = "rdbCenter";
            this.rdbCenter.Size = new System.Drawing.Size(92, 29);
            this.rdbCenter.TabIndex = 1;
            this.rdbCenter.Text = "Center";
            this.rdbCenter.UseVisualStyleBackColor = true;
            this.rdbCenter.CheckedChanged += new System.EventHandler(this.uitlijning_ckeckedChanged);
            // 
            // rdbLinks
            // 
            this.rdbLinks.AutoSize = true;
            this.rdbLinks.Location = new System.Drawing.Point(44, 78);
            this.rdbLinks.Margin = new System.Windows.Forms.Padding(6);
            this.rdbLinks.Name = "rdbLinks";
            this.rdbLinks.Size = new System.Drawing.Size(79, 29);
            this.rdbLinks.TabIndex = 0;
            this.rdbLinks.Text = "Links";
            this.rdbLinks.UseVisualStyleBackColor = true;
            this.rdbLinks.CheckedChanged += new System.EventHandler(this.uitlijning_ckeckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkInvoervak);
            this.groupBox2.Controls.Add(this.chkLabel);
            this.groupBox2.Location = new System.Drawing.Point(796, 404);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(367, 380);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toepassen op";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkInvoervak
            // 
            this.chkInvoervak.AutoSize = true;
            this.chkInvoervak.Location = new System.Drawing.Point(53, 227);
            this.chkInvoervak.Margin = new System.Windows.Forms.Padding(6);
            this.chkInvoervak.Name = "chkInvoervak";
            this.chkInvoervak.Size = new System.Drawing.Size(119, 29);
            this.chkInvoervak.TabIndex = 1;
            this.chkInvoervak.Text = "Invoervak";
            this.chkInvoervak.UseVisualStyleBackColor = true;
            // 
            // chkLabel
            // 
            this.chkLabel.AutoSize = true;
            this.chkLabel.Location = new System.Drawing.Point(53, 135);
            this.chkLabel.Margin = new System.Windows.Forms.Padding(6);
            this.chkLabel.Name = "chkLabel";
            this.chkLabel.Size = new System.Drawing.Size(82, 29);
            this.chkLabel.TabIndex = 0;
            this.chkLabel.Text = "Label";
            this.chkLabel.UseVisualStyleBackColor = true;
            // 
            // frmHoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.lblLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmHoofd";
            this.Text = "RadioButtons en CheckBoxen.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRechts;
        private System.Windows.Forms.RadioButton rdbCenter;
        private System.Windows.Forms.RadioButton rdbLinks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkInvoervak;
        private System.Windows.Forms.CheckBox chkLabel;
    }
}

