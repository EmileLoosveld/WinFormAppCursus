
namespace WinFormAppCursus
{
    partial class frmOptiesDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbVoorZwart = new System.Windows.Forms.RadioButton();
            this.rdbVoorWit = new System.Windows.Forms.RadioButton();
            this.rdbVoorRood = new System.Windows.Forms.RadioButton();
            this.rdbAchterStandaard = new System.Windows.Forms.RadioButton();
            this.rdbAchterWit = new System.Windows.Forms.RadioButton();
            this.rdbAchterZwart = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVoorRood);
            this.groupBox1.Controls.Add(this.rdbVoorWit);
            this.groupBox1.Controls.Add(this.rdbVoorZwart);
            this.groupBox1.Location = new System.Drawing.Point(67, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voorgrondkleur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAchterZwart);
            this.groupBox2.Controls.Add(this.rdbAchterWit);
            this.groupBox2.Controls.Add(this.rdbAchterStandaard);
            this.groupBox2.Location = new System.Drawing.Point(284, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Achtergrondkleur";
            // 
            // rdbVoorZwart
            // 
            this.rdbVoorZwart.AutoSize = true;
            this.rdbVoorZwart.Checked = true;
            this.rdbVoorZwart.Location = new System.Drawing.Point(23, 50);
            this.rdbVoorZwart.Name = "rdbVoorZwart";
            this.rdbVoorZwart.Size = new System.Drawing.Size(52, 17);
            this.rdbVoorZwart.TabIndex = 0;
            this.rdbVoorZwart.TabStop = true;
            this.rdbVoorZwart.Text = "Zwart";
            this.rdbVoorZwart.UseVisualStyleBackColor = true;
            // 
            // rdbVoorWit
            // 
            this.rdbVoorWit.AutoSize = true;
            this.rdbVoorWit.Location = new System.Drawing.Point(23, 110);
            this.rdbVoorWit.Name = "rdbVoorWit";
            this.rdbVoorWit.Size = new System.Drawing.Size(41, 17);
            this.rdbVoorWit.TabIndex = 1;
            this.rdbVoorWit.Text = "Wit";
            this.rdbVoorWit.UseVisualStyleBackColor = true;
            // 
            // rdbVoorRood
            // 
            this.rdbVoorRood.AutoSize = true;
            this.rdbVoorRood.Location = new System.Drawing.Point(23, 174);
            this.rdbVoorRood.Name = "rdbVoorRood";
            this.rdbVoorRood.Size = new System.Drawing.Size(51, 17);
            this.rdbVoorRood.TabIndex = 2;
            this.rdbVoorRood.Text = "Rood";
            this.rdbVoorRood.UseVisualStyleBackColor = true;
            // 
            // rdbAchterStandaard
            // 
            this.rdbAchterStandaard.AutoSize = true;
            this.rdbAchterStandaard.Checked = true;
            this.rdbAchterStandaard.Location = new System.Drawing.Point(24, 50);
            this.rdbAchterStandaard.Name = "rdbAchterStandaard";
            this.rdbAchterStandaard.Size = new System.Drawing.Size(74, 17);
            this.rdbAchterStandaard.TabIndex = 0;
            this.rdbAchterStandaard.TabStop = true;
            this.rdbAchterStandaard.Text = "Standaard";
            this.rdbAchterStandaard.UseVisualStyleBackColor = true;
            // 
            // rdbAchterWit
            // 
            this.rdbAchterWit.AutoSize = true;
            this.rdbAchterWit.Location = new System.Drawing.Point(24, 110);
            this.rdbAchterWit.Name = "rdbAchterWit";
            this.rdbAchterWit.Size = new System.Drawing.Size(41, 17);
            this.rdbAchterWit.TabIndex = 1;
            this.rdbAchterWit.Text = "Wit";
            this.rdbAchterWit.UseVisualStyleBackColor = true;
            // 
            // rdbAchterZwart
            // 
            this.rdbAchterZwart.AutoSize = true;
            this.rdbAchterZwart.Location = new System.Drawing.Point(24, 174);
            this.rdbAchterZwart.Name = "rdbAchterZwart";
            this.rdbAchterZwart.Size = new System.Drawing.Size(52, 17);
            this.rdbAchterZwart.TabIndex = 2;
            this.rdbAchterZwart.Text = "Zwart";
            this.rdbAchterZwart.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(308, 348);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 34);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(177, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmOptiesDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(505, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmOptiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOptiesDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVoorRood;
        private System.Windows.Forms.RadioButton rdbVoorWit;
        private System.Windows.Forms.RadioButton rdbVoorZwart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAchterZwart;
        private System.Windows.Forms.RadioButton rdbAchterWit;
        private System.Windows.Forms.RadioButton rdbAchterStandaard;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}