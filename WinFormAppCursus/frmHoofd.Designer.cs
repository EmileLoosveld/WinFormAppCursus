
namespace WinFormAppCursus
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
            this.btnToonVenster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToonVenster
            // 
            this.btnToonVenster.Location = new System.Drawing.Point(222, 168);
            this.btnToonVenster.Name = "btnToonVenster";
            this.btnToonVenster.Size = new System.Drawing.Size(75, 23);
            this.btnToonVenster.TabIndex = 0;
            this.btnToonVenster.Text = "Toon venster";
            this.btnToonVenster.UseVisualStyleBackColor = true;
            this.btnToonVenster.Click += new System.EventHandler(this.btnToonVenster_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(222, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmHoofd
            // 
            this.AcceptButton = this.btnToonVenster;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(723, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnToonVenster);
            this.Name = "frmHoofd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHoofd_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmHoofd_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToonVenster;
        private System.Windows.Forms.Button button1;
    }
}

