namespace RentalHouseManagementSys
{
    partial class Tenant
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
            this.mtcNavigation = new MetroFramework.Controls.MetroTabControl();
            this.mtpProfile = new MetroFramework.Controls.MetroTabPage();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblBalanceOutput = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBankAccountOutput = new System.Windows.Forms.Label();
            this.lblBankAccountNo = new System.Windows.Forms.Label();
            this.lblRentedStatusOutput = new System.Windows.Forms.Label();
            this.lblRentedStatus = new System.Windows.Forms.Label();
            this.lblUsertypeOutput = new System.Windows.Forms.Label();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.btnUploadPictureProfile = new System.Windows.Forms.Button();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblDateOfBirthProfileOutput = new System.Windows.Forms.Label();
            this.lblPhoneNumberProfileOutput = new System.Windows.Forms.Label();
            this.lblGenderProfileOutput = new System.Windows.Forms.Label();
            this.lblUserIDProfileOutput = new System.Windows.Forms.Label();
            this.lblNameProfileOutput = new System.Windows.Forms.Label();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnChangePasswordProfile = new System.Windows.Forms.Button();
            this.lblDateOfBirthProfile = new System.Windows.Forms.Label();
            this.lblPhoneNumberProfile = new System.Windows.Forms.Label();
            this.lblGenderProfile = new System.Windows.Forms.Label();
            this.lblUserIDProfile = new System.Windows.Forms.Label();
            this.lblNameProfile = new System.Windows.Forms.Label();
            this.mtpFeed = new MetroFramework.Controls.MetroTabPage();
            this.flpFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFlatType = new System.Windows.Forms.Label();
            this.cmbFlatType = new System.Windows.Forms.ComboBox();
            this.txtSquareFeetUpperLimit = new System.Windows.Forms.TextBox();
            this.txtSquareFeetLowerLimit = new System.Windows.Forms.TextBox();
            this.lblSqareFeet = new System.Windows.Forms.Label();
            this.cmbSelectArea = new System.Windows.Forms.ComboBox();
            this.txtRentUpperLimit = new System.Windows.Forms.TextBox();
            this.txtRentLowerLimit = new System.Windows.Forms.TextBox();
            this.lblRentRange = new System.Windows.Forms.Label();
            this.cbEnableFilter = new System.Windows.Forms.CheckBox();
            this.lblSelectArea = new System.Windows.Forms.Label();
            this.mtpNotification = new MetroFramework.Controls.MetroTabPage();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.mtpAgreements = new MetroFramework.Controls.MetroTabPage();
            this.pnlAgreements = new System.Windows.Forms.Panel();
            this.mtpPayment = new MetroFramework.Controls.MetroTabPage();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.mtpRecharge = new MetroFramework.Controls.MetroTabPage();
            this.pnlRecharge = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.txtRechargeAmount = new System.Windows.Forms.TextBox();
            this.lblRechargeAmount = new System.Windows.Forms.Label();
            this.btnRequestRecharge = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.mtcNavigation.SuspendLayout();
            this.mtpProfile.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.mtpFeed.SuspendLayout();
            this.flpFeed.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.mtpNotification.SuspendLayout();
            this.mtpAgreements.SuspendLayout();
            this.mtpPayment.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.mtpRecharge.SuspendLayout();
            this.pnlRecharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcNavigation
            // 
            this.mtcNavigation.Controls.Add(this.mtpProfile);
            this.mtcNavigation.Controls.Add(this.mtpFeed);
            this.mtcNavigation.Controls.Add(this.mtpNotification);
            this.mtcNavigation.Controls.Add(this.mtpAgreements);
            this.mtcNavigation.Controls.Add(this.mtpPayment);
            this.mtcNavigation.Controls.Add(this.mtpRecharge);
            this.mtcNavigation.Location = new System.Drawing.Point(0, 63);
            this.mtcNavigation.Name = "mtcNavigation";
            this.mtcNavigation.SelectedIndex = 2;
            this.mtcNavigation.Size = new System.Drawing.Size(975, 639);
            this.mtcNavigation.TabIndex = 0;
            this.mtcNavigation.UseSelectable = true;
            // 
            // mtpProfile
            // 
            this.mtpProfile.Controls.Add(this.pnlProfile);
            this.mtpProfile.HorizontalScrollbarBarColor = true;
            this.mtpProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpProfile.HorizontalScrollbarSize = 10;
            this.mtpProfile.Location = new System.Drawing.Point(4, 38);
            this.mtpProfile.Name = "mtpProfile";
            this.mtpProfile.Size = new System.Drawing.Size(967, 597);
            this.mtpProfile.TabIndex = 0;
            this.mtpProfile.Text = "Profile    ";
            this.mtpProfile.VerticalScrollbarBarColor = true;
            this.mtpProfile.VerticalScrollbarHighlightOnWheel = false;
            this.mtpProfile.VerticalScrollbarSize = 10;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlProfile.Controls.Add(this.lblBalanceOutput);
            this.pnlProfile.Controls.Add(this.lblBalance);
            this.pnlProfile.Controls.Add(this.lblBankAccountOutput);
            this.pnlProfile.Controls.Add(this.lblBankAccountNo);
            this.pnlProfile.Controls.Add(this.lblRentedStatusOutput);
            this.pnlProfile.Controls.Add(this.lblRentedStatus);
            this.pnlProfile.Controls.Add(this.lblUsertypeOutput);
            this.pnlProfile.Controls.Add(this.lblUsertype);
            this.pnlProfile.Controls.Add(this.btnRemovePicture);
            this.pnlProfile.Controls.Add(this.btnUploadPictureProfile);
            this.pnlProfile.Controls.Add(this.pbProfilePicture);
            this.pnlProfile.Controls.Add(this.lblDateOfBirthProfileOutput);
            this.pnlProfile.Controls.Add(this.lblPhoneNumberProfileOutput);
            this.pnlProfile.Controls.Add(this.lblGenderProfileOutput);
            this.pnlProfile.Controls.Add(this.lblUserIDProfileOutput);
            this.pnlProfile.Controls.Add(this.lblNameProfileOutput);
            this.pnlProfile.Controls.Add(this.btnDeleteProfile);
            this.pnlProfile.Controls.Add(this.btnUpdateProfile);
            this.pnlProfile.Controls.Add(this.btnChangePasswordProfile);
            this.pnlProfile.Controls.Add(this.lblDateOfBirthProfile);
            this.pnlProfile.Controls.Add(this.lblPhoneNumberProfile);
            this.pnlProfile.Controls.Add(this.lblGenderProfile);
            this.pnlProfile.Controls.Add(this.lblUserIDProfile);
            this.pnlProfile.Controls.Add(this.lblNameProfile);
            this.pnlProfile.Location = new System.Drawing.Point(0, 3);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(966, 594);
            this.pnlProfile.TabIndex = 2;
            // 
            // lblBalanceOutput
            // 
            this.lblBalanceOutput.AutoSize = true;
            this.lblBalanceOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceOutput.ForeColor = System.Drawing.Color.White;
            this.lblBalanceOutput.Location = new System.Drawing.Point(448, 487);
            this.lblBalanceOutput.Name = "lblBalanceOutput";
            this.lblBalanceOutput.Size = new System.Drawing.Size(64, 21);
            this.lblBalanceOutput.TabIndex = 42;
            this.lblBalanceOutput.Text = "100000";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(316, 487);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(79, 21);
            this.lblBalance.TabIndex = 41;
            this.lblBalance.Text = "Balance :";
            // 
            // lblBankAccountOutput
            // 
            this.lblBankAccountOutput.AutoSize = true;
            this.lblBankAccountOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankAccountOutput.ForeColor = System.Drawing.Color.White;
            this.lblBankAccountOutput.Location = new System.Drawing.Point(448, 458);
            this.lblBankAccountOutput.Name = "lblBankAccountOutput";
            this.lblBankAccountOutput.Size = new System.Drawing.Size(100, 21);
            this.lblBankAccountOutput.TabIndex = 36;
            this.lblBankAccountOutput.Text = "6783698379";
            // 
            // lblBankAccountNo
            // 
            this.lblBankAccountNo.AutoSize = true;
            this.lblBankAccountNo.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankAccountNo.ForeColor = System.Drawing.Color.White;
            this.lblBankAccountNo.Location = new System.Drawing.Point(249, 458);
            this.lblBankAccountNo.Name = "lblBankAccountNo";
            this.lblBankAccountNo.Size = new System.Drawing.Size(147, 21);
            this.lblBankAccountNo.TabIndex = 35;
            this.lblBankAccountNo.Text = "Bank Account No :";
            // 
            // lblRentedStatusOutput
            // 
            this.lblRentedStatusOutput.AutoSize = true;
            this.lblRentedStatusOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedStatusOutput.ForeColor = System.Drawing.Color.White;
            this.lblRentedStatusOutput.Location = new System.Drawing.Point(448, 423);
            this.lblRentedStatusOutput.Name = "lblRentedStatusOutput";
            this.lblRentedStatusOutput.Size = new System.Drawing.Size(94, 21);
            this.lblRentedStatusOutput.TabIndex = 34;
            this.lblRentedStatusOutput.Text = "Not Rented";
            // 
            // lblRentedStatus
            // 
            this.lblRentedStatus.AutoSize = true;
            this.lblRentedStatus.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedStatus.ForeColor = System.Drawing.Color.White;
            this.lblRentedStatus.Location = new System.Drawing.Point(269, 423);
            this.lblRentedStatus.Name = "lblRentedStatus";
            this.lblRentedStatus.Size = new System.Drawing.Size(126, 21);
            this.lblRentedStatus.TabIndex = 33;
            this.lblRentedStatus.Text = "Rented Status :";
            // 
            // lblUsertypeOutput
            // 
            this.lblUsertypeOutput.AutoSize = true;
            this.lblUsertypeOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsertypeOutput.ForeColor = System.Drawing.Color.White;
            this.lblUsertypeOutput.Location = new System.Drawing.Point(448, 249);
            this.lblUsertypeOutput.Name = "lblUsertypeOutput";
            this.lblUsertypeOutput.Size = new System.Drawing.Size(62, 21);
            this.lblUsertypeOutput.TabIndex = 32;
            this.lblUsertypeOutput.Text = "Tenant";
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsertype.ForeColor = System.Drawing.Color.White;
            this.lblUsertype.Location = new System.Drawing.Point(308, 249);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(87, 21);
            this.lblUsertype.TabIndex = 31;
            this.lblUsertype.Text = "Usertype :";
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.BackColor = System.Drawing.Color.Black;
            this.btnRemovePicture.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePicture.ForeColor = System.Drawing.Color.White;
            this.btnRemovePicture.Location = new System.Drawing.Point(491, 160);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(80, 41);
            this.btnRemovePicture.TabIndex = 30;
            this.btnRemovePicture.Text = "Remove Picture";
            this.btnRemovePicture.UseVisualStyleBackColor = false;
            // 
            // btnUploadPictureProfile
            // 
            this.btnUploadPictureProfile.BackColor = System.Drawing.Color.Black;
            this.btnUploadPictureProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPictureProfile.ForeColor = System.Drawing.Color.White;
            this.btnUploadPictureProfile.Location = new System.Drawing.Point(405, 160);
            this.btnUploadPictureProfile.Name = "btnUploadPictureProfile";
            this.btnUploadPictureProfile.Size = new System.Drawing.Size(80, 41);
            this.btnUploadPictureProfile.TabIndex = 29;
            this.btnUploadPictureProfile.Text = "Upload Picture";
            this.btnUploadPictureProfile.UseVisualStyleBackColor = false;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Image = global::RentalHouseManagementSys.Properties.Resources.NoImage;
            this.pbProfilePicture.Location = new System.Drawing.Point(420, 14);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(135, 131);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 28;
            this.pbProfilePicture.TabStop = false;
            // 
            // lblDateOfBirthProfileOutput
            // 
            this.lblDateOfBirthProfileOutput.AutoSize = true;
            this.lblDateOfBirthProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirthProfileOutput.Location = new System.Drawing.Point(448, 387);
            this.lblDateOfBirthProfileOutput.Name = "lblDateOfBirthProfileOutput";
            this.lblDateOfBirthProfileOutput.Size = new System.Drawing.Size(92, 21);
            this.lblDateOfBirthProfileOutput.TabIndex = 27;
            this.lblDateOfBirthProfileOutput.Text = "10.22.2014";
            // 
            // lblPhoneNumberProfileOutput
            // 
            this.lblPhoneNumberProfileOutput.AutoSize = true;
            this.lblPhoneNumberProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumberProfileOutput.Location = new System.Drawing.Point(448, 351);
            this.lblPhoneNumberProfileOutput.Name = "lblPhoneNumberProfileOutput";
            this.lblPhoneNumberProfileOutput.Size = new System.Drawing.Size(109, 21);
            this.lblPhoneNumberProfileOutput.TabIndex = 26;
            this.lblPhoneNumberProfileOutput.Text = "01571798589";
            // 
            // lblGenderProfileOutput
            // 
            this.lblGenderProfileOutput.AutoSize = true;
            this.lblGenderProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblGenderProfileOutput.Location = new System.Drawing.Point(448, 317);
            this.lblGenderProfileOutput.Name = "lblGenderProfileOutput";
            this.lblGenderProfileOutput.Size = new System.Drawing.Size(45, 21);
            this.lblGenderProfileOutput.TabIndex = 25;
            this.lblGenderProfileOutput.Text = "Male";
            // 
            // lblUserIDProfileOutput
            // 
            this.lblUserIDProfileOutput.AutoSize = true;
            this.lblUserIDProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblUserIDProfileOutput.Location = new System.Drawing.Point(448, 218);
            this.lblUserIDProfileOutput.Name = "lblUserIDProfileOutput";
            this.lblUserIDProfileOutput.Size = new System.Drawing.Size(53, 21);
            this.lblUserIDProfileOutput.TabIndex = 24;
            this.lblUserIDProfileOutput.Text = "T-100";
            // 
            // lblNameProfileOutput
            // 
            this.lblNameProfileOutput.AutoSize = true;
            this.lblNameProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblNameProfileOutput.Location = new System.Drawing.Point(448, 283);
            this.lblNameProfileOutput.Name = "lblNameProfileOutput";
            this.lblNameProfileOutput.Size = new System.Drawing.Size(68, 21);
            this.lblNameProfileOutput.TabIndex = 23;
            this.lblNameProfileOutput.Text = "Koushiq";
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProfile.Location = new System.Drawing.Point(591, 519);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(140, 47);
            this.btnDeleteProfile.TabIndex = 22;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(421, 519);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(140, 47);
            this.btnUpdateProfile.TabIndex = 21;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            // 
            // btnChangePasswordProfile
            // 
            this.btnChangePasswordProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChangePasswordProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePasswordProfile.ForeColor = System.Drawing.Color.White;
            this.btnChangePasswordProfile.Location = new System.Drawing.Point(252, 519);
            this.btnChangePasswordProfile.Name = "btnChangePasswordProfile";
            this.btnChangePasswordProfile.Size = new System.Drawing.Size(140, 47);
            this.btnChangePasswordProfile.TabIndex = 20;
            this.btnChangePasswordProfile.Text = "Change Password";
            this.btnChangePasswordProfile.UseVisualStyleBackColor = false;
            this.btnChangePasswordProfile.Click += new System.EventHandler(this.btnChangePasswordProfile_Click);
            // 
            // lblDateOfBirthProfile
            // 
            this.lblDateOfBirthProfile.AutoSize = true;
            this.lblDateOfBirthProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthProfile.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirthProfile.Location = new System.Drawing.Point(271, 387);
            this.lblDateOfBirthProfile.Name = "lblDateOfBirthProfile";
            this.lblDateOfBirthProfile.Size = new System.Drawing.Size(124, 21);
            this.lblDateOfBirthProfile.TabIndex = 19;
            this.lblDateOfBirthProfile.Text = "Date Of Birth  :";
            // 
            // lblPhoneNumberProfile
            // 
            this.lblPhoneNumberProfile.AutoSize = true;
            this.lblPhoneNumberProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberProfile.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumberProfile.Location = new System.Drawing.Point(261, 351);
            this.lblPhoneNumberProfile.Name = "lblPhoneNumberProfile";
            this.lblPhoneNumberProfile.Size = new System.Drawing.Size(134, 21);
            this.lblPhoneNumberProfile.TabIndex = 18;
            this.lblPhoneNumberProfile.Text = "Phone Number  :";
            // 
            // lblGenderProfile
            // 
            this.lblGenderProfile.AutoSize = true;
            this.lblGenderProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderProfile.ForeColor = System.Drawing.Color.White;
            this.lblGenderProfile.Location = new System.Drawing.Point(317, 317);
            this.lblGenderProfile.Name = "lblGenderProfile";
            this.lblGenderProfile.Size = new System.Drawing.Size(79, 21);
            this.lblGenderProfile.TabIndex = 17;
            this.lblGenderProfile.Text = "Gender  :";
            // 
            // lblUserIDProfile
            // 
            this.lblUserIDProfile.AutoSize = true;
            this.lblUserIDProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDProfile.ForeColor = System.Drawing.Color.White;
            this.lblUserIDProfile.Location = new System.Drawing.Point(318, 218);
            this.lblUserIDProfile.Name = "lblUserIDProfile";
            this.lblUserIDProfile.Size = new System.Drawing.Size(78, 21);
            this.lblUserIDProfile.TabIndex = 16;
            this.lblUserIDProfile.Text = "UserID  :";
            // 
            // lblNameProfile
            // 
            this.lblNameProfile.AutoSize = true;
            this.lblNameProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProfile.ForeColor = System.Drawing.Color.White;
            this.lblNameProfile.Location = new System.Drawing.Point(326, 283);
            this.lblNameProfile.Name = "lblNameProfile";
            this.lblNameProfile.Size = new System.Drawing.Size(69, 21);
            this.lblNameProfile.TabIndex = 15;
            this.lblNameProfile.Text = "Name  :";
            // 
            // mtpFeed
            // 
            this.mtpFeed.Controls.Add(this.flpFeed);
            this.mtpFeed.HorizontalScrollbarBarColor = true;
            this.mtpFeed.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpFeed.HorizontalScrollbarSize = 10;
            this.mtpFeed.Location = new System.Drawing.Point(4, 38);
            this.mtpFeed.Name = "mtpFeed";
            this.mtpFeed.Size = new System.Drawing.Size(967, 597);
            this.mtpFeed.TabIndex = 1;
            this.mtpFeed.Text = "Feed    ";
            this.mtpFeed.VerticalScrollbarBarColor = true;
            this.mtpFeed.VerticalScrollbarHighlightOnWheel = false;
            this.mtpFeed.VerticalScrollbarSize = 10;
            // 
            // flpFeed
            // 
            this.flpFeed.AutoScroll = true;
            this.flpFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flpFeed.Controls.Add(this.pnlSearch);
            this.flpFeed.Location = new System.Drawing.Point(0, 4);
            this.flpFeed.Name = "flpFeed";
            this.flpFeed.Size = new System.Drawing.Size(969, 594);
            this.flpFeed.TabIndex = 2;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lblFlatType);
            this.pnlSearch.Controls.Add(this.cmbFlatType);
            this.pnlSearch.Controls.Add(this.txtSquareFeetUpperLimit);
            this.pnlSearch.Controls.Add(this.txtSquareFeetLowerLimit);
            this.pnlSearch.Controls.Add(this.lblSqareFeet);
            this.pnlSearch.Controls.Add(this.cmbSelectArea);
            this.pnlSearch.Controls.Add(this.txtRentUpperLimit);
            this.pnlSearch.Controls.Add(this.txtRentLowerLimit);
            this.pnlSearch.Controls.Add(this.lblRentRange);
            this.pnlSearch.Controls.Add(this.cbEnableFilter);
            this.pnlSearch.Controls.Add(this.lblSelectArea);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(961, 30);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(153, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 33);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFlatType
            // 
            this.lblFlatType.AutoSize = true;
            this.lblFlatType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatType.ForeColor = System.Drawing.Color.White;
            this.lblFlatType.Location = new System.Drawing.Point(377, 68);
            this.lblFlatType.Name = "lblFlatType";
            this.lblFlatType.Size = new System.Drawing.Size(124, 19);
            this.lblFlatType.TabIndex = 51;
            this.lblFlatType.Text = "Apartment Type";
            this.lblFlatType.Visible = false;
            // 
            // cmbFlatType
            // 
            this.cmbFlatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlatType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFlatType.FormattingEnabled = true;
            this.cmbFlatType.Items.AddRange(new object[] {
            "All",
            "Family",
            "Bachelor"});
            this.cmbFlatType.Location = new System.Drawing.Point(514, 68);
            this.cmbFlatType.Name = "cmbFlatType";
            this.cmbFlatType.Size = new System.Drawing.Size(95, 26);
            this.cmbFlatType.TabIndex = 50;
            this.cmbFlatType.Visible = false;
            // 
            // txtSquareFeetUpperLimit
            // 
            this.txtSquareFeetUpperLimit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSquareFeetUpperLimit.Location = new System.Drawing.Point(624, 31);
            this.txtSquareFeetUpperLimit.Name = "txtSquareFeetUpperLimit";
            this.txtSquareFeetUpperLimit.Size = new System.Drawing.Size(92, 26);
            this.txtSquareFeetUpperLimit.TabIndex = 49;
            this.txtSquareFeetUpperLimit.Visible = false;
            // 
            // txtSquareFeetLowerLimit
            // 
            this.txtSquareFeetLowerLimit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSquareFeetLowerLimit.Location = new System.Drawing.Point(514, 31);
            this.txtSquareFeetLowerLimit.Name = "txtSquareFeetLowerLimit";
            this.txtSquareFeetLowerLimit.Size = new System.Drawing.Size(92, 26);
            this.txtSquareFeetLowerLimit.TabIndex = 48;
            this.txtSquareFeetLowerLimit.Visible = false;
            // 
            // lblSqareFeet
            // 
            this.lblSqareFeet.AutoSize = true;
            this.lblSqareFeet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqareFeet.ForeColor = System.Drawing.Color.White;
            this.lblSqareFeet.Location = new System.Drawing.Point(377, 31);
            this.lblSqareFeet.Name = "lblSqareFeet";
            this.lblSqareFeet.Size = new System.Drawing.Size(92, 19);
            this.lblSqareFeet.TabIndex = 47;
            this.lblSqareFeet.Text = "Square Feet";
            this.lblSqareFeet.Visible = false;
            // 
            // cmbSelectArea
            // 
            this.cmbSelectArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectArea.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectArea.FormattingEnabled = true;
            this.cmbSelectArea.Items.AddRange(new object[] {
            "All",
            "Banani",
            "Baily Road",
            "Bosundhora",
            "Dhanmondi",
            "Farmgate",
            "Mirpur",
            "Gulshan",
            "Old-Dhaka"});
            this.cmbSelectArea.Location = new System.Drawing.Point(153, 30);
            this.cmbSelectArea.Name = "cmbSelectArea";
            this.cmbSelectArea.Size = new System.Drawing.Size(202, 26);
            this.cmbSelectArea.TabIndex = 46;
            this.cmbSelectArea.Visible = false;
            // 
            // txtRentUpperLimit
            // 
            this.txtRentUpperLimit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentUpperLimit.Location = new System.Drawing.Point(263, 67);
            this.txtRentUpperLimit.Name = "txtRentUpperLimit";
            this.txtRentUpperLimit.Size = new System.Drawing.Size(92, 26);
            this.txtRentUpperLimit.TabIndex = 45;
            this.txtRentUpperLimit.Visible = false;
            // 
            // txtRentLowerLimit
            // 
            this.txtRentLowerLimit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentLowerLimit.Location = new System.Drawing.Point(153, 67);
            this.txtRentLowerLimit.Name = "txtRentLowerLimit";
            this.txtRentLowerLimit.Size = new System.Drawing.Size(92, 26);
            this.txtRentLowerLimit.TabIndex = 44;
            this.txtRentLowerLimit.Visible = false;
            // 
            // lblRentRange
            // 
            this.lblRentRange.AutoSize = true;
            this.lblRentRange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentRange.ForeColor = System.Drawing.Color.White;
            this.lblRentRange.Location = new System.Drawing.Point(16, 68);
            this.lblRentRange.Name = "lblRentRange";
            this.lblRentRange.Size = new System.Drawing.Size(41, 19);
            this.lblRentRange.TabIndex = 43;
            this.lblRentRange.Text = "Rent";
            // 
            // cbEnableFilter
            // 
            this.cbEnableFilter.AutoSize = true;
            this.cbEnableFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableFilter.ForeColor = System.Drawing.Color.White;
            this.cbEnableFilter.Location = new System.Drawing.Point(16, 7);
            this.cbEnableFilter.Name = "cbEnableFilter";
            this.cbEnableFilter.Size = new System.Drawing.Size(100, 18);
            this.cbEnableFilter.TabIndex = 42;
            this.cbEnableFilter.Text = "Enable Filter";
            this.cbEnableFilter.UseVisualStyleBackColor = true;
            this.cbEnableFilter.CheckedChanged += new System.EventHandler(this.cbEnableFilter_CheckedChanged);
            // 
            // lblSelectArea
            // 
            this.lblSelectArea.AutoSize = true;
            this.lblSelectArea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectArea.ForeColor = System.Drawing.Color.White;
            this.lblSelectArea.Location = new System.Drawing.Point(14, 31);
            this.lblSelectArea.Name = "lblSelectArea";
            this.lblSelectArea.Size = new System.Drawing.Size(88, 19);
            this.lblSelectArea.TabIndex = 37;
            this.lblSelectArea.Text = "Select Area";
            this.lblSelectArea.Visible = false;
            // 
            // mtpNotification
            // 
            this.mtpNotification.Controls.Add(this.flpNotification);
            this.mtpNotification.HorizontalScrollbarBarColor = true;
            this.mtpNotification.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpNotification.HorizontalScrollbarSize = 10;
            this.mtpNotification.Location = new System.Drawing.Point(4, 38);
            this.mtpNotification.Name = "mtpNotification";
            this.mtpNotification.Size = new System.Drawing.Size(967, 597);
            this.mtpNotification.TabIndex = 2;
            this.mtpNotification.Text = "Notification    ";
            this.mtpNotification.VerticalScrollbarBarColor = true;
            this.mtpNotification.VerticalScrollbarHighlightOnWheel = false;
            this.mtpNotification.VerticalScrollbarSize = 10;
            // 
            // flpNotification
            // 
            this.flpNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flpNotification.Location = new System.Drawing.Point(0, 3);
            this.flpNotification.Name = "flpNotification";
            this.flpNotification.Size = new System.Drawing.Size(969, 594);
            this.flpNotification.TabIndex = 2;
            // 
            // mtpAgreements
            // 
            this.mtpAgreements.Controls.Add(this.pnlAgreements);
            this.mtpAgreements.HorizontalScrollbarBarColor = true;
            this.mtpAgreements.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpAgreements.HorizontalScrollbarSize = 10;
            this.mtpAgreements.Location = new System.Drawing.Point(4, 38);
            this.mtpAgreements.Name = "mtpAgreements";
            this.mtpAgreements.Size = new System.Drawing.Size(967, 597);
            this.mtpAgreements.TabIndex = 3;
            this.mtpAgreements.Text = "Agreements    ";
            this.mtpAgreements.VerticalScrollbarBarColor = true;
            this.mtpAgreements.VerticalScrollbarHighlightOnWheel = false;
            this.mtpAgreements.VerticalScrollbarSize = 10;
            // 
            // pnlAgreements
            // 
            this.pnlAgreements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlAgreements.Location = new System.Drawing.Point(0, 3);
            this.pnlAgreements.Name = "pnlAgreements";
            this.pnlAgreements.Size = new System.Drawing.Size(969, 594);
            this.pnlAgreements.TabIndex = 2;
            // 
            // mtpPayment
            // 
            this.mtpPayment.Controls.Add(this.pnlPayment);
            this.mtpPayment.HorizontalScrollbarBarColor = true;
            this.mtpPayment.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpPayment.HorizontalScrollbarSize = 10;
            this.mtpPayment.Location = new System.Drawing.Point(4, 38);
            this.mtpPayment.Name = "mtpPayment";
            this.mtpPayment.Size = new System.Drawing.Size(967, 597);
            this.mtpPayment.TabIndex = 4;
            this.mtpPayment.Text = "Payment    ";
            this.mtpPayment.VerticalScrollbarBarColor = true;
            this.mtpPayment.VerticalScrollbarHighlightOnWheel = false;
            this.mtpPayment.VerticalScrollbarSize = 10;
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlPayment.Controls.Add(this.txtSearchById);
            this.pnlPayment.Controls.Add(this.lblSearchById);
            this.pnlPayment.Controls.Add(this.btnSearchById);
            this.pnlPayment.Controls.Add(this.dgvPayment);
            this.pnlPayment.Controls.Add(this.btnPayment);
            this.pnlPayment.Controls.Add(this.txtPaymentAmount);
            this.pnlPayment.Controls.Add(this.lblPaymentAmount);
            this.pnlPayment.Controls.Add(this.txtAccountNo);
            this.pnlPayment.Controls.Add(this.lblBankAccount);
            this.pnlPayment.Location = new System.Drawing.Point(0, 3);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(966, 594);
            this.pnlPayment.TabIndex = 2;
            this.pnlPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPayment_Paint);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchById.Location = new System.Drawing.Point(707, 17);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(246, 26);
            this.txtSearchById.TabIndex = 40;
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchById.ForeColor = System.Drawing.Color.White;
            this.lblSearchById.Location = new System.Drawing.Point(595, 18);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(106, 21);
            this.lblSearchById.TabIndex = 39;
            this.lblSearchById.Text = "Search By ID";
            // 
            // btnSearchById
            // 
            this.btnSearchById.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearchById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchById.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchById.Location = new System.Drawing.Point(837, 50);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(116, 33);
            this.btnSearchById.TabIndex = 38;
            this.btnSearchById.Text = "Search";
            this.btnSearchById.UseVisualStyleBackColor = false;
            // 
            // dgvPayment
            // 
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(3, 151);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(960, 440);
            this.dgvPayment.TabIndex = 35;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.BlueViolet;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(116, 100);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(116, 33);
            this.btnPayment.TabIndex = 34;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentAmount.Location = new System.Drawing.Point(115, 59);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(246, 26);
            this.txtPaymentAmount.TabIndex = 33;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.ForeColor = System.Drawing.Color.White;
            this.lblPaymentAmount.Location = new System.Drawing.Point(14, 60);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(68, 21);
            this.lblPaymentAmount.TabIndex = 32;
            this.lblPaymentAmount.Text = "Amount";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(115, 18);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(246, 26);
            this.txtAccountNo.TabIndex = 31;
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankAccount.ForeColor = System.Drawing.Color.White;
            this.lblBankAccount.Location = new System.Drawing.Point(14, 19);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(95, 21);
            this.lblBankAccount.TabIndex = 30;
            this.lblBankAccount.Text = "Account No";
            // 
            // mtpRecharge
            // 
            this.mtpRecharge.Controls.Add(this.pnlRecharge);
            this.mtpRecharge.HorizontalScrollbarBarColor = true;
            this.mtpRecharge.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpRecharge.HorizontalScrollbarSize = 10;
            this.mtpRecharge.Location = new System.Drawing.Point(4, 38);
            this.mtpRecharge.Name = "mtpRecharge";
            this.mtpRecharge.Size = new System.Drawing.Size(967, 597);
            this.mtpRecharge.TabIndex = 5;
            this.mtpRecharge.Text = "Recharge    ";
            this.mtpRecharge.VerticalScrollbarBarColor = true;
            this.mtpRecharge.VerticalScrollbarHighlightOnWheel = false;
            this.mtpRecharge.VerticalScrollbarSize = 10;
            // 
            // pnlRecharge
            // 
            this.pnlRecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlRecharge.Controls.Add(this.lblNotice);
            this.pnlRecharge.Controls.Add(this.txtRechargeAmount);
            this.pnlRecharge.Controls.Add(this.lblRechargeAmount);
            this.pnlRecharge.Controls.Add(this.btnRequestRecharge);
            this.pnlRecharge.Controls.Add(this.txtBalance);
            this.pnlRecharge.Controls.Add(this.lblCurrentBalance);
            this.pnlRecharge.Location = new System.Drawing.Point(0, 3);
            this.pnlRecharge.Name = "pnlRecharge";
            this.pnlRecharge.Size = new System.Drawing.Size(967, 594);
            this.pnlRecharge.TabIndex = 2;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.White;
            this.lblNotice.Location = new System.Drawing.Point(53, 307);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(853, 23);
            this.lblNotice.TabIndex = 44;
            this.lblNotice.Text = "Notice : Admin must approve your recharge request , upon approval your account wi" +
    "ll be recharged";
            // 
            // txtRechargeAmount
            // 
            this.txtRechargeAmount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechargeAmount.Location = new System.Drawing.Point(171, 67);
            this.txtRechargeAmount.Name = "txtRechargeAmount";
            this.txtRechargeAmount.Size = new System.Drawing.Size(166, 26);
            this.txtRechargeAmount.TabIndex = 42;
            // 
            // lblRechargeAmount
            // 
            this.lblRechargeAmount.AutoSize = true;
            this.lblRechargeAmount.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechargeAmount.ForeColor = System.Drawing.Color.White;
            this.lblRechargeAmount.Location = new System.Drawing.Point(19, 68);
            this.lblRechargeAmount.Name = "lblRechargeAmount";
            this.lblRechargeAmount.Size = new System.Drawing.Size(68, 21);
            this.lblRechargeAmount.TabIndex = 43;
            this.lblRechargeAmount.Text = "Amount";
            // 
            // btnRequestRecharge
            // 
            this.btnRequestRecharge.BackColor = System.Drawing.Color.Firebrick;
            this.btnRequestRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestRecharge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestRecharge.Location = new System.Drawing.Point(171, 109);
            this.btnRequestRecharge.Name = "btnRequestRecharge";
            this.btnRequestRecharge.Size = new System.Drawing.Size(116, 51);
            this.btnRequestRecharge.TabIndex = 41;
            this.btnRequestRecharge.Text = "Request Recharge";
            this.btnRequestRecharge.UseVisualStyleBackColor = false;
            this.btnRequestRecharge.Click += new System.EventHandler(this.btnRequestRecharge_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(171, 17);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(246, 26);
            this.txtBalance.TabIndex = 36;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.White;
            this.lblCurrentBalance.Location = new System.Drawing.Point(15, 18);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(128, 21);
            this.lblCurrentBalance.TabIndex = 37;
            this.lblCurrentBalance.Text = "Current Balance";
            // 
            // pbLogout
            // 
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::RentalHouseManagementSys.Properties.Resources.logout;
            this.pbLogout.Location = new System.Drawing.Point(910, 35);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(47, 47);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 2;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // Tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 702);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.mtcNavigation);
            this.Name = "Tenant";
            this.Text = "Welcome : ";
            this.mtcNavigation.ResumeLayout(false);
            this.mtpProfile.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.mtpFeed.ResumeLayout(false);
            this.flpFeed.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.mtpNotification.ResumeLayout(false);
            this.mtpAgreements.ResumeLayout(false);
            this.mtpPayment.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.mtpRecharge.ResumeLayout(false);
            this.pnlRecharge.ResumeLayout(false);
            this.pnlRecharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcNavigation;
        private MetroFramework.Controls.MetroTabPage mtpFeed;
        private MetroFramework.Controls.MetroTabPage mtpNotification;
        private MetroFramework.Controls.MetroTabPage mtpProfile;
        private MetroFramework.Controls.MetroTabPage mtpAgreements;
        private MetroFramework.Controls.MetroTabPage mtpPayment;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblDateOfBirthProfileOutput;
        private System.Windows.Forms.Label lblPhoneNumberProfileOutput;
        private System.Windows.Forms.Label lblGenderProfileOutput;
        private System.Windows.Forms.Label lblUserIDProfileOutput;
        private System.Windows.Forms.Label lblNameProfileOutput;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnChangePasswordProfile;
        private System.Windows.Forms.Label lblDateOfBirthProfile;
        private System.Windows.Forms.Label lblPhoneNumberProfile;
        private System.Windows.Forms.Label lblGenderProfile;
        private System.Windows.Forms.Label lblUserIDProfile;
        private System.Windows.Forms.Label lblNameProfile;
        private System.Windows.Forms.FlowLayoutPanel flpFeed;
        private System.Windows.Forms.FlowLayoutPanel flpNotification;
        private System.Windows.Forms.Panel pnlAgreements;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Button btnUploadPictureProfile;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.Button btnSearchById;
        private MetroFramework.Controls.MetroTabPage mtpRecharge;
        private System.Windows.Forms.Panel pnlRecharge;
        private System.Windows.Forms.TextBox txtRechargeAmount;
        private System.Windows.Forms.Label lblRechargeAmount;
        private System.Windows.Forms.Button btnRequestRecharge;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.Label lblUsertypeOutput;
        private System.Windows.Forms.Label lblUsertype;
        private System.Windows.Forms.Label lblBankAccountOutput;
        private System.Windows.Forms.Label lblBankAccountNo;
        private System.Windows.Forms.Label lblRentedStatusOutput;
        private System.Windows.Forms.Label lblRentedStatus;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSelectArea;
        private System.Windows.Forms.ComboBox cmbSelectArea;
        private System.Windows.Forms.TextBox txtRentUpperLimit;
        private System.Windows.Forms.TextBox txtRentLowerLimit;
        private System.Windows.Forms.Label lblRentRange;
        private System.Windows.Forms.CheckBox cbEnableFilter;
        private System.Windows.Forms.TextBox txtSquareFeetUpperLimit;
        private System.Windows.Forms.TextBox txtSquareFeetLowerLimit;
        private System.Windows.Forms.Label lblSqareFeet;
        private System.Windows.Forms.Label lblFlatType;
        private System.Windows.Forms.ComboBox cmbFlatType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBalanceOutput;
        private System.Windows.Forms.Label lblBalance;
    }
}