using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Npgsql;
using System.Drawing.Drawing2D;
using System.Data;


namespace DAUR
{
    public partial class loginPage : Form
    {
        public static string loggedInEmail;

        private NpgsqlConnection conn;
        string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
        public static NpgsqlCommand cmd;
        private string sql = null;


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string sql = @"
                SELECT 
                    CASE 
                        WHEN pi.industri_id IS NOT NULL THEN pi.industri_id 
                        ELSE wc.collector_id 
                    END AS user_id,
                    CASE 
                        WHEN pi.industri_id IS NOT NULL THEN pi.name
                        ELSE wc.name
                    END AS name,
                    CASE 
                        WHEN pi.industri_id IS NOT NULL THEN 'Industri'
                        ELSE 'Collector'
                    END AS user_type,
                    COALESCE(pi.email, wc.email) as email
                FROM (
                    SELECT industri_id, name, email FROM pelaku_industri 
                    WHERE email = @email AND password = @password
                ) pi
                FULL OUTER JOIN (
                    SELECT collector_id, name, email FROM waste_collector 
                    WHERE email = @email AND password = @password
                ) wc ON FALSE";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string userName = reader.GetString(1);
                                string userType = reader.GetString(2);
                                string userEmail = reader.GetString(3);

                                if (userType == "Industri")
                                {
                                    UserSession.SetIndustryUser(userId, userEmail, userName);
                                    NavigatePage.OpenForm<IndustriDashboard>(this);
                                }
                                else
                                {
                                    UserSession.SetCollectorUser(userId, userEmail, userName);
                                    NavigatePage.OpenForm<PengepulDashboard>(this);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}