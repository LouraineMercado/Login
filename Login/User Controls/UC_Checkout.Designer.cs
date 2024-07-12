namespace Login.User_Controls
{
    partial class UC_Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Checkout));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label2 = new Label();
            checkout = new Guna.UI2.WinForms.Guna2Elipse(components);
            label7 = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtRoom = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            txtCName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            guna2CirclePictureBox1.TabIndex = 69;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Garet Heavy", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 4);
            label2.Name = "label2";
            label2.Size = new Size(215, 49);
            label2.TabIndex = 66;
            label2.Text = "Check Out";
            // 
            // checkout
            // 
            checkout.BorderRadius = 30;
            checkout.TargetControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(74, 107);
            label7.Name = "label7";
            label7.Size = new Size(77, 27);
            label7.TabIndex = 71;
            label7.Text = "Name";
            // 
            // txtName
            // 
            txtName.BorderRadius = 15;
            txtName.CustomizableEdges = customizableEdges8;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.ForeColor = Color.Black;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.IconRightOffset = new Point(15, 0);
            txtName.Location = new Point(160, 101);
            txtName.Margin = new Padding(3, 5, 3, 5);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "Enter customer name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtName.Size = new Size(403, 47);
            txtName.TabIndex = 70;
            txtName.TextOffset = new Point(10, 0);
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BorderRadius = 20;
            btnCheckOut.CustomizableEdges = customizableEdges6;
            btnCheckOut.DisabledState.BorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckOut.FillColor = Color.Black;
            btnCheckOut.Font = new Font("Montserrat ExtraBold", 12F, FontStyle.Bold);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.HoverState.FillColor = SystemColors.GrayText;
            btnCheckOut.HoverState.ForeColor = Color.White;
            btnCheckOut.Location = new Point(905, 697);
            btnCheckOut.Margin = new Padding(3, 4, 3, 4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ShadowDecoration.BorderRadius = 5;
            btnCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnCheckOut.Size = new Size(206, 60);
            btnCheckOut.TabIndex = 107;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(947, 13);
            label4.Name = "label4";
            label4.Size = new Size(165, 33);
            label4.TabIndex = 108;
            label4.Text = "Receptionist";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 219, 174);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 243, 243);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 219, 174);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(74, 184);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1037, 461);
            dataGridView1.TabIndex = 115;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(447, 673);
            label3.Name = "label3";
            label3.Size = new Size(121, 27);
            label3.TabIndex = 119;
            label3.Text = "Room No.";
            // 
            // txtRoom
            // 
            txtRoom.BorderRadius = 15;
            txtRoom.CustomizableEdges = customizableEdges4;
            txtRoom.DefaultText = "";
            txtRoom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRoom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRoom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRoom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRoom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoom.Font = new Font("Segoe UI", 9F);
            txtRoom.ForeColor = Color.Black;
            txtRoom.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoom.IconRightOffset = new Point(15, 0);
            txtRoom.Location = new Point(447, 711);
            txtRoom.Margin = new Padding(3, 5, 3, 5);
            txtRoom.Name = "txtRoom";
            txtRoom.PasswordChar = '\0';
            txtRoom.PlaceholderText = "";
            txtRoom.ReadOnly = true;
            txtRoom.SelectedText = "";
            txtRoom.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtRoom.Size = new Size(344, 47);
            txtRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtRoom.TabIndex = 118;
            txtRoom.TextOffset = new Point(10, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 673);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 122;
            label1.Text = "Name";
            // 
            // txtCName
            // 
            txtCName.BorderRadius = 15;
            txtCName.CustomizableEdges = customizableEdges2;
            txtCName.DefaultText = "";
            txtCName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCName.Font = new Font("Segoe UI", 9F);
            txtCName.ForeColor = Color.Black;
            txtCName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCName.IconRightOffset = new Point(15, 0);
            txtCName.Location = new Point(74, 711);
            txtCName.Margin = new Padding(3, 5, 3, 5);
            txtCName.Name = "txtCName";
            txtCName.PasswordChar = '\0';
            txtCName.PlaceholderText = "";
            txtCName.ReadOnly = true;
            txtCName.SelectedText = "";
            txtCName.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtCName.Size = new Size(347, 47);
            txtCName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCName.TabIndex = 121;
            txtCName.TextOffset = new Point(10, 0);
            // 
            // UC_Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(label1);
            Controls.Add(txtCName);
            Controls.Add(label3);
            Controls.Add(txtRoom);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(btnCheckOut);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Checkout";
            Size = new Size(1186, 801);
            Load += UC_Checkout_Load;
            Enter += UC_Checkout_Enter;
            Leave += UC_Checkout_Leave;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse checkout;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Label label4;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckOutDate;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtRoom;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCName;
    }
}
