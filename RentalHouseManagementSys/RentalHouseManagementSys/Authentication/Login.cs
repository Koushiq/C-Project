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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private Registration registration;
        private Admin admin;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text.Equals("root") && txtPassword.Text.Equals("root"))
            {
                this.Visible = false;
                admin = new Admin(this);
                admin.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong user credentials!");
            }
            txtUserID.Text = "";
            txtPassword.Text = "";
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            registration = new Registration(this);
            registration.Visible = true;
        }
    }
}
