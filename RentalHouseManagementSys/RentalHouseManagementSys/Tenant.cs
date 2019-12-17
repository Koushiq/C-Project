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
        public Tenant()
        {
            InitializeComponent();
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
    }
}
