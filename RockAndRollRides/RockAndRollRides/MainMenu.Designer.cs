namespace RockAndRollRides
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picLogoMM = new System.Windows.Forms.PictureBox();
            this.btnAddMemberMM = new System.Windows.Forms.Button();
            this.btnEditMemberMM = new System.Windows.Forms.Button();
            this.btnLookUpMemberMM = new System.Windows.Forms.Button();
            this.btnLookUpVehicleMM = new System.Windows.Forms.Button();
            this.btnExitMM = new System.Windows.Forms.Button();
            this.btnAddVehicleMM = new System.Windows.Forms.Button();
            this.btnEditVehicleMM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMM)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogoMM
            // 
            this.picLogoMM.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMM.Image")));
            this.picLogoMM.Location = new System.Drawing.Point(161, 32);
            this.picLogoMM.Name = "picLogoMM";
            this.picLogoMM.Size = new System.Drawing.Size(296, 239);
            this.picLogoMM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoMM.TabIndex = 0;
            this.picLogoMM.TabStop = false;
            // 
            // btnAddMemberMM
            // 
            this.btnAddMemberMM.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMemberMM.Location = new System.Drawing.Point(312, 277);
            this.btnAddMemberMM.Name = "btnAddMemberMM";
            this.btnAddMemberMM.Size = new System.Drawing.Size(251, 44);
            this.btnAddMemberMM.TabIndex = 1;
            this.btnAddMemberMM.Text = "Add A New Member";
            this.btnAddMemberMM.UseVisualStyleBackColor = true;
            this.btnAddMemberMM.Click += new System.EventHandler(this.btnAddMemberMM_Click);
            // 
            // btnEditMemberMM
            // 
            this.btnEditMemberMM.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMemberMM.Location = new System.Drawing.Point(312, 333);
            this.btnEditMemberMM.Name = "btnEditMemberMM";
            this.btnEditMemberMM.Size = new System.Drawing.Size(251, 44);
            this.btnEditMemberMM.TabIndex = 3;
            this.btnEditMemberMM.Text = "Edit a Current Member";
            this.btnEditMemberMM.UseVisualStyleBackColor = true;
            this.btnEditMemberMM.Click += new System.EventHandler(this.btnEditMemberMM_Click);
            // 
            // btnLookUpMemberMM
            // 
            this.btnLookUpMemberMM.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUpMemberMM.Location = new System.Drawing.Point(312, 389);
            this.btnLookUpMemberMM.Name = "btnLookUpMemberMM";
            this.btnLookUpMemberMM.Size = new System.Drawing.Size(251, 44);
            this.btnLookUpMemberMM.TabIndex = 5;
            this.btnLookUpMemberMM.Text = "Look Up A Member";
            this.btnLookUpMemberMM.UseVisualStyleBackColor = true;
            this.btnLookUpMemberMM.Click += new System.EventHandler(this.btnLookUpMemberMM_Click);
            // 
            // btnLookUpVehicleMM
            // 
            this.btnLookUpVehicleMM.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUpVehicleMM.Location = new System.Drawing.Point(42, 389);
            this.btnLookUpVehicleMM.Name = "btnLookUpVehicleMM";
            this.btnLookUpVehicleMM.Size = new System.Drawing.Size(264, 44);
            this.btnLookUpVehicleMM.TabIndex = 4;
            this.btnLookUpVehicleMM.Text = "Look Up a Vehicle";
            this.btnLookUpVehicleMM.UseVisualStyleBackColor = true;
            this.btnLookUpVehicleMM.Click += new System.EventHandler(this.btnLookUpVehicleMM_Click);
            // 
            // btnExitMM
            // 
            this.btnExitMM.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMM.Location = new System.Drawing.Point(42, 445);
            this.btnExitMM.Name = "btnExitMM";
            this.btnExitMM.Size = new System.Drawing.Size(521, 44);
            this.btnExitMM.TabIndex = 6;
            this.btnExitMM.Text = "Exit Program";
            this.btnExitMM.UseVisualStyleBackColor = true;
            this.btnExitMM.Click += new System.EventHandler(this.btnExitMM_Click);
            // 
            // btnAddVehicleMM
            // 
            this.btnAddVehicleMM.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicleMM.Location = new System.Drawing.Point(42, 277);
            this.btnAddVehicleMM.Name = "btnAddVehicleMM";
            this.btnAddVehicleMM.Size = new System.Drawing.Size(264, 44);
            this.btnAddVehicleMM.TabIndex = 0;
            this.btnAddVehicleMM.Text = "Add A New Vehicle";
            this.btnAddVehicleMM.UseVisualStyleBackColor = true;
            this.btnAddVehicleMM.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditVehicleMM
            // 
            this.btnEditVehicleMM.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVehicleMM.Location = new System.Drawing.Point(42, 333);
            this.btnEditVehicleMM.Name = "btnEditVehicleMM";
            this.btnEditVehicleMM.Size = new System.Drawing.Size(264, 44);
            this.btnEditVehicleMM.TabIndex = 2;
            this.btnEditVehicleMM.Text = "Edit A Current Vehicle";
            this.btnEditVehicleMM.UseVisualStyleBackColor = true;
            this.btnEditVehicleMM.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 580);
            this.Controls.Add(this.btnEditVehicleMM);
            this.Controls.Add(this.btnAddVehicleMM);
            this.Controls.Add(this.btnExitMM);
            this.Controls.Add(this.btnLookUpVehicleMM);
            this.Controls.Add(this.btnLookUpMemberMM);
            this.Controls.Add(this.btnEditMemberMM);
            this.Controls.Add(this.btnAddMemberMM);
            this.Controls.Add(this.picLogoMM);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoMM;
        private System.Windows.Forms.Button btnAddMemberMM;
        private System.Windows.Forms.Button btnEditMemberMM;
        private System.Windows.Forms.Button btnLookUpMemberMM;
        private System.Windows.Forms.Button btnLookUpVehicleMM;
        private System.Windows.Forms.Button btnExitMM;
        private System.Windows.Forms.Button btnAddVehicleMM;
        private System.Windows.Forms.Button btnEditVehicleMM;
    }
}