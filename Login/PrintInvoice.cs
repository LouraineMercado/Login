using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class PrintInvoice : Form
    {
        public string Date, Cname, Checkin, Hours, Pax, Room, Type, Bed, Price;
        public PrintInvoice()
        {
            InitializeComponent();
            Date = DateTime.Now.ToLongDateString();
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = (Guna.UI2.WinForms.Guna2Panel)pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }


        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Print");
        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            labelCname.Text = Cname;
            labelCheckin.Text = Checkin;
            labelHours.Text = Hours;
            labelPax.Text = Pax;
            labelRoom.Text = Room;
            labelType.Text = Type;
            labelBed.Text = Bed;
            labelPrice.Text = Price;

        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelBed_Click(object sender, EventArgs e)
        {

        }
    }
}
