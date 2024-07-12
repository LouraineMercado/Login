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
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;
        Dictionary<int, int> additionalCharges = new Dictionary<int, int>()
        {
            { 3, 300 },
            { 6, 580 },
            { 9, 760 },
            { 12, 930 },
            { 16, 1020 },
            { 20, 1100 },
            { 24, 1170 }
        };
        private int basePrice;

        public UC_Customer()
        {
            InitializeComponent();
            txtName.TextChanged += UpdateBookingDetails;
            txtRoomNo.SelectedIndexChanged += UpdateBookingDetails;
            txtRoomType.SelectedIndexChanged += UpdateBookingDetails;
            txtCheckIn.ValueChanged += UpdateBookingDetails;
            txtPrice.TextChanged += UpdateBookingDetails;
            txtHrs.SelectedIndexChanged += UpdatePriceBasedOnHours;

            txtName.TextChanged += ValidateInputs;
            txtGender.TextChanged += ValidateInputs;
            txtContact.TextChanged += ValidateInputs;
            txtCheckIn.ValueChanged += ValidateInputs;
            txtHrs.SelectedIndexChanged += ValidateInputs;
            txtPax.TextChanged += ValidateInputs;
            txtBed.SelectedIndexChanged += ValidateInputs;
            txtRoomType.SelectedIndexChanged += ValidateInputs;
            txtRoomNo.SelectedIndexChanged += ValidateInputs;
            txtPrice.TextChanged += ValidateInputs;

            this.Leave += UC_Customer_Leave;
            txtCheckIn.Value = DateTime.Now;
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            btnPrint.Enabled = !string.IsNullOrEmpty(txtName.Text) &&
                               !string.IsNullOrEmpty(txtGender.Text) &&
                               !string.IsNullOrEmpty(txtContact.Text) &&
                               txtCheckIn.Value != null &&
                               !string.IsNullOrEmpty(txtHrs.Text) &&
                               !string.IsNullOrEmpty(txtPax.Text) &&
                               !string.IsNullOrEmpty(txtBed.Text) &&
                               !string.IsNullOrEmpty(txtRoomType.Text) &&
                               !string.IsNullOrEmpty(txtRoomNo.Text) &&
                               !string.IsNullOrEmpty(txtPrice.Text);
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
                basePrice = int.Parse(ds.Tables[0].Rows[0]["price"].ToString());
                txtPrice.Text = basePrice.ToString();
                rid = int.Parse(ds.Tables[0].Rows[0]["roomid"].ToString());
            }
            else
            {
                txtPrice.Clear();
                rid = 0;
            }
        }

        private void UpdatePriceBasedOnHours(object sender, EventArgs e)
        {
            if (txtHrs.SelectedIndex != -1 && additionalCharges.ContainsKey(int.Parse(txtHrs.Text)))
            {
                int hours = int.Parse(txtHrs.Text);
                int additionalPrice = additionalCharges[hours];
                txtPrice.Text = (basePrice + additionalPrice).ToString();
                UpdateBookingDetails(sender, e);
            }
        }

        private void btnAllotRoom_Click(object sender, EventArgs e)
        {
            // Format the current date and time to "yyyy-MM-dd HH:mm:ss"
            string formattedCheckInDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Set the formatted date to the txtCheckIn text box
            txtCheckIn.Text = formattedCheckInDate;

            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtCheckIn.Text != "" && txtHrs.Text != "" && txtPax.Text != "" && txtBed.Text != "" && txtRoomType.Text != "" && txtRoomNo.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String gender = txtGender.Text;
                String checkin = formattedCheckInDate; // Use the formatted date
                Int64 hrs = Int64.Parse(txtHrs.Text);
                String pax = txtPax.Text;

                // Insert customer data with formatted check-in date
                query = $"insert into customer (cname, gender, contact, pax, checkin, hours, roomid) values ('{name}', '{gender}', {contact}, '{pax}', '{checkin}', '{hrs}', {rid})";
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
            txtHrs.SelectedIndex = -1;
            ValidateInputs(null, null); // Ensure button state is updated
        }

        private void UC_Customer_Leave(object sender, EventArgs e)
        {
            // Format the current date and time to "yyyy-MM-dd HH:mm:ss"
            string formattedCheckInDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Update check-in date to formatted current date and time
            txtCheckIn.Text = formattedCheckInDate;

            // Update booking details with the new check-in date
            UpdateBookingDetails(sender, e);
        }

        private void UpdateBookingDetails(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblRoom.Text = txtRoomNo.Text;
            lblType.Text = txtRoomType.Text;
            lblCheckin.Text = txtCheckIn.Text;
            lblOras.Text = txtHrs.Text;
            lblTao.Text = txtPax.Text;
            lblPrice.Text = txtPrice.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintInvoice printInvoice = new PrintInvoice();
            printInvoice.Cname = txtName.Text;
            printInvoice.Room = txtRoomNo.Text;
            printInvoice.Hours = txtHrs.Text;
            printInvoice.Pax = txtPax.Text;
            printInvoice.Type = txtRoomType.Text;
            printInvoice.Bed = txtBed.Text;
            printInvoice.Checkin = txtCheckIn.Text;
            printInvoice.Price = txtPrice.Text;

            printInvoice.ShowDialog();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Intentionally left empty
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {

        }




        private void txtPax_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPax.Text))
            {
                int pax;
                if (int.TryParse(txtPax.Text, out pax))
                {
                    if (txtBed.Text == "Single" && pax >= 4)
                    {
                        MessageBox.Show("For Single bed, number of Pax should be less than 4", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPax.Clear();
                    }
                    else if (txtBed.Text == "Double" && pax >= 6)
                    {
                        MessageBox.Show("For Double bed, number of Pax should be less than 6", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPax.Clear();
                    }
                    else if (txtBed.Text == "Triple" && pax >= 8)
                    {
                        MessageBox.Show("For Triple bed, number of Pax should be less than 8", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPax.Clear();
                    }
                }
            }
        }
    }
}
