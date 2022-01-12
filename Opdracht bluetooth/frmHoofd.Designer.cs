
namespace Opdracht_bluetooth
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
            this.lstPoort = new System.Windows.Forms.ListBox();
            this.btnZoekPoorten = new System.Windows.Forms.Button();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.txtInvullen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttekst = new System.Windows.Forms.TextBox();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPoort
            // 
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.Location = new System.Drawing.Point(12, 12);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(120, 368);
            this.lstPoort.TabIndex = 0;
            this.lstPoort.SelectedIndexChanged += new System.EventHandler(this.lstPoort_SelectedIndexChanged);
            // 
            // btnZoekPoorten
            // 
            this.btnZoekPoorten.Location = new System.Drawing.Point(12, 383);
            this.btnZoekPoorten.Name = "btnZoekPoorten";
            this.btnZoekPoorten.Size = new System.Drawing.Size(120, 23);
            this.btnZoekPoorten.TabIndex = 1;
            this.btnZoekPoorten.Text = "Zoek poorten";
            this.btnZoekPoorten.UseVisualStyleBackColor = true;
            this.btnZoekPoorten.Click += new System.EventHandler(this.btnZoekPoorten_Click);
            // 
            // serial
            // 
            this.serial.PortName = "COM10";
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // txtInvullen
            // 
            this.txtInvullen.Location = new System.Drawing.Point(195, 414);
            this.txtInvullen.Name = "txtInvullen";
            this.txtInvullen.Size = new System.Drawing.Size(595, 20);
            this.txtInvullen.TabIndex = 2;
            this.txtInvullen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvullen_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tekst:";
            // 
            // txttekst
            // 
            this.txttekst.Location = new System.Drawing.Point(155, 12);
            this.txttekst.Multiline = true;
            this.txttekst.Name = "txttekst";
            this.txttekst.ReadOnly = true;
            this.txttekst.Size = new System.Drawing.Size(635, 394);
            this.txttekst.TabIndex = 4;
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.Enabled = false;
            this.btnCloseSerial.Location = new System.Drawing.Point(12, 411);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(120, 23);
            this.btnCloseSerial.TabIndex = 5;
            this.btnCloseSerial.Text = "Verbinding verbreken";
            this.btnCloseSerial.UseVisualStyleBackColor = true;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // frmHoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnCloseSerial);
            this.Controls.Add(this.txttekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvullen);
            this.Controls.Add(this.btnZoekPoorten);
            this.Controls.Add(this.lstPoort);
            this.Name = "frmHoofd";
            this.Text = "Bluetooth communicatie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoofd_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPoort;
        private System.Windows.Forms.Button btnZoekPoorten;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.TextBox txtInvullen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttekst;
        private System.Windows.Forms.Button btnCloseSerial;
    }
}

