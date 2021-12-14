
namespace ExtraOefenen
{
    partial class frmConnectSub
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
            this.btnWijzigTekstHoofdfrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWijzigTekstHoofdfrm
            // 
            this.btnWijzigTekstHoofdfrm.Location = new System.Drawing.Point(98, 91);
            this.btnWijzigTekstHoofdfrm.Name = "btnWijzigTekstHoofdfrm";
            this.btnWijzigTekstHoofdfrm.Size = new System.Drawing.Size(252, 81);
            this.btnWijzigTekstHoofdfrm.TabIndex = 0;
            this.btnWijzigTekstHoofdfrm.Text = "Wijzig tekst hoofd frm";
            this.btnWijzigTekstHoofdfrm.UseVisualStyleBackColor = true;
            this.btnWijzigTekstHoofdfrm.Click += new System.EventHandler(this.btnWijzigTekstHoofdfrm_Click);
            // 
            // frmConnectSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWijzigTekstHoofdfrm);
            this.Name = "frmConnectSub";
            this.Text = "frmConnectSub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnectSub_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWijzigTekstHoofdfrm;
    }
}