namespace A_Waddell_Lab_3
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statesDBDataSet = new A_Waddell_Lab_3.StatesDBDataSet();
            this.stateDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDataTableAdapter = new A_Waddell_Lab_3.StatesDBDataSetTableAdapters.StateDataTableAdapter();
            this.tableAdapterManager = new A_Waddell_Lab_3.StatesDBDataSetTableAdapters.TableAdapterManager();
            this.stateDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stateDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateDataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortFlower = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.lBoxNames = new System.Windows.Forms.ListBox();
            this.btnSortCompJob = new System.Windows.Forms.Button();
            this.btnSortBird = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingNavigator)).BeginInit();
            this.stateDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statesDBDataSet
            // 
            this.statesDBDataSet.DataSetName = "StatesDBDataSet";
            this.statesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateDataBindingSource
            // 
            this.stateDataBindingSource.DataMember = "StateData";
            this.stateDataBindingSource.DataSource = this.statesDBDataSet;
            // 
            // stateDataTableAdapter
            // 
            this.stateDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateDataTableAdapter = this.stateDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = A_Waddell_Lab_3.StatesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateDataBindingNavigator
            // 
            this.stateDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stateDataBindingNavigator.BindingSource = this.stateDataBindingSource;
            this.stateDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stateDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stateDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stateDataBindingNavigatorSaveItem});
            this.stateDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stateDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stateDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stateDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stateDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stateDataBindingNavigator.Name = "stateDataBindingNavigator";
            this.stateDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stateDataBindingNavigator.Size = new System.Drawing.Size(1306, 25);
            this.stateDataBindingNavigator.TabIndex = 0;
            this.stateDataBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // stateDataBindingNavigatorSaveItem
            // 
            this.stateDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stateDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stateDataBindingNavigatorSaveItem.Image")));
            this.stateDataBindingNavigatorSaveItem.Name = "stateDataBindingNavigatorSaveItem";
            this.stateDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stateDataBindingNavigatorSaveItem.Text = "Save Data";
            this.stateDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.stateDataBindingNavigatorSaveItem_Click);
            // 
            // stateDataDataGridView
            // 
            this.stateDataDataGridView.AutoGenerateColumns = false;
            this.stateDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.stateDataDataGridView.DataSource = this.stateDataBindingSource;
            this.stateDataDataGridView.Location = new System.Drawing.Point(0, 30);
            this.stateDataDataGridView.Name = "stateDataDataGridView";
            this.stateDataDataGridView.Size = new System.Drawing.Size(1140, 273);
            this.stateDataDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StateName";
            this.dataGridViewTextBoxColumn1.HeaderText = "StateName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StateFlagDesc";
            this.dataGridViewTextBoxColumn2.HeaderText = "StateFlagDesc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StateFlower";
            this.dataGridViewTextBoxColumn3.HeaderText = "StateFlower";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StateBird";
            this.dataGridViewTextBoxColumn4.HeaderText = "StateBird";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StateColors";
            this.dataGridViewTextBoxColumn5.HeaderText = "StateColors";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LargeCityOne";
            this.dataGridViewTextBoxColumn6.HeaderText = "LargeCityOne";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LargeCityTwo";
            this.dataGridViewTextBoxColumn7.HeaderText = "LargeCityTwo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LargeCityThree";
            this.dataGridViewTextBoxColumn8.HeaderText = "LargeCityThree";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Capital";
            this.dataGridViewTextBoxColumn9.HeaderText = "Capital";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MedIncom";
            this.dataGridViewTextBoxColumn10.HeaderText = "MedIncom";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CompJobs";
            this.dataGridViewTextBoxColumn11.HeaderText = "CompJobs";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // btnDetails
            // 
            this.btnDetails.AutoSize = true;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDetails.Location = new System.Drawing.Point(38, 361);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(117, 30);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Open Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.AutoSize = true;
            this.btnSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortName.Location = new System.Drawing.Point(199, 320);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(124, 30);
            this.btnSortName.TabIndex = 3;
            this.btnSortName.Text = "Sort By Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortFlower
            // 
            this.btnSortFlower.AutoSize = true;
            this.btnSortFlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortFlower.Location = new System.Drawing.Point(199, 370);
            this.btnSortFlower.Name = "btnSortFlower";
            this.btnSortFlower.Size = new System.Drawing.Size(130, 30);
            this.btnSortFlower.TabIndex = 4;
            this.btnSortFlower.Text = "Sort By Flower";
            this.btnSortFlower.UseVisualStyleBackColor = true;
            this.btnSortFlower.Click += new System.EventHandler(this.btnSortFlower_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.AutoSize = true;
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSearchName.Location = new System.Drawing.Point(727, 320);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(148, 30);
            this.btnSearchName.TabIndex = 5;
            this.btnSearchName.Text = "Search by Name:";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // lBoxNames
            // 
            this.lBoxNames.FormattingEnabled = true;
            this.lBoxNames.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.lBoxNames.Location = new System.Drawing.Point(902, 320);
            this.lBoxNames.Name = "lBoxNames";
            this.lBoxNames.Size = new System.Drawing.Size(120, 95);
            this.lBoxNames.TabIndex = 6;
            // 
            // btnSortCompJob
            // 
            this.btnSortCompJob.AutoSize = true;
            this.btnSortCompJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortCompJob.Location = new System.Drawing.Point(199, 425);
            this.btnSortCompJob.Name = "btnSortCompJob";
            this.btnSortCompJob.Size = new System.Drawing.Size(205, 30);
            this.btnSortCompJob.TabIndex = 7;
            this.btnSortCompJob.Text = "Sort By Computer Job %";
            this.btnSortCompJob.UseVisualStyleBackColor = true;
            this.btnSortCompJob.Click += new System.EventHandler(this.btnSortCompJob_Click);
            // 
            // btnSortBird
            // 
            this.btnSortBird.AutoSize = true;
            this.btnSortBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortBird.Location = new System.Drawing.Point(199, 473);
            this.btnSortBird.Name = "btnSortBird";
            this.btnSortBird.Size = new System.Drawing.Size(130, 30);
            this.btnSortBird.TabIndex = 8;
            this.btnSortBird.Text = "Sort By Bird";
            this.btnSortBird.UseVisualStyleBackColor = true;
            this.btnSortBird.Click += new System.EventHandler(this.btnSortBird_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAddNew.Location = new System.Drawing.Point(38, 425);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(130, 30);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Add New State";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 543);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSortBird);
            this.Controls.Add(this.btnSortCompJob);
            this.Controls.Add(this.lBoxNames);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.btnSortFlower);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.stateDataDataGridView);
            this.Controls.Add(this.stateDataBindingNavigator);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingNavigator)).EndInit();
            this.stateDataBindingNavigator.ResumeLayout(false);
            this.stateDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatesDBDataSet statesDBDataSet;
        private System.Windows.Forms.BindingSource stateDataBindingSource;
        private StatesDBDataSetTableAdapters.StateDataTableAdapter stateDataTableAdapter;
        private StatesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stateDataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stateDataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stateDataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortFlower;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.ListBox lBoxNames;
        private System.Windows.Forms.Button btnSortCompJob;
        private System.Windows.Forms.Button btnSortBird;
        private System.Windows.Forms.Button btnAddNew;
    }
}