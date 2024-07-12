namespace Login
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            labelError = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1267, 2);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(30, 37);
            btnExit.TabIndex = 11;
            btnExit.Click += btnExit_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.HoverState.FillColor = Color.FromArgb(64, 0, 0);
            guna2Button1.HoverState.ForeColor = Color.White;
            guna2Button1.Location = new Point(154, 396);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(43, 38, 32);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Button1.Size = new Size(375, 60);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "Login";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderColor = Color.Transparent;
            txtPassword.BorderRadius = 10;
            txtPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtPassword.CustomizableEdges = customizableEdges4;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.Transparent;
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Garet Book", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftOffset = new Point(10, 0);
            txtPassword.Location = new Point(154, 312);
            txtPassword.Margin = new Padding(3, 5, 3, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.Gray;
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtPassword.Size = new Size(375, 51);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.BorderColor = Color.Transparent;
            txtUsername.BorderRadius = 10;
            txtUsername.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtUsername.CustomizableEdges = customizableEdges6;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.Transparent;
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Garet Book", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.IconLeftOffset = new Point(10, 0);
            txtUsername.Location = new Point(154, 251);
            txtUsername.Margin = new Padding(3, 5, 3, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.Gray;
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtUsername.Size = new Size(375, 51);
            txtUsername.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("TAN - AEGEAN Regular", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(131, 117);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(429, 115);
            label1.TabIndex = 6;
            label1.Text = "Receptionist";
            label1.Click += label1_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.Transparent;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelError.ForeColor = Color.LightCoral;
            labelError.Location = new Point(238, 462);
            labelError.Name = "labelError";
            labelError.RightToLeft = RightToLeft.Yes;
            labelError.Size = new Size(207, 20);
            labelError.TabIndex = 12;
            labelError.Text = "Wrong Username or Password";
            labelError.Visible = false;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.BackgroundImage = (Image)resources.GetObject("guna2CirclePictureBox1.BackgroundImage");
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2CirclePictureBox1.FillColor = Color.Transparent;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(6, 573);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(38, 33);
            guna2CirclePictureBox1.TabIndex = 13;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.Click += guna2CirclePictureBox1_Click;
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1309, 618);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(labelError);
            Controls.Add(btnExit);
            Controls.Add(guna2Button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Receptionist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display";
            Load += Receptionist_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Label label1;
        private Label labelError;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}