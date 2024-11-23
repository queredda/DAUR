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
        string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
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



        private void tbName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click_1(object sender, EventArgs e)
        {
            if (tbPassword.Text != tbCP.Text)
            {
                MessageBox.Show("Passwords do not match!", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbCollector.Checked && !rbIndustri.Checked)
            {
                MessageBox.Show("Please select a role!", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Initialize the connection
                conn = new NpgsqlConnection(connstring);
                conn.Open();

                string sql = null;

                // Depending on the role selected, choose the appropriate SQL command
                if (rbCollector.Checked)
                {
                    sql = @"SELECT * FROM collector_insert(:_name, :_email, :_password, :_role)";
                }
                else if (rbIndustri.Checked)
                {
                    sql = @"SELECT * FROM industry_insert(:_name, :_email, :_password, :_role)";
                }

                // Create the command
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Adding parameters
                    cmd.Parameters.AddWithValue("_name", tbName.Text);
                    cmd.Parameters.AddWithValue("_email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("_password", tbPassword.Text);

                    // Determine role based on the selected radio button
                    string role = rbCollector.Checked ? "Collector" : "Industri";
                    cmd.Parameters.AddWithValue("_role", role);

                    // Execute the command and get the result
                    int result = (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        MessageBox.Show($"Sign Up for {role} Successful!", "Sign Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear input fields after successful sign-up
                        tbName.Text = tbEmail.Text = tbPassword.Text = tbCP.Text = string.Empty;
                        rbCollector.Checked = rbIndustri.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Sign Up Failed. Please try again.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Close the connection if it's open
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }
}