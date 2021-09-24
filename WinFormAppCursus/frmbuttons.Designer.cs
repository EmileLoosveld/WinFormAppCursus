
namespace WinFormAppCursus
{
    partial class frmbuttons
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
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnCentreer = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLinks
            // 
            this.btnLinks.Location = new System.Drawing.Point(88, 108);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(152, 23);
            this.btnLinks.TabIndex = 0;
            this.btnLinks.Text = "Links uitlijnen";
            this.btnLinks.UseVisualStyleBackColor = true;
            this.btnLinks.Click += new System.EventHandler(this.btnUitlijnen_Click);
            // 
            // btnCentreer
            // 
            this.btnCentreer.Location = new System.Drawing.Point(327, 108);
            this.btnCentreer.Name = "btnCentreer";
            this.btnCentreer.Size = new System.Drawing.Size(138, 23);
            this.btnCentreer.TabIndex = 1;
            this.btnCentreer.Text = "Centreren";
            this.btnCentreer.UseVisualStyleBackColor = true;
            this.btnCentreer.Click += new System.EventHandler(this.btnUitlijnen_Click);
            // 
            // btnRechts
            // 
            this.btnRechts.Location = new System.Drawing.Point(550, 108);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(160, 23);
            this.btnRechts.TabIndex = 2;
            this.btnRechts.Text = "Rechts centreren";
            this.btnRechts.UseVisualStyleBackColor = true;
            this.btnRechts.Click += new System.EventHandler(this.btnUitlijnen_Click);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(88, 47);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(622, 20);
            this.txtTekst.TabIndex = 3;
            this.txtTekst.Text = "Hallo 6ICT";
            // 
            // frmbuttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 207);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnCentreer);
            this.Controls.Add(this.btnLinks);
            this.Name = "frmbuttons";
            this.Text = "frmbuttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnCentreer;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.TextBox txtTekst;
    }
}