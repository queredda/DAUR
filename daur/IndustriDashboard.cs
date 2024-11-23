using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAUR
{
    public partial class IndustriDashboard : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
        public static NpgsqlCommand cmd;
        private string sql = null;
        public IndustriDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newDashboard_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                // Open the database connection
                conn.Open();

                // SQL query to fetch the user's name based on the logged-in email
                sql = "SELECT * FROM pelaku_industri WHERE email = @email";
                cmd = new NpgsqlCommand(sql, conn);

                // Replace with the email of the logged-in user (stored during login)
                cmd.Parameters.AddWithValue("email", loginPage.loggedInEmail); // Assume loggedInEmail stores the email of the logged-in user

                // Execute the query and fetch the result
                string userName = cmd.ExecuteScalar()?.ToString();

                if (!string.IsNullOrEmpty(userName))
                {
                    // Display the user's name on the dashboard
                    guna2HtmlLabel6.Text = $"Welcome, {userName}!";
                }
                else
                {
                    // Fallback if no name is found
                    guna2HtmlLabel6.Text = "Welcome!";
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show($"An error occurred while fetching the user name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OpenSend()
        {
            send send = new send();
            send.Show();
            this.Close();
        }
        private void OpenSetting()
        {
            setting setting = new setting();
            setting.Show();
            this.Close();
        }
        private void OpenProfile()
        {
            Profile Profile = new Profile();
            Profile.Show();
            this.Close();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            OpenSend();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenSetting();
        }
    }
}
