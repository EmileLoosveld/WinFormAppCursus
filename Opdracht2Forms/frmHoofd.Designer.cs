
namespace Opdracht2Forms
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
            this.knop1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // knop1
            // 
            this.knop1.Location = new System.Drawing.Point(244, 125);
            this.knop1.Name = "knop1";
            this.knop1.Size = new System.Drawing.Size(75, 23);
            this.knop1.TabIndex = 0;
            this.knop1.Text = "Knop 1";
            this.knop1.UseVisualStyleBackColor = true;
            this.knop1.Click += new System.EventHandler(this.knop1_Click);
            this.knop1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.knop1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Knop 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmHoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.knop1);
            this.Name = "frmHoofd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHoofd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button knop1;
        private System.Windows.Forms.Button button2;
    }
}

