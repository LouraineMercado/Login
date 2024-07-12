using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.User_Controls
{
    public partial class UC_Checkout : UserControl
    {
        function fn = new function();
        String query;
        public UC_Checkout()
        {
            InitializeComponent();
        }

        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.gender, customer.contact, customer.pax, customer.checkin, customer.hours, rooms.roomNo, rooms.type, rooms.bed from customer inner join rooms on customer.roomid = rooms.roomid where chekout = 'NO'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.gender, customer.contact, customer.pax, customer.checkin, customer.hours, rooms.roomNo, rooms.type, rooms.bed from customer inner join rooms on customer.roomid = rooms.roomid where cname like '" + txtName.Text + "%' and chekout = 'NO'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // First update query
                    query = "update customer set chekout = 'YES', checkout = '" + cdate + "' where cid = " + id;
                    fn.setData(query, "Customer checkout status updated successfully.");

                    // Second update query
                    query = "update rooms set booked = 'NO' where roomNo = '" + txtRoom.Text + "'";
                    fn.setData(query, "Room booking status updated successfully.");

                    // Reload the checkout data and clear all fields
                    UC_Checkout_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Select Customer to Checkout", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
        }

        private void UC_Checkout_Leave(object sender, EventArgs e)
        {
            UC_Checkout_Load(this, null);
            clearAll();
        }

        private void UC_Checkout_Enter(object sender, EventArgs e)
        {
            UC_Checkout_Load(this, null);
        }
    }
}
