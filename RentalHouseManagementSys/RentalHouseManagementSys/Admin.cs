using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalHouseManagementSys
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        private Login LoginForm { get; set; }
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Login login)
        {
            InitializeComponent();
            this.LoginForm = login;
        }

        private void mbtnAddAdmin_Click(object sender, EventArgs e)
        {
            if(!txtName.Text.Equals("") && !txtPassword.Text.Equals("") && !txtRetypePassword.Text.Equals("") && !txtPhoneNumber.Text.Equals("") && (rbMale.Checked || rbFemale.Checked))
            {
                if(txtPassword.Text.Equals(txtRetypePassword.Text))
                {
                    MessageBox.Show("All Fields are selected");
                }
                else
                {
                    MessageBox.Show("Password can't mismatch!");
                }
                
            }
            else
            {
                MessageBox.Show("No Fields Can't Be Left Empty!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void btnUploadPictureProfile_Click(object sender, EventArgs e)
        {

        }
        private void btnChangePasswordProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {

        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.LoginForm.Visible = true;
            this.Dispose();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
