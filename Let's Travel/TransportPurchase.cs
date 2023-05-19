using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Project
{
    public partial class TransportPurchase : Form
    {
        public TransportPurchase()
        {
            InitializeComponent();

            string username = GlobalUser.username;
            string path2 = $@"D:\Study\C#\Project\Data\UserInfo\{username}.txt";

            richTextBox1.Text += "Customer Information: \n\n";

            if (File.Exists(path2))
            {
                string[] infos = File.ReadAllLines(path2);

                foreach (string info in infos)
                {
                    richTextBox1.Text += info + "\n";
                }
            }

            richTextBox1.Text += "Purchase Information: \n\n";

            richTextBox1.Text += "Company Name: "+GlobalTicket.name + "\n";
            richTextBox1.Text += "From: "+GlobalTicket.from + "\n";
            richTextBox1.Text += "To:" +GlobalTicket.to + "\n";
            richTextBox1.Text += "Departure Time: "+GlobalTicket.deptTime + "\n";
            richTextBox1.Text += "Arrival Time"+GlobalTicket.arrivalTime + "\n";
            richTextBox1.Text += "Price"+GlobalTicket.price + "\n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalUser.wallet < GlobalTicket.price)
            {
                MessageBox.Show("Not Enough Balance!!");

                this.Hide();
                new User_Dashboard().Show();
            }

            else
            {
                string path = $@"D:\Study\C#\Project\Data\Wallet\{GlobalUser.username}.txt";

                int main = GlobalUser.wallet -= GlobalTicket.price;

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(Convert.ToString(main));
                }

                using (SaveFileDialog print = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (print.ShowDialog() == DialogResult.OK)
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(print.FileName, FileMode.Create));
                            doc.Open();
                            doc.Add(new iTextSharp.text.Paragraph(richTextBox1.Text));

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }

                MessageBox.Show("Purchase Successful!!");

                this.Hide();
                new User_Dashboard().Show();
            }
    }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
