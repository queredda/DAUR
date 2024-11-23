namespace DAUR
{
    partial class send
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
            button7 = new Button();
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
            panelForm = new Panel();
            tbBerat = new TextBox();
            btnKirim = new Button();
            labelJenis = new Label();
            labelBerat = new Label();
            tbJenis = new TextBox();
            labelJudul = new Label();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBtn).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.ImeMode = ImeMode.NoControl;
            button7.Location = new Point(1632, -1);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(76, 70);
            button7.TabIndex = 11;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            sidebar.Margin = new Padding(4, 4, 4, 4);
            sidebar.MaximumSize = new Size(225, 960);
            sidebar.MinimumSize = new Size(108, 960);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(115, 960);
            sidebar.TabIndex = 12;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(logoBtn);
            panel3.Location = new Point(4, 4);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(94, 145);
            panel3.TabIndex = 0;
            // 
            // logoBtn
            // 
            logoBtn.Cursor = Cursors.Hand;
            logoBtn.Image = Properties.Resources.Logo_junpro;
            logoBtn.Location = new Point(11, 25);
            logoBtn.Margin = new Padding(4, 4, 4, 4);
            logoBtn.Name = "logoBtn";
            logoBtn.Size = new Size(76, 84);
            logoBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBtn.TabIndex = 0;
            logoBtn.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_dashboard);
            panel4.Location = new Point(4, 157);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(94, 72);
            panel4.TabIndex = 1;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Image = Properties.Resources.btn_dashboard;
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(-9, -10);
            btn_dashboard.Margin = new Padding(4, 4, 4, 4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(38, 0, 0, 0);
            btn_dashboard.Size = new Size(242, 96);
            btn_dashboard.TabIndex = 7;
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Location = new Point(4, 237);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(94, 72);
            panel5.TabIndex = 8;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.btn_order;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-9, -10);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(38, 0, 0, 0);
            button3.Size = new Size(242, 96);
            button3.TabIndex = 7;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(4, 317);
            panel6.Margin = new Padding(4, 4, 4, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(94, 72);
            panel6.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(42, 42, 42);
            button4.Image = Properties.Resources.send_btn;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-9, -10);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(38, 0, 0, 0);
            button4.Size = new Size(242, 96);
            button4.TabIndex = 7;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_profile);
            panel7.Location = new Point(4, 397);
            panel7.Margin = new Padding(4, 4, 4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(94, 72);
            panel7.TabIndex = 8;
            // 
            // btn_profile
            // 
            btn_profile.Image = Properties.Resources.btn_profile;
            btn_profile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_profile.Location = new Point(-9, -10);
            btn_profile.Margin = new Padding(4, 4, 4, 4);
            btn_profile.Name = "btn_profile";
            btn_profile.Padding = new Padding(38, 0, 0, 0);
            btn_profile.Size = new Size(242, 96);
            btn_profile.TabIndex = 7;
            btn_profile.TextAlign = ContentAlignment.MiddleLeft;
            btn_profile.UseVisualStyleBackColor = true;
            btn_profile.Click += btn_profile_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_setting);
            panel8.Location = new Point(4, 477);
            panel8.Margin = new Padding(4, 4, 4, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(94, 72);
            panel8.TabIndex = 8;
            // 
            // btn_setting
            // 
            btn_setting.Image = Properties.Resources.btn_setting;
            btn_setting.ImageAlign = ContentAlignment.MiddleLeft;
            btn_setting.Location = new Point(-9, -10);
            btn_setting.Margin = new Padding(4, 4, 4, 4);
            btn_setting.Name = "btn_setting";
            btn_setting.Padding = new Padding(38, 0, 0, 0);
            btn_setting.Size = new Size(242, 96);
            btn_setting.TabIndex = 7;
            btn_setting.TextAlign = ContentAlignment.MiddleLeft;
            btn_setting.UseVisualStyleBackColor = true;
            btn_setting.Click += btn_setting_Click;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(tbBerat);
            panelForm.Controls.Add(btnKirim);
            panelForm.Controls.Add(labelJenis);
            panelForm.Controls.Add(labelBerat);
            panelForm.Controls.Add(tbJenis);
            panelForm.Controls.Add(labelJudul);
            panelForm.Location = new Point(594, 215);
            panelForm.Margin = new Padding(4, 4, 4, 4);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(521, 530);
            panelForm.TabIndex = 13;
            panelForm.Paint += panelForm_Paint;
            // 
            // tbBerat
            // 
            tbBerat.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbBerat.ForeColor = Color.Gray;
            tbBerat.Location = new Point(109, 288);
            tbBerat.Margin = new Padding(4, 4, 4, 4);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(284, 32);
            tbBerat.TabIndex = 9;
            // 
            // btnKirim
            // 
            btnKirim.BackColor = Color.FromArgb(66, 66, 66);
            btnKirim.FlatAppearance.BorderSize = 0;
            btnKirim.FlatStyle = FlatStyle.Flat;
            btnKirim.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKirim.ForeColor = Color.White;
            btnKirim.ImeMode = ImeMode.NoControl;
            btnKirim.Location = new Point(131, 360);
            btnKirim.Margin = new Padding(4, 4, 4, 4);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(244, 54);
            btnKirim.TabIndex = 8;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = false;
            btnKirim.Click += btnKirim_Click;
            // 
            // labelJenis
            // 
            labelJenis.AutoSize = true;
            labelJenis.BackColor = Color.Transparent;
            labelJenis.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelJenis.ForeColor = Color.FromArgb(66, 66, 66);
            labelJenis.ImeMode = ImeMode.NoControl;
            labelJenis.Location = new Point(109, 165);
            labelJenis.Margin = new Padding(4, 0, 4, 0);
            labelJenis.Name = "labelJenis";
            labelJenis.Size = new Size(122, 20);
            labelJenis.TabIndex = 7;
            labelJenis.Text = "Jenis Sampah";
            // 
            // labelBerat
            // 
            labelBerat.AutoSize = true;
            labelBerat.BackColor = Color.Transparent;
            labelBerat.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelBerat.ForeColor = Color.FromArgb(66, 66, 66);
            labelBerat.ImeMode = ImeMode.NoControl;
            labelBerat.Location = new Point(109, 256);
            labelBerat.Margin = new Padding(4, 0, 4, 0);
            labelBerat.Name = "labelBerat";
            labelBerat.Size = new Size(91, 20);
            labelBerat.TabIndex = 6;
            labelBerat.Text = "Berat (Kg)";
            // 
            // tbJenis
            // 
            tbJenis.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbJenis.ForeColor = Color.Gray;
            tbJenis.Location = new Point(109, 199);
            tbJenis.Margin = new Padding(4, 4, 4, 4);
            tbJenis.Name = "tbJenis";
            tbJenis.Size = new Size(284, 32);
            tbJenis.TabIndex = 4;
            tbJenis.TextChanged += tbJenis_TextChanged;
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.BackColor = Color.Transparent;
            labelJudul.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.FromArgb(66, 66, 66);
            labelJudul.ImeMode = ImeMode.NoControl;
            labelJudul.Location = new Point(152, 76);
            labelJudul.Margin = new Padding(4, 0, 4, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(187, 32);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Send Waste!";
            // 
<<<<<<< HEAD
=======
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.FromArgb(229, 232, 235);
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(guna2Button4);
            guna2Panel1.Controls.Add(btnDashboard);
            guna2Panel1.Controls.Add(btnSend);
            guna2Panel1.Controls.Add(btnProfile);
            guna2Panel1.Controls.Add(btnSetting);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Location = new Point(0, -1);
            guna2Panel1.Margin = new Padding(4, 4, 4, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(106, 962);
            guna2Panel1.TabIndex = 23;
            // 
            // guna2Button4
            // 
            guna2Button4.BorderRadius = 12;
            guna2Button4.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage");
            guna2Button4.CustomizableEdges = customizableEdges1;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.White;
            guna2Button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Image = Properties.Resources.Logo_junpro;
            guna2Button4.ImageSize = new Size(50, 50);
            guna2Button4.Location = new Point(15, 30);
            guna2Button4.Margin = new Padding(4, 4, 4, 4);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button4.Size = new Size(72, 70);
            guna2Button4.TabIndex = 14;
            // 
            // btnDashboard
            // 
            btnDashboard.BorderRadius = 12;
            btnDashboard.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage1");
            btnDashboard.CustomizableEdges = customizableEdges3;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.White;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.btn_dashboard;
            btnDashboard.ImageSize = new Size(26, 26);
            btnDashboard.Location = new Point(15, 189);
            btnDashboard.Margin = new Padding(4, 4, 4, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDashboard.Size = new Size(72, 70);
            btnDashboard.TabIndex = 13;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSend
            // 
            btnSend.BorderRadius = 12;
            btnSend.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage2");
            btnSend.CustomizableEdges = customizableEdges5;
            btnSend.DisabledState.BorderColor = Color.DarkGray;
            btnSend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSend.FillColor = Color.FromArgb(42, 42, 42);
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Image = Properties.Resources.Send;
            btnSend.ImageSize = new Size(26, 26);
            btnSend.Location = new Point(15, 266);
            btnSend.Margin = new Padding(4, 4, 4, 4);
            btnSend.Name = "btnSend";
            btnSend.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSend.Size = new Size(72, 70);
            btnSend.TabIndex = 12;
            // 
            // btnProfile
            // 
            btnProfile.BorderRadius = 12;
            btnProfile.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage3");
            btnProfile.CustomizableEdges = customizableEdges7;
            btnProfile.DisabledState.BorderColor = Color.DarkGray;
            btnProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProfile.FillColor = Color.White;
            btnProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = Properties.Resources.btn_profile;
            btnProfile.ImageSize = new Size(26, 26);
            btnProfile.Location = new Point(15, 344);
            btnProfile.Margin = new Padding(4, 4, 4, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnProfile.Size = new Size(72, 70);
            btnProfile.TabIndex = 11;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnSetting
            // 
            btnSetting.BorderRadius = 12;
            btnSetting.CustomImages.CheckedImage = (Image)resources.GetObject("resource.CheckedImage4");
            btnSetting.CustomizableEdges = customizableEdges9;
            btnSetting.DisabledState.BorderColor = Color.DarkGray;
            btnSetting.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSetting.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSetting.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSetting.FillColor = Color.White;
            btnSetting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = Color.White;
            btnSetting.Image = Properties.Resources.btn_setting;
            btnSetting.ImageSize = new Size(26, 26);
            btnSetting.Location = new Point(15, 421);
            btnSetting.Margin = new Padding(4, 4, 4, 4);
            btnSetting.Name = "btnSetting";
            btnSetting.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSetting.Size = new Size(72, 70);
            btnSetting.TabIndex = 10;
            // 
>>>>>>> ed45a1ca7596b15229ffd944d5c908d9bf55328a
            // send
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(1708, 960);
=======
            BackColor = Color.White;
            ClientSize = new Size(1708, 960);
            Controls.Add(guna2Panel1);
>>>>>>> ed45a1ca7596b15229ffd944d5c908d9bf55328a
            Controls.Add(panelForm);
            Controls.Add(sidebar);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            MaximumSize = new Size(1708, 960);
            MinimumSize = new Size(1708, 960);
            Name = "send";
            Text = "send";
            Load += send_Load;
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBtn).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panelForm;
        private TextBox tbBerat;
        private Button btnKirim;
        private Label labelJenis;
        private Label labelBerat;
        private TextBox tbJenis;
        private Label labelJudul;
    }
}