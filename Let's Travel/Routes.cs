using System;
using System.Collections;
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
    public partial class Routes : Form
    {
        public Routes()
        {
            InitializeComponent();

            string path= @"D:\Study\C#\Project\Data\Buslist";
            string[] filenames = Directory.GetFiles($"{path}");

            foreach(string file in filenames )
            {
                using (StreamReader sr = File.OpenText(file))
                {
                    string s = String.Empty;
                    
                    s += sr.ReadLine();
                    s += "-";
                    s += sr.ReadLine();

                    BuscomboBox.Items.Add( s );
                }
            }
            
            
        }

        private void BuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string from= FromcomboBox.Text;
            string to= TocomboBox.Text;
            string bus= BuscomboBox.Text;
            string departure= DeparturecomboBox.Text;
            string arrival= ArrivalcomboBox.Text;
            string seattype= SeatTypecomboBox.Text;
            int price= Convert.ToInt32(PricetextBox.Text);
            int routeid= Convert.ToInt32(RouteIdtextBox.Text);
            
            string buslist = $@"D:\Study\C#\Project\Data\Routes\{from}-{to}.txt";

            using (StreamWriter writer = new StreamWriter(buslist,true))
            {
                writer.WriteLine($"{routeid}    {bus}    {departure} {arrival} {seattype} {price}");
            }
        }

        private void PricetextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
