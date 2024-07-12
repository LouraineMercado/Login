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
    public partial class UC_FRONTD : UserControl
    {
        function fn = new function();
        String query;

        public UC_FRONTD()
        {
            InitializeComponent();
            txtRoomType.SelectedIndexChanged += txtRoomType_SelectedIndexChanged;
            txtNumberOfBeds.SelectedIndexChanged += txtNumberOfBeds_SelectedIndexChanged;

            // Subscribe to the CellFormatting event
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void UC_FRONTD_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            LoadData();
        }

        private void LoadData()
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtNumberOfBeds.Text != "" && txtPrice.Text != "")
                {
                    String roomno = txtRoomNo.Text;

                    // Check if the room number already exists
                    query = "select count(*) from rooms where roomNo = '" + roomno + "'";
                    DataSet ds = fn.getData(query);
                    int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                    if (count > 0)
                    {
                        MessageBox.Show("Room number already exists. Please enter a different room number.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        String bed = txtNumberOfBeds.Text;
                        Int64 price = Int64.Parse(txtPrice.Text);
                        String type = txtRoomType.Text;

                        query = "insert into rooms (roomNo, type, bed, price) values ('" + txtRoomNo.Text + "','" + txtRoomType.Text + "','" + txtNumberOfBeds.Text + "','" + txtPrice.Text + "')";
                        fn.setData(query, "Room Added");
                        UC_FRONTD_Load(this, null);
                        clearAll();
                    }
                }
                else
                {
                    MessageBox.Show("Fill all fields first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtNumberOfBeds.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int basePrice = 0;

            if (txtRoomType.Text == "Standard")
            {
                basePrice = 1000;
            }
            else if (txtRoomType.Text == "Deluxe")
            {
                basePrice = 2000;
            }
            else if (txtRoomType.Text == "Suite")
            {
                basePrice = 4000;
            }

            int additionalPrice = 0;

            if (txtNumberOfBeds.Text == "Double")
            {
                additionalPrice = 250;
            }
            else if (txtNumberOfBeds.Text == "Triple")
            {
                additionalPrice = 500;
            }
            else if (txtNumberOfBeds.Text == "Single")
            {
                additionalPrice = 0;
            }

            txtPrice.Text = (basePrice + additionalPrice).ToString();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice_TextChanged(sender, e);
        }

        private void txtNumberOfBeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice_TextChanged(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtRoomNo.Text = row.Cells["roomNo"].Value.ToString();
                txtRoomType.Text = row.Cells["type"].Value.ToString();
                txtNumberOfBeds.Text = row.Cells["bed"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "")
            {
                String roomno = txtRoomNo.Text;
                query = "select booked from rooms where roomNo = '" + roomno + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    String booked = ds.Tables[0].Rows[0]["booked"].ToString();

                    if (booked.ToLower() == "yes")
                    {
                        MessageBox.Show("Room cannot be deleted since it is occupied", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        query = "delete from rooms where roomNo = '" + roomno + "'";
                        fn.setData(query, "Room Deleted");
                        LoadData();
                        clearAll();
                    }
                }
                else
                {
                    MessageBox.Show("Room not found", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter Room No to delete", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtNumberOfBeds.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String bed = txtNumberOfBeds.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                String type = txtRoomType.Text;

                query = "update rooms set type = '" + type + "', bed = '" + bed + "', price = '" + price + "' where roomNo = '" + roomno + "'";
                fn.setData(query, "Room Updated");
                LoadData();
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all fields first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "booked")
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString().ToLower() == "yes")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.SelectionForeColor = Color.Green;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                    else if (e.Value.ToString().ToLower() == "no")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                }
            }
        }
    }
}
