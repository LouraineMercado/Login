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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }

        private void dashb2_Click(object sender, EventArgs e)
        {
            AdminDashb dashboardform = new AdminDashb();
            dashboardform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frontd1_Click(object sender, EventArgs e)
        {
            FrontD frontDform = new FrontD();
            frontDform.Show();
            this.Hide();
        }
    }
}
