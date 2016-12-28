namespace slow
{
    partial class booksSee
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
            System.Windows.Forms.Label bOOK_PHOTOLabel;
            System.Windows.Forms.Label bOOK_COMMENTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booksSee));
            this.dataSet2 = new slow.DataSet2();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new slow.DataSet2TableAdapters.BOOKSTableAdapter();
            this.tableAdapterManager = new slow.DataSet2TableAdapters.TableAdapterManager();
            this.bOOKSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bOOKSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bOOKSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOK_PHOTOPictureBox = new System.Windows.Forms.PictureBox();
            this.bOOK_COMMENTLabel1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            bOOK_PHOTOLabel = new System.Windows.Forms.Label();
            bOOK_COMMENTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingNavigator)).BeginInit();
            this.bOOKSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOK_PHOTOPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bOOK_PHOTOLabel
            // 
            bOOK_PHOTOLabel.AutoSize = true;
            bOOK_PHOTOLabel.Location = new System.Drawing.Point(876, 40);
            bOOK_PHOTOLabel.Name = "bOOK_PHOTOLabel";
            bOOK_PHOTOLabel.Size = new System.Drawing.Size(81, 13);
            bOOK_PHOTOLabel.TabIndex = 2;
            bOOK_PHOTOLabel.Text = "BOOK PHOTO:";
            // 
            // bOOK_COMMENTLabel
            // 
            bOOK_COMMENTLabel.AutoSize = true;
            bOOK_COMMENTLabel.Location = new System.Drawing.Point(1087, 40);
            bOOK_COMMENTLabel.Name = "bOOK_COMMENTLabel";
            bOOK_COMMENTLabel.Size = new System.Drawing.Size(98, 13);
            bOOK_COMMENTLabel.TabIndex = 4;
            bOOK_COMMENTLabel.Text = "BOOK COMMENT:";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.dataSet2;
            this.bOOKSBindingSource.CurrentChanged += new System.EventHandler(this.bOOKSBindingSource_CurrentChanged);
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.UpdateOrder = slow.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bOOKSBindingNavigator
            // 
            this.bOOKSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bOOKSBindingNavigator.BindingSource = this.bOOKSBindingSource;
            this.bOOKSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bOOKSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bOOKSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bOOKSBindingNavigatorSaveItem});
            this.bOOKSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bOOKSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bOOKSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bOOKSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bOOKSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bOOKSBindingNavigator.Name = "bOOKSBindingNavigator";
            this.bOOKSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bOOKSBindingNavigator.Size = new System.Drawing.Size(1250, 25);
            this.bOOKSBindingNavigator.TabIndex = 0;
            this.bOOKSBindingNavigator.Text = "bindingNavigator1";
            this.bOOKSBindingNavigator.Visible = false;
            this.bOOKSBindingNavigator.RefreshItems += new System.EventHandler(this.bOOKSBindingNavigator_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bOOKSBindingNavigatorSaveItem
            // 
            this.bOOKSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bOOKSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKSBindingNavigatorSaveItem.Image")));
            this.bOOKSBindingNavigatorSaveItem.Name = "bOOKSBindingNavigatorSaveItem";
            this.bOOKSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bOOKSBindingNavigatorSaveItem.Text = "Save Data";
            this.bOOKSBindingNavigatorSaveItem.Click += new System.EventHandler(this.bOOKSBindingNavigatorSaveItem_Click);
            // 
            // bOOKSDataGridView
            // 
            this.bOOKSDataGridView.AutoGenerateColumns = false;
            this.bOOKSDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bOOKSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bOOKSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bOOKSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.bOOKSDataGridView.DataSource = this.bOOKSBindingSource;
            this.bOOKSDataGridView.Location = new System.Drawing.Point(62, 68);
            this.bOOKSDataGridView.Name = "bOOKSDataGridView";
            this.bOOKSDataGridView.Size = new System.Drawing.Size(750, 220);
            this.bOOKSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BOOK_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BOOK_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BOOK_TITLE";
            this.dataGridViewTextBoxColumn2.HeaderText = "BOOK_TITLE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BOOK_PAGES";
            this.dataGridViewTextBoxColumn3.HeaderText = "BOOK_PAGES";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BOOK_CATEGORY";
            this.dataGridViewTextBoxColumn4.HeaderText = "BOOK_CATEGORY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BOOK_POSITION";
            this.dataGridViewTextBoxColumn5.HeaderText = "BOOK_POSITION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BOOK_PRICE";
            this.dataGridViewTextBoxColumn6.HeaderText = "BOOK_PRICE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AUTHOR_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "AUTHOR_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // bOOK_PHOTOPictureBox
            // 
            this.bOOK_PHOTOPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bOOK_PHOTOPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bOOK_PHOTOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bOOKSBindingSource, "BOOK_PHOTO", true));
            this.bOOK_PHOTOPictureBox.Location = new System.Drawing.Point(839, 68);
            this.bOOK_PHOTOPictureBox.Name = "bOOK_PHOTOPictureBox";
            this.bOOK_PHOTOPictureBox.Size = new System.Drawing.Size(184, 220);
            this.bOOK_PHOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bOOK_PHOTOPictureBox.TabIndex = 3;
            this.bOOK_PHOTOPictureBox.TabStop = false;
            // 
            // bOOK_COMMENTLabel1
            // 
            this.bOOK_COMMENTLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "BOOK_COMMENT", true));
            this.bOOK_COMMENTLabel1.Location = new System.Drawing.Point(1071, 68);
            this.bOOK_COMMENTLabel1.Name = "bOOK_COMMENTLabel1";
            this.bOOK_COMMENTLabel1.Size = new System.Drawing.Size(168, 334);
            this.bOOK_COMMENTLabel1.TabIndex = 5;
            this.bOOK_COMMENTLabel1.Text = "label1";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(849, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 43);
            this.button5.TabIndex = 21;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(931, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 20;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(931, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "NEXT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(849, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "PREVIOUS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // booksSee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 453);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(bOOK_COMMENTLabel);
            this.Controls.Add(this.bOOK_COMMENTLabel1);
            this.Controls.Add(bOOK_PHOTOLabel);
            this.Controls.Add(this.bOOK_PHOTOPictureBox);
            this.Controls.Add(this.bOOKSDataGridView);
            this.Controls.Add(this.bOOKSBindingNavigator);
            this.Name = "booksSee";
            this.Text = "ALL BOOKS";
            this.Load += new System.EventHandler(this.booksSee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingNavigator)).EndInit();
            this.bOOKSBindingNavigator.ResumeLayout(false);
            this.bOOKSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOK_PHOTOPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bOOKSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bOOKSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bOOKSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.PictureBox bOOK_PHOTOPictureBox;
        private System.Windows.Forms.Label bOOK_COMMENTLabel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;


    }
}