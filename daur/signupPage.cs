using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;
using System.Data;

namespace DAUR
{
    public partial class signupPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private NpgsqlConnection conn;
        string connstring = "Host = localhost; Port = 5432; Username = postgres; Password = HusnaYTB223; Database = DAUR";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        public signupPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void signupPage_Load(object sender, EventArgs e)
        {
            btn_SignUp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_SignUp.Width, btn_SignUp.Height, 35, 35));
            tbName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbName.Width, tbName.Height, 15, 15));
            tbEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbEmail.Width, tbEmail.Height, 15, 15));
            tbPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbPassword.Width, tbPassword.Height, 15, 15));
            tbCP.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbCP.Width, tbCP.Height, 15, 15));
            signupPnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signupPnl.Width, signupPnl.Height, 25, 25));
            conn = new NpgsqlConnection(connstring);

        }

        private void signupPnl_Paint(object sender, PaintEventArgs e)
        {
            signupPnl.BackColor = Color.FromArgb(120, 72, 207, 203);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
           
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

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"select * from acc_insert(:_name, :_email, :_password)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_name", tbName.Text);
            cmd.Parameters.AddWithValue("_email", tbEmail.Text);
            cmd.Parameters.AddWithValue("_password", tbPassword.Text);
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Sign Up Successful!", "Sign Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                tbName.Text = tbEmail.Text = tbPassword.Text = tbCP.Text = null;
            }
        }
    }
}