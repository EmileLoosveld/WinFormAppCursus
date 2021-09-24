
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
            this.rdbLinks = new System.Windows.Forms.RadioButton();
            this.rdbCenter = new System.Windows.Forms.RadioButton();
            this.rdbRechts = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLabel = new System.Windows.Forms.CheckBox();
            this.chkInvoervak = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(273, 69);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(63, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Tekst Label";
            this.lblLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(92, 148);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(542, 20);
            this.txtTekst.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRechts);
            this.groupBox1.Controls.Add(this.rdbCenter);
            this.groupBox1.Controls.Add(this.rdbLinks);
            this.groupBox1.Location = new System.Drawing.Point(92, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uitlijning";
            // 
            // rdbLinks
            // 
            this.rdbLinks.AutoSize = true;
            this.rdbLinks.Location = new System.Drawing.Point(24, 42);
            this.rdbLinks.Name = "rdbLinks";
            this.rdbLinks.Size = new System.Drawing.Size(50, 17);
            this.rdbLinks.TabIndex = 0;
            this.rdbLinks.TabStop = true;
            this.rdbLinks.Text = "Links";
            this.rdbLinks.UseVisualStyleBackColor = true;
            // 
            // rdbCenter
            // 
            this.rdbCenter.AutoSize = true;
            this.rdbCenter.Location = new System.Drawing.Point(24, 84);
            this.rdbCenter.Name = "rdbCenter";
            this.rdbCenter.Size = new System.Drawing.Size(56, 17);
            this.rdbCenter.TabIndex = 1;
            this.rdbCenter.TabStop = true;
            this.rdbCenter.Text = "Center";
            this.rdbCenter.UseVisualStyleBackColor = true;
            // 
            // rdbRechts
            // 
            this.rdbRechts.AutoSize = true;
            this.rdbRechts.Location = new System.Drawing.Point(24, 123);
            this.rdbRechts.Name = "rdbRechts";
            this.rdbRechts.Size = new System.Drawing.Size(59, 17);
            this.rdbRechts.TabIndex = 2;
            this.rdbRechts.TabStop = true;
            this.rdbRechts.Text = "Rechts";
            this.rdbRechts.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkInvoervak);
            this.groupBox2.Controls.Add(this.chkLabel);
            this.groupBox2.Location = new System.Drawing.Point(434, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toepassen op";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkLabel
            // 
            this.chkLabel.AutoSize = true;
            this.chkLabel.Location = new System.Drawing.Point(29, 73);
            this.chkLabel.Name = "chkLabel";
            this.chkLabel.Size = new System.Drawing.Size(52, 17);
            this.chkLabel.TabIndex = 0;
            this.chkLabel.Text = "Label";
            this.chkLabel.UseVisualStyleBackColor = true;
            // 
            // chkInvoervak
            // 
            this.chkInvoervak.AutoSize = true;
            this.chkInvoervak.Location = new System.Drawing.Point(29, 123);
            this.chkInvoervak.Name = "chkInvoervak";
            this.chkInvoervak.Size = new System.Drawing.Size(74, 17);
            this.chkInvoervak.TabIndex = 1;
            this.chkInvoervak.Text = "Invoervak";
            this.chkInvoervak.UseVisualStyleBackColor = true;
            // 
            // frmHoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.lblLabel);
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

