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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        private Login LoginForm { get; set; }
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(Login login)
        {
            InitializeComponent();
            this.LoginForm = login;
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
    }
}
