using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalHouseManagementSys
{
   
    public partial class Landlord : MetroFramework.Forms.MetroForm
    {
        private List<Button> viewTenantProfileBtn;
        private List<Button> approveRequestBtn;
        private List<Panel> notificationPanels;
        private List<Label> notificationLabels;
        private List<Panel> adsPanel ;
        private List<Label>[] adsAttribute;
        private string[] attributeNames;
        private List<PictureBox> adsPicture;
        private bool[] pictureSelected = new bool[] { false, false, false, false };
        private PictureBox[] pb;
        private TextBox[] tb;
        private string[] des;
        private string CredentialId { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        
        private DataAccess DaUsername { get; set; }
        private DataSet DsUsername { get; set; }
        private DataAccess DaNotification { get; set; }
        private DataSet DsNotification { get; set; }
        private Login LoginForm { get; set; }
       
        public Landlord()
        {
            InitializeComponent();
        }
        public Landlord(Login login,string credentialId)
        {
            InitializeComponent();
            this.LoginForm = login;
            this.CredentialId = credentialId;
            this.GetFeedData();
            this.GetNotificationData();
            this.GetAdID();
            this.PopulateGridViewAgreements();
        }
        private void PopulateGridViewAgreements()
        {
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery("select * from agreement where landlordid = '"+this.CredentialId+"'");
            this.dgvAgreements.AutoGenerateColumns = false;
            this.dgvAgreements.DataSource =this.Ds.Tables[0];
            
        }

        public void GetNotificationData()
        {
            this.notificationPanels = new List<Panel>();
            this.notificationLabels = new List<Label>();
            this.viewTenantProfileBtn = new List<Button>();
            this.approveRequestBtn = new List<Button>();
            try
            {
                this.Da = new DataAccess();
               
                this.Ds = this.Da.ExecuteQuery("select * from notification where receiver = '" + this.CredentialId + "' and status='pending' order by id");

                this.DaUsername = new DataAccess();

                Console.WriteLine("Row of notification is " + this.Ds.Tables[0].Rows.Count);

                for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
                {
                    this.DsUsername = this.DaUsername.ExecuteQuery("select username from tenantinfo where userid = '" + this.Ds.Tables[0].Rows[i]["sender"].ToString() + "'");
                    
                    //runtime notification panel
                    this.notificationPanels.Add(new Panel());
                    this.notificationPanels.ElementAt(i).Size = new Size(958, 55);
                    this.notificationPanels.ElementAt(i).BackColor = Color.FromArgb(200, 255, 255, 255);

                    //runtime notification label per panel 
                    this.notificationLabels.Add(new Label());
                    this.notificationLabels.ElementAt(i).Size = new Size(919, 20);
                    this.notificationLabels.ElementAt(i).Location = new Point(9, 20);
                    //runtime label styling 
                    this.notificationLabels.ElementAt(i).Text = this.DsUsername.Tables[0].Rows[0]["username"].ToString() + " wants to rent your home from " + this.Ds.Tables[0].Rows[i]["adid"];
                    this.notificationLabels.ElementAt(i).ForeColor = Color.FromArgb(0, 0, 0);
                    this.notificationLabels.ElementAt(i).Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    //runtime notification approve request buttons 
                    this.approveRequestBtn.Add(new Button());
                    this.approveRequestBtn.ElementAt(i).Text = "Approve Request";
                    this.approveRequestBtn.ElementAt(i).Size = new Size(90, 40);
                    this.approveRequestBtn.ElementAt(i).Location = new Point(750,10);
                    this.approveRequestBtn.ElementAt(i).Click += new EventHandler(ApproveRequestBtn_Click);


                    //runtime notification approve request buttons 
                    this.viewTenantProfileBtn.Add(new Button());
                    this.viewTenantProfileBtn.ElementAt(i).Text = "view profile";
                    this.viewTenantProfileBtn.ElementAt(i).Size = new Size(90, 40);
                    this.viewTenantProfileBtn.ElementAt(i).Location = new Point(850, 10);
                    this.viewTenantProfileBtn.ElementAt(i).Click += new EventHandler(ViewTenantProfileBtn_Click);



                    this.notificationPanels.ElementAt(i).Controls.Add(this.approveRequestBtn.ElementAt(i));
                    this.notificationPanels.ElementAt(i).Controls.Add(this.viewTenantProfileBtn.ElementAt(i));
                    this.notificationPanels.ElementAt(i).Controls.Add(this.notificationLabels.ElementAt(i));
                    this.flpNotification.Controls.Add(notificationPanels.ElementAt(i));


                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
         
        public void GetFeedData()
        {
           this.attributeNames = new string[12] { "AD-ID :","Title : ", "Rent : " , "Location : ", "Block/Road :", "Apartment No : ", "Contact : " , "SquareFeet : " , "Floor : ", "Facilities : ", "Owener ID : ","Flat available for : "};
           this.adsPanel = new List<Panel>();
           this.adsAttribute = new List<Label>[12];
          

           for(int i=0;i<this.adsAttribute.Length;i++)
           {
                this.adsAttribute[i] = new List<Label>();
           }
            
            try
            {
                this.Da = new DataAccess();
                try
                {
                    this.Ds = Da.ExecuteQuery("select * from ad order by adid");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex); 
                }
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    //runtime panel
                    this.adsPicture = new List<PictureBox>();
                    this.adsPanel.Add(new Panel());
                    this.adsPanel.ElementAt(i).Size = new Size(930, 600);
                    this.adsPanel.ElementAt(i).BackColor = Color.FromArgb(190, 255, 255, 255);
                   
                    //load Attributes to feed 
                    for (int j=0,k=0;j<adsAttribute.Length;j++,k+=40)
                    {

                        Console.WriteLine(Ds.Tables[0].Rows[i][j].ToString());
                        this.adsAttribute[i].Add(new Label());
                        this.adsAttribute[i].ElementAt(j).Size = new Size(300, 24);
                        this.adsAttribute[i].ElementAt(j).Location = new Point( 59 , (18+k));
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
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
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
                pnlSearch.Size = new Size(961, 30);

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
                pnlSearch.Size = new Size(961, 156);

            }
        }

        private void ClearFeed()
        {
            for(int i=0;i<this.adsPanel.Count;i++)
            {
                this.adsPanel.ElementAt(i).Dispose();
            }
        }


        private void btnPostAd_Click(object sender, EventArgs e)
        {
            this.ClearFeed();
            string src;

            //PictureBox[] 
            this.pb = new PictureBox[] { pbFlatPicture1, pbFlatPicture2, pbFlatPicture3, pbFlatPicture4 };
            this.tb = new TextBox[] { txtAdTitle, txtRent, txtBlockAndRoadNo, txtApartmentNo, txtContact,txtSquareFeet,txtFloor,txtFacilities };
            this.des= new string[4];

            bool txtNotEmpty = true;
            
            for(int i=0;i<this.tb.Length;i++)
            {
                if(this.tb[i].Text.Equals(""))
                {
                    txtNotEmpty = false;
                    break;
                }
            }

            if (txtNotEmpty == true && this.pictureSelected[0] == true && this.pictureSelected[1] == true && this.pictureSelected[2] == true && this.pictureSelected[3] == true)
            {
                for (int i = 0; i < this.pb.Length; i++)
                {
                    this.des[i] = "./FeedData/img/"+this.txtAdId.Text+"-" + (i + 1) + ".jpg";
                    Console.WriteLine(des[i]);
                }
                //query
                try
                {
                    this.Da = new DataAccess();
                    this.Da.ExecuteUpdateQuery("insert into ad values('"+ this.txtAdId.Text + "', '" + this.txtAdTitle.Text + "' , '" + this.txtRent.Text + "','" + this.cmbLocation.Text + "', '" + this.txtBlockAndRoadNo.Text + "', '" + this.txtApartmentNo.Text + "', '" + this.txtContact.Text + "','" + this.txtSquareFeet.Text + "','" + this.txtFloor.Text + "','" + this.txtFacilities.Text + "',  '"+this.CredentialId+"','"+this.cmbTenantType.Text+ "','" + des[0] + "' , '" + des[1] + "', '" + des[2] + "', '" + des[3] + "' , 'not rented'); ");

                    try
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            src = this.pb[i].ImageLocation;
                            File.Copy(src, des[i]);
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    MessageBox.Show("Ad Posted ad id is " + this.txtAdId.Text);



                }
                catch (Exception sqe)
                {
                    Console.WriteLine("Service Unavailable reason " + sqe);
                }
                try
                {
                    this.Ds= this.Da.ExecuteQuery("select flatcount from landlordinfo where userid = '"+this.CredentialId+"' ");

                    int flatCount = Convert.ToInt32(this.Ds.Tables[0].Rows[0][0].ToString());
                    flatCount++;

                    this.Da.ExecuteUpdateQuery("update landlordinfo set flatcount = '" + flatCount + "' where userid = '"+this.CredentialId+"'  ");

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }

             

            }
            else
            {
                MessageBox.Show("No fields can't be left empty !");
            }

            for (int i = 0; i < this.pb.Length; i++)
            {
                this.pictureSelected[i] = false;
                this.pb[i].Image = RentalHouseManagementSys.Properties.Resources.NoImage;
                
            }

            for(int i=0;i<this.tb.Length;i++)
            {
                this.tb[i].Text = "";
            }
            this.cmbLocation.Text = "";


            this.GetFeedData();
            this.GetAdID();
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";

             if (open.ShowDialog() == DialogResult.OK)
             {
                 this.pbFlatPicture1.ImageLocation = open.FileName.ToString();
             }
            this.pictureSelected[0] = true;
            
           
        }

        private void btnUpload2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.pbFlatPicture2.ImageLocation = open.FileName.ToString();
            }
            this.pictureSelected[1] = true;
        }

        private void btnUpload3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.pbFlatPicture3.ImageLocation = open.FileName.ToString();
            }
            this.pictureSelected[2] = true;
        }

        private void btnUpload4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.pbFlatPicture4.ImageLocation = open.FileName.ToString();
            }
            this.pictureSelected[3] = true;
        }

        private void cbEnableAutoSearch_CheckedChanged(object sender, EventArgs e)
        {
            this.btnSearchById.Enabled = !this.btnSearchById.Enabled;
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.LoginForm.Visible = true;
            this.Dispose();
        }

        private void btnChangePasswordProfile_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this.CredentialId,"landlordinfo");
            changePassword.Visible = true;
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {

        }

        public void ApproveRequestBtn_Click(Object sender, EventArgs e)
        {
           
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery("select * from notification where receiver = '" + this.CredentialId + "' and status = 'pending' order by id");
            Button button = sender as Button;
           
            for(int i=0;i<this.approveRequestBtn.Count;i++)
            {
                if (button==this.approveRequestBtn.ElementAt(i))
                {
                    Console.WriteLine("Notification id no "+this.Ds.Tables[0].Rows[i]["id"].ToString()+ " is to be removed");
                    try
                    {
                        this.DaNotification = new DataAccess();
                        this.DaNotification.ExecuteUpdateQuery("update notification set status = 'approved' where id = '" + this.Ds.Tables[0].Rows[i]["id"].ToString() + "'");
                        this.DaNotification.ExecuteUpdateQuery("delete from notification where adid ='" + this.Ds.Tables[0].Rows[i]["adid"] + "' and status ='pending' ;");
                        this.DaNotification.ExecuteUpdateQuery("update ad set status= 'pending' where adid= '" + this.Ds.Tables[0].Rows[i]["adid"] + "' ");
                        this.ClearNotification();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                }
                
            }
        }
        private void ClearNotification()
        {
            for(int i=0; i<this.notificationPanels.Count;i++)
            {
                this.notificationPanels.ElementAt(i).Dispose();
            }
            this.GetNotificationData();
        }

        public void ViewTenantProfileBtn_Click(Object sender, EventArgs e)
        {
           
            Button button = sender as Button;
            for (int i = 0; i < this.viewTenantProfileBtn.Count; i++)
            {
                if(button==this.approveRequestBtn.ElementAt(i))
                {

                }
            }
        }

        private void GetAdID()
        {
            int numeric;
            string[] adidNumeric;
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery("select * from ad order by adid desc; ");
            if (this.Ds.Tables[0].Rows.Count == 0)
            {
                numeric = 100;
            }
            else
            {
                adidNumeric = this.Ds.Tables[0].Rows[0]["adid"].ToString().Split('-');
                numeric = Convert.ToInt32(adidNumeric[1]);
                numeric++;
            }
            this.txtAdId.Text = "ad-" + numeric.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery("select * from landlordinfo where userid = '"+this.CredentialId+"' ");
            this.lblUserIDProfileOutput.Text = this.Ds.Tables[0].Rows[0]["userid"].ToString();
            this.lblNameProfileOutput.Text = this.Ds.Tables[0].Rows[0]["username"].ToString();
            this.lblGenderProfileOutput.Text = this.Ds.Tables[0].Rows[0]["gender"].ToString();
            this.lblPhoneNumberProfileOutput.Text = this.Ds.Tables[0].Rows[0]["phonenumber"].ToString();
            this.lblDateOfBirthProfileOutput.Text = this.Ds.Tables[0].Rows[0]["dateofbirth"].ToString();
            this.lblFlatsRegisteredOutput.Text = this.Ds.Tables[0].Rows[0]["flatcount"].ToString();
            this.lblBankAccountOutput.Text = this.Ds.Tables[0].Rows[0]["bankaccountid"].ToString();
        }
    }
}
