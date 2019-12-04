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
            this.mtpNotification = new MetroFramework.Controls.MetroTabPage();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.mtpAgreements = new MetroFramework.Controls.MetroTabPage();
            this.pnlAgreements = new System.Windows.Forms.Panel();
            this.mtpPayment = new MetroFramework.Controls.MetroTabPage();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.btnUploadPictureProfile = new System.Windows.Forms.Button();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.mtcNavigation.SuspendLayout();
            this.mtpProfile.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.mtpFeed.SuspendLayout();
            this.mtpNotification.SuspendLayout();
            this.mtpAgreements.SuspendLayout();
            this.mtpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcNavigation
            // 
            this.mtcNavigation.Controls.Add(this.mtpProfile);
            this.mtcNavigation.Controls.Add(this.mtpFeed);
            this.mtcNavigation.Controls.Add(this.mtpNotification);
            this.mtcNavigation.Controls.Add(this.mtpAgreements);
            this.mtcNavigation.Controls.Add(this.mtpPayment);
            this.mtcNavigation.Location = new System.Drawing.Point(0, 63);
            this.mtcNavigation.Name = "mtcNavigation";
            this.mtcNavigation.SelectedIndex = 4;
            this.mtcNavigation.Size = new System.Drawing.Size(978, 639);
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
            this.mtpProfile.Size = new System.Drawing.Size(970, 597);
            this.mtpProfile.TabIndex = 0;
            this.mtpProfile.Text = "Profile    ";
            this.mtpProfile.VerticalScrollbarBarColor = true;
            this.mtpProfile.VerticalScrollbarHighlightOnWheel = false;
            this.mtpProfile.VerticalScrollbarSize = 10;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
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
            // lblDateOfBirthProfileOutput
            // 
            this.lblDateOfBirthProfileOutput.AutoSize = true;
            this.lblDateOfBirthProfileOutput.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthProfileOutput.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirthProfileOutput.Location = new System.Drawing.Point(437, 458);
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
            this.lblPhoneNumberProfileOutput.Location = new System.Drawing.Point(437, 392);
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
            this.lblGenderProfileOutput.Location = new System.Drawing.Point(437, 331);
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
            this.lblUserIDProfileOutput.Location = new System.Drawing.Point(437, 218);
            this.lblUserIDProfileOutput.Name = "lblUserIDProfileOutput";
            this.lblUserIDProfileOutput.Size = new System.Drawing.Size(54, 21);
            this.lblUserIDProfileOutput.TabIndex = 24;
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
            this.lblNameProfileOutput.TabIndex = 23;
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
            this.btnDeleteProfile.TabIndex = 22;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(421, 515);
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
            this.btnChangePasswordProfile.Location = new System.Drawing.Point(252, 515);
            this.btnChangePasswordProfile.Name = "btnChangePasswordProfile";
            this.btnChangePasswordProfile.Size = new System.Drawing.Size(140, 47);
            this.btnChangePasswordProfile.TabIndex = 20;
            this.btnChangePasswordProfile.Text = "Change Password";
            this.btnChangePasswordProfile.UseVisualStyleBackColor = false;
            // 
            // lblDateOfBirthProfile
            // 
            this.lblDateOfBirthProfile.AutoSize = true;
            this.lblDateOfBirthProfile.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthProfile.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirthProfile.Location = new System.Drawing.Point(243, 458);
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
            this.lblPhoneNumberProfile.Location = new System.Drawing.Point(233, 392);
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
            this.lblGenderProfile.Location = new System.Drawing.Point(289, 331);
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
            this.lblUserIDProfile.Location = new System.Drawing.Point(290, 218);
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
            this.lblNameProfile.Location = new System.Drawing.Point(299, 271);
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
            this.mtpFeed.Size = new System.Drawing.Size(970, 597);
            this.mtpFeed.TabIndex = 1;
            this.mtpFeed.Text = "Feed    ";
            this.mtpFeed.VerticalScrollbarBarColor = true;
            this.mtpFeed.VerticalScrollbarHighlightOnWheel = false;
            this.mtpFeed.VerticalScrollbarSize = 10;
            // 
            // flpFeed
            // 
            this.flpFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flpFeed.Location = new System.Drawing.Point(0, 4);
            this.flpFeed.Name = "flpFeed";
            this.flpFeed.Size = new System.Drawing.Size(969, 594);
            this.flpFeed.TabIndex = 2;
            // 
            // mtpNotification
            // 
            this.mtpNotification.Controls.Add(this.flpNotification);
            this.mtpNotification.HorizontalScrollbarBarColor = true;
            this.mtpNotification.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpNotification.HorizontalScrollbarSize = 10;
            this.mtpNotification.Location = new System.Drawing.Point(4, 38);
            this.mtpNotification.Name = "mtpNotification";
            this.mtpNotification.Size = new System.Drawing.Size(970, 597);
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
            this.mtpAgreements.Size = new System.Drawing.Size(970, 597);
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
            this.mtpPayment.Size = new System.Drawing.Size(970, 597);
            this.mtpPayment.TabIndex = 4;
            this.mtpPayment.Text = "Payment    ";
            this.mtpPayment.VerticalScrollbarBarColor = true;
            this.mtpPayment.VerticalScrollbarHighlightOnWheel = false;
            this.mtpPayment.VerticalScrollbarSize = 10;
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
            // 
            // btnUploadPictureProfile
            // 
            this.btnUploadPictureProfile.BackColor = System.Drawing.Color.Black;
            this.btnUploadPictureProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPictureProfile.ForeColor = System.Drawing.Color.White;
            this.btnUploadPictureProfile.Location = new System.Drawing.Point(439, 157);
            this.btnUploadPictureProfile.Name = "btnUploadPictureProfile";
            this.btnUploadPictureProfile.Size = new System.Drawing.Size(105, 35);
            this.btnUploadPictureProfile.TabIndex = 29;
            this.btnUploadPictureProfile.Text = "Upload Picture";
            this.btnUploadPictureProfile.UseVisualStyleBackColor = false;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Image = global::RentalHouseManagementSys.Properties.Resources.NoImage;
            this.pbProfilePicture.Location = new System.Drawing.Point(425, 14);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(135, 131);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 28;
            this.pbProfilePicture.TabStop = false;
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlPayment.Controls.Add(this.txtSearchById);
            this.pnlPayment.Controls.Add(this.lblSearchById);
            this.pnlPayment.Controls.Add(this.btnSearchById);
            this.pnlPayment.Controls.Add(this.lblBalance);
            this.pnlPayment.Controls.Add(this.txtBalance);
            this.pnlPayment.Controls.Add(this.dgvPayment);
            this.pnlPayment.Controls.Add(this.btnPayment);
            this.pnlPayment.Controls.Add(this.txtAmount);
            this.pnlPayment.Controls.Add(this.lblAmount);
            this.pnlPayment.Controls.Add(this.txtAccountNo);
            this.pnlPayment.Controls.Add(this.lblBankAccount);
            this.pnlPayment.Location = new System.Drawing.Point(0, 3);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(966, 594);
            this.pnlPayment.TabIndex = 2;
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankAccount.ForeColor = System.Drawing.Color.White;
            this.lblBankAccount.Location = new System.Drawing.Point(7, 59);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(95, 21);
            this.lblBankAccount.TabIndex = 30;
            this.lblBankAccount.Text = "Account No";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(108, 58);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(246, 26);
            this.txtAccountNo.TabIndex = 31;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(7, 100);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(68, 21);
            this.lblAmount.TabIndex = 32;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(108, 99);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(246, 26);
            this.txtAmount.TabIndex = 33;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.BlueViolet;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(109, 136);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(116, 33);
            this.btnPayment.TabIndex = 34;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // dgvPayment
            // 
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(3, 189);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(960, 402);
            this.dgvPayment.TabIndex = 35;
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(108, 17);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(246, 26);
            this.txtBalance.TabIndex = 36;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(7, 18);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(68, 21);
            this.lblBalance.TabIndex = 37;
            this.lblBalance.Text = "Balance";
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
            // Tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 702);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.mtcNavigation);
            this.Name = "Tenant";
            this.Text = "Welcome : ";
            this.mtcNavigation.ResumeLayout(false);
            this.mtpProfile.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.mtpFeed.ResumeLayout(false);
            this.mtpNotification.ResumeLayout(false);
            this.mtpAgreements.ResumeLayout(false);
            this.mtpPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
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
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.Button btnSearchById;
    }
}