namespace GO6ICTStartProgramma
{
    partial class frmBasis
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
            this.pnlMand = new System.Windows.Forms.Panel();
            this.pnlKast = new System.Windows.Forms.Panel();
            this.pnlBoven = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlLinks = new System.Windows.Forms.Panel();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpInstellingen = new System.Windows.Forms.GroupBox();
            this.btnSymbool = new System.Windows.Forms.Button();
            this.numAantal = new System.Windows.Forms.NumericUpDown();
            this.btnKleur = new System.Windows.Forms.Button();
            this.lblKleur = new System.Windows.Forms.Label();
            this.lblSymbool = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlBoven.SuspendLayout();
            this.pnlLinks.SuspendLayout();
            this.grpInstellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMand
            // 
            this.pnlMand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMand.BackgroundImage = global::GO6ICTStartProgramma.Properties.Resources.mand;
            this.pnlMand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMand.Location = new System.Drawing.Point(811, 157);
            this.pnlMand.Name = "pnlMand";
            this.pnlMand.Size = new System.Drawing.Size(329, 481);
            this.pnlMand.TabIndex = 7;
            // 
            // pnlKast
            // 
            this.pnlKast.BackColor = System.Drawing.Color.Yellow;
            this.pnlKast.BackgroundImage = global::GO6ICTStartProgramma.Properties.Resources.kast;
            this.pnlKast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlKast.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKast.Location = new System.Drawing.Point(301, 157);
            this.pnlKast.Name = "pnlKast";
            this.pnlKast.Size = new System.Drawing.Size(510, 481);
            this.pnlKast.TabIndex = 6;
            // 
            // pnlBoven
            // 
            this.pnlBoven.Controls.Add(this.label5);
            this.pnlBoven.Controls.Add(this.lblAantal);
            this.pnlBoven.Controls.Add(this.label1);
            this.pnlBoven.Controls.Add(this.lblInfo);
            this.pnlBoven.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBoven.Location = new System.Drawing.Point(301, 0);
            this.pnlBoven.Name = "pnlBoven";
            this.pnlBoven.Size = new System.Drawing.Size(839, 157);
            this.pnlBoven.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(839, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Als je klaar bent klik dan op \"Mand is gevuld\".";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAantal
            // 
            this.lblAantal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantal.Location = new System.Drawing.Point(0, 76);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(839, 34);
            this.lblAantal.TabIndex = 6;
            this.lblAantal.Text = "0";
            this.lblAantal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doe dit tot de mand het aantal objecten bevat zoals hier opgegeven na klikken op " +
    "\"Mand ledigen\".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(839, 33);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Via dubbelklikken verplaats je de objecten van de kast naar de mand en opgekeerd." +
    " ";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLinks
            // 
            this.pnlLinks.Controls.Add(this.lblResultaat);
            this.pnlLinks.Controls.Add(this.btnStop);
            this.pnlLinks.Controls.Add(this.grpInstellingen);
            this.pnlLinks.Controls.Add(this.btnStart);
            this.pnlLinks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLinks.Location = new System.Drawing.Point(0, 0);
            this.pnlLinks.Name = "pnlLinks";
            this.pnlLinks.Size = new System.Drawing.Size(301, 638);
            this.pnlLinks.TabIndex = 4;
            // 
            // lblResultaat
            // 
            this.lblResultaat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultaat.ForeColor = System.Drawing.Color.Blue;
            this.lblResultaat.Location = new System.Drawing.Point(0, 112);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(301, 139);
            this.lblResultaat.TabIndex = 4;
            this.lblResultaat.Text = "Vul de mand met ... objecten";
            this.lblResultaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.Location = new System.Drawing.Point(0, 56);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(301, 56);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Mand is gevuld";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpInstellingen
            // 
            this.grpInstellingen.Controls.Add(this.btnSymbool);
            this.grpInstellingen.Controls.Add(this.numAantal);
            this.grpInstellingen.Controls.Add(this.btnKleur);
            this.grpInstellingen.Controls.Add(this.lblKleur);
            this.grpInstellingen.Controls.Add(this.lblSymbool);
            this.grpInstellingen.Controls.Add(this.label4);
            this.grpInstellingen.Controls.Add(this.label3);
            this.grpInstellingen.Controls.Add(this.label2);
            this.grpInstellingen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpInstellingen.Location = new System.Drawing.Point(0, 459);
            this.grpInstellingen.Name = "grpInstellingen";
            this.grpInstellingen.Size = new System.Drawing.Size(301, 179);
            this.grpInstellingen.TabIndex = 1;
            this.grpInstellingen.TabStop = false;
            this.grpInstellingen.Text = "Instellingen:";
            // 
            // btnSymbool
            // 
            this.btnSymbool.Location = new System.Drawing.Point(170, 70);
            this.btnSymbool.Name = "btnSymbool";
            this.btnSymbool.Size = new System.Drawing.Size(40, 23);
            this.btnSymbool.TabIndex = 10;
            this.btnSymbool.Text = "...";
            this.btnSymbool.UseVisualStyleBackColor = true;
            this.btnSymbool.Click += new System.EventHandler(this.btnSymbool_Click);
            // 
            // numAantal
            // 
            this.numAantal.Location = new System.Drawing.Point(125, 44);
            this.numAantal.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numAantal.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numAantal.Name = "numAantal";
            this.numAantal.Size = new System.Drawing.Size(85, 20);
            this.numAantal.TabIndex = 9;
            this.numAantal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAantal.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnKleur
            // 
            this.btnKleur.Location = new System.Drawing.Point(170, 99);
            this.btnKleur.Name = "btnKleur";
            this.btnKleur.Size = new System.Drawing.Size(40, 23);
            this.btnKleur.TabIndex = 8;
            this.btnKleur.Text = "...";
            this.btnKleur.UseVisualStyleBackColor = true;
            this.btnKleur.Click += new System.EventHandler(this.btnKleur_Click);
            // 
            // lblKleur
            // 
            this.lblKleur.AutoSize = true;
            this.lblKleur.ForeColor = System.Drawing.Color.Lime;
            this.lblKleur.Location = new System.Drawing.Point(122, 103);
            this.lblKleur.Name = "lblKleur";
            this.lblKleur.Size = new System.Drawing.Size(30, 13);
            this.lblKleur.TabIndex = 6;
            this.lblKleur.Text = "kleur";
            // 
            // lblSymbool
            // 
            this.lblSymbool.AutoSize = true;
            this.lblSymbool.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblSymbool.Location = new System.Drawing.Point(122, 71);
            this.lblSymbool.Name = "lblSymbool";
            this.lblSymbool.Size = new System.Drawing.Size(18, 19);
            this.lblSymbool.TabIndex = 5;
            this.lblSymbool.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kleur Labels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Symbool Labels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal Labels:";
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(301, 56);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Nieuwe opdracht starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmBasis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 638);
            this.Controls.Add(this.pnlMand);
            this.Controls.Add(this.pnlKast);
            this.Controls.Add(this.pnlBoven);
            this.Controls.Add(this.pnlLinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBasis";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.frmBasis_ClientSizeChanged);
            this.pnlBoven.ResumeLayout(false);
            this.pnlLinks.ResumeLayout(false);
            this.grpInstellingen.ResumeLayout(false);
            this.grpInstellingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMand;
        private System.Windows.Forms.Panel pnlKast;
        private System.Windows.Forms.Panel pnlBoven;
        private System.Windows.Forms.Panel pnlLinks;
        private System.Windows.Forms.GroupBox grpInstellingen;
        private System.Windows.Forms.Button btnSymbool;
        private System.Windows.Forms.NumericUpDown numAantal;
        private System.Windows.Forms.Button btnKleur;
        private System.Windows.Forms.Label lblKleur;
        private System.Windows.Forms.Label lblSymbool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

