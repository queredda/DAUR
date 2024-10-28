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
            linkLog = new LinkLabel();
            lblLog = new Label();
            EmailLbl = new Label();
            tbEmail = new TextBox();
            tbCP = new TextBox();
            confirmpwLbl = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            label5 = new Label();
            button3 = new Button();
            tbPassword = new TextBox();
            btn_SignUp = new Button();
            NameLbl = new Label();
            pwLbl = new Label();
            tbName = new TextBox();
            SignUpLbl = new Label();
            button1 = new Button();
            signupPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signupPnl
            // 
            signupPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupPnl.BackColor = Color.White;
            signupPnl.Controls.Add(linkLog);
            signupPnl.Controls.Add(lblLog);
            signupPnl.Controls.Add(EmailLbl);
            signupPnl.Controls.Add(tbEmail);
            signupPnl.Controls.Add(tbCP);
            signupPnl.Controls.Add(confirmpwLbl);
            signupPnl.Controls.Add(pictureBox1);
            signupPnl.Controls.Add(button5);
            signupPnl.Controls.Add(button4);
            signupPnl.Controls.Add(label5);
            signupPnl.Controls.Add(button3);
            signupPnl.Controls.Add(tbPassword);
            signupPnl.Controls.Add(btn_SignUp);
            signupPnl.Controls.Add(NameLbl);
            signupPnl.Controls.Add(pwLbl);
            signupPnl.Controls.Add(tbName);
            signupPnl.Controls.Add(SignUpLbl);
            signupPnl.Location = new Point(589, 42);
            signupPnl.Margin = new Padding(4, 4, 4, 4);
            signupPnl.Name = "signupPnl";
            signupPnl.Size = new Size(508, 828);
            signupPnl.TabIndex = 2;
            signupPnl.Paint += signupPnl_Paint;
            // 
            // linkLog
            // 
            linkLog.AutoSize = true;
            linkLog.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point);
            linkLog.Location = new Point(352, 752);
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
            lblLog.Location = new Point(110, 752);
            lblLog.Margin = new Padding(4, 0, 4, 0);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(218, 20);
            lblLog.TabIndex = 22;
            lblLog.Text = "Already have an Account?";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.BackColor = Color.Transparent;
            EmailLbl.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            EmailLbl.ForeColor = Color.FromArgb(66, 66, 66);
            EmailLbl.ImeMode = ImeMode.NoControl;
            EmailLbl.Location = new Point(110, 342);
            EmailLbl.Margin = new Padding(4, 0, 4, 0);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(53, 20);
            EmailLbl.TabIndex = 21;
            EmailLbl.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.Gray;
            tbEmail.Location = new Point(110, 376);
            tbEmail.Margin = new Padding(4, 4, 4, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(284, 25);
            tbEmail.TabIndex = 20;
            // 
            // tbCP
            // 
            tbCP.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point);
            tbCP.ForeColor = Color.Gray;
            tbCP.Location = new Point(110, 536);
            tbCP.Margin = new Padding(4, 4, 4, 4);
            tbCP.Name = "tbCP";
            tbCP.Size = new Size(284, 25);
            tbCP.TabIndex = 19;
            tbCP.UseSystemPasswordChar = true;
            // 
            // confirmpwLbl
            // 
            confirmpwLbl.AutoSize = true;
            confirmpwLbl.BackColor = Color.Transparent;
            confirmpwLbl.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            confirmpwLbl.ForeColor = Color.FromArgb(66, 66, 66);
            confirmpwLbl.ImeMode = ImeMode.NoControl;
            confirmpwLbl.Location = new Point(110, 502);
            confirmpwLbl.Margin = new Padding(4, 0, 4, 0);
            confirmpwLbl.Name = "confirmpwLbl";
            confirmpwLbl.Size = new Size(153, 20);
            confirmpwLbl.TabIndex = 18;
            confirmpwLbl.Text = "Confirm Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(189, 41);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(306, 694);
            button5.Margin = new Padding(4, 4, 4, 4);
            button5.Name = "button5";
            button5.Size = new Size(44, 44);
            button5.TabIndex = 16;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(232, 694);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(44, 44);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(159, 661);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 14;
            label5.Text = "or continue with";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(159, 694);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(44, 44);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.Gray;
            tbPassword.Location = new Point(110, 461);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(284, 25);
            tbPassword.TabIndex = 9;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.FromArgb(66, 66, 66);
            btn_SignUp.FlatAppearance.BorderSize = 0;
            btn_SignUp.FlatStyle = FlatStyle.Flat;
            btn_SignUp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_SignUp.ForeColor = Color.White;
            btn_SignUp.ImeMode = ImeMode.NoControl;
            btn_SignUp.Location = new Point(128, 590);
            btn_SignUp.Margin = new Padding(4, 4, 4, 4);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(244, 54);
            btn_SignUp.TabIndex = 8;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.Transparent;
            NameLbl.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NameLbl.ForeColor = Color.FromArgb(66, 66, 66);
            NameLbl.ImeMode = ImeMode.NoControl;
            NameLbl.Location = new Point(110, 265);
            NameLbl.Margin = new Padding(4, 0, 4, 0);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(55, 20);
            NameLbl.TabIndex = 7;
            NameLbl.Text = "Name";
            // 
            // pwLbl
            // 
            pwLbl.AutoSize = true;
            pwLbl.BackColor = Color.Transparent;
            pwLbl.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pwLbl.ForeColor = Color.FromArgb(66, 66, 66);
            pwLbl.ImeMode = ImeMode.NoControl;
            pwLbl.Location = new Point(110, 428);
            pwLbl.Margin = new Padding(4, 0, 4, 0);
            pwLbl.Name = "pwLbl";
            pwLbl.Size = new Size(86, 20);
            pwLbl.TabIndex = 6;
            pwLbl.Text = "Password";
            // 
            // tbName
            // 
            tbName.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point);
            tbName.ForeColor = Color.Gray;
            tbName.Location = new Point(110, 299);
            tbName.Margin = new Padding(4, 4, 4, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(284, 25);
            tbName.TabIndex = 4;
            // 
            // SignUpLbl
            // 
            SignUpLbl.AutoSize = true;
            SignUpLbl.BackColor = Color.Transparent;
            SignUpLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpLbl.ForeColor = Color.FromArgb(66, 66, 66);
            SignUpLbl.ImeMode = ImeMode.NoControl;
            SignUpLbl.Location = new Point(110, 208);
            SignUpLbl.Margin = new Padding(4, 0, 4, 0);
            SignUpLbl.Name = "SignUpLbl";
            SignUpLbl.Size = new Size(99, 29);
            SignUpLbl.TabIndex = 0;
            SignUpLbl.Text = "SignUp";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox tbPassword;
        private Button btn_SignUp;
        private Label NameLbl;
        private Label pwLbl;
        private TextBox tbName;
        private Label SignUpLbl;
        private TextBox tbCP;
        private Label confirmpwLbl;
        private Label EmailLbl;
        private TextBox tbEmail;
        private Button button1;
        private LinkLabel linkLog;
        private Label lblLog;
    }
}