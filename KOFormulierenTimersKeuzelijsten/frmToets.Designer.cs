
namespace KOFormulierenTimersKeuzelijsten
{
    partial class frmToets
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
            this.lblBeweeg = new System.Windows.Forms.Label();
            this.tmrTijd = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnVerder = new System.Windows.Forms.Button();
            this.lstTijd = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.txtVoegToe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBeweeg
            // 
            this.lblBeweeg.AutoSize = true;
            this.lblBeweeg.Font = new System.Drawing.Font("Webdings", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblBeweeg.Location = new System.Drawing.Point(0, 0);
            this.lblBeweeg.Name = "lblBeweeg";
            this.lblBeweeg.Size = new System.Drawing.Size(48, 34);
            this.lblBeweeg.TabIndex = 0;
            this.lblBeweeg.Text = "e";
            // 
            // tmrTijd
            // 
            this.tmrTijd.Tick += new System.EventHandler(this.tmrTijd_Tick);
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(87, 208);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(87, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start vanaf begin";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnVerder
            // 
            this.btnVerder.Location = new System.Drawing.Point(87, 179);
            this.btnVerder.Name = "btnVerder";
            this.btnVerder.Size = new System.Drawing.Size(128, 23);
            this.btnVerder.TabIndex = 3;
            this.btnVerder.Text = "Ga Verder";
            this.btnVerder.UseVisualStyleBackColor = true;
            this.btnVerder.Click += new System.EventHandler(this.btnVerder_Click);
            // 
            // lstTijd
            // 
            this.lstTijd.FormattingEnabled = true;
            this.lstTijd.Items.AddRange(new object[] {
            "10",
            "100",
            "1000"});
            this.lstTijd.Location = new System.Drawing.Point(270, 150);
            this.lstTijd.Name = "lstTijd";
            this.lstTijd.Size = new System.Drawing.Size(120, 95);
            this.lstTijd.Sorted = true;
            this.lstTijd.TabIndex = 4;
            this.lstTijd.SelectedValueChanged += new System.EventHandler(this.lstTijd_SelectedValueChanged);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(426, 150);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegToe.TabIndex = 5;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVoegToe_MouseUp);
            // 
            // txtVoegToe
            // 
            this.txtVoegToe.Location = new System.Drawing.Point(270, 251);
            this.txtVoegToe.Name = "txtVoegToe";
            this.txtVoegToe.Size = new System.Drawing.Size(120, 20);
            this.txtVoegToe.TabIndex = 6;
            // 
            // frmToets
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVoegToe);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lstTijd);
            this.Controls.Add(this.btnVerder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblBeweeg);
            this.Name = "frmToets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KO2 Emile Loosveld";
            this.ClientSizeChanged += new System.EventHandler(this.frmToets_ClientSizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeweeg;
        private System.Windows.Forms.Timer tmrTijd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnVerder;
        private System.Windows.Forms.ListBox lstTijd;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.TextBox txtVoegToe;
    }
}