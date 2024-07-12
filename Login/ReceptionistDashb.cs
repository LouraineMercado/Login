using Login.User_Controls;
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
    public partial class ReceptionistDashb : Form

    {
        public SQLiteConnection sqlite_conn;
        public ReceptionistDashb()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeUserControls();
        }

        private void InitializeDatabase()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=C:\\Users\\merca\\Downloads\\OOPfinals-FINALREALTALAGA\\OOPfinals-FINALREALTALAGA\\Login\\bin\\Debug\\oopDB.db; Version=3; New=True; Compress=True;");
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeUserControls()
        {
        }
        private void ReceptionistDashb_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void CloseDatabase()
        {
            if (sqlite_conn != null)
            {
                sqlite_conn.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseDatabase();
        }
        private void Logout()
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Close the current form and show the login form.
                this.Close();
                FinalSignIn finalSignIn = new FinalSignIn();
                finalSignIn.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper();
        }

        private void frontd_Click(object sender, EventArgs e)
        {
            uC_Customer1.BringToFront();
            uC_Customer1.Visible = true;
        }

        private void display_Click(object sender, EventArgs e)
        {
            uC_ReceptRooms1.BringToFront();
            uC_ReceptRooms1.Visible = true;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            uC_Checkout1.BringToFront();
            uC_Checkout1.Visible = true;
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRom_Click(object sender, EventArgs e)
        {
            uC_RecRooms1.BringToFront();
            uC_RecRooms1.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
