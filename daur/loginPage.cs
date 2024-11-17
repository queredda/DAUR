using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Npgsql;
using System.Drawing.Drawing2D;


namespace DAUR
{
    public partial class loginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public loginPage()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;

            this.Controls.Add(button1);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Gainsboro;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color shadowColor = Color.FromArgb(255, 0, 0, 0); // A semi-transparent dark color for shadow effect
            panel1.BackColor = Color.FromArgb(255, 250, 250, 250);
            Color borderColor = Color.FromArgb(236, 233, 254); // #ECE9FE

            using (Pen borderPen = new Pen(borderColor, 4)) // 4px border width
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, panel1.Width, panel1.Height);
            }

            using (Pen borderPen = new Pen(borderColor, 2)) // 2px border width
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Define the rounded rectangle path
                    path.AddArc(0, 0, 20, 20, 180, 90);  // Top-left corner
                    path.AddArc(panel1.Width - 20, 0, 20, 20, 270, 90);  // Top-right corner
                    path.AddArc(panel1.Width - 20, panel1.Height - 20, 20, 20, 0, 90);  // Bottom-right corner
                    path.AddArc(0, panel1.Height - 20, 20, 20, 90, 90);  // Bottom-left corner
                    path.CloseFigure();

                    // Draw the border
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 40, 40));
            tbEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbEmail.Width, tbEmail.Height, 35, 35));
            tbPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbPassword.Width, tbPassword.Height, 35, 35));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
            this.BackColor = Color.FromArgb(249, 250, 251);
            tbEmail.Padding = new Padding(10, 0, 10, 0); // Left and Right Padding: 10px, Top and Bottom Padding: 0px
            tbPassword.Padding = new Padding(10, 0, 10, 0); // Same padding for password textbox

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenSignUpPage();
        }
        private void OpenSignUpPage()
        {
            signupPage signUpForm = new signupPage();
            signUpForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }

        private void OpenDashboard()
        {
            newDashboard newdashboard = new newDashboard();
            newdashboard.Show();
            this.Hide();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}