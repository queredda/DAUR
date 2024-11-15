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
            button1 = new Button();
            panel1 = new Panel();
            linkSign = new LinkLabel();
            lblSign = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkSign);
            panel1.Controls.Add(lblSign);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
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
            // tbPassword
            // 
            resources.ApplyResources(tbPassword, "tbPassword");
            tbPassword.ForeColor = Color.Gray;
            tbPassword.Name = "tbPassword";
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(66, 66, 66);
            btnLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
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
            // tbEmail
            // 
            resources.ApplyResources(tbEmail, "tbEmail");
            tbEmail.ForeColor = Color.Gray;
            tbEmail.Name = "tbEmail";
            tbEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(66, 66, 66);
            label1.Name = "label1";
            // 
            // loginPage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            BackgroundImage = Properties.Resources.login_dashboard;
            Controls.Add(panel1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginPage";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox tbEmail;
        private Label label1;
        private TextBox tbPassword;
        private Label lblSign;
        private LinkLabel linkSign;
    }
}