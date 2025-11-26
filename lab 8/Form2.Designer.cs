namespace lab_8
{
    partial class Form2
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
            System.Windows.Forms.Label iD_produsLabel;
            System.Windows.Forms.Label denumireLabel;
            System.Windows.Forms.Label uMLabel;
            System.Windows.Forms.Label stoc_sigurantaLabel;
            System.Windows.Forms.Label pret_unitarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bdDataSet = new lab_8.bdDataSet();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseTableAdapter = new lab_8.bdDataSetTableAdapters.produseTableAdapter();
            this.tableAdapterManager = new lab_8.bdDataSetTableAdapters.TableAdapterManager();
            this.iesiriTableAdapter = new lab_8.bdDataSetTableAdapters.IesiriTableAdapter();
            this.produseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_produsTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.uMTextBox = new System.Windows.Forms.TextBox();
            this.stoc_sigurantaTextBox = new System.Windows.Forms.TextBox();
            this.pret_unitarTextBox = new System.Windows.Forms.TextBox();
            this.iesiriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iesiriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            iD_produsLabel = new System.Windows.Forms.Label();
            denumireLabel = new System.Windows.Forms.Label();
            uMLabel = new System.Windows.Forms.Label();
            stoc_sigurantaLabel = new System.Windows.Forms.Label();
            pret_unitarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingNavigator)).BeginInit();
            this.produseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iesiriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iesiriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_produsLabel
            // 
            iD_produsLabel.AutoSize = true;
            iD_produsLabel.Location = new System.Drawing.Point(25, 37);
            iD_produsLabel.Name = "iD_produsLabel";
            iD_produsLabel.Size = new System.Drawing.Size(68, 16);
            iD_produsLabel.TabIndex = 1;
            iD_produsLabel.Text = "ID produs:";
            // 
            // denumireLabel
            // 
            denumireLabel.AutoSize = true;
            denumireLabel.Location = new System.Drawing.Point(25, 65);
            denumireLabel.Name = "denumireLabel";
            denumireLabel.Size = new System.Drawing.Size(68, 16);
            denumireLabel.TabIndex = 3;
            denumireLabel.Text = "Denumire:";
            // 
            // uMLabel
            // 
            uMLabel.AutoSize = true;
            uMLabel.Location = new System.Drawing.Point(25, 93);
            uMLabel.Name = "uMLabel";
            uMLabel.Size = new System.Drawing.Size(31, 16);
            uMLabel.TabIndex = 5;
            uMLabel.Text = "UM:";
            // 
            // stoc_sigurantaLabel
            // 
            stoc_sigurantaLabel.AutoSize = true;
            stoc_sigurantaLabel.Location = new System.Drawing.Point(25, 121);
            stoc_sigurantaLabel.Name = "stoc_sigurantaLabel";
            stoc_sigurantaLabel.Size = new System.Drawing.Size(93, 16);
            stoc_sigurantaLabel.TabIndex = 7;
            stoc_sigurantaLabel.Text = "stoc siguranta:";
            // 
            // pret_unitarLabel
            // 
            pret_unitarLabel.AutoSize = true;
            pret_unitarLabel.Location = new System.Drawing.Point(25, 149);
            pret_unitarLabel.Name = "pret_unitarLabel";
            pret_unitarLabel.Size = new System.Drawing.Size(68, 16);
            pret_unitarLabel.TabIndex = 9;
            pret_unitarLabel.Text = "pret unitar:";
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "produse";
            this.produseBindingSource.DataSource = this.bdDataSet;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IesiriTableAdapter = this.iesiriTableAdapter;
            this.tableAdapterManager.IntrariTableAdapter = null;
            this.tableAdapterManager.produseTableAdapter = this.produseTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab_8.bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iesiriTableAdapter
            // 
            this.iesiriTableAdapter.ClearBeforeFill = true;
            // 
            // produseBindingNavigator
            // 
            this.produseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produseBindingNavigator.BindingSource = this.produseBindingSource;
            this.produseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.produseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produseBindingNavigatorSaveItem});
            this.produseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produseBindingNavigator.Name = "produseBindingNavigator";
            this.produseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produseBindingNavigator.Size = new System.Drawing.Size(667, 27);
            this.produseBindingNavigator.TabIndex = 0;
            this.produseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // produseBindingNavigatorSaveItem
            // 
            this.produseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produseBindingNavigatorSaveItem.Image")));
            this.produseBindingNavigatorSaveItem.Name = "produseBindingNavigatorSaveItem";
            this.produseBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.produseBindingNavigatorSaveItem.Text = "Save Data";
            this.produseBindingNavigatorSaveItem.Click += new System.EventHandler(this.produseBindingNavigatorSaveItem_Click);
            // 
            // iD_produsTextBox
            // 
            this.iD_produsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produseBindingSource, "ID_produs", true));
            this.iD_produsTextBox.Location = new System.Drawing.Point(124, 34);
            this.iD_produsTextBox.Name = "iD_produsTextBox";
            this.iD_produsTextBox.Size = new System.Drawing.Size(100, 22);
            this.iD_produsTextBox.TabIndex = 2;
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produseBindingSource, "Denumire", true));
            this.denumireTextBox.Location = new System.Drawing.Point(124, 62);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(100, 22);
            this.denumireTextBox.TabIndex = 4;
            // 
            // uMTextBox
            // 
            this.uMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produseBindingSource, "UM", true));
            this.uMTextBox.Location = new System.Drawing.Point(124, 90);
            this.uMTextBox.Name = "uMTextBox";
            this.uMTextBox.Size = new System.Drawing.Size(100, 22);
            this.uMTextBox.TabIndex = 6;
            // 
            // stoc_sigurantaTextBox
            // 
            this.stoc_sigurantaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produseBindingSource, "stoc_siguranta", true));
            this.stoc_sigurantaTextBox.Location = new System.Drawing.Point(124, 118);
            this.stoc_sigurantaTextBox.Name = "stoc_sigurantaTextBox";
            this.stoc_sigurantaTextBox.Size = new System.Drawing.Size(100, 22);
            this.stoc_sigurantaTextBox.TabIndex = 8;
            // 
            // pret_unitarTextBox
            // 
            this.pret_unitarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produseBindingSource, "pret_unitar", true));
            this.pret_unitarTextBox.Location = new System.Drawing.Point(124, 146);
            this.pret_unitarTextBox.Name = "pret_unitarTextBox";
            this.pret_unitarTextBox.Size = new System.Drawing.Size(100, 22);
            this.pret_unitarTextBox.TabIndex = 10;
            // 
            // iesiriBindingSource
            // 
            this.iesiriBindingSource.DataMember = "produseIesiri";
            this.iesiriBindingSource.DataSource = this.produseBindingSource;
            // 
            // iesiriDataGridView
            // 
            this.iesiriDataGridView.AutoGenerateColumns = false;
            this.iesiriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iesiriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.iesiriDataGridView.DataSource = this.iesiriBindingSource;
            this.iesiriDataGridView.Location = new System.Drawing.Point(28, 217);
            this.iesiriDataGridView.Name = "iesiriDataGridView";
            this.iesiriDataGridView.RowHeadersWidth = 51;
            this.iesiriDataGridView.RowTemplate.Height = 24;
            this.iesiriDataGridView.Size = new System.Drawing.Size(608, 179);
            this.iesiriDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_iesire";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_iesire";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn2.HeaderText = "data";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_produs";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_produs";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantitate";
            this.dataGridViewTextBoxColumn4.HeaderText = "cantitate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "revenire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iesiriDataGridView);
            this.Controls.Add(iD_produsLabel);
            this.Controls.Add(this.iD_produsTextBox);
            this.Controls.Add(denumireLabel);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(uMLabel);
            this.Controls.Add(this.uMTextBox);
            this.Controls.Add(stoc_sigurantaLabel);
            this.Controls.Add(this.stoc_sigurantaTextBox);
            this.Controls.Add(pret_unitarLabel);
            this.Controls.Add(this.pret_unitarTextBox);
            this.Controls.Add(this.produseBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingNavigator)).EndInit();
            this.produseBindingNavigator.ResumeLayout(false);
            this.produseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iesiriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iesiriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private bdDataSetTableAdapters.produseTableAdapter produseTableAdapter;
        private bdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produseBindingNavigatorSaveItem;
        private bdDataSetTableAdapters.IesiriTableAdapter iesiriTableAdapter;
        private System.Windows.Forms.TextBox iD_produsTextBox;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.TextBox uMTextBox;
        private System.Windows.Forms.TextBox stoc_sigurantaTextBox;
        private System.Windows.Forms.TextBox pret_unitarTextBox;
        private System.Windows.Forms.BindingSource iesiriBindingSource;
        private System.Windows.Forms.DataGridView iesiriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}