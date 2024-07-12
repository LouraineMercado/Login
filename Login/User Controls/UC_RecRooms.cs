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
    public partial class UC_RecRooms : UserControl
    {
        function fn = new function();
        String query;
        System.Windows.Forms.Timer refreshTimer;

        public UC_RecRooms()
        {
            InitializeComponent();

            // Subscribe to the CellFormatting event
            guna2DataGridView1.CellFormatting += guna2DataGridView1_CellFormatting;

            // Initialize and set up the timer
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000; // Set interval to 5 seconds (5000 milliseconds)
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void UC_RecRooms_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "booked")
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

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Example: Refresh the data when a cell is clicked
            // Note: Adjust the logic as needed based on your specific requirements
            LoadData();
        }
    }
}
