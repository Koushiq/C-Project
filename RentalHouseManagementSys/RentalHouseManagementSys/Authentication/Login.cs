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
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private Registration registration;
        private Admin admin;
        private Landlord landlord;
        private Tenant tenant;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(!this.txtUserID.Text.Equals("") && !this.txtPassword.Text.Equals(""))
            {
                this.Da = new DataAccess();
                string firstchar = txtUserID.Text;
                Console.WriteLine(firstchar[0]);
                if (firstchar[0].Equals('a'))
                {
                    this.Ds = this.Da.ExecuteQuery("select password from admin where id = '" + this.txtUserID.Text + " ' ");
                    if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][0].ToString().Equals(this.txtPassword.Text))
                    {
                        MessageBox.Show("Access Granted");
                        this.Visible = false;
                        this.admin = new Admin(this,this.txtUserID.Text);
                        this.admin.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong user credentials!");

                    }
                }
                else if (firstchar[0].Equals('T'))
                {
                    this.Ds = this.Da.ExecuteQuery("select password from tenantinfo where userid = '" + this.txtUserID.Text + " ' ");
                    if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][0].ToString().Equals(this.txtPassword.Text))
                    {
                        MessageBox.Show("Access Granted");
                        this.Visible = false;
                        this.tenant = new Tenant(this, this.txtUserID.Text);
                        this.tenant.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong user credentials!");

                    }
                }
                else if (firstchar[0].Equals('L'))
                {
                    this.Ds = this.Da.ExecuteQuery("select password from landlordinfo where userid = '" + this.txtUserID.Text + " ' ");
                    if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][0].ToString().Equals(this.txtPassword.Text))
                    {
                        MessageBox.Show("Access Granted");
                        this.Visible = false;
                        this.landlord = new Landlord(this,this.txtUserID.Text);
                        this.landlord.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong user credentials!");

                    }
                }
                else
                {
                    MessageBox.Show("Wrong user credentials!");
                }
                Console.WriteLine("here");
            }
            else
            {
                MessageBox.Show("No field can't be empty");
            }
            this.txtUserID.Text = "";
            this.txtPassword.Text = "";
        }
           

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            registration = new Registration(this);
            registration.Visible = true;
        }
    }
}
