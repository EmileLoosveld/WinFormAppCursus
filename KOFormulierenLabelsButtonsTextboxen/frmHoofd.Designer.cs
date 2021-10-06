
namespace KOFormulierenLabelsButtonsTextboxen
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
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btndialoogvenster = new System.Windows.Forms.Button();
            this.lblGroen = new System.Windows.Forms.Label();
            this.lblWit = new System.Windows.Forms.Label();
            this.lblBlauw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAfsluiten.Location = new System.Drawing.Point(334, 240);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(141, 23);
            this.btnAfsluiten.TabIndex = 1;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btndialoogvenster
            // 
            this.btndialoogvenster.Location = new System.Drawing.Point(151, 240);
            this.btndialoogvenster.Name = "btndialoogvenster";
            this.btndialoogvenster.Size = new System.Drawing.Size(141, 23);
            this.btndialoogvenster.TabIndex = 0;
            this.btndialoogvenster.Text = "Dialoogvenster openen";
            this.btndialoogvenster.UseVisualStyleBackColor = true;
            this.btndialoogvenster.Click += new System.EventHandler(this.btndialoogvenster_Click);
            // 
            // lblGroen
            // 
            this.lblGroen.AutoSize = true;
            this.lblGroen.BackColor = System.Drawing.Color.Lime;
            this.lblGroen.Location = new System.Drawing.Point(269, 63);
            this.lblGroen.Name = "lblGroen";
            this.lblGroen.Size = new System.Drawing.Size(34, 13);
            this.lblGroen.TabIndex = 2;
            this.lblGroen.Text = "groen";
            this.lblGroen.Enter += new System.EventHandler(this.lblBlauw_DragEnter);
            this.lblGroen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // lblWit
            // 
            this.lblWit.AutoSize = true;
            this.lblWit.BackColor = System.Drawing.Color.White;
            this.lblWit.Location = new System.Drawing.Point(269, 108);
            this.lblWit.Name = "lblWit";
            this.lblWit.Size = new System.Drawing.Size(23, 13);
            this.lblWit.TabIndex = 3;
            this.lblWit.Text = "Wit";
            this.lblWit.Enter += new System.EventHandler(this.lblBlauw_DragEnter);
            this.lblWit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // lblBlauw
            // 
            this.lblBlauw.AutoSize = true;
            this.lblBlauw.BackColor = System.Drawing.Color.Blue;
            this.lblBlauw.Location = new System.Drawing.Point(269, 154);
            this.lblBlauw.Name = "lblBlauw";
            this.lblBlauw.Size = new System.Drawing.Size(36, 13);
            this.lblBlauw.TabIndex = 4;
            this.lblBlauw.Text = "Blauw";
            this.lblBlauw.Enter += new System.EventHandler(this.lblBlauw_DragEnter);
            this.lblBlauw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // frmHoofd
            // 
            this.AcceptButton = this.btndialoogvenster;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAfsluiten;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBlauw);
            this.Controls.Add(this.lblWit);
            this.Controls.Add(this.lblGroen);
            this.Controls.Add(this.btndialoogvenster);
            this.Controls.Add(this.btnAfsluiten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHoofd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KO1 Emile Loosveld";
            this.Load += new System.EventHandler(this.frmHoofd_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmHoofd_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button btndialoogvenster;
        private System.Windows.Forms.Label lblGroen;
        private System.Windows.Forms.Label lblWit;
        private System.Windows.Forms.Label lblBlauw;
    }
}

