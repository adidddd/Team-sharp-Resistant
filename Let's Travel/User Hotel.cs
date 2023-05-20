using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_App;

namespace Project
{
    public partial class User_Hotel : Form
    {
        public User_Hotel()
        {
            InitializeComponent();
        }

        private void HotelNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowRoombutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RoomCodecomboBox.Items.Clear();
            listBox1.Items.Add("Room Code\t\tRoom Type\t\tPrice");

            string Destination = DestinationcomboBox.Text;
            string Name = HotelNamecomboBox.Text;

            string codes = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Codes.txt";
            string types = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\types.txt";
            string prices = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\prices.txt";

            if (File.Exists(codes) && (File.Exists(types)) && (File.Exists(prices)))
            {
                string[] code = File.ReadAllLines(codes);
                string[] type = File.ReadAllLines(types);
                string[] price = File.ReadAllLines(prices);

                for (int i = 0; i < code.Length; i++)
                {
                    listBox1.Items.Add($"{code[i]}\t\t{type[i]}\t\t{price[i]}");
                    RoomCodecomboBox.Items.Add(code[i]);
                }
            }
        }

        private void ShowHotelbutton_Click(object sender, EventArgs e)
        {
            HotelNamecomboBox.Items.Clear();
            listBox1.Items.Clear();
            
            string Destination = DestinationcomboBox.Text;

            string path = $@"D:\Study\C#\Project\Data\Hotel\{Destination}";
            string[] Hotellist = Directory.GetDirectories(path);

            foreach (string hotel in Hotellist)
            {
                string dname= new DirectoryInfo(hotel).Name;
                HotelNamecomboBox.Items.Add(dname);

                string hotelinfo = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{dname}\Info.txt";

                if (File.Exists(hotelinfo))
                {
                    string[] infos = File.ReadAllLines(hotelinfo);

                    for (int i = 0; i < infos.Length; i++)
                    {
                        listBox1.Items.Add($"{infos[i]}");
                    }
                }
            }
        }

        private void Paymentbutton_Click(object sender, EventArgs e)
        {
            string SelectedCode= RoomCodecomboBox.Text;
            string Destination = DestinationcomboBox.Text;
            string Name = HotelNamecomboBox.Text;

            

            string path = $@"D:\Study\C#\Project\Data\Temp.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hotel Booking\n");

                string hotelinfo = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Info.txt";
                string[] infos2 = File.ReadAllLines(hotelinfo);
                
                writer.WriteLine(infos2[0]);
                writer.WriteLine(infos2[1]);
                writer.WriteLine(infos2[2]+"\n");

                string codes = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Codes.txt";
                string types = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\types.txt";
                string prices = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\prices.txt";

                if (File.Exists(codes) && (File.Exists(types)) && (File.Exists(prices)))
                {
                    string[] Lcode = File.ReadAllLines(codes);
                    string[] type = File.ReadAllLines(types);
                    string[] price = File.ReadAllLines(prices);

                    for (int i = 0; i < Lcode.Length; i++)
                    {
                        if (SelectedCode == Lcode[i])
                        {
                            GlobalUser.price = Convert.ToInt32(price[i]);

                            writer.WriteLine("Room Details:");
                            writer.WriteLine("Room Type: " + type[i]);
                            writer.WriteLine("Price: " + price[i] +"\n");
                        }
                    }
                }
            }


            this.Hide();
            new Purchase().Show();
        }

        private void RoomCodecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Hotel_Load(object sender, EventArgs e)
        {

        }
    }
}
