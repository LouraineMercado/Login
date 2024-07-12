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
    public partial class FinalSignIn : Form
    {
        public FinalSignIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin signin = new Admin();
            signin.Show();
            this.Hide();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            Receptionist signin = new Receptionist();
            signin.Show();
            this.Hide();
        }
    }
}
