namespace DAUR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            label5 = new Label();
            button3 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
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
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1290, 0);
            button1.Name = "button1";
            button1.Size = new Size(76, 59);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(478, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 579);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(252, 486);
            button5.Name = "button5";
            button5.Size = new Size(35, 35);
            button5.TabIndex = 16;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(193, 486);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(134, 460);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 14;
            label5.Text = "or continue with";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(134, 486);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat Black", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(66, 66, 66);
            label4.Location = new Point(89, 366);
            label4.Name = "label4";
            label4.Size = new Size(137, 18);
            label4.TabIndex = 10;
            label4.Text = "Forgot Password?";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(89, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = " password";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(66, 66, 66);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(110, 393);
            button2.Name = "button2";
            button2.Size = new Size(195, 42);
            button2.TabIndex = 8;
            button2.Text = "Sign in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat Black", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(66, 66, 66);
            label3.Location = new Point(89, 229);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 7;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat Black", 7.79999971F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(66, 66, 66);
            label2.Location = new Point(89, 309);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(89, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = " example@gmail.com";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(66, 66, 66);
            label1.Location = new Point(89, 183);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(636, 17);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 2;
            label6.Text = "DAUR App";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1366, 768);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private TextBox textBox2;
        private Button button5;
        private Button button4;
        private Label label5;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label6;
    }
}