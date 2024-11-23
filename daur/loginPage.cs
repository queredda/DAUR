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
            string email = tbEmail.Text; // Get email from the textbox
            string password = tbPassword.Text; // Get password from the textbox

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Open connection
                conn.Open();

                // SQL query to check if the user exists with the given email and password
                string sql = @"
            SELECT 
                industri_id AS user_id, 
                email, 
                password, 
                role, 
                'Industri' AS user_type -- This indicates the user is from pelaku_industri
            FROM 
                pelaku_industri 
            WHERE 
                email = @email AND password = @password

            UNION

            SELECT 
                collector_id AS user_id, 
                email, 
                password, 
                role, 
                'Collector' AS user_type -- This indicates the user is from waste_collector
            FROM 
                waste_collector 
            WHERE 
                email = @email AND password = @password;
        ";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Parameterized query to prevent SQL Injection
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);

                    // Execute query
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string userType = reader["user_type"].ToString(); // This tells if the user is from pelaku_industri or waste_collector
                            string role = reader["role"].ToString(); // Get the user's role
                            int userId = Convert.ToInt32(reader["user_id"]); // The user_id (either industri_id or collector_id)

                            // Set session or static variable based on user type
                            if (userType == "Industri")
                            {
                                // Set the logged-in user's id for industri
                                UserSession.LoggedInIndustryID = userId;

                                // Navigate to the Industri dashboard
                                NavigatePage.OpenForm<IndustriDashboard>(this);
                            }
                            else if (userType == "Collector")
                            {
                                // Set the logged-in user's id for collector
                                UserSession.LoggedInCollectorID = userId;

                                // Navigate to the Collector dashboard
                                NavigatePage.OpenForm<PengepulDashboard>(this);
                            }
                            else
                            {
                                MessageBox.Show("Unknown role. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Invalid credentials
                            MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}