namespace DAUR
{
    partial class setting
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
            sidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            logoBtn = new PictureBox();
            panel4 = new Panel();
            btn_dashboard = new Button();
            panel5 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            btn_send = new Button();
            panel7 = new Panel();
            btn_profile = new Button();
            panel8 = new Panel();
            button6 = new Button();
            button7 = new Button();
            lbl_weather = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button5 = new Button();
            label4 = new Label();
            button8 = new Button();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBtn).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
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
            sidebar.Paint += sidebar_Paint;
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
            btn_dashboard.Click += btn_dashboard_Click;
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
            panel6.Controls.Add(btn_send);
            panel6.Location = new Point(3, 253);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 58);
            panel6.TabIndex = 8;
            // 
            // btn_send
            // 
            btn_send.Image = Properties.Resources.send_btn;
            btn_send.ImageAlign = ContentAlignment.MiddleLeft;
            btn_send.Location = new Point(-7, -8);
            btn_send.Name = "btn_send";
            btn_send.Padding = new Padding(30, 0, 0, 0);
            btn_send.Size = new Size(194, 77);
            btn_send.TabIndex = 7;
            btn_send.TextAlign = ContentAlignment.MiddleLeft;
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
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
            btn_profile.Click += btn_profile_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button6);
            panel8.Location = new Point(3, 381);
            panel8.Name = "panel8";
            panel8.Size = new Size(75, 58);
            panel8.TabIndex = 8;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.btn_setting;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-7, -8);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 0, 0);
            button6.Size = new Size(194, 77);
            button6.TabIndex = 7;
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
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
            button7.Location = new Point(1306, -2);
            button7.Name = "button7";
            button7.Size = new Size(61, 56);
            button7.TabIndex = 10;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // lbl_weather
            // 
            lbl_weather.AutoSize = true;
            lbl_weather.BackColor = Color.Transparent;
            lbl_weather.Font = new Font("Montserrat SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_weather.Location = new Point(217, 51);
            lbl_weather.Name = "lbl_weather";
            lbl_weather.Size = new Size(174, 55);
            lbl_weather.TabIndex = 11;
            lbl_weather.Text = "Setting";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 309);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 12;
            label1.Text = "Edit username";
            // 
            // button1
            // 
            button1.Location = new Point(900, 301);
            button1.Name = "button1";
            button1.Size = new Size(139, 50);
            button1.TabIndex = 13;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(217, 394);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 14;
            label2.Text = "Change Password";
            // 
            // button2
            // 
            button2.Location = new Point(900, 381);
            button2.Name = "button2";
            button2.Size = new Size(139, 50);
            button2.TabIndex = 15;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 486);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 16;
            label3.Text = "Edit bio";
            // 
            // button5
            // 
            button5.Location = new Point(900, 478);
            button5.Name = "button5";
            button5.Size = new Size(139, 50);
            button5.TabIndex = 17;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(217, 219);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 18;
            label4.Text = "View Profiles";
            // 
            // button8
            // 
            button8.Location = new Point(900, 211);
            button8.Name = "button8";
            button8.Size = new Size(139, 50);
            button8.TabIndex = 19;
            button8.Text = "View";
            button8.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(button8);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lbl_weather);
            Controls.Add(button7);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "setting";
            Text = " ";
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBtn).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private PictureBox logoBtn;
        private Panel panel4;
        private Button btn_dashboard;
        private Panel panel5;
        private Button button3;
        private Panel panel6;
        private Button btn_send;
        private Panel panel7;
        private Button btn_profile;
        private Panel panel8;
        private Button button6;
        private Button button7;
        private Label lbl_weather;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button5;
        private Label label4;
        private Button button8;
    }
}