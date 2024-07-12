namespace Login
{
    partial class PrintInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInvoice));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBoxPrint = new PictureBox();
            toolTip1 = new ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label20 = new Label();
            labelType = new Label();
            label18 = new Label();
            labelBed = new Label();
            label24 = new Label();
            labelPrice = new Label();
            label3 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label17 = new Label();
            panelPrint = new Guna.UI2.WinForms.Guna2Panel();
            labelPax = new Label();
            label23 = new Label();
            labelHours = new Label();
            label19 = new Label();
            pictureBox2 = new PictureBox();
            labelRoom = new Label();
            label22 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            labelCheckin = new Label();
            label9 = new Label();
            labelCname = new Label();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.BackColor = Color.Transparent;
            pictureBoxPrint.BackgroundImage = (Image)resources.GetObject("pictureBoxPrint.BackgroundImage");
            pictureBoxPrint.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPrint.Location = new Point(829, 865);
            pictureBoxPrint.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(47, 47);
            pictureBoxPrint.TabIndex = 0;
            pictureBoxPrint.TabStop = false;
            pictureBoxPrint.Click += pictureBoxPrint_Click;
            pictureBoxPrint.MouseHover += pictureBoxPrint_MouseHover;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(35, 686);
            label20.Name = "label20";
            label20.Size = new Size(113, 23);
            label20.TabIndex = 21;
            label20.Text = "Room Type:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelType.Location = new Point(202, 687);
            labelType.Name = "labelType";
            labelType.Size = new Size(228, 22);
            labelType.TabIndex = 22;
            labelType.Text = "opulencehotels@gmail.com";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(35, 726);
            label18.Name = "label18";
            label18.Size = new Size(58, 23);
            label18.TabIndex = 23;
            label18.Text = "Beds:";
            // 
            // labelBed
            // 
            labelBed.AutoSize = true;
            labelBed.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBed.Location = new Point(202, 727);
            labelBed.Name = "labelBed";
            labelBed.Size = new Size(263, 22);
            labelBed.TabIndex = 24;
            labelBed.Text = "PUP QC St., Group 6, OOP City";
            labelBed.Click += labelBed_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(531, 789);
            label24.Name = "label24";
            label24.Size = new Size(186, 38);
            label24.TabIndex = 25;
            label24.Text = "Total Price:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(762, 783);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(100, 46);
            labelPrice.TabIndex = 26;
            labelPrice.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(723, 783);
            label3.Name = "label3";
            label3.Size = new Size(42, 46);
            label3.TabIndex = 28;
            label3.Text = "₱";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(272, 894);
            label10.Name = "label10";
            label10.Size = new Size(361, 33);
            label10.TabIndex = 30;
            label10.Text = "Thank you for staying with us! ";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(27, 749);
            label12.Name = "label12";
            label12.Size = new Size(863, 34);
            label12.TabIndex = 31;
            label12.Text = "----------------------------------------------------------------------------------------------------------\r\n";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(27, 827);
            label13.Name = "label13";
            label13.Size = new Size(863, 34);
            label13.TabIndex = 32;
            label13.Text = "----------------------------------------------------------------------------------------------------------\r\n";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(377, 927);
            label17.Name = "label17";
            label17.Size = new Size(136, 20);
            label17.TabIndex = 33;
            label17.Text = "Opulence.com.ph";
            // 
            // panelPrint
            // 
            panelPrint.Controls.Add(labelPax);
            panelPrint.Controls.Add(pictureBoxPrint);
            panelPrint.Controls.Add(label23);
            panelPrint.Controls.Add(labelHours);
            panelPrint.Controls.Add(label19);
            panelPrint.Controls.Add(label17);
            panelPrint.Controls.Add(label13);
            panelPrint.Controls.Add(label12);
            panelPrint.Controls.Add(label10);
            panelPrint.Controls.Add(pictureBox2);
            panelPrint.Controls.Add(label3);
            panelPrint.Controls.Add(labelPrice);
            panelPrint.Controls.Add(label24);
            panelPrint.Controls.Add(labelBed);
            panelPrint.Controls.Add(label18);
            panelPrint.Controls.Add(labelType);
            panelPrint.Controls.Add(label20);
            panelPrint.Controls.Add(labelRoom);
            panelPrint.Controls.Add(label22);
            panelPrint.Controls.Add(label16);
            panelPrint.Controls.Add(label15);
            panelPrint.Controls.Add(label14);
            panelPrint.Controls.Add(labelCheckin);
            panelPrint.Controls.Add(label9);
            panelPrint.Controls.Add(labelCname);
            panelPrint.Controls.Add(label11);
            panelPrint.Controls.Add(label7);
            panelPrint.Controls.Add(label8);
            panelPrint.Controls.Add(label5);
            panelPrint.Controls.Add(label6);
            panelPrint.Controls.Add(label4);
            panelPrint.Controls.Add(label2);
            panelPrint.Controls.Add(label1);
            panelPrint.Controls.Add(pictureBox1);
            panelPrint.CustomizableEdges = customizableEdges1;
            panelPrint.Dock = DockStyle.Fill;
            panelPrint.Location = new Point(0, 0);
            panelPrint.Margin = new Padding(3, 4, 3, 4);
            panelPrint.Name = "panelPrint";
            panelPrint.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelPrint.Size = new Size(914, 1045);
            panelPrint.TabIndex = 1;
            panelPrint.Paint += panelPrint_Paint;
            // 
            // labelPax
            // 
            labelPax.AutoSize = true;
            labelPax.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPax.Location = new Point(202, 611);
            labelPax.Name = "labelPax";
            labelPax.Size = new Size(39, 22);
            labelPax.TabIndex = 37;
            labelPax.Text = "Pax";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(35, 610);
            label23.Name = "label23";
            label23.Size = new Size(49, 23);
            label23.TabIndex = 36;
            label23.Text = "Pax:";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHours.Location = new Point(202, 574);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(58, 22);
            labelHours.TabIndex = 35;
            labelHours.Text = "Hours";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(35, 573);
            label19.Name = "label19";
            label19.Size = new Size(68, 23);
            label19.TabIndex = 34;
            label19.Text = "Hours:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(27, 33);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 152);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRoom.Location = new Point(202, 649);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(132, 22);
            labelRoom.TabIndex = 20;
            labelRoom.Text = "Phone Number:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(35, 648);
            label22.Name = "label22";
            label22.Size = new Size(93, 23);
            label22.TabIndex = 19;
            label22.Text = "Room No.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(390, 100);
            label16.Name = "label16";
            label16.Size = new Size(136, 46);
            label16.TabIndex = 18;
            label16.Text = "Invoice";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(31, 441);
            label15.Name = "label15";
            label15.Size = new Size(294, 35);
            label15.TabIndex = 17;
            label15.Text = "INVOICE DETAILS:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(31, 235);
            label14.Name = "label14";
            label14.Size = new Size(257, 35);
            label14.TabIndex = 16;
            label14.Text = "HOTEL DETAILS";
            // 
            // labelCheckin
            // 
            labelCheckin.AutoSize = true;
            labelCheckin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCheckin.Location = new Point(202, 536);
            labelCheckin.Name = "labelCheckin";
            labelCheckin.Size = new Size(263, 22);
            labelCheckin.TabIndex = 15;
            labelCheckin.Text = "PUP QC St., Group 6, OOP City";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 536);
            label9.Name = "label9";
            label9.Size = new Size(95, 23);
            label9.TabIndex = 14;
            label9.Text = "Check-In:";
            // 
            // labelCname
            // 
            labelCname.AutoSize = true;
            labelCname.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCname.Location = new Point(202, 498);
            labelCname.Name = "labelCname";
            labelCname.Size = new Size(228, 22);
            labelCname.TabIndex = 13;
            labelCname.Text = "opulencehotels@gmail.com";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(35, 498);
            label11.Name = "label11";
            label11.Size = new Size(153, 23);
            label11.TabIndex = 12;
            label11.Text = "Customer Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(188, 365);
            label7.Name = "label7";
            label7.Size = new Size(263, 22);
            label7.TabIndex = 9;
            label7.Text = "PUP QC St., Group 6, OOP City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 365);
            label8.Name = "label8";
            label8.Size = new Size(135, 23);
            label8.TabIndex = 8;
            label8.Text = "Place Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(188, 328);
            label5.Name = "label5";
            label5.Size = new Size(228, 22);
            label5.TabIndex = 7;
            label5.Text = "opulencehotels@gmail.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 328);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 6;
            label6.Text = "Email Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 290);
            label4.Name = "label4";
            label4.Size = new Size(139, 22);
            label4.TabIndex = 5;
            label4.Text = "0978-548-6359 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 290);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 3;
            label2.Text = " Phone Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("TAN - AEGEAN Regular", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 38);
            label1.Name = "label1";
            label1.Size = new Size(447, 86);
            label1.TabIndex = 2;
            label1.Text = "Opulence Hotels";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(728, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 163);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PrintInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            ClientSize = new Size(914, 1045);
            Controls.Add(panelPrint);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintInvoice";
            Text = "PrintInvoice";
            Load += PrintInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            panelPrint.ResumeLayout(false);
            panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPrint;
        private ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label20;
        private Label labelType;
        private Label label18;
        private Label labelBed;
        private Label label24;
        private Label labelPrice;
        private Label label3;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label17;
        private Guna.UI2.WinForms.Guna2Panel panelPrint;
        private PictureBox pictureBox2;
        private Label labelRoom;
        private Label label22;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label labelCheckin;
        private Label label9;
        private Label labelCname;
        private Label label11;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelPax;
        private Label label23;
        private Label labelHours;
        private Label label19;
    }
}