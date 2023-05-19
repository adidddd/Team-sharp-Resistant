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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BusForm().Show();
        }

        private void TrainTicketbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Trainform().Show();
        }
    }
}
