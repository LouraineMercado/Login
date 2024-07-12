using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.User_Controls
{
    public partial class UC_PrintCustomer : UserControl
    {
        function fn = new function();
        String query;
        SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\merca\\Downloads\\OOPfinals-FINALREALTALAGA\\OOPfinals-FINALREALTALAGA\\Login\\bin\\Debug\\oopDB.db;Version=3;");
        public UC_PrintCustomer()
        {
            InitializeComponent();
        }

        private void UC_PrintCustomer_Load(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.gender, customer.contact, customer.pax, customer.checkin, customer.checkout, rooms.roomNo, rooms.type, rooms.bed from customer inner join rooms on customer.roomid = rooms.roomid";
            DataSet ds = fn.getData(query);
            datagridcustomer.DataSource = ds.Tables[0];
        }

        Bitmap bmp;
        int currentPage = 0;
        int pageHeight;
        int totalPages;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.Landscape = true;

            // Calculate the scaling factor to fit the DataGridView to the printable area
            float widthRatio = e.PageBounds.Width / (float)bmp.Width;
            float heightRatio = e.PageBounds.Height / (float)bmp.Height;
            float scaleFactor = Math.Min(widthRatio, heightRatio);

            // Calculate the new width and height
            int scaledWidth = (int)(bmp.Width * scaleFactor);
            int scaledHeight = (int)(bmp.Height * scaleFactor);

            // Center the image
            int xOffset = (e.PageBounds.Width - scaledWidth) / 2;
            int yOffset = (e.PageBounds.Height - scaledHeight) / 2;

            // Draw the scaled image
            e.Graphics.DrawImage(bmp, xOffset, yOffset, scaledWidth, scaledHeight);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int height = datagridcustomer.Height;

                // Temporarily increase the height to capture the entire DataGridView content
                datagridcustomer.Height = datagridcustomer.RowCount * datagridcustomer.RowTemplate.Height * 2;

                // Create a bitmap of the DataGridView content
                bmp = new Bitmap(datagridcustomer.Width, datagridcustomer.Height);
                datagridcustomer.DrawToBitmap(bmp, new Rectangle(0, 0, datagridcustomer.Width, datagridcustomer.Height));

                // Restore the original height
                datagridcustomer.Height = height;

                // Set the print document to landscape
                printDocument1.DefaultPageSettings.Landscape = true;

                // Show the print preview
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                // Handle the exception, for example, log it or show a message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagridcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
