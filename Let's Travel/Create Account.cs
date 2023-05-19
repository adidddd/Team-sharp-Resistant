using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project
{
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            CheckAccount();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_Login().Show();
        }

        public void CheckAccount()
        {
            int a = 0;
            string Username = UsernametextBox.Text;
            string path = $@"D:\Study\C#\Project\Data\Users\";
            string[] filenames = Directory.GetFiles(path);

            foreach (string file in filenames)
            {
                if (path + Username + ".txt" == file)
                {
                    a = 5;
                    MessageBox.Show("Username Already Exists");
                }
            }

            if(PasswordtextBox.Text != PasswordtextBox2.Text)
            {
                a = 5;
                MessageBox.Show("Passwords doesn't match");
            }
            if(PasswordtextBox.Text == null)
            {
                MessageBox.Show("Create a password");
            }

            if (a == 0)
            {
                string pass = $@"D:\Study\C#\Project\Data\Users\{Username}.txt";
                string info = $@"D:\Study\C#\Project\Data\UserInfo\{Username}.txt";
                string wallet = $@"D:\Study\C#\Project\Data\Wallet\{Username}.txt";

                using (StreamWriter writer = new StreamWriter(pass))
                {
                    writer.WriteLine(PasswordtextBox.Text);
                }

                using (StreamWriter writer = new StreamWriter(info))
                {
                    writer.WriteLine("First Name        :" + FirsttextBox.Text);
                    writer.WriteLine("Last Name         :" + LasttextBox.Text);
                    writer.WriteLine("Date of Birth     :" + dateTimePicker.Text);
                    writer.WriteLine("Sex               :" + sexComboBox.Text);
                    writer.WriteLine("Marital Status    :" + marryComboBox.Text);
                    writer.WriteLine("Nationality       :" + countrycomboBox2.Text);
                    writer.WriteLine("Phone Number      :" + phonetextBox.Text);
                    writer.WriteLine("Email             :" + emailtextBox.Text);
                    writer.WriteLine("Address           :" + addresstextBox.Text);
                    writer.WriteLine("Country Of Birth  :" + countryComboBox.Text);
                    writer.WriteLine("Place Of Birth    :" + placetextBox.Text);
                }

                using (StreamWriter writer = new StreamWriter(wallet))
                {
                    int money = 0;
                    writer.WriteLine(money);
                }

                MessageBox.Show($"Account Successfully created for user {Username}");

                this.Hide();
                new User_Login().Show();
            }
        }
    }
}
