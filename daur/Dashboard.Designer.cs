﻿namespace DAUR
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            nav_pnl = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            main_pnl = new Panel();
            panel2 = new Panel();
            pnl_artikel = new Panel();
            label3 = new Label();
            pnl_weather = new Panel();
            lbl_weather = new Label();
            today_weather = new Label();
            pictureBox5 = new PictureBox();
            pnl_waste = new Panel();
            total_waste = new Label();
            lbl_waste = new Label();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            nav_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            main_pnl.SuspendLayout();
            panel2.SuspendLayout();
            pnl_weather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnl_waste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Tipen";
            // 
            // nav_pnl
            // 
            nav_pnl.BackColor = Color.White;
            nav_pnl.Controls.Add(button6);
            nav_pnl.Controls.Add(button5);
            nav_pnl.Controls.Add(button4);
            nav_pnl.Controls.Add(button3);
            nav_pnl.Controls.Add(button2);
            nav_pnl.Controls.Add(pictureBox1);
            nav_pnl.Location = new Point(-8, -6);
            nav_pnl.Name = "nav_pnl";
            nav_pnl.Size = new Size(125, 780);
            nav_pnl.TabIndex = 1;
            nav_pnl.Paint += nav_pnl_Paint;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.btn_setting;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(51, 536);
            button6.Name = "button6";
            button6.Size = new Size(31, 31);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.btn_profile;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(51, 461);
            button5.Name = "button5";
            button5.Size = new Size(31, 31);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.send_btn;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(51, 386);
            button4.Name = "button4";
            button4.Size = new Size(31, 31);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.btn_order;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(51, 311);
            button3.Name = "button3";
            button3.Size = new Size(31, 31);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(51, 236);
            button2.Name = "button2";
            button2.Size = new Size(31, 31);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // main_pnl
            // 
            main_pnl.Controls.Add(panel2);
            main_pnl.Controls.Add(pnl_weather);
            main_pnl.Controls.Add(pnl_waste);
            main_pnl.Location = new Point(117, 119);
            main_pnl.Name = "main_pnl";
            main_pnl.Size = new Size(1254, 655);
            main_pnl.TabIndex = 2;
            main_pnl.Paint += main_pnl_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button9);
            panel2.Controls.Add(pnl_artikel);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(47, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 318);
            panel2.TabIndex = 3;
            // 
            // pnl_artikel
            // 
            pnl_artikel.Location = new Point(0, 78);
            pnl_artikel.Name = "pnl_artikel";
            pnl_artikel.Size = new Size(1130, 240);
            pnl_artikel.TabIndex = 2;
            pnl_artikel.Paint += pnl_artikel_Paint_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 24);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 1;
            label3.Text = "Article";
            // 
            // pnl_weather
            // 
            pnl_weather.BackColor = Color.WhiteSmoke;
            pnl_weather.Controls.Add(button8);
            pnl_weather.Controls.Add(lbl_weather);
            pnl_weather.Controls.Add(today_weather);
            pnl_weather.Controls.Add(pictureBox5);
            pnl_weather.Location = new Point(642, 44);
            pnl_weather.Name = "pnl_weather";
            pnl_weather.Size = new Size(535, 248);
            pnl_weather.TabIndex = 1;
            // 
            // lbl_weather
            // 
            lbl_weather.AutoSize = true;
            lbl_weather.BackColor = Color.Transparent;
            lbl_weather.Font = new Font("Montserrat SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_weather.Location = new Point(30, 142);
            lbl_weather.Name = "lbl_weather";
            lbl_weather.Size = new Size(153, 55);
            lbl_weather.TabIndex = 3;
            lbl_weather.Text = "Sunny";
            // 
            // today_weather
            // 
            today_weather.AutoSize = true;
            today_weather.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            today_weather.Location = new Point(36, 114);
            today_weather.Name = "today_weather";
            today_weather.Size = new Size(136, 21);
            today_weather.TabIndex = 2;
            today_weather.Text = "Today's Weather";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.weather_icon;
            pictureBox5.Location = new Point(36, 24);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pnl_waste
            // 
            pnl_waste.BackColor = Color.WhiteSmoke;
            pnl_waste.Controls.Add(button7);
            pnl_waste.Controls.Add(total_waste);
            pnl_waste.Controls.Add(lbl_waste);
            pnl_waste.Controls.Add(pictureBox4);
            pnl_waste.Location = new Point(47, 44);
            pnl_waste.Name = "pnl_waste";
            pnl_waste.Size = new Size(535, 248);
            pnl_waste.TabIndex = 0;
            // 
            // total_waste
            // 
            total_waste.AutoSize = true;
            total_waste.BackColor = Color.Transparent;
            total_waste.Font = new Font("Montserrat SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            total_waste.Location = new Point(30, 142);
            total_waste.Name = "total_waste";
            total_waste.Size = new Size(47, 55);
            total_waste.TabIndex = 2;
            total_waste.Text = "5";
            // 
            // lbl_waste
            // 
            lbl_waste.AutoSize = true;
            lbl_waste.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_waste.Location = new Point(30, 114);
            lbl_waste.Name = "lbl_waste";
            lbl_waste.Size = new Size(96, 21);
            lbl_waste.TabIndex = 1;
            lbl_waste.Text = "Waste Sent";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.send_icon;
            pictureBox4.Location = new Point(30, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(859, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 26);
            textBox1.TabIndex = 3;
            textBox1.Text = "Search here";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.MouseClick += textBox1_MouseClick;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1181, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1255, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
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
            button1.Location = new Point(1309, -2);
            button1.Name = "button1";
            button1.Size = new Size(61, 56);
            button1.TabIndex = 6;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(117, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 76);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources._3dot;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(484, 24);
            button7.Name = "button7";
            button7.Size = new Size(24, 24);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources._3dot;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(486, 24);
            button8.Name = "button8";
            button8.Size = new Size(24, 24);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImage = Properties.Resources._3dot;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(1081, 30);
            button9.Name = "button9";
            button9.Size = new Size(24, 24);
            button9.TabIndex = 7;
            button9.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(nav_pnl);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(main_pnl);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 768);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            nav_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            main_pnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnl_weather.ResumeLayout(false);
            pnl_weather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnl_waste.ResumeLayout(false);
            pnl_waste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel nav_pnl;
        private Panel main_pnl;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel pnl_waste;
        private Panel pnl_weather;
        private PictureBox pictureBox5;
        private Label lbl_waste;
        private PictureBox pictureBox4;
        private Label lbl_weather;
        private Label today_weather;
        private Label total_waste;
        private Panel panel2;
        private Label label3;
        private Panel pnl_artikel;
        private Button button9;
        private Button button8;
        private Button button7;
    }
}