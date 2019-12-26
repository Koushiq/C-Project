namespace RentalHouseManagementSys.Authentication
{
    partial class UpdateUser
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
            this.mdtDateOfBirth = new MetroFramework.Controls.MetroDateTime();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mdtDateOfBirth
            // 
            this.mdtDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.mdtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mdtDateOfBirth.Location = new System.Drawing.Point(383, 262);
            this.mdtDateOfBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDateOfBirth.Name = "mdtDateOfBirth";
            this.mdtDateOfBirth.Size = new System.Drawing.Size(240, 29);
            this.mdtDateOfBirth.TabIndex = 69;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(235, 262);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(123, 26);
            this.lblDateOfBirth.TabIndex = 68;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(383, 203);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(240, 27);
            this.txtPhoneNumber.TabIndex = 67;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(217, 202);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(141, 26);
            this.lblPhoneNumber.TabIndex = 66;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(290, 89);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(68, 26);
            this.lblUserID.TabIndex = 58;
            this.lblUserID.Text = "UserID";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(383, 90);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(240, 27);
            this.txtUserID.TabIndex = 57;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(383, 148);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 27);
            this.txtUsername.TabIndex = 55;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(260, 147);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 26);
            this.lblUsername.TabIndex = 53;
            this.lblUsername.Text = "Username";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(430, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 42);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 468);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.mdtDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime mdtDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUpdate;
    }
}