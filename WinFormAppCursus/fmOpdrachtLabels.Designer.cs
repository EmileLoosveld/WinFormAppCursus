
namespace WinFormAppCursus
{
    partial class fmOpdrachtLabels
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
            this.vrachtwagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vrachtwagen
            // 
            this.vrachtwagen.AutoSize = true;
            this.vrachtwagen.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.vrachtwagen.Location = new System.Drawing.Point(281, 202);
            this.vrachtwagen.Name = "vrachtwagen";
            this.vrachtwagen.Size = new System.Drawing.Size(19, 17);
            this.vrachtwagen.TabIndex = 0;
            this.vrachtwagen.Text = "h";
            this.vrachtwagen.Click += new System.EventHandler(this.vrachtwagen_Click);
            // 
            // fmOpdrachtLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(805, 448);
            this.Controls.Add(this.vrachtwagen);
            this.Name = "fmOpdrachtLabels";
            this.Text = "Label beweegt met pijltjestoetsen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vrachtwagen;
    }
}