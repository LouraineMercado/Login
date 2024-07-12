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
    public partial class UC_FrontCust : UserControl
    {
        function fn = new function();
        String query;
        public UC_FrontCust()
        {
            InitializeComponent();
            txtName.TextChanged += UpdateBookingDetails;
            txtRoomNo.SelectedIndexChanged += UpdateBookingDetails;
            txtRoomType.SelectedIndexChanged += UpdateBookingDetails;
            txtCheckIn.ValueChanged += UpdateBookingDetails;
            txtPrice.TextChanged += UpdateBookingDetails;

            this.Leave += UC_FrontCust_Leave;
            txtCheckIn.Value = DateTime.Now;
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SQLiteDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and type = '" + txtRoomType.Text + "' and booked = 'NO'";
            setComboBox(query, txtRoomNo);


        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo = '" + txtRoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtPrice.Text = ds.Tables[0].Rows[0]["price"].ToString();
                rid = int.Parse(ds.Tables[0].Rows[0]["roomid"].ToString());
            }
            else
            {
                txtPrice.Clear();
                rid = 0;
            }
        }

        private void btnAllotRoom_Click(object sender, EventArgs e)
        {
            // Format the current date and time to "yyyy-MM-dd HH:mm:ss"
            string formattedCheckInDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Set the formatted date to the txtCheckIn text box
            txtCheckIn.Text = formattedCheckInDate;

            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtCheckIn.Text != "" && txtPax.Text != "" && txtBed.Text != "" && txtRoomType.Text != "" && txtRoomNo.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String gender = txtGender.Text;
                String checkin = formattedCheckInDate; // Use the formatted date
                String pax = txtPax.Text;

                // Insert customer data with formatted check-in date
                query = $"insert into customer (cname, gender, contact, pax, checkin, roomid) values ('{name}', '{gender}', {contact}, '{pax}', '{checkin}', {rid})";
                fn.setData(query, $"Room No {txtRoomNo.Text} allocation successful");

                // Update room booking status
                query = $"update rooms set booked = 'YES' where roomNo = '{txtRoomNo.Text}'";
                fn.setData(query, $"Room No {txtRoomNo.Text} status updated to booked");

                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void clearAll()
        {
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtContact.Clear();
            txtCheckIn.ResetText();
            txtPax.Clear();
            txtBed.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UpdateBookingDetails(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblRoom.Text = txtRoomNo.Text;
            lblType.Text = txtRoomType.Text;
            lblCheckin.Text = txtCheckIn.Text; // This will reflect the formatted date
            lblPrice.Text = txtPrice.Text;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintInvoice printInvoice = new PrintInvoice();
            printInvoice.Cname = txtName.Text;
            printInvoice.Room = txtRoomNo.Text;
            printInvoice.Type = txtRoomType.Text;
            printInvoice.Bed = txtBed.Text;
            printInvoice.Checkin = txtCheckIn.Text;
            printInvoice.Price = txtPrice.Text;

            printInvoice.ShowDialog();

        }

        private void UC_FrontCust_Leave(object sender, EventArgs e)
        {
            // Format the current date and time to "yyyy-MM-dd HH:mm:ss"
            string formattedCheckInDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Update check-in date to formatted current date and time
            txtCheckIn.Text = formattedCheckInDate;

            // Update booking details with the new check-in date
            UpdateBookingDetails(sender, e);
        }
    }
}

