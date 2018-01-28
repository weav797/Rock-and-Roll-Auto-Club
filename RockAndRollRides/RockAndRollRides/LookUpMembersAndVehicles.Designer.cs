namespace RockAndRollRides
{
    partial class frmLookUpMembersAndVehicles
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
            System.Windows.Forms.Label lblAutoID;
            System.Windows.Forms.Label memberIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookUpMembersAndVehicles));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMembersDataGridView = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rockAndRollDataSet = new RockAndRollRides.RockAndRollDataSet();
            this.grpSearchByMember = new System.Windows.Forms.GroupBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.btnSearchByMember = new System.Windows.Forms.Button();
            this.grpSearchByVin = new System.Windows.Forms.GroupBox();
            this.txtAutoId = new System.Windows.Forms.TextBox();
            this.tblAutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchByVIN = new System.Windows.Forms.Button();
            this.lblLookUp = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLookUpInstructions = new System.Windows.Forms.Label();
            this.tblAutosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblAutosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblAutosTableAdapter = new RockAndRollRides.RockAndRollDataSetTableAdapters.tblAutosTableAdapter();
            this.tableAdapterManager = new RockAndRollRides.RockAndRollDataSetTableAdapters.TableAdapterManager();
            this.tblMembersTableAdapter = new RockAndRollRides.RockAndRollDataSetTableAdapters.tblMembersTableAdapter();
            this.tblAutosDataGridView = new System.Windows.Forms.DataGridView();
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
            lblAutoID = new System.Windows.Forms.Label();
            memberIDLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).BeginInit();
            this.grpSearchByMember.SuspendLayout();
            this.grpSearchByVin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosBindingNavigator)).BeginInit();
            this.tblAutosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoID
            // 
            lblAutoID.AutoSize = true;
            lblAutoID.Location = new System.Drawing.Point(15, 58);
            lblAutoID.Name = "lblAutoID";
            lblAutoID.Size = new System.Drawing.Size(67, 21);
            lblAutoID.TabIndex = 7;
            lblAutoID.Text = "Auto ID:";
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(56, 54);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(93, 21);
            memberIDLabel.TabIndex = 6;
            memberIDLabel.Text = "Member ID:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(646, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // tblMembersDataGridView
            // 
            this.tblMembersDataGridView.AutoGenerateColumns = false;
            this.tblMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMembersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn});
            this.tblMembersDataGridView.DataSource = this.tblMembersBindingSource;
            this.tblMembersDataGridView.Location = new System.Drawing.Point(18, 431);
            this.tblMembersDataGridView.Name = "tblMembersDataGridView";
            this.tblMembersDataGridView.Size = new System.Drawing.Size(603, 168);
            this.tblMembersDataGridView.TabIndex = 0;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member ID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // tblMembersBindingSource
            // 
            this.tblMembersBindingSource.DataMember = "tblMembers";
            this.tblMembersBindingSource.DataSource = this.rockAndRollDataSet;
            // 
            // rockAndRollDataSet
            // 
            this.rockAndRollDataSet.DataSetName = "RockAndRollDataSet";
            this.rockAndRollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpSearchByMember
            // 
            this.grpSearchByMember.Controls.Add(memberIDLabel);
            this.grpSearchByMember.Controls.Add(this.txtMemberId);
            this.grpSearchByMember.Controls.Add(this.btnSearchByMember);
            this.grpSearchByMember.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchByMember.Location = new System.Drawing.Point(18, 253);
            this.grpSearchByMember.Name = "grpSearchByMember";
            this.grpSearchByMember.Size = new System.Drawing.Size(346, 154);
            this.grpSearchByMember.TabIndex = 0;
            this.grpSearchByMember.TabStop = false;
            this.grpSearchByMember.Text = "By Member ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "MemberID", true));
            this.txtMemberId.Location = new System.Drawing.Point(151, 51);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(100, 28);
            this.txtMemberId.TabIndex = 0;
            // 
            // btnSearchByMember
            // 
            this.btnSearchByMember.Location = new System.Drawing.Point(108, 103);
            this.btnSearchByMember.Name = "btnSearchByMember";
            this.btnSearchByMember.Size = new System.Drawing.Size(81, 31);
            this.btnSearchByMember.TabIndex = 1;
            this.btnSearchByMember.Text = "Search";
            this.btnSearchByMember.UseVisualStyleBackColor = true;
            this.btnSearchByMember.Click += new System.EventHandler(this.btnSearchByMember_Click);
            // 
            // grpSearchByVin
            // 
            this.grpSearchByVin.Controls.Add(lblAutoID);
            this.grpSearchByVin.Controls.Add(this.txtAutoId);
            this.grpSearchByVin.Controls.Add(this.btnSearchByVIN);
            this.grpSearchByVin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchByVin.Location = new System.Drawing.Point(320, 253);
            this.grpSearchByVin.Name = "grpSearchByVin";
            this.grpSearchByVin.Size = new System.Drawing.Size(301, 154);
            this.grpSearchByVin.TabIndex = 1;
            this.grpSearchByVin.TabStop = false;
            this.grpSearchByVin.Text = "By VIN";
            // 
            // txtAutoId
            // 
            this.txtAutoId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "AutoID", true));
            this.txtAutoId.Location = new System.Drawing.Point(88, 54);
            this.txtAutoId.Name = "txtAutoId";
            this.txtAutoId.Size = new System.Drawing.Size(190, 28);
            this.txtAutoId.TabIndex = 0;
            // 
            // tblAutosBindingSource
            // 
            this.tblAutosBindingSource.DataMember = "tblAutos";
            this.tblAutosBindingSource.DataSource = this.rockAndRollDataSet;
            // 
            // btnSearchByVIN
            // 
            this.btnSearchByVIN.Location = new System.Drawing.Point(110, 103);
            this.btnSearchByVIN.Name = "btnSearchByVIN";
            this.btnSearchByVIN.Size = new System.Drawing.Size(81, 31);
            this.btnSearchByVIN.TabIndex = 1;
            this.btnSearchByVIN.Text = "Search";
            this.btnSearchByVIN.UseVisualStyleBackColor = true;
            this.btnSearchByVIN.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLookUp
            // 
            this.lblLookUp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookUp.Location = new System.Drawing.Point(284, 48);
            this.lblLookUp.Name = "lblLookUp";
            this.lblLookUp.Size = new System.Drawing.Size(314, 83);
            this.lblLookUp.TabIndex = 5;
            this.lblLookUp.Text = "How Would You Like To \r\n              Search?";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(18, 48);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(214, 185);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // lblLookUpInstructions
            // 
            this.lblLookUpInstructions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookUpInstructions.Location = new System.Drawing.Point(344, 120);
            this.lblLookUpInstructions.Name = "lblLookUpInstructions";
            this.lblLookUpInstructions.Size = new System.Drawing.Size(195, 103);
            this.lblLookUpInstructions.TabIndex = 7;
            this.lblLookUpInstructions.Text = "Enter The Member ID Or VIN To Look Up Members and Vehicles";
            // 
            // tblAutosBindingNavigator
            // 
            this.tblAutosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblAutosBindingNavigator.BindingSource = this.tblAutosBindingSource;
            this.tblAutosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblAutosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblAutosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblAutosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblAutosBindingNavigatorSaveItem});
            this.tblAutosBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.tblAutosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblAutosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblAutosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblAutosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblAutosBindingNavigator.Name = "tblAutosBindingNavigator";
            this.tblAutosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblAutosBindingNavigator.Size = new System.Drawing.Size(661, 25);
            this.tblAutosBindingNavigator.TabIndex = 8;
            this.tblAutosBindingNavigator.Text = "bindingNavigator1";
            this.tblAutosBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblAutosBindingNavigatorSaveItem
            // 
            this.tblAutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblAutosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblAutosBindingNavigatorSaveItem.Image")));
            this.tblAutosBindingNavigatorSaveItem.Name = "tblAutosBindingNavigatorSaveItem";
            this.tblAutosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 22);
            this.tblAutosBindingNavigatorSaveItem.Text = "Save Data";
            this.tblAutosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblAutosBindingNavigatorSaveItem_Click);
            // 
            // tblAutosTableAdapter
            // 
            this.tblAutosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAutosTableAdapter = this.tblAutosTableAdapter;
            this.tableAdapterManager.tblMembersTableAdapter = this.tblMembersTableAdapter;
            this.tableAdapterManager.UpdateOrder = RockAndRollRides.RockAndRollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblMembersTableAdapter
            // 
            this.tblMembersTableAdapter.ClearBeforeFill = true;
            // 
            // tblAutosDataGridView
            // 
            this.tblAutosDataGridView.AutoGenerateColumns = false;
            this.tblAutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAutosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.tblAutosDataGridView.DataSource = this.tblAutosBindingSource;
            this.tblAutosDataGridView.Location = new System.Drawing.Point(18, 431);
            this.tblAutosDataGridView.Name = "tblAutosDataGridView";
            this.tblAutosDataGridView.RowTemplate.Height = 24;
            this.tblAutosDataGridView.Size = new System.Drawing.Size(603, 111);
            this.tblAutosDataGridView.TabIndex = 8;
            this.tblAutosDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AutoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AutoID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn2.HeaderText = "Year";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Engine";
            this.dataGridViewTextBoxColumn5.HeaderText = "Engine";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn6.HeaderText = "Body";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn7.HeaderText = "Color";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn8.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Modifications";
            this.dataGridViewTextBoxColumn9.HeaderText = "Modifications";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn10.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pictures";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pictures";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // frmLookUpMembersAndVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 643);
            this.ControlBox = false;
            this.Controls.Add(this.tblAutosDataGridView);
            this.Controls.Add(this.tblMembersDataGridView);
            this.Controls.Add(this.tblAutosBindingNavigator);
            this.Controls.Add(this.lblLookUpInstructions);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblLookUp);
            this.Controls.Add(this.grpSearchByVin);
            this.Controls.Add(this.grpSearchByMember);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLookUpMembersAndVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Look Up Members And Vehicles";
            this.Load += new System.EventHandler(this.frmLookUpMembersAndVehicles_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).EndInit();
            this.grpSearchByMember.ResumeLayout(false);
            this.grpSearchByMember.PerformLayout();
            this.grpSearchByVin.ResumeLayout(false);
            this.grpSearchByVin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosBindingNavigator)).EndInit();
            this.tblAutosBindingNavigator.ResumeLayout(false);
            this.tblAutosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSearchByMember;
        private System.Windows.Forms.Button btnSearchByVIN;
        private System.Windows.Forms.Button btnSearchByMember;
        private System.Windows.Forms.GroupBox grpSearchByVin;
        private System.Windows.Forms.Label lblLookUp;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLookUpInstructions;
        private RockAndRollDataSet rockAndRollDataSet;
        private System.Windows.Forms.BindingSource tblAutosBindingSource;
        private RockAndRollDataSetTableAdapters.tblAutosTableAdapter tblAutosTableAdapter;
        private RockAndRollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblAutosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblAutosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtAutoId;
        private RockAndRollDataSetTableAdapters.tblMembersTableAdapter tblMembersTableAdapter;
        private System.Windows.Forms.BindingSource tblMembersBindingSource;
        private System.Windows.Forms.DataGridView tblMembersDataGridView;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView tblAutosDataGridView;
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
    }
}