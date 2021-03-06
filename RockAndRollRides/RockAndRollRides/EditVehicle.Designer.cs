﻿namespace RockAndRollRides
{
    partial class frmEditVehicle
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
            System.Windows.Forms.Label lblAutoId;
            System.Windows.Forms.Label lblYear;
            System.Windows.Forms.Label lblBrand;
            System.Windows.Forms.Label lblModel;
            System.Windows.Forms.Label lblEngine;
            System.Windows.Forms.Label lblBody;
            System.Windows.Forms.Label lblColor;
            System.Windows.Forms.Label lblCondition;
            System.Windows.Forms.Label lblModifications;
            System.Windows.Forms.Label lblMemberID;
            System.Windows.Forms.Label lblPictures;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditVehicle));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpEditVehicle = new System.Windows.Forms.GroupBox();
            this.txtPictures = new System.Windows.Forms.TextBox();
            this.tblAutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rockAndRollDataSet = new RockAndRollRides.RockAndRollDataSet();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtModifications = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblEditInstructions = new System.Windows.Forms.Label();
            this.lblFormTitleEdit = new System.Windows.Forms.Label();
            this.tblAutosTableAdapter = new RockAndRollRides.RockAndRollDataSetTableAdapters.tblAutosTableAdapter();
            this.tableAdapterManager = new RockAndRollRides.RockAndRollDataSetTableAdapters.TableAdapterManager();
            this.txtAutoID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            lblAutoId = new System.Windows.Forms.Label();
            lblYear = new System.Windows.Forms.Label();
            lblBrand = new System.Windows.Forms.Label();
            lblModel = new System.Windows.Forms.Label();
            lblEngine = new System.Windows.Forms.Label();
            lblBody = new System.Windows.Forms.Label();
            lblColor = new System.Windows.Forms.Label();
            lblCondition = new System.Windows.Forms.Label();
            lblModifications = new System.Windows.Forms.Label();
            lblMemberID = new System.Windows.Forms.Label();
            lblPictures = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpEditVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoId
            // 
            lblAutoId.AutoSize = true;
            lblAutoId.Location = new System.Drawing.Point(268, 209);
            lblAutoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAutoId.Name = "lblAutoId";
            lblAutoId.Size = new System.Drawing.Size(58, 17);
            lblAutoId.TabIndex = 0;
            lblAutoId.Text = "Auto ID:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new System.Drawing.Point(12, 33);
            lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new System.Drawing.Size(38, 18);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year:";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new System.Drawing.Point(128, 33);
            lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new System.Drawing.Size(48, 18);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "Brand:";
            lblBrand.Click += new System.EventHandler(this.brandLabel_Click);
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new System.Drawing.Point(353, 33);
            lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new System.Drawing.Size(52, 18);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model:";
            // 
            // lblEngine
            // 
            lblEngine.AutoSize = true;
            lblEngine.Location = new System.Drawing.Point(313, 73);
            lblEngine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new System.Drawing.Size(54, 18);
            lblEngine.TabIndex = 8;
            lblEngine.Text = "Engine:";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Location = new System.Drawing.Point(172, 73);
            lblBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBody.Name = "lblBody";
            lblBody.Size = new System.Drawing.Size(43, 18);
            lblBody.TabIndex = 10;
            lblBody.Text = "Body:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new System.Drawing.Point(12, 73);
            lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(45, 18);
            lblColor.TabIndex = 12;
            lblColor.Text = "Color:";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new System.Drawing.Point(12, 113);
            lblCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new System.Drawing.Size(72, 18);
            lblCondition.TabIndex = 14;
            lblCondition.Text = "Condition:";
            lblCondition.Click += new System.EventHandler(this.conditionLabel_Click);
            // 
            // lblModifications
            // 
            lblModifications.AutoSize = true;
            lblModifications.Location = new System.Drawing.Point(12, 153);
            lblModifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblModifications.Name = "lblModifications";
            lblModifications.Size = new System.Drawing.Size(95, 18);
            lblModifications.TabIndex = 16;
            lblModifications.Text = "Modifications:";
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Location = new System.Drawing.Point(372, 113);
            lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new System.Drawing.Size(81, 18);
            lblMemberID.TabIndex = 18;
            lblMemberID.Text = "Member ID:";
            // 
            // lblPictures
            // 
            lblPictures.AutoSize = true;
            lblPictures.Location = new System.Drawing.Point(458, 73);
            lblPictures.Name = "lblPictures";
            lblPictures.Size = new System.Drawing.Size(62, 18);
            lblPictures.TabIndex = 19;
            lblPictures.Text = "Pictures:";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(19, 48);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(213, 185);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
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
            // grpEditVehicle
            // 
            this.grpEditVehicle.Controls.Add(lblPictures);
            this.grpEditVehicle.Controls.Add(this.txtPictures);
            this.grpEditVehicle.Controls.Add(lblYear);
            this.grpEditVehicle.Controls.Add(this.txtYear);
            this.grpEditVehicle.Controls.Add(lblBrand);
            this.grpEditVehicle.Controls.Add(this.btnEditVehicle);
            this.grpEditVehicle.Controls.Add(this.txtBrand);
            this.grpEditVehicle.Controls.Add(lblModel);
            this.grpEditVehicle.Controls.Add(this.txtModel);
            this.grpEditVehicle.Controls.Add(lblEngine);
            this.grpEditVehicle.Controls.Add(this.txtEngine);
            this.grpEditVehicle.Controls.Add(lblBody);
            this.grpEditVehicle.Controls.Add(this.txtBody);
            this.grpEditVehicle.Controls.Add(lblColor);
            this.grpEditVehicle.Controls.Add(this.txtColor);
            this.grpEditVehicle.Controls.Add(lblCondition);
            this.grpEditVehicle.Controls.Add(this.txtCondition);
            this.grpEditVehicle.Controls.Add(lblModifications);
            this.grpEditVehicle.Controls.Add(this.txtModifications);
            this.grpEditVehicle.Controls.Add(lblMemberID);
            this.grpEditVehicle.Controls.Add(this.txtMemberID);
            this.grpEditVehicle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditVehicle.Location = new System.Drawing.Point(12, 239);
            this.grpEditVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEditVehicle.Name = "grpEditVehicle";
            this.grpEditVehicle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEditVehicle.Size = new System.Drawing.Size(616, 281);
            this.grpEditVehicle.TabIndex = 2;
            this.grpEditVehicle.TabStop = false;
            this.grpEditVehicle.Text = "Vehicle Information";
            // 
            // txtPictures
            // 
            this.txtPictures.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Pictures", true));
            this.txtPictures.Location = new System.Drawing.Point(526, 65);
            this.txtPictures.Name = "txtPictures";
            this.txtPictures.Size = new System.Drawing.Size(67, 26);
            this.txtPictures.TabIndex = 20;
            // 
            // tblAutosBindingSource
            // 
            this.tblAutosBindingSource.DataMember = "tblAutos";
            this.tblAutosBindingSource.DataSource = this.rockAndRollDataSet;
            // 
            // rockAndRollDataSet
            // 
            this.rockAndRollDataSet.DataSetName = "RockAndRollDataSet";
            this.rockAndRollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtYear
            // 
            this.txtYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Year", true));
            this.txtYear.Location = new System.Drawing.Point(58, 25);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(62, 26);
            this.txtYear.TabIndex = 0;
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVehicle.Location = new System.Drawing.Point(175, 215);
            this.btnEditVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(269, 46);
            this.btnEditVehicle.TabIndex = 9;
            this.btnEditVehicle.Text = "Edit Vehicle";
            this.btnEditVehicle.UseVisualStyleBackColor = true;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Brand", true));
            this.txtBrand.Location = new System.Drawing.Point(184, 25);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(161, 26);
            this.txtBrand.TabIndex = 1;
            this.txtBrand.TextChanged += new System.EventHandler(this.brandTextBox_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Model", true));
            this.txtModel.Location = new System.Drawing.Point(413, 25);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(180, 26);
            this.txtModel.TabIndex = 2;
            // 
            // txtEngine
            // 
            this.txtEngine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Engine", true));
            this.txtEngine.Location = new System.Drawing.Point(375, 65);
            this.txtEngine.Margin = new System.Windows.Forms.Padding(4);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(76, 26);
            this.txtEngine.TabIndex = 5;
            // 
            // txtBody
            // 
            this.txtBody.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Body", true));
            this.txtBody.Location = new System.Drawing.Point(223, 65);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(72, 26);
            this.txtBody.TabIndex = 4;
            // 
            // txtColor
            // 
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Color", true));
            this.txtColor.Location = new System.Drawing.Point(63, 65);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(90, 26);
            this.txtColor.TabIndex = 3;
            // 
            // txtCondition
            // 
            this.txtCondition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Condition", true));
            this.txtCondition.Location = new System.Drawing.Point(92, 105);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(272, 26);
            this.txtCondition.TabIndex = 6;
            this.txtCondition.TextChanged += new System.EventHandler(this.conditionTextBox_TextChanged);
            // 
            // txtModifications
            // 
            this.txtModifications.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "Modifications", true));
            this.txtModifications.Location = new System.Drawing.Point(115, 146);
            this.txtModifications.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifications.Name = "txtModifications";
            this.txtModifications.Size = new System.Drawing.Size(478, 26);
            this.txtModifications.TabIndex = 8;
            // 
            // txtMemberID
            // 
            this.txtMemberID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "MemberID", true));
            this.txtMemberID.Location = new System.Drawing.Point(461, 105);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(132, 26);
            this.txtMemberID.TabIndex = 7;
            // 
            // lblEditInstructions
            // 
            this.lblEditInstructions.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInstructions.Location = new System.Drawing.Point(296, 98);
            this.lblEditInstructions.Name = "lblEditInstructions";
            this.lblEditInstructions.Size = new System.Drawing.Size(269, 71);
            this.lblEditInstructions.TabIndex = 36;
            this.lblEditInstructions.Text = "Edit Vehicle Information Then Click Edit Vehicle. NOTE: Modifications Is Not Requ" +
    "ired.";
            // 
            // lblFormTitleEdit
            // 
            this.lblFormTitleEdit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitleEdit.Location = new System.Drawing.Point(277, 65);
            this.lblFormTitleEdit.Name = "lblFormTitleEdit";
            this.lblFormTitleEdit.Size = new System.Drawing.Size(309, 43);
            this.lblFormTitleEdit.TabIndex = 35;
            this.lblFormTitleEdit.Text = "Edit An Existing Vehicle";
            // 
            // tblAutosTableAdapter
            // 
            this.tblAutosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAutosTableAdapter = this.tblAutosTableAdapter;
            this.tableAdapterManager.tblMembersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RockAndRollRides.RockAndRollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtAutoID
            // 
            this.txtAutoID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAutosBindingSource, "AutoID", true));
            this.txtAutoID.Location = new System.Drawing.Point(328, 206);
            this.txtAutoID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoID.Name = "txtAutoID";
            this.txtAutoID.Size = new System.Drawing.Size(154, 22);
            this.txtAutoID.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(489, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(lblAutoId);
            this.Controls.Add(this.txtAutoID);
            this.Controls.Add(this.lblEditInstructions);
            this.Controls.Add(this.lblFormTitleEdit);
            this.Controls.Add(this.grpEditVehicle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Vehicles";
            this.Load += new System.EventHandler(this.frmEditVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpEditVehicle.ResumeLayout(false);
            this.grpEditVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockAndRollDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpEditVehicle;
        private System.Windows.Forms.Label lblEditInstructions;
        private System.Windows.Forms.Label lblFormTitleEdit;
        private System.Windows.Forms.Button btnEditVehicle;
        private RockAndRollDataSet rockAndRollDataSet;
        private System.Windows.Forms.BindingSource tblAutosBindingSource;
        private RockAndRollDataSetTableAdapters.tblAutosTableAdapter tblAutosTableAdapter;
        private RockAndRollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtModifications;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtAutoID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPictures;
    }
}