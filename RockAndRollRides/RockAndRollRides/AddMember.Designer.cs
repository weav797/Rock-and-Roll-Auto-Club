namespace RockAndRollRides
{
    partial class frmAddMember
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
            System.Windows.Forms.Label lblMemberID;
            System.Windows.Forms.Label lblLastName;
            System.Windows.Forms.Label lblFirstName;
            System.Windows.Forms.Label lblPhone;
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label lblCity;
            System.Windows.Forms.Label lblState;
            System.Windows.Forms.Label lblZip;
            System.Windows.Forms.Label lblSpecialty;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMember));
            this.grpAddMember = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.tblMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rockAndRollDataSet = new RockAndRollRides.RockAndRollDataSet();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.lblAddInstructions = new System.Windows.Forms.Label();
            this.lblAddMembers = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMembersTableAdapter = new RockAndRollRides.RockAndRollDataSetTableAdapters.tblMembersTableAdapter();
            this.tableAdapterManager = new RockAndRollRides.RockAndRollDataSetTableAdapters.TableAdapterManager();
            this.tblMembersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblMembersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            lblMemberID = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblZip = new System.Windows.Forms.Label();
            lblSpecialty = new System.Windows.Forms.Label();
            this.grpAddMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingNavigator)).BeginInit();
            this.tblMembersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Location = new System.Drawing.Point(263, 210);
            lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new System.Drawing.Size(80, 17);
            lblMemberID.TabIndex = 0;
            lblMemberID.Text = "Member ID:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(17, 34);
            lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(76, 18);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(297, 32);
            lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(79, 18);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(41, 154);
            lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(52, 18);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(31, 74);
            lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(62, 18);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address:";
            lblAddress.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(57, 114);
            lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(36, 18);
            lblCity.TabIndex = 10;
            lblCity.Text = "City:";
            lblCity.Click += new System.EventHandler(this.cityLabel_Click);
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new System.Drawing.Point(368, 114);
            lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(44, 18);
            lblState.TabIndex = 12;
            lblState.Text = "State:";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new System.Drawing.Point(456, 114);
            lblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblZip.Name = "lblZip";
            lblZip.Size = new System.Drawing.Size(31, 18);
            lblZip.TabIndex = 14;
            lblZip.Text = "Zip:";
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Location = new System.Drawing.Point(239, 154);
            lblSpecialty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new System.Drawing.Size(68, 18);
            lblSpecialty.TabIndex = 16;
            lblSpecialty.Text = "Specialty:";
            // 
            // grpAddMember
            // 
            this.grpAddMember.Controls.Add(lblLastName);
            this.grpAddMember.Controls.Add(this.txtLastName);
            this.grpAddMember.Controls.Add(lblFirstName);
            this.grpAddMember.Controls.Add(this.txtFirstName);
            this.grpAddMember.Controls.Add(this.btnAddMember);
            this.grpAddMember.Controls.Add(lblPhone);
            this.grpAddMember.Controls.Add(this.txtPhone);
            this.grpAddMember.Controls.Add(lblAddress);
            this.grpAddMember.Controls.Add(this.txtAddress);
            this.grpAddMember.Controls.Add(lblCity);
            this.grpAddMember.Controls.Add(this.txtCity);
            this.grpAddMember.Controls.Add(lblState);
            this.grpAddMember.Controls.Add(this.txtState);
            this.grpAddMember.Controls.Add(lblZip);
            this.grpAddMember.Controls.Add(this.txtZip);
            this.grpAddMember.Controls.Add(lblSpecialty);
            this.grpAddMember.Controls.Add(this.txtSpecialty);
            this.grpAddMember.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddMember.Location = new System.Drawing.Point(12, 239);
            this.grpAddMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAddMember.Name = "grpAddMember";
            this.grpAddMember.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAddMember.Size = new System.Drawing.Size(616, 281);
            this.grpAddMember.TabIndex = 1;
            this.grpAddMember.TabStop = false;
            this.grpAddMember.Text = "Member Information";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(99, 26);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 26);
            this.txtLastName.TabIndex = 0;
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
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(385, 26);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(215, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(175, 215);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(269, 46);
            this.btnAddMember.TabIndex = 8;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(99, 146);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(99, 66);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(501, 26);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "City", true));
            this.txtCity.Location = new System.Drawing.Point(100, 106);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(261, 26);
            this.txtCity.TabIndex = 3;
            this.txtCity.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "State", true));
            this.txtState.Location = new System.Drawing.Point(419, 106);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(30, 26);
            this.txtState.TabIndex = 4;
            // 
            // txtZip
            // 
            this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "Zip", true));
            this.txtZip.Location = new System.Drawing.Point(494, 106);
            this.txtZip.Margin = new System.Windows.Forms.Padding(4);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(106, 26);
            this.txtZip.TabIndex = 5;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "Specialty", true));
            this.txtSpecialty.Location = new System.Drawing.Point(312, 146);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(288, 26);
            this.txtSpecialty.TabIndex = 7;
            // 
            // lblAddInstructions
            // 
            this.lblAddInstructions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddInstructions.Location = new System.Drawing.Point(275, 102);
            this.lblAddInstructions.Name = "lblAddInstructions";
            this.lblAddInstructions.Size = new System.Drawing.Size(269, 71);
            this.lblAddInstructions.TabIndex = 31;
            this.lblAddInstructions.Text = "Enter New Member Information Then Click Add Member. NOTE: A Specialty Is Not Requ" +
    "ired.";
            // 
            // lblAddMembers
            // 
            this.lblAddMembers.AutoSize = true;
            this.lblAddMembers.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMembers.Location = new System.Drawing.Point(277, 65);
            this.lblAddMembers.Name = "lblAddMembers";
            this.lblAddMembers.Size = new System.Drawing.Size(265, 37);
            this.lblAddMembers.TabIndex = 30;
            this.lblAddMembers.Text = "Add A New Member";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(19, 48);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(213, 185);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 32;
            this.picLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(638, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // tblMembersTableAdapter
            // 
            this.tblMembersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAutosTableAdapter = null;
            this.tableAdapterManager.tblMembersTableAdapter = this.tblMembersTableAdapter;
            this.tableAdapterManager.UpdateOrder = RockAndRollRides.RockAndRollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblMembersBindingNavigator
            // 
            this.tblMembersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblMembersBindingNavigator.BindingSource = this.tblMembersBindingSource;
            this.tblMembersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblMembersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblMembersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblMembersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblMembersBindingNavigatorSaveItem});
            this.tblMembersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblMembersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblMembersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblMembersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblMembersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblMembersBindingNavigator.Name = "tblMembersBindingNavigator";
            this.tblMembersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblMembersBindingNavigator.Size = new System.Drawing.Size(657, 31);
            this.tblMembersBindingNavigator.TabIndex = 35;
            this.tblMembersBindingNavigator.Text = "bindingNavigator1";
            this.tblMembersBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tblMembersBindingNavigatorSaveItem
            // 
            this.tblMembersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblMembersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblMembersBindingNavigatorSaveItem.Image")));
            this.tblMembersBindingNavigatorSaveItem.Name = "tblMembersBindingNavigatorSaveItem";
            this.tblMembersBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 28);
            this.tblMembersBindingNavigatorSaveItem.Text = "Save Data";
            this.tblMembersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblMembersBindingNavigatorSaveItem_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "MemberID", true));
            this.txtMemberID.Location = new System.Drawing.Point(351, 206);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(132, 22);
            this.txtMemberID.TabIndex = 0;
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 531);
            this.ControlBox = false;
            this.Controls.Add(lblMemberID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblAddInstructions);
            this.Controls.Add(this.lblAddMembers);
            this.Controls.Add(this.grpAddMember);
            this.Controls.Add(this.tblMembersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Member";
            this.Load += new System.EventHandler(this.frmAddMember_Load);
            this.grpAddMember.ResumeLayout(false);
            this.grpAddMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingNavigator)).EndInit();
            this.tblMembersBindingNavigator.ResumeLayout(false);
            this.tblMembersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddMember;
        private System.Windows.Forms.Label lblAddInstructions;
        private System.Windows.Forms.Label lblAddMembers;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private RockAndRollDataSet rockAndRollDataSet;
        private System.Windows.Forms.BindingSource tblMembersBindingSource;
        private RockAndRollDataSetTableAdapters.tblMembersTableAdapter tblMembersTableAdapter;
        private RockAndRollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblMembersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblMembersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtMemberID;
    }
}