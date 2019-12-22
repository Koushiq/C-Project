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
    public partial class Form1 : Form
    {
        private List<Button> button = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            {
                button.Add(new Button());
                button.ElementAt(i).Click += new EventHandler(button_click);
                button.ElementAt(i).Text = "Click ME ";
                flowLayoutPanel1.Controls.Add(button.ElementAt(i));
            }
            
           
        }

        private void button_click(Object sender,EventArgs e)
        {
            Button button = sender as Button;
            for(int i=0;i<this.button.Count;i++)
            {
                if(button==this.button.ElementAt(i))
                {
                    Console.WriteLine(i + "was clicked !");
                }
            }
            
            
        }
    }
}
