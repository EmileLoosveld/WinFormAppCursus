
namespace WinFormAppCursus
{
    partial class frmPanels
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGrey = new System.Windows.Forms.Button();
            this.splTop = new System.Windows.Forms.Splitter();
            this.plnRight = new System.Windows.Forms.Panel();
            this.btnBlue = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnRed = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnWhite = new System.Windows.Forms.Button();
            this.splLeft = new System.Windows.Forms.Splitter();
            this.splRight = new System.Windows.Forms.Splitter();
            this.pnlTop.SuspendLayout();
            this.plnRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.AutoScroll = true;
            this.pnlTop.AutoScrollMargin = new System.Drawing.Size(300, 0);
            this.pnlTop.Controls.Add(this.btnGrey);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(877, 124);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.Click += new System.EventHandler(this.pnlTop_Click);
            // 
            // btnGrey
            // 
            this.btnGrey.Location = new System.Drawing.Point(394, 45);
            this.btnGrey.Name = "btnGrey";
            this.btnGrey.Size = new System.Drawing.Size(75, 23);
            this.btnGrey.TabIndex = 0;
            this.btnGrey.Tag = "Grey";
            this.btnGrey.Text = "&Grijs";
            this.btnGrey.UseVisualStyleBackColor = true;
            this.btnGrey.Click += new System.EventHandler(this.btn_Click);
            // 
            // splTop
            // 
            this.splTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splTop.Location = new System.Drawing.Point(0, 124);
            this.splTop.Name = "splTop";
            this.splTop.Size = new System.Drawing.Size(877, 10);
            this.splTop.TabIndex = 4;
            this.splTop.TabStop = false;
            // 
            // plnRight
            // 
            this.plnRight.Controls.Add(this.btnBlue);
            this.plnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plnRight.Location = new System.Drawing.Point(646, 134);
            this.plnRight.Name = "plnRight";
            this.plnRight.Size = new System.Drawing.Size(231, 407);
            this.plnRight.TabIndex = 5;
            // 
            // btnBlue
            // 
            this.btnBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlue.Location = new System.Drawing.Point(73, 58);
            this.btnBlue.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Tag = "Blue";
            this.btnBlue.Text = "&Blauw";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnRed);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 134);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(236, 407);
            this.pnlLeft.TabIndex = 6;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(71, 58);
            this.btnRed.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 2;
            this.btnRed.Tag = "Red";
            this.btnRed.Text = "&Rood";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.btnWhite);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(236, 134);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(410, 407);
            this.pnlFill.TabIndex = 7;
            // 
            // btnWhite
            // 
            this.btnWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhite.Location = new System.Drawing.Point(116, 58);
            this.btnWhite.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(171, 23);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.Tag = "White";
            this.btnWhite.Text = "&Wit";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btn_Click);
            // 
            // splLeft
            // 
            this.splLeft.Location = new System.Drawing.Point(236, 134);
            this.splLeft.Name = "splLeft";
            this.splLeft.Size = new System.Drawing.Size(3, 407);
            this.splLeft.TabIndex = 8;
            this.splLeft.TabStop = false;
            // 
            // splRight
            // 
            this.splRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splRight.Location = new System.Drawing.Point(643, 134);
            this.splRight.Name = "splRight";
            this.splRight.Size = new System.Drawing.Size(3, 407);
            this.splRight.TabIndex = 9;
            this.splRight.TabStop = false;
            // 
            // frmPanels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 541);
            this.Controls.Add(this.splRight);
            this.Controls.Add(this.splLeft);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.plnRight);
            this.Controls.Add(this.splTop);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmPanels";
            this.Text = "frmPanels";
            this.pnlTop.ResumeLayout(false);
            this.plnRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnGrey;
        private System.Windows.Forms.Splitter splTop;
        private System.Windows.Forms.Panel plnRight;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Splitter splLeft;
        private System.Windows.Forms.Splitter splRight;
    }
}