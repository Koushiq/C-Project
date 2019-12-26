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

        private string [] attributeNames;
        private List<Panel> adsPanel;
        private List<Label>[] adsAttribute;
        private List<PictureBox> adsPicture;
        private Login LoginForm { get; set; }
        private string CredentialsId { get; set; }
        public Admin()
        {
            InitializeComponent();
            
        }
        public Admin(Login login,string credentailId)
        {
            InitializeComponent();
            this.LoginForm = login;
            this.GetFeedData("select * from ad order by adid");
            this.PopulateGridView();
            this.CredentialsId = credentailId;
        }
        public void GetFeedData(string sql)
        {
            this.attributeNames = new string[12] { "AD-ID :", "Title : ", "Rent : ", "Location : ", "Block/Road :", "Apartment No : ", "Contact : ", "SquareFeet : ", "Floor : ", "Facilities : ", "Owener ID : ", "Flat available for : " };
            this.adsPanel = new List<Panel>();
            this.adsAttribute = new List<Label>[12];


            for (int i = 0; i < adsAttribute.Length; i++)
            {
                this.adsAttribute[i] = new List<Label>();
            }

            try
            {
                this.Da = new DataAccess();
                this.Ds = Da.ExecuteQuery(sql);
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    //runtime panel
                    this.adsPicture = new List<PictureBox>();
                    this.adsPanel.Add(new Panel());
                    this.adsPanel.ElementAt(i).Size = new Size(930, 600);
                    this.adsPanel.ElementAt(i).BackColor = Color.FromArgb(190, 255, 255, 255);

                    //load Attributes to feed 
                    for (int j = 0, k = 0; j < adsAttribute.Length; j++, k += 40)
                    {
                        Console.WriteLine(Ds.Tables[0].Rows[i][j].ToString());
                        this.adsAttribute[i].Add(new Label());
                        this.adsAttribute[i].ElementAt(j).Size = new Size(300, 24);
                        this.adsAttribute[i].ElementAt(j).Location = new Point(59, (18 + k));
                        this.adsAttribute[i].ElementAt(j).BackColor = Color.FromArgb(0, 255, 255, 255);
                        this.adsAttribute[i].ElementAt(j).Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.adsAttribute[i].ElementAt(j).Text += attributeNames[j] + Ds.Tables[0].Rows[i][j].ToString();
                        this.adsPanel.ElementAt(i).Controls.Add(adsAttribute[i].ElementAt(j));
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        this.adsPicture.Add(new PictureBox());
                        this.adsPicture.ElementAt(j).Size = new Size(200, 200);
                        this.adsPicture.ElementAt(j).SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        this.adsPicture.ElementAt(j).ImageLocation = Ds.Tables[0].Rows[i][j + 12].ToString();
                        this.adsPicture.ElementAt(j).Visible = true;
                        this.adsPanel.ElementAt(i).Controls.Add(adsPicture.ElementAt(j));
                    }
                    this.adsPicture.ElementAt(0).Location = new Point(500, 9);
                    this.adsPicture.ElementAt(1).Location = new Point(720, 9);
                    this.adsPicture.ElementAt(2).Location = new Point(500, 250);
                    this.adsPicture.ElementAt(3).Location = new Point(720, 250);

                    this.flpFeed.Controls.Add(adsPanel.ElementAt(i));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
       
        private void mbtnAddAdmin_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.GetID());
            num++;
            string id ="a-"+ num.ToString("D3");
           
            if(!this.txtName.Text.Equals("") && !this.txtPassword.Text.Equals("") && !this.txtRetypePassword.Text.Equals("") && !this.txtPhoneNumber.Text.Equals("") && (this.rbMale.Checked || this.rbFemale.Checked))
            {
                if(this.txtPassword.Text.Equals(this.txtRetypePassword.Text))
                {
                    try
                    {
                        if(this.rbMale.Checked)
                        {
                            this.Sql = "INSERT INTO admin VALUES('"+id+"', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtPhoneNumber.Text + "', 'Male', '"+this.mdtDateOfBirth.Text+"');";
                           
                        }
                        else
                        {
                            this.Sql = "INSERT INTO admin VALUES('"+id+"', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtPhoneNumber.Text + "', 'Female', '"+ this.mdtDateOfBirth.Text +"');";
                        }
                        this.Da.ExecuteUpdateQuery(Sql);
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
            ChangePassword changePassword = new ChangePassword(this.CredentialsId, "admin");
            changePassword.Visible = true;
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            this.Da = new DataAccess();
            this.Da.ExecuteUpdateQuery("delete from admin where id = '"+CredentialsId+"'");
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

      
        public void PopulateGridView(string sql="select * from admin")
        {
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(sql);
            this.dgvSystemDataUsersSystemData.AutoGenerateColumns = false;
            this.dgvSystemDataUsersSystemData.DataSource = Ds.Tables[0];
        }
        public string GetID()
        {
            this.Sql = "select id from admin order by id desc;";
            this.Da = new DataAccess();
            this.Ds = Da.ExecuteQuery(Sql);
           string str= Ds.Tables[0].Rows[0]["id"].ToString();
           string []id=str.Split('-');
            return id[1];
            
        }

        private void cbEnableFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbEnableFilter.Checked)
            {
                this.lblSearchByArea.Visible = false;
                this.lblRentRange.Visible = false;
                this.lblSqareFeet.Visible = false;
                this.lblFlatType.Visible = false;
                this.cmbSearchByArea.Visible = false;
                this.txtRentLowerLimit.Visible = false;
                this.txtRentUpperLimit.Visible = false;
                this.txtSquareFeetLowerLimit.Visible = false;
                this.txtSquareFeetUpperLimit.Visible = false;
                this.cmbFlatType.Visible = false;
                this.pnlSearch.Size = new Size(961, 30);

                try
                {

                }
                catch (SqlException ex)
                {

                }

            }
            else
            {
                this.lblSearchByArea.Visible = true;
                this.lblRentRange.Visible = true;
                this.lblSqareFeet.Visible = true;
                this.lblFlatType.Visible = true;
                this.cmbSearchByArea.Visible = true;
                this.txtRentLowerLimit.Visible = true;
                this.txtRentUpperLimit.Visible = true;
                this.txtSquareFeetLowerLimit.Visible = true;
                this.txtSquareFeetUpperLimit.Visible = true;
                this.cmbFlatType.Visible = true;
                this.pnlSearch.Size = new Size(961, 156);

            }
        }

       

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery(" select * from admin where id = '" + this.CredentialsId + "'");
            this.lblUserIDProfileOutput.Text = this.Ds.Tables[0].Rows[0]["id"].ToString();
            this.lblNameProfileOutput.Text = this.Ds.Tables[0].Rows[0]["name"].ToString();
            this.lblGenderProfileOutput.Text = this.Ds.Tables[0].Rows[0]["gender"].ToString();
            this.lblPhoneNumberProfileOutput.Text = this.Ds.Tables[0].Rows[0]["phone"].ToString();
            this.lblDateOfBirthProfileOutput.Text = this.Ds.Tables[0].Rows[0]["dateofbirth"].ToString();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < this.adsPanel.Count; i++)
            {
                this.adsPanel.ElementAt(i).Dispose();
            }
            if (cbEnableFilter.Checked)
            {
                Console.WriteLine("select * from ad where location = '" + this.cmbSearchByArea.Text + "' and rent>= " + this.txtRentLowerLimit.Text + " and rent<= " + this.txtRentUpperLimit.Text + " and squarefeet >= " + this.txtSquareFeetLowerLimit.Text + "  and squarefeet <= " + this.txtSquareFeetUpperLimit.Text + " and flattype = '" + this.cmbFlatType.Text + "' order by adid;");
                try
                {
                    if (!this.cmbSearchByArea.Text.Equals("") && !this.txtRentLowerLimit.Text.Equals("") && !this.txtRentUpperLimit.Text.Equals("") && !this.txtSquareFeetLowerLimit.Text.Equals("") && !this.txtSquareFeetUpperLimit.Text.Equals("") && !this.cmbFlatType.Text.Equals(""))
                    {
                        this.GetFeedData("select * from ad where location = '" + this.cmbSearchByArea.Text + "' and rent>= " + this.txtRentLowerLimit.Text + " and rent<= " + this.txtRentUpperLimit.Text + " and squarefeet >= " + this.txtSquareFeetLowerLimit.Text + "  and squarefeet <= " + this.txtSquareFeetUpperLimit.Text + " and flattype = '" + this.cmbFlatType.Text + "'; ");
                    }
                    else
                    {
                        MessageBox.Show("Parameters can't be empty ");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
            else
            {
                try
                {
                    this.GetFeedData("select * from ad ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
