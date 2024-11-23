namespace DAUR
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            linkSign = new LinkLabel();
            lblSign = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.Black;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // linkSign
            // 
            resources.ApplyResources(linkSign, "linkSign");
            linkSign.Name = "linkSign";
            linkSign.TabStop = true;
            linkSign.LinkClicked += linkSign_LinkClicked;
            // 
            // lblSign
            // 
            resources.ApplyResources(lblSign, "lblSign");
            lblSign.BackColor = Color.Transparent;
            lblSign.ForeColor = Color.FromArgb(66, 66, 66);
            lblSign.Name = "lblSign";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(66, 66, 66);
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(66, 66, 66);
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(66, 66, 66);
            label1.Name = "label1";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.FromArgb(236, 233, 254);
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(linkSign);
            guna2Panel1.Controls.Add(btnLogin);
            guna2Panel1.Controls.Add(lblSign);
            guna2Panel1.Controls.Add(tbPassword);
            guna2Panel1.Controls.Add(tbEmail);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 25;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(66, 66, 66);
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // tbPassword
            // 
            tbPassword.BorderRadius = 16;
            tbPassword.CustomizableEdges = customizableEdges3;
            tbPassword.DefaultText = "";
            tbPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            resources.ApplyResources(tbPassword, "tbPassword");
            tbPassword.ForeColor = Color.FromArgb(188, 190, 192);
            tbPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '●';
            tbPassword.PlaceholderText = "Password";
            tbPassword.SelectedText = "";
            tbPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbPassword.TextOffset = new Point(10, -2);
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            tbEmail.BorderRadius = 16;
            tbEmail.CustomizableEdges = customizableEdges5;
            tbEmail.DefaultText = "";
            tbEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            resources.ApplyResources(tbEmail, "tbEmail");
            tbEmail.ForeColor = Color.FromArgb(188, 190, 192);
            tbEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEmail.Name = "tbEmail";
            tbEmail.PasswordChar = '\0';
            tbEmail.PlaceholderText = "username@gmail.com";
            tbEmail.SelectedText = "";
            tbEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbEmail.TextOffset = new Point(10, -2);
            // 
            // loginPage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            BackgroundImage = Properties.Resources.login_dashboard;
            Controls.Add(guna2Panel1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginPage";
            Load += Form1_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblSign;
        private LinkLabel linkSign;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
    }
}