
namespace KOFormulierenLabelsButtonsTextboxen
{
    partial class frmDialoog
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
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitel
            // 
            this.txtTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitel.Location = new System.Drawing.Point(0, 0);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(441, 20);
            this.txtTitel.TabIndex = 0;
            this.txtTitel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitel_KeyDown);
            // 
            // frmDialoog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 290);
            this.Controls.Add(this.txtTitel);
            this.Name = "frmDialoog";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialoogvenster";
            this.TransparencyKey = System.Drawing.Color.White;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDialoog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitel;
    }
}