namespace DAUR
{
    partial class Profile
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
            button1 = new Button();
            panel1 = new Panel();
            sidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            logoBtn = new PictureBox();
            panel4 = new Panel();
            btn_dashboard = new Button();
            panel5 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            button4 = new Button();
            panel7 = new Panel();
            btn_profile = new Button();
            panel8 = new Panel();
            btn_setting = new Button();
            button7 = new Button();
            pnl_profile = new Panel();
            lblRole = new Label();
            role_role = new Label();
            lblEmail = new Label();
            email_email = new Label();
            pictureBox1 = new PictureBox();
            urProfile = new Label();
            panel1.SuspendLayout();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBtn).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            pnl_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            button1.Location = new Point(1307, -1);
            button1.Name = "button1";
            button1.Size = new Size(61, 56);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(sidebar);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(pnl_profile);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1366, 768);
            panel1.MinimumSize = new Size(1366, 768);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 10;
            // 
            // sidebar
            // 
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel8);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(180, 768);
            sidebar.MinimumSize = new Size(86, 768);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(92, 768);
            sidebar.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(logoBtn);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(75, 116);
            panel3.TabIndex = 0;
            // 
            // logoBtn
            // 
            logoBtn.Cursor = Cursors.Hand;
            logoBtn.Image = Properties.Resources.Logo_junpro;
            logoBtn.Location = new Point(9, 20);
            logoBtn.Name = "logoBtn";
            logoBtn.Size = new Size(61, 67);
            logoBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBtn.TabIndex = 0;
            logoBtn.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_dashboard);
            panel4.Location = new Point(3, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(75, 58);
            panel4.TabIndex = 1;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Image = Properties.Resources.btn_dashboard;
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(-7, -8);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(30, 0, 0, 0);
            btn_dashboard.Size = new Size(194, 77);
            btn_dashboard.TabIndex = 7;
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Location = new Point(3, 189);
            panel5.Name = "panel5";
            panel5.Size = new Size(75, 58);
            panel5.TabIndex = 8;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.btn_order;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-7, -8);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(194, 77);
            button3.TabIndex = 7;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 253);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 58);
            panel6.TabIndex = 8;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.send_btn;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-7, -8);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(194, 77);
            button4.TabIndex = 7;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_profile);
            panel7.Location = new Point(3, 317);
            panel7.Name = "panel7";
            panel7.Size = new Size(75, 58);
            panel7.TabIndex = 8;
            // 
            // btn_profile
            // 
            btn_profile.Image = Properties.Resources.btn_profile;
            btn_profile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_profile.Location = new Point(-7, -8);
            btn_profile.Name = "btn_profile";
            btn_profile.Padding = new Padding(30, 0, 0, 0);
            btn_profile.Size = new Size(194, 77);
            btn_profile.TabIndex = 7;
            btn_profile.TextAlign = ContentAlignment.MiddleLeft;
            btn_profile.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_setting);
            panel8.Location = new Point(3, 381);
            panel8.Name = "panel8";
            panel8.Size = new Size(75, 58);
            panel8.TabIndex = 8;
            // 
            // btn_setting
            // 
            btn_setting.Image = Properties.Resources.btn_setting;
            btn_setting.ImageAlign = ContentAlignment.MiddleLeft;
            btn_setting.Location = new Point(-7, -8);
            btn_setting.Name = "btn_setting";
            btn_setting.Padding = new Padding(30, 0, 0, 0);
            btn_setting.Size = new Size(194, 77);
            btn_setting.TabIndex = 7;
            btn_setting.TextAlign = ContentAlignment.MiddleLeft;
            btn_setting.UseVisualStyleBackColor = true;
            btn_setting.Click += btn_setting_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.ImeMode = ImeMode.NoControl;
            button7.Location = new Point(1305, -2);
            button7.Name = "button7";
            button7.Size = new Size(61, 56);
            button7.TabIndex = 7;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pnl_profile
            // 
            pnl_profile.Controls.Add(lblRole);
            pnl_profile.Controls.Add(role_role);
            pnl_profile.Controls.Add(lblEmail);
            pnl_profile.Controls.Add(email_email);
            pnl_profile.Controls.Add(pictureBox1);
            pnl_profile.Controls.Add(urProfile);
            pnl_profile.Location = new Point(140, 113);
            pnl_profile.Name = "pnl_profile";
            pnl_profile.Size = new Size(848, 579);
            pnl_profile.TabIndex = 0;
            pnl_profile.Paint += pnl_profile_Paint;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.Location = new Point(174, 413);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(126, 21);
            lblRole.TabIndex = 5;
            lblRole.Text = "Pelaku Industri";
            // 
            // role_role
            // 
            role_role.AutoSize = true;
            role_role.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            role_role.Location = new Point(174, 379);
            role_role.Name = "role_role";
            role_role.Size = new Size(44, 21);
            role_role.TabIndex = 4;
            role_role.Text = "Role";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(174, 330);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(161, 21);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "snroha@gmail.com";
            // 
            // email_email
            // 
            email_email.AutoSize = true;
            email_email.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            email_email.Location = new Point(174, 290);
            email_email.Name = "email_email";
            email_email.Size = new Size(53, 21);
            email_email.TabIndex = 2;
            email_email.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(357, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 133);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // urProfile
            // 
            urProfile.AutoSize = true;
            urProfile.Font = new Font("Montserrat ExtraBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            urProfile.Location = new Point(342, 34);
            urProfile.Name = "urProfile";
            urProfile.Size = new Size(207, 41);
            urProfile.TabIndex = 0;
            urProfile.Text = "Your Profile";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 768);
            Name = "Profile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBtn).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            pnl_profile.ResumeLayout(false);
            pnl_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Panel pnl_profile;
        private Label urProfile;
        private Label lblEmail;
        private Label email_email;
        private PictureBox pictureBox1;
        private Label lblRole;
        private Label role_role;
        private Button button7;
        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private PictureBox logoBtn;
        private Panel panel4;
        private Button btn_dashboard;
        private Panel panel5;
        private Button button3;
        private Panel panel6;
        private Button button4;
        private Panel panel7;
        private Button btn_profile;
        private Panel panel8;
        private Button btn_setting;
    }
}