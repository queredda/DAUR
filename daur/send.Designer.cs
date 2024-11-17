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
            button7.Location = new Point(1306, -1);
            button7.Name = "button7";
            button7.Size = new Size(61, 56);
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
            sidebar.MaximumSize = new Size(180, 768);
            sidebar.MinimumSize = new Size(86, 768);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(92, 768);
            sidebar.TabIndex = 12;
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
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 253);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 58);
            panel6.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(42, 42, 42);
            button4.Image = Properties.Resources.send_btn;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-7, -8);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(194, 77);
            button4.TabIndex = 7;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
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
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(tbBerat);
            panelForm.Controls.Add(btnKirim);
            panelForm.Controls.Add(labelJenis);
            panelForm.Controls.Add(labelBerat);
            panelForm.Controls.Add(tbJenis);
            panelForm.Controls.Add(labelJudul);
            panelForm.Location = new Point(475, 172);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(417, 424);
            panelForm.TabIndex = 13;
            panelForm.Paint += panelForm_Paint;
            // 
            // tbBerat
            // 
            tbBerat.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbBerat.ForeColor = Color.Gray;
            tbBerat.Location = new Point(87, 230);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(228, 29);
            tbBerat.TabIndex = 9;
            // 
            // btnKirim
            // 
            btnKirim.BackColor = Color.FromArgb(66, 66, 66);
            btnKirim.FlatAppearance.BorderSize = 0;
            btnKirim.FlatStyle = FlatStyle.Flat;
            btnKirim.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKirim.ForeColor = Color.White;
            btnKirim.ImeMode = ImeMode.NoControl;
            btnKirim.Location = new Point(105, 288);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(195, 43);
            btnKirim.TabIndex = 8;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = false;
            // 
            // labelJenis
            // 
            labelJenis.AutoSize = true;
            labelJenis.BackColor = Color.Transparent;
            labelJenis.Font = new Font("Montserrat", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelJenis.ForeColor = Color.FromArgb(66, 66, 66);
            labelJenis.ImeMode = ImeMode.NoControl;
            labelJenis.Location = new Point(87, 132);
            labelJenis.Name = "labelJenis";
            labelJenis.Size = new Size(104, 20);
            labelJenis.TabIndex = 7;
            labelJenis.Text = "Jenis Sampah";
            // 
            // labelBerat
            // 
            labelBerat.AutoSize = true;
            labelBerat.BackColor = Color.Transparent;
            labelBerat.Font = new Font("Montserrat", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelBerat.ForeColor = Color.FromArgb(66, 66, 66);
            labelBerat.ImeMode = ImeMode.NoControl;
            labelBerat.Location = new Point(87, 205);
            labelBerat.Name = "labelBerat";
            labelBerat.Size = new Size(80, 20);
            labelBerat.TabIndex = 6;
            labelBerat.Text = "Berat (Kg)";
            // 
            // tbJenis
            // 
            tbJenis.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbJenis.ForeColor = Color.Gray;
            tbJenis.Location = new Point(87, 159);
            tbJenis.Name = "tbJenis";
            tbJenis.Size = new Size(228, 29);
            tbJenis.TabIndex = 4;
            tbJenis.TextChanged += tbJenis_TextChanged;
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.BackColor = Color.Transparent;
            labelJudul.Font = new Font("Montserrat", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.FromArgb(66, 66, 66);
            labelJudul.ImeMode = ImeMode.NoControl;
            labelJudul.Location = new Point(122, 61);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(168, 36);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Send Waste!";
            // 
            // send
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(1366, 768);
            Controls.Add(panelForm);
            Controls.Add(sidebar);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
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