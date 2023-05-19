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
    public partial class Add_Money : Form
    {
        public Add_Money()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(AmountTextBox.Text);
            string code = CodeTextBox.Text;
            string username = GlobalUser.username;

            string wallet = $@"C:\Study\C#\Project\Data\Wallet\{username}.txt";

            string path = $@"D:\Study\C#\Project\Data\Money_Code\{amount}.txt";

            if (File.Exists(path))
            {
                string[] codes = File.ReadAllLines(path);

                foreach (string ccode in codes)
                {
                    if (ccode == code)
                    {
                        int money = Convert.ToInt32(File.ReadAllText(wallet));
                        money += amount;

                        using (StreamWriter writer = new StreamWriter(wallet))
                        {
                            writer.WriteLine(money);
                        }
                    }
                }
            }
        }
    }
}
