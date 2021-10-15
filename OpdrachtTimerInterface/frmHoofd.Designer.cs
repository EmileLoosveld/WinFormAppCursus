
namespace OpdrachtTimerInterface
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
            this.components = new System.ComponentModel.Container();
            this.chkKnipper = new System.Windows.Forms.CheckBox();
            this.grpTijd = new System.Windows.Forms.GroupBox();
            this.rdbTien = new System.Windows.Forms.RadioButton();
            this.rdbVijf = new System.Windows.Forms.RadioButton();
            this.rdbEen = new System.Windows.Forms.RadioButton();
            this.tmrKnipper = new System.Windows.Forms.Timer(this.components);
            this.grpTijd.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkKnipper
            // 
            this.chkKnipper.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKnipper.AutoSize = true;
            this.chkKnipper.Location = new System.Drawing.Point(181, 47);
            this.chkKnipper.Name = "chkKnipper";
            this.chkKnipper.Size = new System.Drawing.Size(53, 23);
            this.chkKnipper.TabIndex = 0;
            this.chkKnipper.Text = "Knipper";
            this.chkKnipper.UseVisualStyleBackColor = true;
            this.chkKnipper.CheckedChanged += new System.EventHandler(this.chkKnipper_CheckedChanged);
            // 
            // grpTijd
            // 
            this.grpTijd.Controls.Add(this.rdbTien);
            this.grpTijd.Controls.Add(this.rdbVijf);
            this.grpTijd.Controls.Add(this.rdbEen);
            this.grpTijd.Location = new System.Drawing.Point(40, 33);
            this.grpTijd.Name = "grpTijd";
            this.grpTijd.Size = new System.Drawing.Size(96, 180);
            this.grpTijd.TabIndex = 1;
            this.grpTijd.TabStop = false;
            this.grpTijd.Text = "Tijden";
            // 
            // rdbTien
            // 
            this.rdbTien.AutoSize = true;
            this.rdbTien.Location = new System.Drawing.Point(13, 140);
            this.rdbTien.Name = "rdbTien";
            this.rdbTien.Size = new System.Drawing.Size(57, 17);
            this.rdbTien.TabIndex = 2;
            this.rdbTien.Text = "10 sec";
            this.rdbTien.UseVisualStyleBackColor = true;
            this.rdbTien.CheckedChanged += new System.EventHandler(this.rdbEen_CheckedChanged);
            // 
            // rdbVijf
            // 
            this.rdbVijf.AutoSize = true;
            this.rdbVijf.Checked = true;
            this.rdbVijf.Location = new System.Drawing.Point(13, 95);
            this.rdbVijf.Name = "rdbVijf";
            this.rdbVijf.Size = new System.Drawing.Size(51, 17);
            this.rdbVijf.TabIndex = 1;
            this.rdbVijf.TabStop = true;
            this.rdbVijf.Text = "5 sec";
            this.rdbVijf.UseVisualStyleBackColor = true;
            this.rdbVijf.CheckedChanged += new System.EventHandler(this.rdbEen_CheckedChanged);
            // 
            // rdbEen
            // 
            this.rdbEen.AutoSize = true;
            this.rdbEen.Location = new System.Drawing.Point(13, 49);
            this.rdbEen.Name = "rdbEen";
            this.rdbEen.Size = new System.Drawing.Size(51, 17);
            this.rdbEen.TabIndex = 0;
            this.rdbEen.Text = "1 sec";
            this.rdbEen.UseVisualStyleBackColor = true;
            this.rdbEen.CheckedChanged += new System.EventHandler(this.rdbEen_CheckedChanged);
            // 
            // tmrKnipper
            // 
            this.tmrKnipper.Interval = 5000;
            this.tmrKnipper.Tick += new System.EventHandler(this.tmrKnipper_Tick);
            // 
            // frmHoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 274);
            this.Controls.Add(this.grpTijd);
            this.Controls.Add(this.chkKnipper);
            this.Name = "frmHoofd";
            this.Text = "Timer LED | Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoofd_FormClosing);
            this.grpTijd.ResumeLayout(false);
            this.grpTijd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkKnipper;
        private System.Windows.Forms.GroupBox grpTijd;
        private System.Windows.Forms.RadioButton rdbTien;
        private System.Windows.Forms.RadioButton rdbVijf;
        private System.Windows.Forms.RadioButton rdbEen;
        private System.Windows.Forms.Timer tmrKnipper;
    }
}

