using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DAUR
{
    public partial class signupPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public signupPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void signupPage_Load(object sender, EventArgs e)
        {
            // Set round corners for controls
            btn_SignUp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_SignUp.Width, btn_SignUp.Height, 35, 35));
            tbName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbName.Width, tbName.Height, 15, 15));
            tbEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbEmail.Width, tbEmail.Height, 15, 15));
            tbPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbPassword.Width, tbPassword.Height, 15, 15));
            tbCP.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbCP.Width, tbCP.Height, 15, 15));
            signupPnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signupPnl.Width, signupPnl.Height, 25, 25));

        }

        private void signupPnl_Paint(object sender, PaintEventArgs e)
        {
            signupPnl.BackColor = Color.FromArgb(120, 72, 207, 203);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Add signup logic here
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

        private void linkLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLogInPage();
        }

        private void OpenLogInPage()
        {
            loginPage loginForm = new loginPage();
            loginForm.Show();
            this.Hide();
        }
    }
}