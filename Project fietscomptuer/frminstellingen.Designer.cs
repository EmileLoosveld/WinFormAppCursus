
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlInstellingen = new System.Windows.Forms.Panel();
            this.pnlKaart = new System.Windows.Forms.Panel();
            this.pnlPoort = new System.Windows.Forms.Panel();
            this.picKaart = new System.Windows.Forms.PictureBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.picFiets = new System.Windows.Forms.PictureBox();
            this.pnlInstellingen.SuspendLayout();
            this.pnlKaart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKaart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1350, 148);
            this.pnlInfo.TabIndex = 0;
            // 
            // pnlInstellingen
            // 
            this.pnlInstellingen.Controls.Add(this.pnlPoort);
            this.pnlInstellingen.Controls.Add(this.pnlKaart);
            this.pnlInstellingen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInstellingen.Location = new System.Drawing.Point(0, 148);
            this.pnlInstellingen.Name = "pnlInstellingen";
            this.pnlInstellingen.Size = new System.Drawing.Size(1350, 506);
            this.pnlInstellingen.TabIndex = 2;
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
            this.pnlKaart.Size = new System.Drawing.Size(1000, 506);
            this.pnlKaart.TabIndex = 0;
            // 
            // pnlPoort
            // 
            this.pnlPoort.AutoSize = true;
            this.pnlPoort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPoort.Location = new System.Drawing.Point(1000, 0);
            this.pnlPoort.Name = "pnlPoort";
            this.pnlPoort.Size = new System.Drawing.Size(350, 506);
            this.pnlPoort.TabIndex = 1;
            // 
            // picKaart
            // 
            this.picKaart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picKaart.Image = global::Project_fietscomptuer.Properties.Resources.defaultkaart;
            this.picKaart.Location = new System.Drawing.Point(0, 0);
            this.picKaart.Name = "picKaart";
            this.picKaart.Size = new System.Drawing.Size(1000, 506);
            this.picKaart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKaart.TabIndex = 0;
            this.picKaart.TabStop = false;
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
            this.lblStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblStart_MouseDown);
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
            this.lblFinish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblStart_MouseDown);
            // 
            // picFiets
            // 
            this.picFiets.BackColor = System.Drawing.Color.Transparent;
            this.picFiets.Image = global::Project_fietscomptuer.Properties.Resources.rennerL;
            this.picFiets.Location = new System.Drawing.Point(124, 46);
            this.picFiets.Name = "picFiets";
            this.picFiets.Size = new System.Drawing.Size(75, 53);
            this.picFiets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFiets.TabIndex = 3;
            this.picFiets.TabStop = false;
            // 
            // frminstellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 654);
            this.Controls.Add(this.pnlInstellingen);
            this.Controls.Add(this.pnlInfo);
            this.MaximizeBox = false;
            this.Name = "frminstellingen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instellingen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frminstellingen_Load);
            this.pnlInstellingen.ResumeLayout(false);
            this.pnlInstellingen.PerformLayout();
            this.pnlKaart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picKaart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiets)).EndInit();
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
    }
}