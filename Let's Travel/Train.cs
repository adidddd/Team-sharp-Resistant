using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
            listBox1.Items.Add("Company Name\t\tTrain ID\t\t\tDeparture Time\t\tArrival Time\tPrice");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            busIDCombo.Items.Clear();
            listBox1.Items.Add("Company Name\t\tTrain ID\t\t\tDeparture Time\t\tArrival Time\tPrice");
            string from = FromcomboBox.Text;
            string to = TocomboBox.Text;
            string route = $"{from}TO{to}";

            string trainlist = $@"D:\Study\C#\Project\Data\Trainlist\{route}\Trains.txt";

            string[] buses = File.ReadAllLines(trainlist);

            foreach (string bus in buses)
            {
                string companyName = bus.Split('-')[0];
                string busID = bus.Split('-')[1];
                string deptTime = bus.Split('-')[2];
                string arrivalTime = bus.Split('-')[3];
                int price = Convert.ToInt32(bus.Split('-')[4]);

                listBox1.Items.Add($"{companyName}\t\t\t{busID}\t\t\t{deptTime}\t\t{arrivalTime}\t{price}");
                busIDCombo.Items.Add(busID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (busIDCombo.Text != null)
            {
                GlobalTicket.ID = Convert.ToInt32(busIDCombo.Text);

                string from = FromcomboBox.Text;
                string to = TocomboBox.Text;
                string route = $"{from}TO{to}";

                string trainlist = $@"D:\Study\C#\Project\Data\Trainlist\{route}\Trains.txt";

                string[] buses = File.ReadAllLines(trainlist);

                foreach (string bus in buses)
                {
                    string companyName = bus.Split('-')[0];
                    string busID = bus.Split('-')[1];
                    string deptTime = bus.Split('-')[2];
                    string arrivalTime = bus.Split('-')[3];
                    int price = Convert.ToInt32(bus.Split('-')[4]);

                    if (Convert.ToInt32(busID) == GlobalTicket.ID)
                    {
                        GlobalTicket.name = companyName;
                        GlobalTicket.deptTime = deptTime;
                        GlobalTicket.arrivalTime = arrivalTime;
                        GlobalTicket.price = price;
                        GlobalTicket.from = from;
                        GlobalTicket.to = to;
                    }
                }

            }

            this.Hide();
            new TransportPurchase().Show();
        }
    }
}
