using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_App;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Project
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();

            string username = GlobalUser.username;
            string path = $@"D:\Study\C#\Project\Data\Temp.txt";
            string path2 = $@"D:\Study\C#\Project\Data\UserInfo\{username}.txt";

            richTextBox1.Text += "Customer Information: \n\n";

            if (File.Exists(path2))
            {
                string[] infos = File.ReadAllLines(path2);

                foreach (string info in infos)
                {
                    richTextBox1.Text += info+"\n";
                }
            }

            richTextBox1.Text += "Purchase Information: \n\n";
            if (File.Exists(path))
            {
                string[] infos = File.ReadAllLines(path);

                foreach (string info in infos)
                {
                    richTextBox1.Text += info+"\n";
                }
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string username = GlobalUser.username;
            string path = $@"D:\Study\C#\Project\Data\Temp.txt";
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
            if (File.Exists(path))
            {
                string[] infos = File.ReadAllLines(path);

                foreach (string info in infos)
                {
                    richTextBox1.Text += info + "\n";
                }
            }
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalUser.wallet < GlobalUser.price)
            {
                MessageBox.Show("Not Enough Balance!!");

                this.Hide();
                new User_Dashboard().Show();    
            }

            else
            {
                string path = $@"D:\Study\C#\Project\Data\Wallet\{GlobalUser.username}.txt";

                int main = GlobalUser.wallet -= GlobalUser.price;

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

    }
}
