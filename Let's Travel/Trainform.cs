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

namespace Project
{
    public partial class Trainform : Form
    {
        public Trainform()
        {
            InitializeComponent();
            listBox1.Items.Add("Train ID\t\tCompany Name\t\tDeparture Time\t\tArrival Time");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string CompanyName = CompanyNametextBox.Text;
            int TrainId = Convert.ToInt32(BusIdtextBox.Text);
            string from = FromcomboBox.Text;
            string to = TocomboBox.Text;
            string folderName = $"{from}TO{to}";
            string deptTime = deptTimeBox.Text;
            string arrivalTime = arrivalTimeBox.Text;
            int price = Convert.ToInt32(PricetextBox.Text);

            listBox1.Items.Add($"{TrainId}\t\t{CompanyName}\t\t\t{deptTime}\t\t{arrivalTime}\t\t{price}");

            string route = $@"D:\Study\C#\Project\Data\Trainlist\{folderName}\Trains.txt";

            using (StreamWriter writer = File.AppendText(route))
            {
                writer.WriteLine($"{CompanyName}-{TrainId}-{deptTime}-{arrivalTime}-{price}");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void departurecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string from = FromcomboBox.Text;
            string to = TocomboBox.Text;
            string folderName = $"{from}TO{to}";

            string buslist = $@"D:\Study\C#\Project\Data\Trainlist";

            Directory.CreateDirectory(Path.Combine(buslist, folderName));

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string from = FromcomboBox.Text;
            string to = TocomboBox.Text;
            string folderName = $"{from}TO{to}";

            string buslist = $@"D:\Study\C#\Project\Data\Trainlist";

            Directory.CreateDirectory(Path.Combine(buslist, folderName));
        }

        private void Trainform_Load(object sender, EventArgs e)
        {

        }
    }
}
