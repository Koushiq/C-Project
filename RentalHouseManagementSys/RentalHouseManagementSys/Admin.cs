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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private Login LoginForm { get; set; }
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Login login)
        {
            InitializeComponent();
            this.LoginForm = login;
            PopulateGridView();
        }

        private void mbtnAddAdmin_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.GetID());
            num++;
            string id ="a-"+ num.ToString("D3");
           
            if(!txtName.Text.Equals("") && !txtPassword.Text.Equals("") && !txtRetypePassword.Text.Equals("") && !txtPhoneNumber.Text.Equals("") && (rbMale.Checked || rbFemale.Checked))
            {
                if(txtPassword.Text.Equals(txtRetypePassword.Text))
                {
                    try
                    {
                        if(rbMale.Checked)
                        {
                            this.Sql = "INSERT INTO admin VALUES('"+id+"', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtPhoneNumber.Text + "', 'Male', '"+this.mdtDateOfBirth.Text+"');";
                           
                        }
                        else
                        {
                            this.Sql = "INSERT INTO admin VALUES('"+id+"', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtPhoneNumber.Text + "', 'Female', '"+ this.mdtDateOfBirth.Text +"');";
                        }
                        Da.ExecuteUpdateQuery(Sql);
                        MessageBox.Show("Your id is " + id);
                        this.txtName.Text = "";
                        this.txtPassword.Text = "";
                        this.txtRetypePassword.Text = "";
                        this.txtPhoneNumber.Text = "";
                        this.rbMale.Checked = false;
                        this.rbFemale.Checked = false;

                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex);
                    } 
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        public void PopulateGridView(string sql="select * from admin")
        {
            Da = new DataAccess();
            Ds = Da.ExecuteQuery(sql);
            this.dgvSystemDataUsersSystemData.AutoGenerateColumns = false;
            this.dgvSystemDataUsersSystemData.DataSource = Ds.Tables[0];
        }
        public string GetID()
        {
            this.Sql = "select id from admin order by id desc;";
            Da = new DataAccess();
            Ds = Da.ExecuteQuery(Sql);
           string str= Ds.Tables[0].Rows[0]["id"].ToString();
           string []id=str.Split('-');
            return id[1];
            
        }
    }
}
