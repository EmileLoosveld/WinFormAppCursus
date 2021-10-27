
namespace WinFormAppCursus
{
    partial class frmHoofdDialog
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
            this.lblTekst = new System.Windows.Forms.Label();
            this.btnOpties = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(51, 48);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(65, 13);
            this.lblTekst.TabIndex = 0;
            this.lblTekst.Text = "Kleur kiezen";
            // 
            // btnOpties
            // 
            this.btnOpties.Location = new System.Drawing.Point(135, 43);
            this.btnOpties.Name = "btnOpties";
            this.btnOpties.Size = new System.Drawing.Size(75, 23);
            this.btnOpties.TabIndex = 1;
            this.btnOpties.Text = "Opties";
            this.btnOpties.UseVisualStyleBackColor = true;
            this.btnOpties.Click += new System.EventHandler(this.btnOpties_Click);
            // 
            // frmHoofdDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 109);
            this.Controls.Add(this.btnOpties);
            this.Controls.Add(this.lblTekst);
            this.Name = "frmHoofdDialog";
            this.Text = "frmHoofdDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Button btnOpties;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}