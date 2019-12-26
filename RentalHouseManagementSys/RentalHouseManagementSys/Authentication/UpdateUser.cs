using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalHouseManagementSys.Authentication
{
    public partial class UpdateUser : MetroFramework.Forms.MetroForm
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        private string Credentials { get; set; }

        private string AccountType { get; set; }
        public UpdateUser(string credentials,string accountType)
        {
            InitializeComponent();
            this.Credentials = credentials;
            this.AccountType = accountType;
            this.txtUserID.Text = this.Credentials;
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Da = new DataAccess();
            if (!this.txtUsername.Text.Equals("") && !this.txtPhoneNumber.Text.Equals(""))
            {
                try
                {
                    this.Da.ExecuteUpdateQuery("update  " + this.AccountType + " set username= '" + this.txtUsername.Text + "' , phonenumber = '" + this.txtPhoneNumber.Text + "' , dateofbirth = '" + this.mdtDateOfBirth.Text + "'  where userid ='" + this.Credentials + "' ");
                    MessageBox.Show("updated successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Parameters");
            }
        }
    }
}
