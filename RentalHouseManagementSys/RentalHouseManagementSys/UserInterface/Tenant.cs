﻿using RentalHouseManagementSys.Authentication;
using RentalHouseManagementSys.Entity;
using RentalHouseManagementSys.repository;
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
    public partial class Tenant : MetroFramework.Forms.MetroForm
    {
        private List<Notification> notificationList;
        private NotificationRepository NotificationRepo { get; set; }

        private PaymentRepository paymentRepo { get; set; }
        private AgreementRepository AgreementRepo { get; set; }
        private List<Button> requestForRent;
        private List<Button> viewLandlordProfile;
        private string[] attributeNames = new string[12] { "AD-ID :", "Title : ", "Rent : ", "Location : ", "Block/Road :", "Apartment No : ", "Contact : ", "SquareFeet : ", "Floor : ", "Facilities : ", "Owener ID : ", "Flat available for : " };
        private List<Panel> adsPanel;
        private List<Label>[] adsAttribute = new List<Label>[12];
        private List<PictureBox> adsPicture;
        private string Sql { get; set; }
        //private FilterSearchEntity FilterSearchEn { get; set; }

        private string CredentialId { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataAccess DaNotification { get; set; }
        private DataSet DsNotification { get; set; }
        private Login LoginForm { get; set; }

        private DataAccess DaAgreement { get; set; }
        private DataSet DsAgreement { get; set; }

        private List<Panel> notificationPanels;
        private List<Label> notificationLabels;
        private List<Button> confirmRequestBtn;
        public Tenant()
        {
            InitializeComponent();
           
        }
        public Tenant(Login login,string credentialId)
        {
            InitializeComponent();
            this.LoginForm = login;
            this.CredentialId = credentialId;
            this.GetFeedData("select * from ad where status !='rented' order by adid ");
            this.GetNotification();
            this.PopulateGridViewAgreements();
        }
        private void PopulateGridViewAgreements()
        {
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery("select * from agreement where tenantid = '" + this.CredentialId + "'");
            this.dgvAgreements.AutoGenerateColumns = false;
            this.dgvAgreements.DataSource = this.Ds.Tables[0];

        }

        private void GetNotification()
        {
            this.NotificationRepo = new NotificationRepository(this.CredentialId);
            this.notificationList =this.NotificationRepo.GenerateNotificationQuery("select * from notification where sender = '"+this.CredentialId+"' and status = 'approved' order by id ; ");
            //this.notificationList= this.NotificationRepo.GenerateNotificationQue
            this.notificationPanels = new List<Panel>();
            this.notificationLabels = new List<Label>();
            this.confirmRequestBtn = new List<Button>();

            for (int i=0;i<this.notificationList.Count;i++)
            {
                this.notificationPanels.Add(new Panel());
                this.notificationPanels.ElementAt(i).Size = new Size(958, 55);
                this.notificationPanels.ElementAt(i).BackColor = Color.FromArgb(200, 255, 255, 255);
                this.flpNotification.Controls.Add(this.notificationPanels.ElementAt(i));
                //runtime notification label per panel 
                this.notificationLabels.Add(new Label());
                this.notificationLabels.ElementAt(i).Size = new Size(919, 20);
                this.notificationLabels.ElementAt(i).Location = new Point(9, 20);
                //runtime label styling 
                this.notificationLabels.ElementAt(i).Text = this.notificationList.ElementAt(i).Receiver + " approved your request " + this.notificationList.ElementAt(i).AdId;
                this.notificationLabels.ElementAt(i).ForeColor = Color.FromArgb(0, 0, 0);
                this.notificationLabels.ElementAt(i).Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               

                //runtime notification approve request buttons 
                this.confirmRequestBtn.Add(new Button());
                this.confirmRequestBtn.ElementAt(i).Text = "Confirm Rental Agreement";
                this.confirmRequestBtn.ElementAt(i).Size = new Size(90, 40);
                this.confirmRequestBtn.ElementAt(i).Location = new Point(750, 10);
                this.confirmRequestBtn.ElementAt(i).Click += new EventHandler(ConfirmRequestBtn_Click);

                this.notificationPanels.ElementAt(i).Controls.Add(this.confirmRequestBtn.ElementAt(i));
                this.notificationPanels.ElementAt(i).Controls.Add(this.notificationLabels.ElementAt(i));
            }
        }
        private void ConfirmRequestBtn_Click(object sender,EventArgs e)
        {
            DateTime d = DateTime.Now;
            d = d.AddMonths(1);
            this.AgreementRepo = new AgreementRepository(this.CredentialId);
            this.Da = new DataAccess();
            Button button = sender as Button;
            for (int i = 0; i < this.confirmRequestBtn.Count; i++)
            {
                if (button == this.confirmRequestBtn.ElementAt(i))
                {
                    try
                    {
                        this.Ds = this.Da.ExecuteQuery("select rent from ad where adid = '" + this.notificationList.ElementAt(i).AdId + "' ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                   // this.NotificationRepo.Update("update notification set status = 'confirmed' where adid = '" + this.notificationList.ElementAt(i).AdId + "' ");
                    this.AgreementRepo.Update("insert into agreement values ('" + this.notificationList.ElementAt(i).AdId + "', '"+ this.notificationList.ElementAt(i).Receiver+ "'  ,'" + this.notificationList.ElementAt(i).Sender + "', '"+this.Ds.Tables[0].Rows[0][0].ToString()+"' , '"+d.ToString("yyyy-MM-dd")+"' )  ");
                    try
                    {
                        this.Da.ExecuteUpdateQuery("update ad set status = 'rented' where adid = '"+ this.notificationList.ElementAt(i).AdId+"' ");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    int paymentid=0;
                    string id="P-100";
                    string [] idNumeric;
                    try
                    {

                        this.Ds = this.Da.ExecuteQuery("select paymentid from payment order by paymentid desc");
                        if(this.Ds.Tables[0].Rows.Count==0)
                        {
                            paymentid = 100;
                        }
                        else
                        {
                            id=this.Ds.Tables[0].Rows[0][0].ToString();
                            idNumeric = id.Split('-');
                            paymentid = Convert.ToInt32(idNumeric[1]);
                            paymentid++;
                        }
                        id = "P-" + paymentid.ToString();
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }



                    try
                    {
                        
                        
                      //this.Da.ExecuteUpdateQuery("insert into payment values ('"+id+"', '" +this.notificationList.ElementAt(i).AdId+"' , 'ACC-"+this.notificationList.ElementAt(i).+"' )");
                    }
                    catch(Exception ex)
                    {

                    }
                    try
                    {
                        this.Da.ExecuteUpdateQuery("update tenantinfo set rentedstatus = 'true'  where userid= '" + this.notificationList.ElementAt(i).Sender + " ' ");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    this.NotificationRepo.Update("delete from notification where sender = '" + this.notificationList.ElementAt(i).Sender + "' and status != 'confirmed' ");

                    this.ClearNotification();
                }
            }
        }
        private void ClearNotification()
        {
            for(int i=0;i<this.notificationPanels.Count;i++)
            {
                this.notificationPanels.ElementAt(i).Dispose();
            }
        }

        private void GetFeedData(string sql)
        {
           // this.Sql = sql;
            this.requestForRent = new List<Button>();
            this.viewLandlordProfile = new List<Button>();
            this.adsPanel = new List<Panel>();
            for (int i = 0; i < this.adsAttribute.Length; i++)
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
                    //runtime request button
                    this.requestForRent.Add(new Button());
                    this.requestForRent.ElementAt(i).Text = "Request For Rent";
                    this.requestForRent.ElementAt(i).Size = new Size(150,40);
                    this.requestForRent.ElementAt(i).Location = new Point(498,460);
                    this.requestForRent.ElementAt(i).Click += new EventHandler(RequestForRent_Click);
                    this.adsPanel.ElementAt(i).Controls.Add(this.requestForRent.ElementAt(i));

                    //runtime landlordprofile button
                    this.viewLandlordProfile.Add(new Button());
                    this.viewLandlordProfile.ElementAt(i).Text = "view landlord profile";
                    this.viewLandlordProfile.ElementAt(i).Size = new Size(150, 40);
                    this.viewLandlordProfile.ElementAt(i).Location = new Point(718, 460);
                    this.viewLandlordProfile.ElementAt(i).Click += new EventHandler(ViewLandlordProfile_Click);
                    this.adsPanel.ElementAt(i).Controls.Add(this.viewLandlordProfile.ElementAt(i));

                    //load Attributes to feed 
                    for (int j = 0, k = 0; j < adsAttribute.Length; j++, k += 40)
                    {
                        Console.WriteLine("lala " + Ds.Tables[0].Rows[i][j].ToString());
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
        private void pnlPayment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbEnableFilter_CheckedChanged(object sender, EventArgs e)
        {
            if(!cbEnableFilter.Checked)
            {
                this.lblSelectArea.Visible = false;
                this.lblRentRange.Visible = false;
                this.lblSqareFeet.Visible = false;
                this.lblFlatType.Visible = false;
                this.cmbSelectArea.Visible = false;
                this.txtRentLowerLimit.Visible = false;
                this.txtRentUpperLimit.Visible = false;
                this.txtSquareFeetLowerLimit.Visible = false;
                this.txtSquareFeetUpperLimit.Visible = false;
                this.cmbFlatType.Visible = false;
                pnlSearch.Size = new Size(961, 30);

            }
            else
            {
                this.lblSelectArea.Visible = true;
                this.lblRentRange.Visible = true;
                this.lblSqareFeet.Visible = true;
                this.lblFlatType.Visible = true;
                this.cmbSelectArea.Visible = true;
                this.txtRentLowerLimit.Visible = true;
                this.txtRentUpperLimit.Visible = true;
                this.txtSquareFeetLowerLimit.Visible = true;
                this.txtSquareFeetUpperLimit.Visible = true;
                this.cmbFlatType.Visible = true;
                pnlSearch.Size = new Size(961, 156);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.adsPanel.Count; i++)
            {
                this.adsPanel.ElementAt(i).Dispose();
            }
            if (cbEnableFilter.Checked)
            {
                Console.WriteLine("select * from ad where location = '" + this.cmbSelectArea.Text + "' and rent>= " + this.txtRentLowerLimit.Text + " and rent<= " + this.txtRentUpperLimit.Text + " and squarefeet >= " + this.txtSquareFeetLowerLimit.Text + "  and squarefeet <= " + this.txtSquareFeetUpperLimit.Text + " and flattype = '" + this.cmbFlatType.Text + "';");
                try
                {
                    if (!this.cmbSelectArea.Text.Equals("") && !this.txtRentLowerLimit.Text.Equals("") && !this.txtRentUpperLimit.Text.Equals("") && !this.txtSquareFeetLowerLimit.Text.Equals("") && !this.txtSquareFeetUpperLimit.Text.Equals("") && !this.cmbFlatType.Text.Equals(""))
                    {
                        this.GetFeedData("select * from ad where location = '" + this.cmbSelectArea.Text + "' and rent>= " + this.txtRentLowerLimit.Text + " and rent<= " + this.txtRentUpperLimit.Text + " and squarefeet >= " + this.txtSquareFeetLowerLimit.Text + "  and squarefeet <= " + this.txtSquareFeetUpperLimit.Text + " and flattype = '" + this.cmbFlatType.Text + "'; ");
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

        private void btnRequestRecharge_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePasswordProfile_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this.CredentialId,"tenantinfo");
            changePassword.Visible=true;
           

        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.LoginForm.Visible = true;
            this.Dispose();
        }
        public void RequestForRent_Click(Object sender, EventArgs e)
        {
            Button button = sender as Button;

            for(int i=0;i<this.requestForRent.Count;i++)
            {
                string adAttributeIdText;
                string [] adid;

                string autoGeneratedNotificationId="Delete";
                string[] notificationIdNumeric;
                int numeric;
                if (button==this.requestForRent.ElementAt(i))
                {
                    this.requestForRent.ElementAt(i).Enabled = false;
                    adAttributeIdText = this.adsAttribute[i].ElementAt(0).Text;
                    Console.WriteLine("IDDDD ISSSS ZZZ" + adAttributeIdText);
                    adid = adAttributeIdText.Split(':');

                    try
                    {
                       this.Da = new DataAccess();
                       this.Ds = this.Da.ExecuteQuery("select owenerid from ad where adid = '" + adid[1] + "' ");
                       
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    try
                    {
                        this.DaNotification = new DataAccess();
                        this.DsNotification = this.DaNotification.ExecuteQuery("select * from notification order by id desc");
                        if(this.DsNotification.Tables[0].Rows.Count==0)
                        {
                            numeric = 100;
                        }
                        else
                        {
                            notificationIdNumeric=this.DsNotification.Tables[0].Rows[0]["id"].ToString().Split('-');
                            numeric = Convert.ToInt32(notificationIdNumeric[1]);
                            numeric++;
                        }
                        autoGeneratedNotificationId = "N-" + numeric.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }


                    try
                    {
                        Console.WriteLine("Notification id " + this.Ds.Tables[0].Rows[0][0].ToString());
                        this.Da = new DataAccess();
                        this.Da.ExecuteUpdateQuery("insert into notification values ('" + autoGeneratedNotificationId + "','" + this.CredentialId + "','" + this.Ds.Tables[0].Rows[0][0].ToString() + "', '" + adid[1] + "', 'pending') ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                }
                
            }
         
        }
        public void ViewLandlordProfile_Click(Object sender, EventArgs e)
        {
           
            Button button = sender as Button;
            for (int i = 0; i < this.viewLandlordProfile.Count; i++)
            {
                if (button == this.viewLandlordProfile.ElementAt(i))
                {
                    
                  
                   
                }
            }
           
        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery(" select * from tenantinfo where userid = '"+this.CredentialId+"'");
            this.lblUserIDProfileOutput.Text = this.Ds.Tables[0].Rows[0]["userid"].ToString();
            this.lblNameProfileOutput.Text = this.Ds.Tables[0].Rows[0]["username"].ToString();
            this.lblGenderProfileOutput.Text = this.Ds.Tables[0].Rows[0]["gender"].ToString();
            this.lblPhoneNumberProfileOutput.Text = this.Ds.Tables[0].Rows[0]["phonenumber"].ToString();
            this.lblDateOfBirthProfileOutput.Text = this.Ds.Tables[0].Rows[0]["dateofbirth"].ToString();
            this.lblRentedStatusOutput.Text = this.Ds.Tables[0].Rows[0]["rentedstatus"].ToString();
            this.lblBankAccountOutput.Text = this.Ds.Tables[0].Rows[0]["bankaccountid"].ToString();
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            this.Da = new DataAccess();
            try
            {
                this.Da.ExecuteUpdateQuery("delete from tenantinfo where ");
            }
            catch
            {

            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateUser updatUser = new UpdateUser(this.CredentialId, "tenantinfo");
            updatUser.Visible = true;
        }
    }
}
