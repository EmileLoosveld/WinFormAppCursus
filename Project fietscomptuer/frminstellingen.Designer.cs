
namespace Project_fietscomptuer
{
    partial class frminstellingen
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnSlaOp = new System.Windows.Forms.Button();
            this.btnTestRennerRit = new System.Windows.Forms.Button();
            this.numWielLengte = new System.Windows.Forms.NumericUpDown();
            this.numAfstand = new System.Windows.Forms.NumericUpDown();
            this.btnTestRenner = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInstellingen = new System.Windows.Forms.Panel();
            this.pnlPoort = new System.Windows.Forms.Panel();
            this.pnlKaart = new System.Windows.Forms.Panel();
            this.picFiets = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.picKaart = new System.Windows.Forms.PictureBox();
            this.tmrSimuleerRit = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.lstPoort = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWiel = new System.Windows.Forms.Label();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWielLengte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfstand)).BeginInit();
            this.pnlInstellingen.SuspendLayout();
            this.pnlPoort.SuspendLayout();
            this.pnlKaart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFiets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKaart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnSlaOp);
            this.pnlInfo.Controls.Add(this.btnTestRennerRit);
            this.pnlInfo.Controls.Add(this.numWielLengte);
            this.pnlInfo.Controls.Add(this.numAfstand);
            this.pnlInfo.Controls.Add(this.btnTestRenner);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1049, 142);
            this.pnlInfo.TabIndex = 0;
            // 
            // btnSlaOp
            // 
            this.btnSlaOp.Location = new System.Drawing.Point(787, 37);
            this.btnSlaOp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSlaOp.Name = "btnSlaOp";
            this.btnSlaOp.Size = new System.Drawing.Size(142, 36);
            this.btnSlaOp.TabIndex = 8;
            this.btnSlaOp.Text = "Gegevens opslaan";
            this.btnSlaOp.UseVisualStyleBackColor = true;
            this.btnSlaOp.Click += new System.EventHandler(this.btnSlaOp_Click);
            // 
            // btnTestRennerRit
            // 
            this.btnTestRennerRit.Location = new System.Drawing.Point(633, 78);
            this.btnTestRennerRit.Name = "btnTestRennerRit";
            this.btnTestRennerRit.Size = new System.Drawing.Size(142, 36);
            this.btnTestRennerRit.TabIndex = 7;
            this.btnTestRennerRit.Text = "Test Renner met Fietswiel VOLLEDIG";
            this.btnTestRennerRit.UseVisualStyleBackColor = true;
            this.btnTestRennerRit.Click += new System.EventHandler(this.btnTestRennerRit_Click);
            // 
            // numWielLengte
            // 
            this.numWielLengte.DecimalPlaces = 3;
            this.numWielLengte.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numWielLengte.Location = new System.Drawing.Point(506, 57);
            this.numWielLengte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numWielLengte.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWielLengte.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            196608});
            this.numWielLengte.Name = "numWielLengte";
            this.numWielLengte.Size = new System.Drawing.Size(52, 20);
            this.numWielLengte.TabIndex = 6;
            this.numWielLengte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWielLengte.Value = new decimal(new int[] {
            2175,
            0,
            0,
            196608});
            this.numWielLengte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_Increment);
            this.numWielLengte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Num_Increment);
            this.numWielLengte.Leave += new System.EventHandler(this.num_ValueChanged);
            // 
            // numAfstand
            // 
            this.numAfstand.DecimalPlaces = 1;
            this.numAfstand.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAfstand.Location = new System.Drawing.Point(170, 57);
            this.numAfstand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAfstand.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAfstand.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAfstand.Name = "numAfstand";
            this.numAfstand.Size = new System.Drawing.Size(52, 20);
            this.numAfstand.TabIndex = 5;
            this.numAfstand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAfstand.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAfstand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_Increment);
            this.numAfstand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Num_Increment);
            this.numAfstand.Leave += new System.EventHandler(this.num_ValueChanged);
            // 
            // btnTestRenner
            // 
            this.btnTestRenner.Location = new System.Drawing.Point(633, 36);
            this.btnTestRenner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestRenner.Name = "btnTestRenner";
            this.btnTestRenner.Size = new System.Drawing.Size(142, 36);
            this.btnTestRenner.TabIndex = 4;
            this.btnTestRenner.Text = "Test Renner met Fietswiel STAP VOOR STAP";
            this.btnTestRenner.UseVisualStyleBackColor = true;
            this.btnTestRenner.Click += new System.EventHandler(this.btnTestRenner_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "lengte fietswiel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "km";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "afstand rit:";
            // 
            // pnlInstellingen
            // 
            this.pnlInstellingen.Controls.Add(this.pnlPoort);
            this.pnlInstellingen.Controls.Add(this.pnlKaart);
            this.pnlInstellingen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInstellingen.Location = new System.Drawing.Point(0, 142);
            this.pnlInstellingen.Name = "pnlInstellingen";
            this.pnlInstellingen.Size = new System.Drawing.Size(1049, 433);
            this.pnlInstellingen.TabIndex = 2;
            // 
            // pnlPoort
            // 
            this.pnlPoort.AutoSize = true;
            this.pnlPoort.Controls.Add(this.lblWiel);
            this.pnlPoort.Controls.Add(this.label6);
            this.pnlPoort.Controls.Add(this.lstPoort);
            this.pnlPoort.Controls.Add(this.label5);
            this.pnlPoort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPoort.Location = new System.Drawing.Point(603, 0);
            this.pnlPoort.Name = "pnlPoort";
            this.pnlPoort.Size = new System.Drawing.Size(446, 433);
            this.pnlPoort.TabIndex = 1;
            // 
            // pnlKaart
            // 
            this.pnlKaart.Controls.Add(this.picFiets);
            this.pnlKaart.Controls.Add(this.lblFinish);
            this.pnlKaart.Controls.Add(this.lblStart);
            this.pnlKaart.Controls.Add(this.picKaart);
            this.pnlKaart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKaart.Location = new System.Drawing.Point(0, 0);
            this.pnlKaart.Name = "pnlKaart";
            this.pnlKaart.Size = new System.Drawing.Size(603, 433);
            this.pnlKaart.TabIndex = 0;
            // 
            // picFiets
            // 
            this.picFiets.BackColor = System.Drawing.Color.Transparent;
            this.picFiets.Image = global::Project_fietscomptuer.Properties.Resources.rennerL;
            this.picFiets.Location = new System.Drawing.Point(124, 47);
            this.picFiets.Name = "picFiets";
            this.picFiets.Size = new System.Drawing.Size(75, 53);
            this.picFiets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFiets.TabIndex = 3;
            this.picFiets.TabStop = false;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Image = global::Project_fietscomptuer.Properties.Resources.CirkelRood;
            this.lblFinish.Location = new System.Drawing.Point(247, 55);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(43, 35);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.startFinish_MouseMove);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Image = global::Project_fietscomptuer.Properties.Resources.CirkelGroen;
            this.lblStart.Location = new System.Drawing.Point(38, 55);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(43, 35);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.startFinish_MouseMove);
            // 
            // picKaart
            // 
            this.picKaart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picKaart.Image = global::Project_fietscomptuer.Properties.Resources.defaultkaart;
            this.picKaart.Location = new System.Drawing.Point(0, 0);
            this.picKaart.Name = "picKaart";
            this.picKaart.Size = new System.Drawing.Size(603, 433);
            this.picKaart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKaart.TabIndex = 0;
            this.picKaart.TabStop = false;
            this.picKaart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picKaart_MouseClick);
            // 
            // tmrSimuleerRit
            // 
            this.tmrSimuleerRit.Interval = 500;
            this.tmrSimuleerRit.Tick += new System.EventHandler(this.btnTestRenner_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Selecteer eerst een seriële poort en sluit dan pas het fietsmeettoestel aan.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstPoort
            // 
            this.lstPoort.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.Location = new System.Drawing.Point(0, 30);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(446, 186);
            this.lstPoort.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(3, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Draai aan je wiel en test de geselecteerde poort.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWiel
            // 
            this.lblWiel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblWiel.Location = new System.Drawing.Point(0, 406);
            this.lblWiel.Name = "lblWiel";
            this.lblWiel.Size = new System.Drawing.Size(446, 27);
            this.lblWiel.TabIndex = 3;
            this.lblWiel.Text = "Wiel: 0 Toeren";
            this.lblWiel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frminstellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 575);
            this.Controls.Add(this.pnlInstellingen);
            this.Controls.Add(this.pnlInfo);
            this.MaximizeBox = false;
            this.Name = "frminstellingen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instellingen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frminstellingen_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWielLengte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfstand)).EndInit();
            this.pnlInstellingen.ResumeLayout(false);
            this.pnlInstellingen.PerformLayout();
            this.pnlPoort.ResumeLayout(false);
            this.pnlKaart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFiets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKaart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlInstellingen;
        private System.Windows.Forms.Panel pnlPoort;
        private System.Windows.Forms.Panel pnlKaart;
        private System.Windows.Forms.PictureBox picKaart;
        private System.Windows.Forms.PictureBox picFiets;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.NumericUpDown numWielLengte;
        private System.Windows.Forms.NumericUpDown numAfstand;
        private System.Windows.Forms.Button btnTestRenner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestRennerRit;
        private System.Windows.Forms.Timer tmrSimuleerRit;
        private System.Windows.Forms.Button btnSlaOp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblWiel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstPoort;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serial;
    }
}