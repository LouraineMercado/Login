using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrontD : Form
    {
        public FrontD()
        {
            InitializeComponent();

        }
        private void FrontD_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dashb_Click(object sender, EventArgs e)
        {
            AdminDashb dashboardform = new AdminDashb();
            dashboardform.Show();
            this.Hide();
        }
        private void roomz_Click(object sender, EventArgs e)
        {
            Rooms roomsform = new Rooms();
            roomsform.Show();
            this.Hide();
        }

        private void display_Click(object sender, EventArgs e)
        {
            Receptionist dispform = new Receptionist();
            dispform.Show();
            this.Hide();
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }




        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
