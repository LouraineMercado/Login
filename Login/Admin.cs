using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Admin : Form
    {
        function fn = new function();
        String query;
        public Admin()
        {
            InitializeComponent();
        }
        SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\merca\\Downloads\\OOPfinals-FINALREALTALAGA\\OOPfinals-FINALREALTALAGA\\Login\\bin\\Debug\\oopDB.db;Version=3;");

        private void Admin_Load(object sender, EventArgs e)
        {
            query = "select * from admin";
            DataSet ds = fn.getData(query);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                string query = "select * from admin where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                    AdminDashb adminDashb = new AdminDashb();
                    adminDashb.Show();
                    this.Hide();
                }
                else
                {
                    labelError.Visible = true;
                    txtPassword.Clear();
                }
            }
            catch
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            FinalSignIn finalSignIn = new FinalSignIn();
            finalSignIn.Show();
            this.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}
