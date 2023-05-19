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
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();

            listBox1.Items.Add("BusID\t\tCompany Name\t\tDeparture Time\t\tArrival Time");
        }

        private void BusForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string CompanyName= CompanyNametextBox.Text;
            int BusId= Convert.ToInt32(BusIdtextBox.Text);
            string from = FromcomboBox.Text;
            string to = TocomboBox.Text;
            string folderName = $"{from}TO{to}";
            string deptTime = deptTimeBox.Text;
            string arrivalTime = arrivalTimeBox.Text;
            int price = Convert.ToInt32(PricetextBox.Text);

            listBox1.Items.Add($"{BusId}\t\t{CompanyName}\t\t\t{deptTime}\t\t{arrivalTime}\t\t{price}");

            string route = $@"D:\Study\C#\Project\Data\Buslist\{folderName}\Buses.txt";

            using (StreamWriter writer = File.AppendText(route))
            {
                writer.WriteLine($"{CompanyName}-{BusId}-{deptTime}-{arrivalTime}-{price}");
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

            string buslist = $@"D:\Study\C#\Project\Data\Buslist";

            Directory.CreateDirectory(Path.Combine(buslist, folderName));

        }
    }
}
