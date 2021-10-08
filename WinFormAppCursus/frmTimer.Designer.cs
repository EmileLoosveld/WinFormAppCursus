
namespace WinFormAppCursus
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            this.lblText = new System.Windows.Forms.Label();
            this.tmrTekst = new System.Windows.Forms.Timer(this.components);
            this.chkStartStop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(141, 54);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(68, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Druk op start";
            // 
            // tmrTekst
            // 
            this.tmrTekst.Interval = 1000;
            this.tmrTekst.Tick += new System.EventHandler(this.tmrTekst_Tick);
            // 
            // chkStartStop
            // 
            this.chkStartStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStartStop.AutoSize = true;
            this.chkStartStop.Location = new System.Drawing.Point(63, 49);
            this.chkStartStop.Name = "chkStartStop";
            this.chkStartStop.Size = new System.Drawing.Size(37, 23);
            this.chkStartStop.TabIndex = 2;
            this.chkStartStop.Text = "start";
            this.chkStartStop.UseVisualStyleBackColor = true;
            this.chkStartStop.CheckedChanged += new System.EventHandler(this.chkStartStop_CheckedChanged);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 121);
            this.Controls.Add(this.chkStartStop);
            this.Controls.Add(this.lblText);
            this.Name = "frmTimer";
            this.Text = "Timer testen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Timer tmrTekst;
        private System.Windows.Forms.CheckBox chkStartStop;
    }
}