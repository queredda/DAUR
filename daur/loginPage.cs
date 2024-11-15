using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Npgsql;


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
            panel1.BackColor = Color.FromArgb(120, 72, 207, 203);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 35, 35));
            tbEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbEmail.Width, tbEmail.Height, 15, 15));
            tbPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbPassword.Width, tbPassword.Height, 15, 15));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
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
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}