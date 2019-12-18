using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalHouseManagementSys
{
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        private string AccountID { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private Login LoginForm { get; set; }
        public Registration()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public Registration(Login login)
        {
            InitializeComponent();
            this.LoginForm = login;
            this.Da = new DataAccess();
        }
        private void GetID(string usertype)
        {
            int idNumberCount=0;
            string[] value;
            this.AccountID = "";
            if (this.cmbAccountType.SelectedItem.Equals("Tenant"))
            {
                this.AccountID += "T-";
            }
            else if (this.cmbAccountType.SelectedItem.Equals("Landlord"))
            {
                this.AccountID += "L-";
            }


            try
            {
                if(this.AccountID.Equals("T-"))
                {
                    this.Ds = this.Da.ExecuteQuery("select * from tenantinfo order by userid desc;");
                }
                else
                {
                    this.Ds = this.Da.ExecuteQuery("select * from landlordinfo order by userid desc;");
                }
                
                if (this.Ds.Tables[0].Rows.Count == 0)
                {
                    this.AccountID += "100";
                    this.txtUserID.Text = this.AccountID;
                }
                else
                {
                    value = this.Ds.Tables[0].Rows[0][0].ToString().Split('-');
                    idNumberCount = Convert.ToInt32(value[1]);
                    idNumberCount++;
                    this.AccountID += idNumberCount.ToString();
                    
                }
                this.txtUserID.Text = this.AccountID;
               
                this.txtBankAccountID.Text = "ACCID-" + (this.AccountID);
                
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.ToString());
            }
            this.AccountID = "";
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.LoginForm.Visible = true;
            this.Dispose();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string g;
            if (!this.txtUsername.Text.Equals("") && !this.txtPassword.Text.Equals("") && !this.txtRetypePassword.Text.Equals("") && (this.rbMale.Checked || this.rbFemale.Checked) && !this.txtPhoneNumber.Text.Equals("") && !this.mdtDateOfBirth.Text.Equals("") && !this.cmbAccountType.Text.Equals(""))
            {
                if (!this.txtPassword.Text.Equals(this.txtRetypePassword.Text))
                {
                    MessageBox.Show("Password Mismatch!");
                }
                else
                {
                    this.Da = new DataAccess();
                    if(rbMale.Checked)
                    {
                        g = "Male";
                    }
                    else
                    {
                        g = "Female";
                    }

                    if(cmbAccountType.Text.Equals("Tenant"))
                    {
                        this.Da.ExecuteUpdateQuery("insert into tenantinfo (userid,username,password,gender,phonenumber,dateofbirth,accounttype,bankaccountid,rentedstatus) values  ('" + this.txtUserID.Text + "', '" + this.txtUsername.Text + "', '" + this.txtPassword.Text + "' , '"+g+"', '" + this.txtPhoneNumber.Text + "', '" + this.mdtDateOfBirth.Text + "', '" + this.cmbAccountType.Text + "','" + this.txtBankAccountID.Text + "','false') ;");
                    }
                    else
                    {
                        this.Da.ExecuteUpdateQuery("insert into landlordinfo (userid,username,password,gender,phonenumber,dateofbirth,accounttype,bankaccountid,flatcount) values  ('" + this.txtUserID.Text + "', '" + this.txtUsername.Text + "', '" + this.txtPassword.Text + "' , '"+g+"', '" + this.txtPhoneNumber.Text + "', '" + this.mdtDateOfBirth.Text + "', '" + this.cmbAccountType.Text + "','" + this.txtBankAccountID.Text + "','0') ;");
                    }
                    this.txtUsername.Text = "";
                    this.txtPassword.Text = "";
                    this.txtRetypePassword.Text = "";
                    this.rbMale.Checked = false;
                    this.rbFemale.Checked = false;
                    this.txtPhoneNumber.Text = "";
                    this.mdtDateOfBirth.Text = ""; 
                }
            }
            else
            {
                MessageBox.Show("No fields can't be empty");
            }
        }
            
        

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetID(this.cmbAccountType.Text);
        }
    }
}
