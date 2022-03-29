
namespace ExamenPasen
{
    partial class Form1
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
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.verbindingVerbreken = new System.Windows.Forms.Button();
            this.btnZoekPoorten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPoort
            // 
            this.lstPoort.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.Location = new System.Drawing.Point(0, 0);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(148, 450);
            this.lstPoort.TabIndex = 0;
            this.lstPoort.SelectedIndexChanged += new System.EventHandler(this.lstPoort_SelectedIndexChanged);
            // 
            // serial
            // 
            this.serial.WriteTimeout = 1000;
            this.serial.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serial_PinChanged);
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // verbindingVerbreken
            // 
            this.verbindingVerbreken.Location = new System.Drawing.Point(154, 12);
            this.verbindingVerbreken.Name = "verbindingVerbreken";
            this.verbindingVerbreken.Size = new System.Drawing.Size(131, 23);
            this.verbindingVerbreken.TabIndex = 1;
            this.verbindingVerbreken.Text = "Verbinding verbreken";
            this.verbindingVerbreken.UseVisualStyleBackColor = true;
            this.verbindingVerbreken.Click += new System.EventHandler(this.verbindingVerbreken_Click);
            // 
            // btnZoekPoorten
            // 
            this.btnZoekPoorten.Location = new System.Drawing.Point(155, 42);
            this.btnZoekPoorten.Name = "btnZoekPoorten";
            this.btnZoekPoorten.Size = new System.Drawing.Size(130, 23);
            this.btnZoekPoorten.TabIndex = 2;
            this.btnZoekPoorten.Text = "Zoek poorten";
            this.btnZoekPoorten.UseVisualStyleBackColor = true;
            this.btnZoekPoorten.Click += new System.EventHandler(this.btnZoekPoorten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZoekPoorten);
            this.Controls.Add(this.verbindingVerbreken);
            this.Controls.Add(this.lstPoort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPoort;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Button verbindingVerbreken;
        private System.Windows.Forms.Button btnZoekPoorten;
    }
}

