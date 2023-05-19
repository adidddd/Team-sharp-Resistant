using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Travel_App;
using System.IO;

namespace Project
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }

        public void checkUser(string user)
        {
            string username = $@"D:\Study\C#\Project\Data\Users\{user}.txt";

            if (File.Exists(username))
            {
                string password = File.ReadAllText(username);

                if (passTextBox.Text == password)
                {
                    GlobalUser.username = user;
                    this.Hide();
                    new User_Dashboard().Show();
                    string path = $@"D:\Study\C#\Project\Data\Wallet\{user}.txt";

                    int money = Convert.ToInt32(File.ReadAllText(path));
                    GlobalUser.wallet = money;
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Password");

                }
            }

            else
            {
                MessageBox.Show("Account does not exist");
            }
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            checkUser(userTextBox.Text);
        }

        private void User_Login_Load(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passTextBox.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Create_Account().Show();
        }
    }
}
