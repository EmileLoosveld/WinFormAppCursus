
namespace OpdrachtTextBoxen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKleurRood = new System.Windows.Forms.TextBox();
            this.btnKleur = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.txtPaswoord = new System.Windows.Forms.TextBox();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKleurGroen = new System.Windows.Forms.TextBox();
            this.txtKleurBlauw = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKleurBlauw);
            this.panel1.Controls.Add(this.txtKleurGroen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtKleurRood);
            this.panel1.Controls.Add(this.btnKleur);
            this.panel1.Controls.Add(this.btnAnnuleer);
            this.panel1.Controls.Add(this.txtPaswoord);
            this.panel1.Controls.Add(this.txtGebruikersnaam);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 650);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kleur (Rood):";
            // 
            // txtKleurRood
            // 
            this.txtKleurRood.Location = new System.Drawing.Point(404, 353);
            this.txtKleurRood.Name = "txtKleurRood";
            this.txtKleurRood.Size = new System.Drawing.Size(480, 29);
            this.txtKleurRood.TabIndex = 7;
            // 
            // btnKleur
            // 
            this.btnKleur.Location = new System.Drawing.Point(404, 502);
            this.btnKleur.Name = "btnKleur";
            this.btnKleur.Size = new System.Drawing.Size(160, 43);
            this.btnKleur.TabIndex = 6;
            this.btnKleur.Text = "KIES KLEUR";
            this.btnKleur.UseVisualStyleBackColor = true;
            this.btnKleur.Click += new System.EventHandler(this.btnKleur_Click);
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuleer.Location = new System.Drawing.Point(570, 272);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(160, 43);
            this.btnAnnuleer.TabIndex = 5;
            this.btnAnnuleer.Text = "ANNULEER";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // txtPaswoord
            // 
            this.txtPaswoord.Location = new System.Drawing.Point(404, 225);
            this.txtPaswoord.Name = "txtPaswoord";
            this.txtPaswoord.PasswordChar = '*';
            this.txtPaswoord.Size = new System.Drawing.Size(480, 29);
            this.txtPaswoord.TabIndex = 4;
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(404, 176);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(480, 29);
            this.txtGebruikersnaam.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(404, 272);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 43);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paswoord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kleur (Groen):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kleur (Blauw)";
            // 
            // txtKleurGroen
            // 
            this.txtKleurGroen.Location = new System.Drawing.Point(404, 401);
            this.txtKleurGroen.Name = "txtKleurGroen";
            this.txtKleurGroen.Size = new System.Drawing.Size(480, 29);
            this.txtKleurGroen.TabIndex = 11;
            // 
            // txtKleurBlauw
            // 
            this.txtKleurBlauw.Location = new System.Drawing.Point(404, 447);
            this.txtKleurBlauw.Name = "txtKleurBlauw";
            this.txtKleurBlauw.Size = new System.Drawing.Size(480, 29);
            this.txtKleurBlauw.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuleer;
            this.ClientSize = new System.Drawing.Size(1210, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geef je gegevens in!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.TextBox txtPaswoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Button btnKleur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKleurRood;
        private System.Windows.Forms.TextBox txtKleurBlauw;
        private System.Windows.Forms.TextBox txtKleurGroen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

