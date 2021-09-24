
namespace WinFormAppCursus
{
    partial class frmLabels
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
            this.lblMuisTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMuisTest
            // 
            this.lblMuisTest.AutoSize = true;
            this.lblMuisTest.Location = new System.Drawing.Point(37, 29);
            this.lblMuisTest.Name = "lblMuisTest";
            this.lblMuisTest.Size = new System.Drawing.Size(140, 13);
            this.lblMuisTest.TabIndex = 0;
            this.lblMuisTest.Text = "Beweeg met je muis over mij";
            this.lblMuisTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblMuisTest_MouseClick);
            this.lblMuisTest.MouseEnter += new System.EventHandler(this.lblMuisTest_MouseEnter);
            this.lblMuisTest.MouseLeave += new System.EventHandler(this.lblMuisTest_MouseLeave);
            this.lblMuisTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMuisTest_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Voornaam";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 5;
            // 
            // frmLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 352);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMuisTest);
            this.KeyPreview = true;
            this.Name = "frmLabels";
            this.Text = "frmLabels";
            this.Load += new System.EventHandler(this.frmLabels_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLabels_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLabels_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLabels_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMuisTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}