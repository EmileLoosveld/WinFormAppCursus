
namespace WinFormsAppTCPIPServer
{
    partial class frmTCPIPServer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtMelding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommunicatie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVerbreek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtIPadres = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPoortnr = new System.Windows.Forms.MaskedTextBox();
            this.chkStartServer = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBericht = new System.Windows.Forms.TextBox();
            this.btnZend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bgWorkerListener = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerOntvang = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(354, 618);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 72);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.txtMelding);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.txtCommunicatie);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Size = new System.Drawing.Size(354, 451);
            this.splitContainer2.SplitterDistance = 268;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            // 
            // txtMelding
            // 
            this.txtMelding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMelding.Location = new System.Drawing.Point(0, 28);
            this.txtMelding.Margin = new System.Windows.Forms.Padding(2);
            this.txtMelding.Multiline = true;
            this.txtMelding.Name = "txtMelding";
            this.txtMelding.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMelding.Size = new System.Drawing.Size(354, 240);
            this.txtMelding.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meldingen:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCommunicatie
            // 
            this.txtCommunicatie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommunicatie.Location = new System.Drawing.Point(0, 27);
            this.txtCommunicatie.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommunicatie.Multiline = true;
            this.txtCommunicatie.Name = "txtCommunicatie";
            this.txtCommunicatie.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommunicatie.Size = new System.Drawing.Size(354, 153);
            this.txtCommunicatie.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Berichten:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnVerbreek, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtxtIPadres, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtxtPoortnr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkStartServer, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnVerbreek
            // 
            this.btnVerbreek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerbreek.Enabled = false;
            this.btnVerbreek.Location = new System.Drawing.Point(179, 46);
            this.btnVerbreek.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerbreek.Name = "btnVerbreek";
            this.btnVerbreek.Size = new System.Drawing.Size(173, 24);
            this.btnVerbreek.TabIndex = 5;
            this.btnVerbreek.Text = "Verbreek verbinding";
            this.btnVerbreek.UseVisualStyleBackColor = true;
            this.btnVerbreek.Click += new System.EventHandler(this.btnVerbreek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(179, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poort-nr.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP-adres:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtIPadres
            // 
            this.mtxtIPadres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxtIPadres.Location = new System.Drawing.Point(2, 25);
            this.mtxtIPadres.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtIPadres.Mask = "990,990,990,990";
            this.mtxtIPadres.Name = "mtxtIPadres";
            this.mtxtIPadres.Size = new System.Drawing.Size(173, 20);
            this.mtxtIPadres.TabIndex = 2;
            this.mtxtIPadres.Text = "127000000001";
            this.mtxtIPadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtIPadres.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtIPadres_MaskInputRejected);
            // 
            // mtxtPoortnr
            // 
            this.mtxtPoortnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxtPoortnr.Location = new System.Drawing.Point(179, 25);
            this.mtxtPoortnr.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPoortnr.Mask = "99000";
            this.mtxtPoortnr.Name = "mtxtPoortnr";
            this.mtxtPoortnr.Size = new System.Drawing.Size(173, 20);
            this.mtxtPoortnr.TabIndex = 3;
            this.mtxtPoortnr.Text = "50000";
            this.mtxtPoortnr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkStartServer
            // 
            this.chkStartServer.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStartServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkStartServer.Location = new System.Drawing.Point(2, 46);
            this.chkStartServer.Margin = new System.Windows.Forms.Padding(2);
            this.chkStartServer.Name = "chkStartServer";
            this.chkStartServer.Size = new System.Drawing.Size(173, 24);
            this.chkStartServer.TabIndex = 4;
            this.chkStartServer.Text = "Start Server";
            this.chkStartServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStartServer.UseVisualStyleBackColor = true;
            this.chkStartServer.CheckedChanged += new System.EventHandler(this.chkStartServer_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtBericht, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnZend, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 92);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // txtBericht
            // 
            this.txtBericht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBericht.Location = new System.Drawing.Point(2, 34);
            this.txtBericht.Margin = new System.Windows.Forms.Padding(2);
            this.txtBericht.Name = "txtBericht";
            this.txtBericht.Size = new System.Drawing.Size(452, 20);
            this.txtBericht.TabIndex = 9;
            this.txtBericht.Text = "Bericht van server";
            // 
            // btnZend
            // 
            this.btnZend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZend.Location = new System.Drawing.Point(2, 50);
            this.btnZend.Margin = new System.Windows.Forms.Padding(2);
            this.btnZend.Name = "btnZend";
            this.btnZend.Size = new System.Drawing.Size(452, 40);
            this.btnZend.TabIndex = 8;
            this.btnZend.Text = "Stuur bericht naar Client";
            this.btnZend.UseVisualStyleBackColor = true;
            this.btnZend.Click += new System.EventHandler(this.btnZend_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(452, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Verstuur bericht:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bgWorkerListener
            // 
            this.bgWorkerListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerListener_DoWork);
            this.bgWorkerListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerListener_RunWorkerCompleted);
            // 
            // bgWorkerOntvang
            // 
            this.bgWorkerOntvang.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerOntvang_DoWork);
            this.bgWorkerOntvang.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerOntvang_RunWorkerCompleted);
            // 
            // frmTCPIPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 618);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTCPIPServer";
            this.Text = "TCP/IP Server";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtMelding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCommunicatie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnVerbreek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtIPadres;
        private System.Windows.Forms.MaskedTextBox mtxtPoortnr;
        private System.Windows.Forms.CheckBox chkStartServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtBericht;
        private System.Windows.Forms.Button btnZend;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker bgWorkerListener;
        private System.ComponentModel.BackgroundWorker bgWorkerOntvang;
    }
}

