namespace Login.User_Controls
{
    partial class UC_PrintCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PrintCustomer));
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
            datagridcustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            printcustoms = new Guna.UI2.WinForms.Guna2Elipse(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panelPrint = new Panel();
            printPreviewDialog1 = new PrintPreviewDialog();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridcustomer).BeginInit();
            panelPrint.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(920, 30);
            label4.Name = "label4";
            label4.Size = new Size(181, 33);
            label4.TabIndex = 74;
            label4.Text = "Administrator";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(1107, 21);
            guna2CirclePictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(48, 59);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 76;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Garet Heavy", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 21);
            label2.Name = "label2";
            label2.Size = new Size(225, 49);
            label2.TabIndex = 75;
            label2.Text = "Customers";
            // 
            // datagridcustomer
            // 
            datagridcustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(218, 218, 218);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridcustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridcustomer.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagridcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagridcustomer.ColumnHeadersHeight = 40;
            datagridcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(218, 218, 218);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridcustomer.DefaultCellStyle = dataGridViewCellStyle3;
            datagridcustomer.GridColor = Color.FromArgb(231, 229, 255);
            datagridcustomer.Location = new Point(8, 11);
            datagridcustomer.Margin = new Padding(3, 4, 3, 4);
            datagridcustomer.Name = "datagridcustomer";
            datagridcustomer.ReadOnly = true;
            datagridcustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            datagridcustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            datagridcustomer.RowHeadersVisible = false;
            datagridcustomer.RowHeadersWidth = 51;
            datagridcustomer.RowTemplate.Height = 42;
            datagridcustomer.Size = new Size(1113, 572);
            datagridcustomer.TabIndex = 86;
            datagridcustomer.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagridcustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            datagridcustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            datagridcustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            datagridcustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            datagridcustomer.ThemeStyle.BackColor = Color.White;
            datagridcustomer.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            datagridcustomer.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            datagridcustomer.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridcustomer.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            datagridcustomer.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagridcustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridcustomer.ThemeStyle.HeaderStyle.Height = 40;
            datagridcustomer.ThemeStyle.ReadOnly = true;
            datagridcustomer.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagridcustomer.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridcustomer.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            datagridcustomer.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagridcustomer.ThemeStyle.RowsStyle.Height = 42;
            datagridcustomer.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            datagridcustomer.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridcustomer.CellContentClick += datagridcustomer_CellContentClick;
            // 
            // printcustoms
            // 
            printcustoms.TargetControl = this;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // panelPrint
            // 
            panelPrint.Controls.Add(datagridcustomer);
            panelPrint.Location = new Point(23, 91);
            panelPrint.Margin = new Padding(3, 4, 3, 4);
            panelPrint.Name = "panelPrint";
            panelPrint.Size = new Size(1133, 593);
            panelPrint.TabIndex = 109;
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
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(209, 179, 83);
            guna2Button1.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.BorderColor = Color.Transparent;
            guna2Button1.HoverState.FillColor = Color.FromArgb(64, 0, 0);
            guna2Button1.HoverState.ForeColor = Color.White;
            guna2Button1.Location = new Point(950, 705);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Button1.Size = new Size(206, 60);
            guna2Button1.TabIndex = 110;
            guna2Button1.Text = "Print";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // UC_PrintCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(guna2Button1);
            Controls.Add(panelPrint);
            Controls.Add(label4);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_PrintCustomer";
            Size = new Size(1186, 801);
            Load += UC_PrintCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridcustomer).EndInit();
            panelPrint.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView datagridcustomer;
        private Guna.UI2.WinForms.Guna2Elipse printcustoms;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panelPrint;
        private PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
