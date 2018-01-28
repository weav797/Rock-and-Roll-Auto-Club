namespace RockAndRollRides
{
    partial class frmEditMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditMember));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpAddMember = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.tblMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rockAndRollDataSet = new RockAndRollRides.RockAndRollDataSet();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddMembers = new System.Windows.Forms.Label();
            this.lblAddInstructions = new System.Windows.Forms.Label();
            this.tblMembersTableAdapter = new RockAndRollRides.RockAndRollDataSetTableAdapters.tblMembersTableAdapter();
            this.tableAdapterManager = new RockAndRollRides.RockAndRollDataSetTableAdapters.TableAdapterManager();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            lblMemberID = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblZip = new System.Windows.Forms.Label();
            lblSpecialty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpAddMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            lblFirstName.Location = new System.Drawing.Point(300, 34);
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
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(19, 48);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(213, 185);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // grpAddMember
            // 
            this.grpAddMember.Controls.Add(lblLastName);
            this.grpAddMember.Controls.Add(this.txtLastName);
            this.grpAddMember.Controls.Add(lblFirstName);
            this.grpAddMember.Controls.Add(this.txtFirstName);
            this.grpAddMember.Controls.Add(lblPhone);
            this.grpAddMember.Controls.Add(this.btnEditMember);
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
            this.grpAddMember.Size = new System.Drawing.Size(616, 279);
            this.grpAddMember.TabIndex = 2;
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
            // btnEditMember
            // 
            this.btnEditMember.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.Location = new System.Drawing.Point(175, 215);
            this.btnEditMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(269, 46);
            this.btnEditMember.TabIndex = 8;
            this.btnEditMember.Text = "Edit Member";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
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
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "City", true));
            this.txtCity.Location = new System.Drawing.Point(100, 106);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(261, 26);
            this.txtCity.TabIndex = 3;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(638, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // lblAddMembers
            // 
            this.lblAddMembers.AutoSize = true;
            this.lblAddMembers.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMembers.Location = new System.Drawing.Point(277, 65);
            this.lblAddMembers.Name = "lblAddMembers";
            this.lblAddMembers.Size = new System.Drawing.Size(319, 37);
            this.lblAddMembers.TabIndex = 26;
            this.lblAddMembers.Text = "Edit An Existing Member";
            // 
            // lblAddInstructions
            // 
            this.lblAddInstructions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddInstructions.Location = new System.Drawing.Point(301, 102);
            this.lblAddInstructions.Name = "lblAddInstructions";
            this.lblAddInstructions.Size = new System.Drawing.Size(269, 94);
            this.lblAddInstructions.TabIndex = 27;
            this.lblAddInstructions.Text = "Change Member Information Then Click Edit Member. NOTE: A Speciality Is Not Requi" +
    "red";
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
            // txtMemberID
            // 
            this.txtMemberID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMembersBindingSource, "MemberID", true));
            this.txtMemberID.Location = new System.Drawing.Point(351, 206);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(132, 22);
            this.txtMemberID.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(lblMemberID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblAddInstructions);
            this.Controls.Add(this.lblAddMembers);
            this.Controls.Add(this.grpAddMember);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit An Existing Member";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpAddMember.ResumeLayout(false);
            this.grpAddMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpAddMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblAddMembers;
        private System.Windows.Forms.Label lblAddInstructions;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private RockAndRollDataSet rockAndRollDataSet;
        private System.Windows.Forms.BindingSource tblMembersBindingSource;
        private RockAndRollDataSetTableAdapters.tblMembersTableAdapter tblMembersTableAdapter;
        private RockAndRollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnSearch;
    }
}

