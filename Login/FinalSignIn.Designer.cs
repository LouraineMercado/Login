namespace Login
{
    partial class FinalSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalSignIn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            btnRec = new Guna.UI2.WinForms.Guna2Button();
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
            btnExit.Size = new Size(30, 42);
            btnExit.TabIndex = 11;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.BorderRadius = 20;
            btnAdmin.CustomizableEdges = customizableEdges2;
            btnAdmin.DisabledState.BorderColor = Color.DarkGray;
            btnAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdmin.FillColor = Color.FromArgb(209, 179, 83);
            btnAdmin.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Location = new Point(892, 345);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdmin.Size = new Size(342, 67);
            btnAdmin.TabIndex = 17;
            btnAdmin.Text = "Admin";
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnRec
            // 
            btnRec.BackColor = Color.Transparent;
            btnRec.BorderRadius = 20;
            btnRec.CustomizableEdges = customizableEdges4;
            btnRec.DisabledState.BorderColor = Color.DarkGray;
            btnRec.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRec.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRec.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRec.FillColor = Color.FromArgb(209, 179, 83);
            btnRec.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            btnRec.ForeColor = Color.Black;
            btnRec.Location = new Point(892, 443);
            btnRec.Margin = new Padding(3, 4, 3, 4);
            btnRec.Name = "btnRec";
            btnRec.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnRec.Size = new Size(342, 67);
            btnRec.TabIndex = 16;
            btnRec.Text = "Receptionist";
            btnRec.Click += btnRec_Click;
            // 
            // FinalSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1309, 618);
            Controls.Add(btnAdmin);
            Controls.Add(btnRec);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FinalSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalSignIn";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnRec;
    }
}