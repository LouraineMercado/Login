namespace Login.User_Controls
{
    partial class UC_ReceptRooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ReceptRooms));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label4 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label2 = new Label();
            datagridInvoice = new Guna.UI2.WinForms.Guna2DataGridView();
            ucinvoice = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnPrintInvoice = new Guna.UI2.WinForms.Guna2Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridInvoice).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(942, 20);
            label4.Name = "label4";
            label4.Size = new Size(165, 33);
            label4.TabIndex = 111;
            label4.Text = "Receptionist";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(1118, 4);
            guna2CirclePictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(48, 59);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 110;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Garet Heavy", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 4);
            label2.Name = "label2";
            label2.Size = new Size(158, 49);
            label2.TabIndex = 109;
            label2.Text = "Invoice";
            // 
            // datagridInvoice
            // 
            datagridInvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(207, 207, 207);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            datagridInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridInvoice.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagridInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagridInvoice.ColumnHeadersHeight = 40;
            datagridInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 207, 207);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            datagridInvoice.GridColor = Color.Black;
            datagridInvoice.Location = new Point(46, 109);
            datagridInvoice.Margin = new Padding(3, 4, 3, 4);
            datagridInvoice.Name = "datagridInvoice";
            datagridInvoice.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            datagridInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            datagridInvoice.RowHeadersVisible = false;
            datagridInvoice.RowHeadersWidth = 51;
            datagridInvoice.RowTemplate.Height = 25;
            datagridInvoice.Size = new Size(1102, 564);
            datagridInvoice.TabIndex = 114;
            datagridInvoice.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagridInvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            datagridInvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            datagridInvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            datagridInvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            datagridInvoice.ThemeStyle.BackColor = Color.White;
            datagridInvoice.ThemeStyle.GridColor = Color.Black;
            datagridInvoice.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            datagridInvoice.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridInvoice.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            datagridInvoice.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagridInvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridInvoice.ThemeStyle.HeaderStyle.Height = 40;
            datagridInvoice.ThemeStyle.ReadOnly = false;
            datagridInvoice.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagridInvoice.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridInvoice.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            datagridInvoice.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagridInvoice.ThemeStyle.RowsStyle.Height = 25;
            datagridInvoice.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            datagridInvoice.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridInvoice.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BorderRadius = 20;
            btnPrintInvoice.CustomizableEdges = customizableEdges2;
            btnPrintInvoice.DisabledState.BorderColor = Color.DarkGray;
            btnPrintInvoice.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrintInvoice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrintInvoice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrintInvoice.FillColor = Color.FromArgb(209, 179, 83);
            btnPrintInvoice.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.HoverState.BorderColor = Color.Transparent;
            btnPrintInvoice.HoverState.FillColor = Color.DarkOrange;
            btnPrintInvoice.HoverState.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(942, 705);
            btnPrintInvoice.Margin = new Padding(3, 4, 3, 4);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnPrintInvoice.Size = new Size(206, 60);
            btnPrintInvoice.TabIndex = 115;
            btnPrintInvoice.Text = "Print";
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // UC_ReceptRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(btnPrintInvoice);
            Controls.Add(datagridInvoice);
            Controls.Add(label4);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_ReceptRooms";
            Size = new Size(1186, 801);
            Load += UC_ReceptRooms_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView datagridInvoice;
        private Guna.UI2.WinForms.Guna2Elipse ucinvoice;
        private Guna.UI2.WinForms.Guna2Button btnPrintInvoice;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
