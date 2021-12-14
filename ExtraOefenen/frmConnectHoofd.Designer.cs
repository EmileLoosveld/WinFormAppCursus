namespace ExtraOefenen
{
    partial class frmConnectHoofd
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
            this.btnOpenSub = new System.Windows.Forms.Button();
            this.btnToonTekst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenSub
            // 
            this.btnOpenSub.Location = new System.Drawing.Point(38, 34);
            this.btnOpenSub.Name = "btnOpenSub";
            this.btnOpenSub.Size = new System.Drawing.Size(120, 77);
            this.btnOpenSub.TabIndex = 0;
            this.btnOpenSub.Text = "Open sub form";
            this.btnOpenSub.UseVisualStyleBackColor = true;
            this.btnOpenSub.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnToonTekst
            // 
            this.btnToonTekst.Location = new System.Drawing.Point(38, 129);
            this.btnToonTekst.Name = "btnToonTekst";
            this.btnToonTekst.Size = new System.Drawing.Size(120, 63);
            this.btnToonTekst.TabIndex = 1;
            this.btnToonTekst.Text = "Toon tekst";
            this.btnToonTekst.UseVisualStyleBackColor = true;
            this.btnToonTekst.Click += new System.EventHandler(this.btnToonTekst_Click);
            // 
            // frmConnectHoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToonTekst);
            this.Controls.Add(this.btnOpenSub);
            this.Name = "frmConnectHoofd";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSub;
        private System.Windows.Forms.Button btnToonTekst;
    }
}

