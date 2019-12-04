namespace RentalHouseManagementSys
{
    partial class Admin
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
            this.lblDateOfBirthProfileOutput = new System.Windows.Forms.Label();
            this.lblPhoneNumberProfileOutput = new System.Windows.Forms.Label();
            this.lblGenderProfileOutput = new System.Windows.Forms.Label();
            this.lblUserIDProfileOutput = new System.Windows.Forms.Label();
            this.lblNameProfileOutput = new System.Windows.Forms.Label();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnChangePasswordProfile = new System.Windows.Forms.Button();
            this.btnUploadPictureProfile = new System.Windows.Forms.Button();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblDateOfBirthProfile = new System.Windows.Forms.Label();
            this.lblPhoneNumberProfile = new System.Windows.Forms.Label();
            this.lblGenderProfile = new System.Windows.Forms.Label();
            this.lblUserIDProfile = new System.Windows.Forms.Label();
            this.lblNameProfile = new System.Windows.Forms.Label();
            this.mtpFeed = new MetroFramework.Controls.MetroTabPage();
            this.flpFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.mtpNotification = new MetroFramework.Controls.MetroTabPage();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.mtpAgreements = new MetroFramework.Controls.MetroTabPage();
            this.mtpAddAdmin = new MetroFramework.Controls.MetroTabPage();
            this.pnlAddAdmin = new System.Windows.Forms.Panel();
            this.mbtnAddAdmin = new MetroFramework.Controls.MetroButton();
            this.mdtDateOfBirth = new MetroFramework.Controls.MetroDateTime();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.mtpSystemData = new MetroFramework.Controls.MetroTabPage();
            this.mtcSystemDataTab = new MetroFramework.Controls.MetroTabControl();
            this.mtpUsers = new MetroFramework.Controls.MetroTabPage();
            this.pnlSystemDataUsers = new System.Windows.Forms.Panel();
            this.btnSystemDataUsersRemove = new System.Windows.Forms.Button();
            this.dgvSystemDataUsersSystemData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.lblSystemDataUsersSearchByID = new System.Windows.Forms.Label();
            this.btnSystemDataUsersSearch = new System.Windows.Forms.Button();
            this.cmbSystemDataUsersUserType = new System.Windows.Forms.ComboBox();
            this.txtSystemDataUsersSearch = new System.Windows.Forms.TextBox();
            this.mtpApartments = new MetroFramework.Controls.MetroTabPage();
            this.pnlSystemDataApartments = new System.Windows.Forms.Panel();
            this.dgvSystemDataApartments = new System.Windows.Forms.DataGridView();
            this.btnSystemDataApartmentsRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSystemDataApartmentsSearch = new System.Windows.Forms.Button();
            this.lblSystemDataApartmentsSearchByID = new System.Windows.Forms.Label();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.mtpPayment = new MetroFramework.Controls.MetroTabPage();
            this.mtcNavigation.SuspendLayout();
            this.mtpProfile.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.mtpFeed.SuspendLayout();
            this.mtpNotification.SuspendLayout();
            this.mtpAddAdmin.SuspendLayout();
            this.pnlAddAdmin.SuspendLayout();
            this.mtpSystemData.SuspendLayout();
            this.mtcSystemDataTab.SuspendLayout();
            this.mtpUsers.SuspendLayout();
            this.pnlSystemDataUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemDataUsersSystemData)).BeginInit();
            this.mtpApartments.SuspendLayout();
            this.pnlSystemDataApartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemDataApartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcNavigation
            // 
            this.mtcNavigation.Controls.Add(this.mtpProfile);
            this.mtcNavigation.Controls.Add(this.mtpFeed);
            this.mtcNavigation.Controls.Add(this.mtpNotification);
            this.mtcNavigation.Controls.Add(this.mtpAddAdmin);
            this.mtcNavigation.Controls.Add(this.mtpSystemData);
            this.mtcNavigation.Controls.Add(this.mtpAgreements);
            this.mtcNavigation.Location = new System.Drawing.Point(0, 63);
            this.mtcNavigation.Name = "mtcNavigation";
            this.mtcNavigation.SelectedIndex = 5;
            this.mtcNavigation.Size = new System.Drawing.Size(977, 639);
            this.mtcNavigation.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtcNavigation.TabIndex = 0;
            this.mtcNavigation.UseSelectable = true;
            // 
            // mtpProfile
            // 
            this.mtpProfile.Controls.Add(this.pnlProfile);
            this.mtpProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtpProfile.HorizontalScrollbarBarColor = true;
            this.mtpProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpProfile.HorizontalScrollbarSize = 10;
            this.mtpProfile.Location = new System.Drawing.Point(4, 38);
            this.mtpProfile.Name = "mtpProfile";
            this.mtpProfile.Size = new System.Drawing.Size(969, 597);
            this.mtpProfile.TabIndex = 0;
            this.mtpProfile.Text = "Profile    ";
            this.mtpProfile.VerticalScrollbarBarColor = true;
            this.mtpProfile.VerticalScrollbarHighlightOnWheel = false;
            this.mtpProfile.VerticalScrollbarSize = 10;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlProfile.Controls.Add(this.lblDateOfBirthProfileOutput);
            this.pnlProfile.Controls.Add(this.lblPhoneNumberProfileOutput);
            this.pnlProfile.Controls.Add(this.lblGenderProfileOutput);
            this.pnlProfile.Controls.Add(this.lblUserIDProfileOutput);
            this.pnlProfile.Controls.Add(this.lblNameProfileOutput);
            this.pnlProfile.Controls.Add(this.btnDeleteProfile);
            this.pnlProfile.Controls.Add(this.btnUpdateProfile);
            this.pnlProfile.Controls.Add(this.btnChangePasswordProfile);
            this.pnlProfile.Controls.Add(this.btnUploadPictureProfile);
            this.pnlProfile.Controls.Add(this.pbProfilePicture);
            this.pnlProfile.Controls.Add(this.lblDateOfBirthProfile);
            this.pnlProfile.Controls.Add(this.lblPhoneNumberProfile);
            this.pnlProfile.Controls.Add(this.lblGenderProfile);
            this.pnlProfile.Controls.Add(this.lblUserIDProfile);
            this.pnlProfile.Controls.Add(this.lblNameProfile);
            this.pnlProfile.Location = new System.Drawing.Point(0, 3);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(969, 594);
            this.pnlProfile.TabIndex = 2;
            // 
            // lblDateOfBirthProfileOutput
            // 
            this.lblDateOfBirthProfileOutput.AutoSize = true;
            this.lblDateOfBirthProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirthProfileOutput.Location = new System.Drawing.Point(437, 458);
            this.lblDateOfBirthProfileOutput.Name = "lblDateOfBirthProfileOutput";
            this.lblDateOfBirthProfileOutput.Size = new System.Drawing.Size(92, 21);
            this.lblDateOfBirthProfileOutput.TabIndex = 14;
            this.lblDateOfBirthProfileOutput.Text = "10.22.2014";
            // 
            // lblPhoneNumberProfileOutput
            // 
            this.lblPhoneNumberProfileOutput.AutoSize = true;
            this.lblPhoneNumberProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumberProfileOutput.Location = new System.Drawing.Point(437, 392);
            this.lblPhoneNumberProfileOutput.Name = "lblPhoneNumberProfileOutput";
            this.lblPhoneNumberProfileOutput.Size = new System.Drawing.Size(109, 21);
            this.lblPhoneNumberProfileOutput.TabIndex = 13;
            this.lblPhoneNumberProfileOutput.Text = "01571798589";
            // 
            // lblGenderProfileOutput
            // 
            this.lblGenderProfileOutput.AutoSize = true;
            this.lblGenderProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblGenderProfileOutput.Location = new System.Drawing.Point(437, 331);
            this.lblGenderProfileOutput.Name = "lblGenderProfileOutput";
            this.lblGenderProfileOutput.Size = new System.Drawing.Size(45, 21);
            this.lblGenderProfileOutput.TabIndex = 12;
            this.lblGenderProfileOutput.Text = "Male";
            // 
            // lblUserIDProfileOutput
            // 
            this.lblUserIDProfileOutput.AutoSize = true;
            this.lblUserIDProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblUserIDProfileOutput.Location = new System.Drawing.Point(437, 218);
            this.lblUserIDProfileOutput.Name = "lblUserIDProfileOutput";
            this.lblUserIDProfileOutput.Size = new System.Drawing.Size(54, 21);
            this.lblUserIDProfileOutput.TabIndex = 11;
            this.lblUserIDProfileOutput.Text = "A-100";
            // 
            // lblNameProfileOutput
            // 
            this.lblNameProfileOutput.AutoSize = true;
            this.lblNameProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblNameProfileOutput.Location = new System.Drawing.Point(437, 271);
            this.lblNameProfileOutput.Name = "lblNameProfileOutput";
            this.lblNameProfileOutput.Size = new System.Drawing.Size(68, 21);
            this.lblNameProfileOutput.TabIndex = 10;
            this.lblNameProfileOutput.Text = "Koushiq";
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProfile.Location = new System.Drawing.Point(591, 515);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(140, 47);
            this.btnDeleteProfile.TabIndex = 9;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(421, 515);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(140, 47);
            this.btnUpdateProfile.TabIndex = 8;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnChangePasswordProfile
            // 
            this.btnChangePasswordProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChangePasswordProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePasswordProfile.ForeColor = System.Drawing.Color.White;
            this.btnChangePasswordProfile.Location = new System.Drawing.Point(252, 515);
            this.btnChangePasswordProfile.Name = "btnChangePasswordProfile";
            this.btnChangePasswordProfile.Size = new System.Drawing.Size(140, 47);
            this.btnChangePasswordProfile.TabIndex = 7;
            this.btnChangePasswordProfile.Text = "Change Password";
            this.btnChangePasswordProfile.UseVisualStyleBackColor = false;
            this.btnChangePasswordProfile.Click += new System.EventHandler(this.btnChangePasswordProfile_Click);
            // 
            // btnUploadPictureProfile
            // 
            this.btnUploadPictureProfile.BackColor = System.Drawing.Color.Black;
            this.btnUploadPictureProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPictureProfile.ForeColor = System.Drawing.Color.White;
            this.btnUploadPictureProfile.Location = new System.Drawing.Point(439, 157);
            this.btnUploadPictureProfile.Name = "btnUploadPictureProfile";
            this.btnUploadPictureProfile.Size = new System.Drawing.Size(105, 35);
            this.btnUploadPictureProfile.TabIndex = 6;
            this.btnUploadPictureProfile.Text = "Upload Picture";
            this.btnUploadPictureProfile.UseVisualStyleBackColor = false;
            this.btnUploadPictureProfile.Click += new System.EventHandler(this.btnUploadPictureProfile_Click);
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Image = global::RentalHouseManagementSys.Properties.Resources.NoImage;
            this.pbProfilePicture.Location = new System.Drawing.Point(425, 14);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(135, 131);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 5;
            this.pbProfilePicture.TabStop = false;
            // 
            // lblDateOfBirthProfile
            // 
            this.lblDateOfBirthProfile.AutoSize = true;
            this.lblDateOfBirthProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthProfile.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirthProfile.Location = new System.Drawing.Point(244, 458);
            this.lblDateOfBirthProfile.Name = "lblDateOfBirthProfile";
            this.lblDateOfBirthProfile.Size = new System.Drawing.Size(124, 21);
            this.lblDateOfBirthProfile.TabIndex = 4;
            this.lblDateOfBirthProfile.Text = "Date Of Birth  :";
            // 
            // lblPhoneNumberProfile
            // 
            this.lblPhoneNumberProfile.AutoSize = true;
            this.lblPhoneNumberProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberProfile.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumberProfile.Location = new System.Drawing.Point(234, 392);
            this.lblPhoneNumberProfile.Name = "lblPhoneNumberProfile";
            this.lblPhoneNumberProfile.Size = new System.Drawing.Size(134, 21);
            this.lblPhoneNumberProfile.TabIndex = 3;
            this.lblPhoneNumberProfile.Text = "Phone Number  :";
            // 
            // lblGenderProfile
            // 
            this.lblGenderProfile.AutoSize = true;
            this.lblGenderProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderProfile.ForeColor = System.Drawing.Color.White;
            this.lblGenderProfile.Location = new System.Drawing.Point(289, 331);
            this.lblGenderProfile.Name = "lblGenderProfile";
            this.lblGenderProfile.Size = new System.Drawing.Size(79, 21);
            this.lblGenderProfile.TabIndex = 2;
            this.lblGenderProfile.Text = "Gender  :";
            // 
            // lblUserIDProfile
            // 
            this.lblUserIDProfile.AutoSize = true;
            this.lblUserIDProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDProfile.ForeColor = System.Drawing.Color.White;
            this.lblUserIDProfile.Location = new System.Drawing.Point(290, 218);
            this.lblUserIDProfile.Name = "lblUserIDProfile";
            this.lblUserIDProfile.Size = new System.Drawing.Size(78, 21);
            this.lblUserIDProfile.TabIndex = 1;
            this.lblUserIDProfile.Text = "UserID  :";
            // 
            // lblNameProfile
            // 
            this.lblNameProfile.AutoSize = true;
            this.lblNameProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProfile.ForeColor = System.Drawing.Color.White;
            this.lblNameProfile.Location = new System.Drawing.Point(299, 271);
            this.lblNameProfile.Name = "lblNameProfile";
            this.lblNameProfile.Size = new System.Drawing.Size(69, 21);
            this.lblNameProfile.TabIndex = 0;
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
            this.mtpFeed.Size = new System.Drawing.Size(969, 597);
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
            this.flpFeed.Location = new System.Drawing.Point(0, 3);
            this.flpFeed.Name = "flpFeed";
            this.flpFeed.Size = new System.Drawing.Size(969, 592);
            this.flpFeed.TabIndex = 3;
            // 
            // mtpNotification
            // 
            this.mtpNotification.Controls.Add(this.flpNotification);
            this.mtpNotification.HorizontalScrollbarBarColor = true;
            this.mtpNotification.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpNotification.HorizontalScrollbarSize = 10;
            this.mtpNotification.Location = new System.Drawing.Point(4, 38);
            this.mtpNotification.Name = "mtpNotification";
            this.mtpNotification.Size = new System.Drawing.Size(969, 597);
            this.mtpNotification.TabIndex = 2;
            this.mtpNotification.Text = "Notification    ";
            this.mtpNotification.VerticalScrollbarBarColor = true;
            this.mtpNotification.VerticalScrollbarHighlightOnWheel = false;
            this.mtpNotification.VerticalScrollbarSize = 10;
            // 
            // flpNotification
            // 
            this.flpNotification.AutoScroll = true;
            this.flpNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flpNotification.Location = new System.Drawing.Point(0, 3);
            this.flpNotification.Name = "flpNotification";
            this.flpNotification.Size = new System.Drawing.Size(969, 594);
            this.flpNotification.TabIndex = 2;
            // 
            // mtpAgreements
            // 
            this.mtpAgreements.HorizontalScrollbarBarColor = true;
            this.mtpAgreements.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpAgreements.HorizontalScrollbarSize = 10;
            this.mtpAgreements.Location = new System.Drawing.Point(4, 38);
            this.mtpAgreements.Name = "mtpAgreements";
            this.mtpAgreements.Size = new System.Drawing.Size(969, 597);
            this.mtpAgreements.TabIndex = 5;
            this.mtpAgreements.Text = "Agreements    ";
            this.mtpAgreements.VerticalScrollbarBarColor = true;
            this.mtpAgreements.VerticalScrollbarHighlightOnWheel = false;
            this.mtpAgreements.VerticalScrollbarSize = 10;
            // 
            // mtpAddAdmin
            // 
            this.mtpAddAdmin.Controls.Add(this.pnlAddAdmin);
            this.mtpAddAdmin.HorizontalScrollbarBarColor = true;
            this.mtpAddAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpAddAdmin.HorizontalScrollbarSize = 10;
            this.mtpAddAdmin.Location = new System.Drawing.Point(4, 38);
            this.mtpAddAdmin.Name = "mtpAddAdmin";
            this.mtpAddAdmin.Size = new System.Drawing.Size(969, 597);
            this.mtpAddAdmin.TabIndex = 3;
            this.mtpAddAdmin.Text = "Add Admin    ";
            this.mtpAddAdmin.VerticalScrollbarBarColor = true;
            this.mtpAddAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.mtpAddAdmin.VerticalScrollbarSize = 10;
            // 
            // pnlAddAdmin
            // 
            this.pnlAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlAddAdmin.Controls.Add(this.mbtnAddAdmin);
            this.pnlAddAdmin.Controls.Add(this.mdtDateOfBirth);
            this.pnlAddAdmin.Controls.Add(this.rbFemale);
            this.pnlAddAdmin.Controls.Add(this.rbMale);
            this.pnlAddAdmin.Controls.Add(this.txtPhoneNumber);
            this.pnlAddAdmin.Controls.Add(this.txtRetypePassword);
            this.pnlAddAdmin.Controls.Add(this.txtPassword);
            this.pnlAddAdmin.Controls.Add(this.txtName);
            this.pnlAddAdmin.Controls.Add(this.lblDateOfBirth);
            this.pnlAddAdmin.Controls.Add(this.lblGender);
            this.pnlAddAdmin.Controls.Add(this.lblPhoneNumber);
            this.pnlAddAdmin.Controls.Add(this.lblRetypePassword);
            this.pnlAddAdmin.Controls.Add(this.lblPassword);
            this.pnlAddAdmin.Controls.Add(this.lblName);
            this.pnlAddAdmin.Location = new System.Drawing.Point(-4, 3);
            this.pnlAddAdmin.Name = "pnlAddAdmin";
            this.pnlAddAdmin.Size = new System.Drawing.Size(973, 598);
            this.pnlAddAdmin.TabIndex = 2;
            // 
            // mbtnAddAdmin
            // 
            this.mbtnAddAdmin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtnAddAdmin.Location = new System.Drawing.Point(446, 484);
            this.mbtnAddAdmin.Name = "mbtnAddAdmin";
            this.mbtnAddAdmin.Size = new System.Drawing.Size(127, 35);
            this.mbtnAddAdmin.TabIndex = 13;
            this.mbtnAddAdmin.Text = "Add Admin";
            this.mbtnAddAdmin.UseSelectable = true;
            this.mbtnAddAdmin.Click += new System.EventHandler(this.mbtnAddAdmin_Click);
            // 
            // mdtDateOfBirth
            // 
            this.mdtDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.mdtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mdtDateOfBirth.Location = new System.Drawing.Point(379, 404);
            this.mdtDateOfBirth.MinimumSize = new System.Drawing.Size(4, 29);
            this.mdtDateOfBirth.Name = "mdtDateOfBirth";
            this.mdtDateOfBirth.Size = new System.Drawing.Size(338, 29);
            this.mdtDateOfBirth.TabIndex = 12;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(531, 332);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(73, 22);
            this.rbFemale.TabIndex = 11;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(379, 332);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 22);
            this.rbMale.TabIndex = 10;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(379, 259);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(338, 26);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.Location = new System.Drawing.Point(379, 183);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(338, 26);
            this.txtRetypePassword.TabIndex = 8;
            this.txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(379, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(338, 26);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(379, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 26);
            this.txtName.TabIndex = 6;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(158, 413);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(115, 20);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(204, 333);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(146, 261);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePassword.ForeColor = System.Drawing.Color.White;
            this.lblRetypePassword.Location = new System.Drawing.Point(125, 185);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(148, 20);
            this.lblRetypePassword.TabIndex = 2;
            this.lblRetypePassword.Text = "Retype Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(187, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(218, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // mtpSystemData
            // 
            this.mtpSystemData.Controls.Add(this.mtcSystemDataTab);
            this.mtpSystemData.HorizontalScrollbarBarColor = true;
            this.mtpSystemData.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpSystemData.HorizontalScrollbarSize = 10;
            this.mtpSystemData.Location = new System.Drawing.Point(4, 38);
            this.mtpSystemData.Name = "mtpSystemData";
            this.mtpSystemData.Size = new System.Drawing.Size(969, 597);
            this.mtpSystemData.TabIndex = 4;
            this.mtpSystemData.Text = "System Data    ";
            this.mtpSystemData.VerticalScrollbarBarColor = true;
            this.mtpSystemData.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSystemData.VerticalScrollbarSize = 10;
            // 
            // mtcSystemDataTab
            // 
            this.mtcSystemDataTab.Controls.Add(this.mtpUsers);
            this.mtcSystemDataTab.Controls.Add(this.mtpApartments);
            this.mtcSystemDataTab.Controls.Add(this.mtpPayment);
            this.mtcSystemDataTab.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.mtcSystemDataTab.Location = new System.Drawing.Point(-4, 4);
            this.mtcSystemDataTab.Name = "mtcSystemDataTab";
            this.mtcSystemDataTab.SelectedIndex = 2;
            this.mtcSystemDataTab.Size = new System.Drawing.Size(977, 597);
            this.mtcSystemDataTab.TabIndex = 2;
            this.mtcSystemDataTab.UseSelectable = true;
            // 
            // mtpUsers
            // 
            this.mtpUsers.Controls.Add(this.pnlSystemDataUsers);
            this.mtpUsers.HorizontalScrollbarBarColor = true;
            this.mtpUsers.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpUsers.HorizontalScrollbarSize = 10;
            this.mtpUsers.Location = new System.Drawing.Point(4, 34);
            this.mtpUsers.Name = "mtpUsers";
            this.mtpUsers.Size = new System.Drawing.Size(969, 559);
            this.mtpUsers.TabIndex = 0;
            this.mtpUsers.Text = "Users";
            this.mtpUsers.VerticalScrollbarBarColor = true;
            this.mtpUsers.VerticalScrollbarHighlightOnWheel = false;
            this.mtpUsers.VerticalScrollbarSize = 10;
            // 
            // pnlSystemDataUsers
            // 
            this.pnlSystemDataUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlSystemDataUsers.Controls.Add(this.btnSystemDataUsersRemove);
            this.pnlSystemDataUsers.Controls.Add(this.dgvSystemDataUsersSystemData);
            this.pnlSystemDataUsers.Controls.Add(this.lblSelectUser);
            this.pnlSystemDataUsers.Controls.Add(this.lblSystemDataUsersSearchByID);
            this.pnlSystemDataUsers.Controls.Add(this.btnSystemDataUsersSearch);
            this.pnlSystemDataUsers.Controls.Add(this.cmbSystemDataUsersUserType);
            this.pnlSystemDataUsers.Controls.Add(this.txtSystemDataUsersSearch);
            this.pnlSystemDataUsers.Location = new System.Drawing.Point(-3, 6);
            this.pnlSystemDataUsers.Name = "pnlSystemDataUsers";
            this.pnlSystemDataUsers.Size = new System.Drawing.Size(969, 553);
            this.pnlSystemDataUsers.TabIndex = 2;
            // 
            // btnSystemDataUsersRemove
            // 
            this.btnSystemDataUsersRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSystemDataUsersRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemDataUsersRemove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemDataUsersRemove.ForeColor = System.Drawing.Color.White;
            this.btnSystemDataUsersRemove.Location = new System.Drawing.Point(668, 77);
            this.btnSystemDataUsersRemove.Name = "btnSystemDataUsersRemove";
            this.btnSystemDataUsersRemove.Size = new System.Drawing.Size(87, 38);
            this.btnSystemDataUsersRemove.TabIndex = 7;
            this.btnSystemDataUsersRemove.Text = "Remove";
            this.btnSystemDataUsersRemove.UseVisualStyleBackColor = false;
            // 
            // dgvSystemDataUsersSystemData
            // 
            this.dgvSystemDataUsersSystemData.AllowUserToAddRows = false;
            this.dgvSystemDataUsersSystemData.AllowUserToDeleteRows = false;
            this.dgvSystemDataUsersSystemData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSystemDataUsersSystemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSystemDataUsersSystemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.password,
            this.phonenumber,
            this.gender,
            this.dateofbirth});
            this.dgvSystemDataUsersSystemData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvSystemDataUsersSystemData.Location = new System.Drawing.Point(3, 129);
            this.dgvSystemDataUsersSystemData.Name = "dgvSystemDataUsersSystemData";
            this.dgvSystemDataUsersSystemData.ReadOnly = true;
            this.dgvSystemDataUsersSystemData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSystemDataUsersSystemData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSystemDataUsersSystemData.Size = new System.Drawing.Size(963, 417);
            this.dgvSystemDataUsersSystemData.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "UserID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Username";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Contact";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "Date Of Birth";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectUser.ForeColor = System.Drawing.Color.White;
            this.lblSelectUser.Location = new System.Drawing.Point(767, 8);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(134, 18);
            this.lblSelectUser.TabIndex = 4;
            this.lblSelectUser.Text = "Select User Type";
            // 
            // lblSystemDataUsersSearchByID
            // 
            this.lblSystemDataUsersSearchByID.AutoSize = true;
            this.lblSystemDataUsersSearchByID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemDataUsersSearchByID.ForeColor = System.Drawing.Color.White;
            this.lblSystemDataUsersSearchByID.Location = new System.Drawing.Point(545, 8);
            this.lblSystemDataUsersSearchByID.Name = "lblSystemDataUsersSearchByID";
            this.lblSystemDataUsersSearchByID.Size = new System.Drawing.Size(103, 18);
            this.lblSystemDataUsersSearchByID.TabIndex = 3;
            this.lblSystemDataUsersSearchByID.Text = "Search By Id";
            // 
            // btnSystemDataUsersSearch
            // 
            this.btnSystemDataUsersSearch.BackColor = System.Drawing.Color.Purple;
            this.btnSystemDataUsersSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemDataUsersSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemDataUsersSearch.ForeColor = System.Drawing.Color.White;
            this.btnSystemDataUsersSearch.Location = new System.Drawing.Point(825, 77);
            this.btnSystemDataUsersSearch.Name = "btnSystemDataUsersSearch";
            this.btnSystemDataUsersSearch.Size = new System.Drawing.Size(131, 38);
            this.btnSystemDataUsersSearch.TabIndex = 2;
            this.btnSystemDataUsersSearch.Text = "Search";
            this.btnSystemDataUsersSearch.UseVisualStyleBackColor = false;
            this.btnSystemDataUsersSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSystemDataUsersUserType
            // 
            this.cmbSystemDataUsersUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSystemDataUsersUserType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSystemDataUsersUserType.FormattingEnabled = true;
            this.cmbSystemDataUsersUserType.Items.AddRange(new object[] {
            "Admin",
            "Landlord",
            "Tenant"});
            this.cmbSystemDataUsersUserType.Location = new System.Drawing.Point(770, 38);
            this.cmbSystemDataUsersUserType.Name = "cmbSystemDataUsersUserType";
            this.cmbSystemDataUsersUserType.Size = new System.Drawing.Size(186, 26);
            this.cmbSystemDataUsersUserType.TabIndex = 1;
            // 
            // txtSystemDataUsersSearch
            // 
            this.txtSystemDataUsersSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemDataUsersSearch.Location = new System.Drawing.Point(548, 38);
            this.txtSystemDataUsersSearch.Name = "txtSystemDataUsersSearch";
            this.txtSystemDataUsersSearch.Size = new System.Drawing.Size(207, 26);
            this.txtSystemDataUsersSearch.TabIndex = 0;
            this.txtSystemDataUsersSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // mtpApartments
            // 
            this.mtpApartments.Controls.Add(this.pnlSystemDataApartments);
            this.mtpApartments.HorizontalScrollbarBarColor = true;
            this.mtpApartments.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpApartments.HorizontalScrollbarSize = 10;
            this.mtpApartments.Location = new System.Drawing.Point(4, 34);
            this.mtpApartments.Name = "mtpApartments";
            this.mtpApartments.Size = new System.Drawing.Size(969, 559);
            this.mtpApartments.TabIndex = 1;
            this.mtpApartments.Text = "Apartments";
            this.mtpApartments.VerticalScrollbarBarColor = true;
            this.mtpApartments.VerticalScrollbarHighlightOnWheel = false;
            this.mtpApartments.VerticalScrollbarSize = 10;
            // 
            // pnlSystemDataApartments
            // 
            this.pnlSystemDataApartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlSystemDataApartments.Controls.Add(this.dgvSystemDataApartments);
            this.pnlSystemDataApartments.Controls.Add(this.btnSystemDataApartmentsRemove);
            this.pnlSystemDataApartments.Controls.Add(this.textBox1);
            this.pnlSystemDataApartments.Controls.Add(this.btnSystemDataApartmentsSearch);
            this.pnlSystemDataApartments.Controls.Add(this.lblSystemDataApartmentsSearchByID);
            this.pnlSystemDataApartments.Location = new System.Drawing.Point(-5, 0);
            this.pnlSystemDataApartments.Name = "pnlSystemDataApartments";
            this.pnlSystemDataApartments.Size = new System.Drawing.Size(973, 559);
            this.pnlSystemDataApartments.TabIndex = 2;
            // 
            // dgvSystemDataApartments
            // 
            this.dgvSystemDataApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemDataApartments.Location = new System.Drawing.Point(7, 137);
            this.dgvSystemDataApartments.Name = "dgvSystemDataApartments";
            this.dgvSystemDataApartments.Size = new System.Drawing.Size(963, 415);
            this.dgvSystemDataApartments.TabIndex = 14;
            // 
            // btnSystemDataApartmentsRemove
            // 
            this.btnSystemDataApartmentsRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSystemDataApartmentsRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemDataApartmentsRemove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemDataApartmentsRemove.ForeColor = System.Drawing.Color.White;
            this.btnSystemDataApartmentsRemove.Location = new System.Drawing.Point(733, 76);
            this.btnSystemDataApartmentsRemove.Name = "btnSystemDataApartmentsRemove";
            this.btnSystemDataApartmentsRemove.Size = new System.Drawing.Size(87, 38);
            this.btnSystemDataApartmentsRemove.TabIndex = 13;
            this.btnSystemDataApartmentsRemove.Text = "Remove";
            this.btnSystemDataApartmentsRemove.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(733, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 26);
            this.textBox1.TabIndex = 8;
            // 
            // btnSystemDataApartmentsSearch
            // 
            this.btnSystemDataApartmentsSearch.BackColor = System.Drawing.Color.Purple;
            this.btnSystemDataApartmentsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemDataApartmentsSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemDataApartmentsSearch.ForeColor = System.Drawing.Color.White;
            this.btnSystemDataApartmentsSearch.Location = new System.Drawing.Point(827, 76);
            this.btnSystemDataApartmentsSearch.Name = "btnSystemDataApartmentsSearch";
            this.btnSystemDataApartmentsSearch.Size = new System.Drawing.Size(131, 38);
            this.btnSystemDataApartmentsSearch.TabIndex = 10;
            this.btnSystemDataApartmentsSearch.Text = "Search";
            this.btnSystemDataApartmentsSearch.UseVisualStyleBackColor = false;
            // 
            // lblSystemDataApartmentsSearchByID
            // 
            this.lblSystemDataApartmentsSearchByID.AutoSize = true;
            this.lblSystemDataApartmentsSearchByID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemDataApartmentsSearchByID.ForeColor = System.Drawing.Color.White;
            this.lblSystemDataApartmentsSearchByID.Location = new System.Drawing.Point(730, 5);
            this.lblSystemDataApartmentsSearchByID.Name = "lblSystemDataApartmentsSearchByID";
            this.lblSystemDataApartmentsSearchByID.Size = new System.Drawing.Size(103, 18);
            this.lblSystemDataApartmentsSearchByID.TabIndex = 11;
            this.lblSystemDataApartmentsSearchByID.Text = "Search By Id";
            // 
            // pbLogout
            // 
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::RentalHouseManagementSys.Properties.Resources.logout;
            this.pbLogout.Location = new System.Drawing.Point(910, 35);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(47, 47);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 1;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // mtpPayment
            // 
            this.mtpPayment.HorizontalScrollbarBarColor = true;
            this.mtpPayment.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpPayment.HorizontalScrollbarSize = 10;
            this.mtpPayment.Location = new System.Drawing.Point(4, 34);
            this.mtpPayment.Name = "mtpPayment";
            this.mtpPayment.Size = new System.Drawing.Size(969, 559);
            this.mtpPayment.TabIndex = 2;
            this.mtpPayment.Text = "Payment    ";
            this.mtpPayment.VerticalScrollbarBarColor = true;
            this.mtpPayment.VerticalScrollbarHighlightOnWheel = false;
            this.mtpPayment.VerticalScrollbarSize = 10;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 702);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.mtcNavigation);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Welcome : ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.mtcNavigation.ResumeLayout(false);
            this.mtpProfile.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.mtpFeed.ResumeLayout(false);
            this.mtpNotification.ResumeLayout(false);
            this.mtpAddAdmin.ResumeLayout(false);
            this.pnlAddAdmin.ResumeLayout(false);
            this.pnlAddAdmin.PerformLayout();
            this.mtpSystemData.ResumeLayout(false);
            this.mtcSystemDataTab.ResumeLayout(false);
            this.mtpUsers.ResumeLayout(false);
            this.pnlSystemDataUsers.ResumeLayout(false);
            this.pnlSystemDataUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemDataUsersSystemData)).EndInit();
            this.mtpApartments.ResumeLayout(false);
            this.pnlSystemDataApartments.ResumeLayout(false);
            this.pnlSystemDataApartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemDataApartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcNavigation;
        private MetroFramework.Controls.MetroTabPage mtpProfile;
        private MetroFramework.Controls.MetroTabPage mtpFeed;
        private MetroFramework.Controls.MetroTabPage mtpNotification;
        private MetroFramework.Controls.MetroTabPage mtpAddAdmin;
        private MetroFramework.Controls.MetroTabPage mtpSystemData;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.FlowLayoutPanel flpFeed;
        private System.Windows.Forms.FlowLayoutPanel flpNotification;
        private System.Windows.Forms.Panel pnlAddAdmin;
        private System.Windows.Forms.Label lblName;
        private MetroFramework.Controls.MetroDateTime mdtDateOfBirth;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.Label lblPassword;
        private MetroFramework.Controls.MetroButton mbtnAddAdmin;
        private System.Windows.Forms.Panel pnlSystemDataUsers;
        private System.Windows.Forms.TextBox txtSystemDataUsersSearch;
        private System.Windows.Forms.Button btnSystemDataUsersSearch;
        private System.Windows.Forms.ComboBox cmbSystemDataUsersUserType;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.Label lblSystemDataUsersSearchByID;
        private System.Windows.Forms.DataGridView dgvSystemDataUsersSystemData;
        private System.Windows.Forms.Button btnUploadPictureProfile;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Label lblDateOfBirthProfile;
        private System.Windows.Forms.Label lblPhoneNumberProfile;
        private System.Windows.Forms.Label lblGenderProfile;
        private System.Windows.Forms.Label lblUserIDProfile;
        private System.Windows.Forms.Label lblNameProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnChangePasswordProfile;
        private System.Windows.Forms.Label lblDateOfBirthProfileOutput;
        private System.Windows.Forms.Label lblPhoneNumberProfileOutput;
        private System.Windows.Forms.Label lblGenderProfileOutput;
        private System.Windows.Forms.Label lblUserIDProfileOutput;
        private System.Windows.Forms.Label lblNameProfileOutput;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.Button btnSystemDataUsersRemove;
        private MetroFramework.Controls.MetroTabPage mtpAgreements;
        private MetroFramework.Controls.MetroTabControl mtcSystemDataTab;
        private MetroFramework.Controls.MetroTabPage mtpUsers;
        private MetroFramework.Controls.MetroTabPage mtpApartments;
        private System.Windows.Forms.Panel pnlSystemDataApartments;
        private System.Windows.Forms.Button btnSystemDataApartmentsRemove;
        private System.Windows.Forms.Label lblSystemDataApartmentsSearchByID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSystemDataApartmentsSearch;
        private System.Windows.Forms.DataGridView dgvSystemDataApartments;
        private MetroFramework.Controls.MetroTabPage mtpPayment;
    }
}

