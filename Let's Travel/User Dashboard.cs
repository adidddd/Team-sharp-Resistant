using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_App;

namespace Project
{
    public partial class User_Dashboard : Form
    {

        string username = GlobalUser.username;
        double wallet = GlobalUser.wallet;
        public User_Dashboard()
        {
            InitializeComponent();
            label2.Text= "Welcome, " + username;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text= "Balance: "+ GlobalUser.wallet.ToString();
            
        }

        private void BookHotelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_Hotel().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BusTicketbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bus().Show();
        }

        private void TrainTicketbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Train().Show();
        }

        private void AddMoneybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Add_Money().Show();
        }
    }
}
