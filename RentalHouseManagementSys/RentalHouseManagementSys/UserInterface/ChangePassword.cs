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
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        private string Credetials { get; set; }
        private string Usertyep { get; set; }


        private DataAccess Da;
        private DataSet Ds;
        public ChangePassword(string credentials,string usertype)
        {
            InitializeComponent();
            this.Credetials = credentials;
            this.Usertyep = usertype;
            this.txtUserID.Text = this.Credetials;
           
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            if(!this.txtUserID.Text.Equals("") && !this.txtPassword.Text.Equals("")  && !this.txtRetypePassword.Text.Equals("")  && this.txtPassword.Text.Equals(this.txtRetypePassword.Text)  )
            {
                this.Da = new DataAccess();
                if (this.Usertyep.Equals("admin"))
                {
                    this.Da.ExecuteUpdateQuery("update "+this.Usertyep +" set password = '"+this.txtPassword.Text+"' where userid = '"+this.txtUserID.Text+"'  ");
                }
                else
                {
                    Console.WriteLine("update '" + this.Usertyep + "' set password = '" + this.txtPassword.Text + "' where userid= '" + this.txtUserID.Text + "'");
                    try
                    {
                        this.Da.ExecuteUpdateQuery("update " + this.Usertyep + " set password = '" + this.txtPassword.Text + "' where userid= '" + this.txtUserID.Text + "'");
                        MessageBox.Show("Done");
                        this.Dispose();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("incorrect Parameters !");
            }
        }

       
    }
}
