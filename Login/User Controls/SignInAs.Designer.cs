namespace Login.User_Controls
{
    partial class SignInAs
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btnRec = new Guna.UI2.WinForms.Guna2Button();
            btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            signIn = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("TAN - AEGEAN Regular", 32F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(289, 91);
            label1.TabIndex = 9;
            label1.Text = "Sign in as";
            // 
            // btnRec
            // 
            btnRec.BackColor = Color.Transparent;
            btnRec.BorderRadius = 10;
            btnRec.CustomizableEdges = customizableEdges1;
            btnRec.DisabledState.BorderColor = Color.DarkGray;
            btnRec.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRec.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRec.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRec.FillColor = Color.FromArgb(209, 179, 83);
            btnRec.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            btnRec.ForeColor = Color.Black;
            btnRec.Location = new Point(28, 165);
            btnRec.Name = "btnRec";
            btnRec.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRec.Size = new Size(291, 50);
            btnRec.TabIndex = 13;
            btnRec.Text = "Receptionist";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.BorderRadius = 10;
            btnAdmin.CustomizableEdges = customizableEdges3;
            btnAdmin.DisabledState.BorderColor = Color.DarkGray;
            btnAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdmin.FillColor = Color.FromArgb(209, 179, 83);
            btnAdmin.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Location = new Point(28, 94);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdmin.Size = new Size(291, 50);
            btnAdmin.TabIndex = 14;
            btnAdmin.Text = "Admin";
            btnAdmin.Click += btnAdmin_Click;
            // 
            // SignInAs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnAdmin);
            Controls.Add(btnRec);
            Controls.Add(label1);
            Name = "SignInAs";
            Size = new Size(362, 275);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRec;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Elipse signIn;
    }
}
