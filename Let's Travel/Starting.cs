using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Login().Show();
        }

        private void Userbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_Login().Show();
        }
    }
}
