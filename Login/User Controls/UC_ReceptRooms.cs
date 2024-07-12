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
    public partial class UC_ReceptRooms : UserControl
    {
        function fn = new function();
        String query;
        SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\merca\\Downloads\\OOPfinals-FINALREALTALAGA\\OOPfinals-FINALREALTALAGA\\Login\\bin\\Debug\\oopDB.db;Version=3;");

        public UC_ReceptRooms()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void UC_ReceptRooms_Load(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid";
            DataSet ds = fn.getData(query);
        }

        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            int height = datagridInvoice.Height;
            datagridInvoice.Height = datagridInvoice.RowCount * datagridInvoice.RowTemplate.Height * 2;
            bmp = new Bitmap(datagridInvoice.Width, datagridInvoice.Height);
            datagridInvoice.DrawToBitmap(bmp, new Rectangle(0, 0, datagridInvoice.Width, datagridInvoice.Height));
            datagridInvoice.Height = height;
            printPreviewDialog1.ShowDialog();
        }
    }
}
