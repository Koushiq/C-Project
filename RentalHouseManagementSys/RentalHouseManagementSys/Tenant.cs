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
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private Login LoginForm { get; set; }
        public Tenant()
        {
            InitializeComponent();
            GetFeedData();
        }
        public Tenant(Login login)
        {
            InitializeComponent();
            this.LoginForm = login;
            GetFeedData();
        }
        public void GetFeedData()
        {
            string[] attributeNames = new string[10] { "AD-ID : ", "Title : ", "Rent : ", "Location : ", "Block/Road :", "Apartment No : ", "Contact : ", "SquareFeet : ", "Floor : ", "Facilities : " };
            List<Panel> adsPanel = new List<Panel>();
            List<Label>[] adsAttribute = new List<Label>[10];


            for (int i = 0; i < adsAttribute.Length; i++)
            {
                adsAttribute[i] = new List<Label>();
            }

            try
            {
                Da = new DataAccess();
                Ds = Da.ExecuteQuery("select * from ad");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    //runtime panel
                    List<PictureBox> adsPicture = new List<PictureBox>();
                    adsPanel.Add(new Panel());
                    adsPanel.ElementAt(i).Size = new Size(930, 600);
                    adsPanel.ElementAt(i).BackColor = Color.FromArgb(190, 255, 255, 255);

                    //load Attributes to feed 
                    for (int j = 0, k = 0; j < adsAttribute.Length; j++, k += 40)
                    {
                        Console.WriteLine(Ds.Tables[0].Rows[i][j].ToString());
                        adsAttribute[i].Add(new Label());
                        adsAttribute[i].ElementAt(j).Size = new Size(300, 24);
                        adsAttribute[i].ElementAt(j).Location = new Point(59, (18 + k));
                        adsAttribute[i].ElementAt(j).BackColor = Color.FromArgb(0, 255, 255, 255);
                        adsAttribute[i].ElementAt(j).Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        adsAttribute[i].ElementAt(j).Text += attributeNames[j] + Ds.Tables[0].Rows[i][j].ToString();
                        adsPanel.ElementAt(i).Controls.Add(adsAttribute[i].ElementAt(j));
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        adsPicture.Add(new PictureBox());
                        adsPicture.ElementAt(j).Size = new Size(200, 200);
                        adsPicture.ElementAt(j).SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        adsPicture.ElementAt(j).ImageLocation = Ds.Tables[0].Rows[i][j + 10].ToString();
                        adsPicture.ElementAt(j).Visible = true;
                        adsPanel.ElementAt(i).Controls.Add(adsPicture.ElementAt(j));
                    }
                    adsPicture.ElementAt(0).Location = new Point(500, 9);
                    adsPicture.ElementAt(1).Location = new Point(720, 9);
                    adsPicture.ElementAt(2).Location = new Point(500, 250);
                    adsPicture.ElementAt(3).Location = new Point(720, 250);

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
                catch(SqlException ex)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SqlException ex)
            {

            }
        }

        private void btnRequestRecharge_Click(object sender, EventArgs e)
        {

        }

    
       

        private void btnChangePasswordProfile_Click(object sender, EventArgs e)
        {

        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.LoginForm.Visible = true;
            this.Dispose();
        }
    }
}
