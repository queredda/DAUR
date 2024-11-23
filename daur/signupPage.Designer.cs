namespace DAUR
{
    partial class signupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupPage));
            signupPnl = new Panel();
            rbCollector = new Guna.UI2.WinForms.Guna2RadioButton();
            roleLbl = new Label();
            rbIndustri = new Guna.UI2.WinForms.Guna2RadioButton();
            tbCP = new TextBox();
            confirmpwLbl = new Label();
            tbPassword = new TextBox();
            btn_SignUp = new Button();
            EmailLbl = new Label();
            tbEmail = new TextBox();
            linkLog = new LinkLabel();
            lblLog = new Label();
            pwLbl = new Label();
            NameLbl = new Label();
            tbName = new TextBox();
            SignUpLbl = new Label();
            button1 = new Button();
            signupPnl.SuspendLayout();
            SuspendLayout();
            // 
            // signupPnl
            // 
            signupPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupPnl.BackColor = Color.White;
            signupPnl.Controls.Add(rbCollector);
            signupPnl.Controls.Add(roleLbl);
            signupPnl.Controls.Add(rbIndustri);
            signupPnl.Controls.Add(tbCP);
            signupPnl.Controls.Add(confirmpwLbl);
            signupPnl.Controls.Add(tbPassword);
            signupPnl.Controls.Add(btn_SignUp);
            signupPnl.Controls.Add(EmailLbl);
            signupPnl.Controls.Add(tbEmail);
            signupPnl.Controls.Add(linkLog);
            signupPnl.Controls.Add(lblLog);
            signupPnl.Controls.Add(pwLbl);
            signupPnl.Controls.Add(NameLbl);
            signupPnl.Controls.Add(tbName);
            signupPnl.Controls.Add(SignUpLbl);
            signupPnl.Location = new Point(589, 42);
            signupPnl.Margin = new Padding(4, 4, 4, 4);
            signupPnl.Name = "signupPnl";
            signupPnl.Size = new Size(508, 828);
            signupPnl.TabIndex = 2;
            signupPnl.Paint += signupPnl_Paint;
            // 
            // rbCollector
            // 
            rbCollector.AutoSize = true;
            rbCollector.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbCollector.CheckedState.BorderThickness = 0;
            rbCollector.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbCollector.CheckedState.InnerColor = Color.White;
            rbCollector.CheckedState.InnerOffset = -4;
            rbCollector.Location = new Point(110, 575);
            rbCollector.Margin = new Padding(4, 4, 4, 4);
            rbCollector.Name = "rbCollector";
            rbCollector.Size = new Size(160, 29);
            rbCollector.TabIndex = 31;
            rbCollector.Text = "Waste Collector";
            rbCollector.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbCollector.UncheckedState.BorderThickness = 2;
            rbCollector.UncheckedState.FillColor = Color.Transparent;
            rbCollector.UncheckedState.InnerColor = Color.Transparent;
            // 
            // roleLbl
            // 
            roleLbl.AutoSize = true;
            roleLbl.BackColor = Color.Transparent;
            roleLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            roleLbl.ForeColor = Color.FromArgb(66, 66, 66);
            roleLbl.ImeMode = ImeMode.NoControl;
            roleLbl.Location = new Point(110, 509);
            roleLbl.Margin = new Padding(4, 0, 4, 0);
            roleLbl.Name = "roleLbl";
            roleLbl.Size = new Size(46, 20);
            roleLbl.TabIndex = 30;
            roleLbl.Text = "Role";
            // 
            // rbIndustri
            // 
            rbIndustri.AutoSize = true;
            rbIndustri.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbIndustri.CheckedState.BorderThickness = 0;
            rbIndustri.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbIndustri.CheckedState.InnerColor = Color.White;
            rbIndustri.CheckedState.InnerOffset = -4;
            rbIndustri.Location = new Point(110, 538);
            rbIndustri.Margin = new Padding(4, 4, 4, 4);
            rbIndustri.Name = "rbIndustri";
            rbIndustri.Size = new Size(152, 29);
            rbIndustri.TabIndex = 29;
            rbIndustri.Text = "Pelaku Industri";
            rbIndustri.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbIndustri.UncheckedState.BorderThickness = 2;
            rbIndustri.UncheckedState.FillColor = Color.Transparent;
            rbIndustri.UncheckedState.InnerColor = Color.Transparent;
            // 
            // tbCP
            // 
            tbCP.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbCP.ForeColor = Color.Gray;
            tbCP.Location = new Point(110, 451);
            tbCP.Margin = new Padding(4, 4, 4, 4);
            tbCP.Name = "tbCP";
            tbCP.Size = new Size(284, 32);
            tbCP.TabIndex = 28;
            // 
            // confirmpwLbl
            // 
            confirmpwLbl.AutoSize = true;
            confirmpwLbl.BackColor = Color.Transparent;
            confirmpwLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            confirmpwLbl.ForeColor = Color.FromArgb(66, 66, 66);
            confirmpwLbl.ImeMode = ImeMode.NoControl;
            confirmpwLbl.Location = new Point(110, 411);
            confirmpwLbl.Margin = new Padding(4, 0, 4, 0);
            confirmpwLbl.Name = "confirmpwLbl";
            confirmpwLbl.Size = new Size(153, 20);
            confirmpwLbl.TabIndex = 27;
            confirmpwLbl.Text = "Confirm Password";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.Gray;
            tbPassword.Location = new Point(110, 348);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(284, 32);
            tbPassword.TabIndex = 26;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.FromArgb(66, 66, 66);
            btn_SignUp.FlatAppearance.BorderSize = 0;
            btn_SignUp.FlatStyle = FlatStyle.Flat;
            btn_SignUp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SignUp.ForeColor = Color.White;
            btn_SignUp.ImeMode = ImeMode.NoControl;
            btn_SignUp.Location = new Point(131, 632);
            btn_SignUp.Margin = new Padding(4, 4, 4, 4);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(244, 54);
            btn_SignUp.TabIndex = 8;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.BackColor = Color.Transparent;
            EmailLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLbl.ForeColor = Color.FromArgb(66, 66, 66);
            EmailLbl.ImeMode = ImeMode.NoControl;
            EmailLbl.Location = new Point(110, 234);
            EmailLbl.Margin = new Padding(4, 0, 4, 0);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(53, 20);
            EmailLbl.TabIndex = 25;
            EmailLbl.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.Gray;
            tbEmail.Location = new Point(110, 262);
            tbEmail.Margin = new Padding(4, 4, 4, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(284, 32);
            tbEmail.TabIndex = 24;
            // 
            // linkLog
            // 
            linkLog.AutoSize = true;
            linkLog.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point);
            linkLog.Location = new Point(351, 730);
            linkLog.Margin = new Padding(4, 0, 4, 0);
            linkLog.Name = "linkLog";
            linkLog.Size = new Size(60, 20);
            linkLog.TabIndex = 23;
            linkLog.TabStop = true;
            linkLog.Text = "Log In";
            linkLog.LinkClicked += linkLog_LinkClicked;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.BackColor = Color.Transparent;
            lblLog.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLog.ForeColor = Color.FromArgb(66, 66, 66);
            lblLog.ImeMode = ImeMode.NoControl;
            lblLog.Location = new Point(110, 730);
            lblLog.Margin = new Padding(4, 0, 4, 0);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(218, 20);
            lblLog.TabIndex = 22;
            lblLog.Text = "Already have an Account?";
            // 
            // pwLbl
            // 
            pwLbl.AutoSize = true;
            pwLbl.BackColor = Color.Transparent;
            pwLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            pwLbl.ForeColor = Color.FromArgb(66, 66, 66);
            pwLbl.ImeMode = ImeMode.NoControl;
            pwLbl.Location = new Point(110, 319);
            pwLbl.Margin = new Padding(4, 0, 4, 0);
            pwLbl.Name = "pwLbl";
            pwLbl.Size = new Size(86, 20);
            pwLbl.TabIndex = 6;
            pwLbl.Text = "Password";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.Transparent;
            NameLbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            NameLbl.ForeColor = Color.FromArgb(66, 66, 66);
            NameLbl.ImeMode = ImeMode.NoControl;
            NameLbl.Location = new Point(110, 146);
            NameLbl.Margin = new Padding(4, 0, 4, 0);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(55, 20);
            NameLbl.TabIndex = 7;
            NameLbl.Text = "Nama";
            // 
            // tbName
            // 
            tbName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbName.ForeColor = Color.Gray;
            tbName.Location = new Point(110, 175);
            tbName.Margin = new Padding(4, 4, 4, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(284, 32);
            tbName.TabIndex = 4;
            // 
            // SignUpLbl
            // 
            SignUpLbl.AutoSize = true;
            SignUpLbl.BackColor = Color.Transparent;
            SignUpLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpLbl.ForeColor = Color.FromArgb(66, 66, 66);
            SignUpLbl.ImeMode = ImeMode.NoControl;
            SignUpLbl.Location = new Point(192, 66);
            SignUpLbl.Margin = new Padding(4, 0, 4, 0);
            SignUpLbl.Name = "SignUpLbl";
            SignUpLbl.Size = new Size(122, 32);
            SignUpLbl.TabIndex = 0;
            SignUpLbl.Text = "Sign Up";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(1606, 2);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(76, 70);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // signupPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1685, 901);
            Controls.Add(button1);
            Controls.Add(signupPnl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            MaximumSize = new Size(1708, 960);
            Name = "signupPage";
            Text = "signupPage";
            Load += signupPage_Load;
            signupPnl.ResumeLayout(false);
            signupPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel signupPnl;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button4;
        private Label label5;
        private Button button3;
        private Label label4;
        private Label NameLbl;
        private Label EmailLbl;
        private TextBox tbEmail;
        private Button button1;
        private LinkLabel linkLog;
        private Label lblLog;
        private Panel panel1;
        private LinkLabel linkSign;
        private Label lblSign;
        private TextBox textBox1;
        private Button btn_SignUp;
        private Label label3;
        private Label pwLbl;
        private TextBox tbName;
        private Label SignUpLbl;
        private TextBox tbCP;
        private Label confirmpwLbl;
        private TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2RadioButton rbCollector;
        private Label roleLbl;
        private Guna.UI2.WinForms.Guna2RadioButton rbIndustri;
    }
}