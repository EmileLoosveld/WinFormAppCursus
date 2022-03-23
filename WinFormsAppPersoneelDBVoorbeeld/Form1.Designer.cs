
namespace WinFormsAppPersoneelDBVoorbeeld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label voornaamLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label nrLabel;
            System.Windows.Forms.Label geboortedatumLabel;
            System.Windows.Forms.Label postIDLabel;
            System.Windows.Forms.Label postIDLabel1;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label gemeenteLabel;
            this.personeelsAdministratieDataSet = new WinFormsAppPersoneelDBVoorbeeld.personeelsAdministratieDataSet();
            this.tablePersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePersTableAdapter = new WinFormsAppPersoneelDBVoorbeeld.personeelsAdministratieDataSetTableAdapters.TablePersTableAdapter();
            this.tableAdapterManager = new WinFormsAppPersoneelDBVoorbeeld.personeelsAdministratieDataSetTableAdapters.TableAdapterManager();
            this.tablePersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tablePersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.straatTextBox = new System.Windows.Forms.TextBox();
            this.nrTextBox = new System.Windows.Forms.TextBox();
            this.geboortedatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tablePostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePostTableAdapter = new WinFormsAppPersoneelDBVoorbeeld.personeelsAdministratieDataSetTableAdapters.TablePostTableAdapter();
            this.postIDLabel2 = new System.Windows.Forms.Label();
            this.postCodeLabel1 = new System.Windows.Forms.Label();
            this.gemeenteLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            voornaamLabel = new System.Windows.Forms.Label();
            straatLabel = new System.Windows.Forms.Label();
            nrLabel = new System.Windows.Forms.Label();
            geboortedatumLabel = new System.Windows.Forms.Label();
            postIDLabel = new System.Windows.Forms.Label();
            postIDLabel1 = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            gemeenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personeelsAdministratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingNavigator)).BeginInit();
            this.tablePersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personeelsAdministratieDataSet
            // 
            this.personeelsAdministratieDataSet.DataSetName = "personeelsAdministratieDataSet";
            this.personeelsAdministratieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablePersBindingSource
            // 
            this.tablePersBindingSource.DataMember = "TablePers";
            this.tablePersBindingSource.DataSource = this.personeelsAdministratieDataSet;
            // 
            // tablePersTableAdapter
            // 
            this.tablePersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TablePersTableAdapter = this.tablePersTableAdapter;
            this.tableAdapterManager.TablePostTableAdapter = this.tablePostTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinFormsAppPersoneelDBVoorbeeld.personeelsAdministratieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tablePersBindingNavigator
            // 
            this.tablePersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tablePersBindingNavigator.BindingSource = this.tablePersBindingSource;
            this.tablePersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tablePersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tablePersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tablePersBindingNavigatorSaveItem});
            this.tablePersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tablePersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tablePersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tablePersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tablePersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tablePersBindingNavigator.Name = "tablePersBindingNavigator";
            this.tablePersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tablePersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tablePersBindingNavigator.TabIndex = 0;
            this.tablePersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tablePersBindingNavigatorSaveItem
            // 
            this.tablePersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tablePersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tablePersBindingNavigatorSaveItem.Image")));
            this.tablePersBindingNavigatorSaveItem.Name = "tablePersBindingNavigatorSaveItem";
            this.tablePersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tablePersBindingNavigatorSaveItem.Text = "Save Data";
            this.tablePersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tablePersBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(142, 114);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(231, 114);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(200, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(142, 143);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(38, 13);
            naamLabel.TabIndex = 3;
            naamLabel.Text = "Naam:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(231, 140);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(200, 20);
            this.naamTextBox.TabIndex = 4;
            // 
            // voornaamLabel
            // 
            voornaamLabel.AutoSize = true;
            voornaamLabel.Location = new System.Drawing.Point(142, 169);
            voornaamLabel.Name = "voornaamLabel";
            voornaamLabel.Size = new System.Drawing.Size(58, 13);
            voornaamLabel.TabIndex = 5;
            voornaamLabel.Text = "Voornaam:";
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Voornaam", true));
            this.voornaamTextBox.Location = new System.Drawing.Point(231, 166);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(200, 20);
            this.voornaamTextBox.TabIndex = 6;
            // 
            // straatLabel
            // 
            straatLabel.AutoSize = true;
            straatLabel.Location = new System.Drawing.Point(142, 195);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(38, 13);
            straatLabel.TabIndex = 7;
            straatLabel.Text = "Straat:";
            // 
            // straatTextBox
            // 
            this.straatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Straat", true));
            this.straatTextBox.Location = new System.Drawing.Point(231, 192);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.Size = new System.Drawing.Size(200, 20);
            this.straatTextBox.TabIndex = 8;
            // 
            // nrLabel
            // 
            nrLabel.AutoSize = true;
            nrLabel.Location = new System.Drawing.Point(142, 221);
            nrLabel.Name = "nrLabel";
            nrLabel.Size = new System.Drawing.Size(19, 13);
            nrLabel.TabIndex = 9;
            nrLabel.Text = "nr:";
            // 
            // nrTextBox
            // 
            this.nrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "nr", true));
            this.nrTextBox.Location = new System.Drawing.Point(231, 218);
            this.nrTextBox.Name = "nrTextBox";
            this.nrTextBox.Size = new System.Drawing.Size(200, 20);
            this.nrTextBox.TabIndex = 10;
            // 
            // geboortedatumLabel
            // 
            geboortedatumLabel.AutoSize = true;
            geboortedatumLabel.Location = new System.Drawing.Point(142, 248);
            geboortedatumLabel.Name = "geboortedatumLabel";
            geboortedatumLabel.Size = new System.Drawing.Size(83, 13);
            geboortedatumLabel.TabIndex = 11;
            geboortedatumLabel.Text = "Geboortedatum:";
            // 
            // geboortedatumDateTimePicker
            // 
            this.geboortedatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tablePersBindingSource, "Geboortedatum", true));
            this.geboortedatumDateTimePicker.Location = new System.Drawing.Point(231, 244);
            this.geboortedatumDateTimePicker.Name = "geboortedatumDateTimePicker";
            this.geboortedatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.geboortedatumDateTimePicker.TabIndex = 12;
            // 
            // postIDLabel
            // 
            postIDLabel.AutoSize = true;
            postIDLabel.Location = new System.Drawing.Point(142, 270);
            postIDLabel.Name = "postIDLabel";
            postIDLabel.Size = new System.Drawing.Size(45, 13);
            postIDLabel.TabIndex = 13;
            postIDLabel.Text = "Post ID:";
            // 
            // postIDNumericUpDown
            // 
            this.postIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tablePersBindingSource, "PostID", true));
            this.postIDNumericUpDown.Location = new System.Drawing.Point(231, 270);
            this.postIDNumericUpDown.Name = "postIDNumericUpDown";
            this.postIDNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.postIDNumericUpDown.TabIndex = 14;
            this.postIDNumericUpDown.ValueChanged += new System.EventHandler(this.postIDNumericUpDown_ValueChanged);
            // 
            // tablePostBindingSource
            // 
            this.tablePostBindingSource.DataMember = "TablePost";
            this.tablePostBindingSource.DataSource = this.personeelsAdministratieDataSet;
            // 
            // tablePostTableAdapter
            // 
            this.tablePostTableAdapter.ClearBeforeFill = true;
            // 
            // postIDLabel1
            // 
            postIDLabel1.AutoSize = true;
            postIDLabel1.Location = new System.Drawing.Point(142, 308);
            postIDLabel1.Name = "postIDLabel1";
            postIDLabel1.Size = new System.Drawing.Size(45, 13);
            postIDLabel1.TabIndex = 15;
            postIDLabel1.Text = "Post ID:";
            // 
            // postIDLabel2
            // 
            this.postIDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePostBindingSource, "PostID", true));
            this.postIDLabel2.Location = new System.Drawing.Point(207, 308);
            this.postIDLabel2.Name = "postIDLabel2";
            this.postIDLabel2.Size = new System.Drawing.Size(100, 23);
            this.postIDLabel2.TabIndex = 16;
            this.postIDLabel2.Text = "label1";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Location = new System.Drawing.Point(142, 331);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(59, 13);
            postCodeLabel.TabIndex = 17;
            postCodeLabel.Text = "Post Code:";
            // 
            // postCodeLabel1
            // 
            this.postCodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePostBindingSource, "PostCode", true));
            this.postCodeLabel1.Location = new System.Drawing.Point(207, 331);
            this.postCodeLabel1.Name = "postCodeLabel1";
            this.postCodeLabel1.Size = new System.Drawing.Size(100, 23);
            this.postCodeLabel1.TabIndex = 18;
            this.postCodeLabel1.Text = "label1";
            // 
            // gemeenteLabel
            // 
            gemeenteLabel.AutoSize = true;
            gemeenteLabel.Location = new System.Drawing.Point(142, 354);
            gemeenteLabel.Name = "gemeenteLabel";
            gemeenteLabel.Size = new System.Drawing.Size(59, 13);
            gemeenteLabel.TabIndex = 19;
            gemeenteLabel.Text = "Gemeente:";
            // 
            // gemeenteLabel1
            // 
            this.gemeenteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePostBindingSource, "Gemeente", true));
            this.gemeenteLabel1.Location = new System.Drawing.Point(207, 354);
            this.gemeenteLabel1.Name = "gemeenteLabel1";
            this.gemeenteLabel1.Size = new System.Drawing.Size(100, 23);
            this.gemeenteLabel1.TabIndex = 20;
            this.gemeenteLabel1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(postIDLabel1);
            this.Controls.Add(this.postIDLabel2);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(this.postCodeLabel1);
            this.Controls.Add(gemeenteLabel);
            this.Controls.Add(this.gemeenteLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(voornaamLabel);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(straatLabel);
            this.Controls.Add(this.straatTextBox);
            this.Controls.Add(nrLabel);
            this.Controls.Add(this.nrTextBox);
            this.Controls.Add(geboortedatumLabel);
            this.Controls.Add(this.geboortedatumDateTimePicker);
            this.Controls.Add(postIDLabel);
            this.Controls.Add(this.postIDNumericUpDown);
            this.Controls.Add(this.tablePersBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personeelsAdministratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingNavigator)).EndInit();
            this.tablePersBindingNavigator.ResumeLayout(false);
            this.tablePersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private personeelsAdministratieDataSet personeelsAdministratieDataSet;
        private System.Windows.Forms.BindingSource tablePersBindingSource;
        private personeelsAdministratieDataSetTableAdapters.TablePersTableAdapter tablePersTableAdapter;
        private personeelsAdministratieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tablePersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tablePersBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.TextBox straatTextBox;
        private System.Windows.Forms.TextBox nrTextBox;
        private System.Windows.Forms.DateTimePicker geboortedatumDateTimePicker;
        private System.Windows.Forms.NumericUpDown postIDNumericUpDown;
        private personeelsAdministratieDataSetTableAdapters.TablePostTableAdapter tablePostTableAdapter;
        private System.Windows.Forms.BindingSource tablePostBindingSource;
        private System.Windows.Forms.Label postIDLabel2;
        private System.Windows.Forms.Label postCodeLabel1;
        private System.Windows.Forms.Label gemeenteLabel1;
    }
}

