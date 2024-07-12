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

namespace Login.User_Controls
{
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\merca\\Downloads\\OOPfinals-FINALREALTALAGA\\OOPfinals-FINALREALTALAGA\\Login\\bin\\Debug\\oopDB.db;Version=3;");
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.pax, customer.checkin, customer.hours, customer.checkout, rooms.roomNo, rooms.type, rooms.bed from customer inner join rooms on customer.roomid = rooms.roomid";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            displayCheckIn();
            displayCheckout();
            displayGuest();
            displayRev();


        }

        public void displayCheckIn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string selectData = "SELECT COUNT (*) FROM customer WHERE chekout = 'NO'";
                    using (SQLiteCommand cmd = new SQLiteCommand(selectData, conn))
                    {
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            txtChkin.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void displayCheckout()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string selectData = "SELECT COUNT (*) FROM customer WHERE chekout = 'YES'";
                    using (SQLiteCommand cmd = new SQLiteCommand(selectData, conn))
                    {
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            txtChkout.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                }
            }

        }

        public void displayGuest()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string selectData = "SELECT SUM(pax) FROM customer";
                    using (SQLiteCommand cmd = new SQLiteCommand(selectData, conn))
                    {
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            int sum = Convert.ToInt32(reader[0]);
                            txtGuest.Text = sum.ToString();
                        }
                        else
                        {
                            txtGuest.Text = "0";
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void displayRev()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string selectData = "SELECT price, hours FROM customer INNER JOIN rooms ON rooms.roomid = customer.roomid WHERE customer.chekout = 'NO' OR customer.chekout = 'YES'";
                    using (SQLiteCommand cmd = new SQLiteCommand(selectData, conn))
                    {
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        int totalRevenue = 0;

                        while (reader.Read())
                        {
                            int price = reader.IsDBNull(0) ? 0 : Convert.ToInt32(reader["price"]);
                            int hours = reader.IsDBNull(1) ? 0 : Convert.ToInt32(reader["hours"]);

                            switch (hours)
                            {
                                case 3:
                                    price += 300;
                                    break;
                                case 6:
                                    price += 580;
                                    break;
                                case 9:
                                    price += 760;
                                    break;
                                case 12:
                                    price += 930;
                                    break;
                                case 16:
                                    price += 1020;
                                    break;
                                case 20:
                                    price += 1100;
                                    break;
                                case 24:
                                    price += 1170;
                                    break;
                            }

                            totalRevenue += price;
                        }

                        txtRev.Text = totalRevenue.ToString();
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }



 


    }
}
