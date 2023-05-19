using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_App;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Destination = DestinationcomboBox.Text;
            string Category = CategorycomboBox.Text;
            string Name = HnametextBox.Text;
            string Address = HaddresstextBox.Text;

            string path = $@"D:\Study\C#\Project\Data\Hotel\{Destination}";
            Directory.CreateDirectory(Path.Combine(path, Name));

            string hotelinfo = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Info.txt";
            string codes = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Codes.txt";
            string types = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\types.txt";
            string prices = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\prices.txt";

            using (StreamWriter writer = new StreamWriter(hotelinfo))
            {
                writer.WriteLine("Hotel Name: " + Name);
                writer.WriteLine("Address: " + Address);
                writer.WriteLine("Category: " + Category);
            }
            using (StreamWriter writer = new StreamWriter(codes)){}
            using (StreamWriter writer = new StreamWriter(types)){}
            using (StreamWriter writer = new StreamWriter(prices)){}
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            string Destination = DestinationcomboBox.Text;
            string Name = HnametextBox.Text;

            string codes = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Codes.txt";
            string types = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\types.txt";
            string prices = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\prices.txt";

            using (StreamWriter writer = File.AppendText(codes))
            {
                writer.WriteLine(RcodetextBox.Text);
            }
            using (StreamWriter writer = File.AppendText(types))
            {
                writer.WriteLine(RtypetextBox.Text);
            }
            using (StreamWriter writer = File.AppendText(prices))
            {
                writer.WriteLine(RpricetextBox.Text);
            }

            listBox1.Items.Add(RcodetextBox.Text + "\t\t\t" + RtypetextBox.Text + "\t\t\t" + RpricetextBox.Text);
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Room Code\t\tRoom Type\t\tPrice");

            string Destination = DestinationcomboBox.Text;
            string Name = HnametextBox.Text;

            string codes = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Codes.txt";
            string types = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\types.txt";
            string prices = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\prices.txt";

            if (File.Exists(codes) && (File.Exists(types)) && (File.Exists(prices)))
            {
                string[] code = File.ReadAllLines(codes);
                string[] type = File.ReadAllLines(types);
                string[] price = File.ReadAllLines(prices);

                for(int i=0; i<code.Length;i++)
                {
                    listBox1.Items.Add($"{code[i]}\t\t{type[i]}\t\t{price[i]}");
                }
            }
            else
            {
                MessageBox.Show("Hotel does not exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Destination = DestinationcomboBox.Text;
            string Name = HnametextBox.Text;

            string hotelinfo = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Info.txt";
            string codes = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\Codes.txt";
            string types = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\types.txt";
            string prices = $@"D:\Study\C#\Project\Data\Hotel\{Destination}\{Name}\prices.txt";

            File.Delete(hotelinfo);
            File.Delete(codes);
            File.Delete(types);
            File.Delete(prices);

            string path = $@"D:\Study\C#\Project\Data\Hotel\{Destination}";
            Directory.Delete(Path.Combine(path, Name));
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
           
        }
    }

    public class Hotel
    {
        string Destination;
        string Category;
        string Name;

        public Hotel(string destination, string category, string name)
        {
            Destination = destination;
            Category = category;
            Name = name;
        }
    }
}
