using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DAUR
{
    public partial class setting : Form
    {
        private string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
        private NpgsqlConnection conn;
        public setting()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();

        }
        private void OpenDashboard()
        {
            IndustriDashboard newDashboard = new IndustriDashboard();
            newDashboard.Show();
            this.Close();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            OpenProfile();

        }
        private void OpenProfile()
        {
            Profile Profile = new Profile();
            Profile.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            OpenSend();
        }

        private void OpenSend()
        {
            send send = new send();
            send.Show();
            this.Close();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int borderWidth = 1;
            Color borderColor = ColorTranslator.FromHtml("#48CFCB");
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, panel.Width - 1, panel.Height - 1));
            }
        }


        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            Color shadowColor = Color.FromArgb(255, 0, 0, 0); // A semi-transparent dark color for shadow effect
            pnlSetting.BackColor = Color.FromArgb(255, 250, 250, 250);
            Color borderColor = Color.FromArgb(236, 233, 254); // #ECE9FE

            using (Pen borderPen = new Pen(borderColor, 4)) // 4px border width
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, pnlSetting.Width, pnlSetting.Height);
            }

            using (Pen borderPen = new Pen(borderColor, 4)) // 2px border width
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Define the rounded rectangle path
                    path.AddArc(0, 0, 20, 20, 180, 90);  // Top-left corner
                    path.AddArc(pnlSetting.Width - 20, 0, 20, 20, 270, 90);  // Top-right corner
                    path.AddArc(pnlSetting.Width - 20, pnlSetting.Height - 20, 20, 20, 0, 90);  // Bottom-right corner
                    path.AddArc(0, pnlSetting.Height - 20, 20, 20, 90, 90);  // Bottom-left corner
                    path.CloseFigure();

                    // Draw the border
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfiles();
        }

        private void OpenProfiles()
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (UserSession.LoggedInIndustryID.HasValue)
            {
                NavigatePage.OpenForm<send>(this);
            }
            else
            {
                NavigatePage.OpenForm<WasteList>(this);

            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (UserSession.LoggedInIndustryID.HasValue)
            {
                NavigatePage.OpenForm<IndustriDashboard>(this);
            }
            else
            {
                NavigatePage.OpenForm<PengepulDashboard>(this);
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Name and Email are required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string sql;
                    NpgsqlCommand cmd;

                    if (UserSession.LoggedInIndustryID.HasValue)
                    {
                        sql = @"UPDATE pelaku_industri 
                       SET name = @name::varchar, email = @email::varchar, role = @role::varchar, bio = @bio::varchar
                       WHERE industri_id = @id";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("id", UserSession.LoggedInIndustryID.Value);
                    }
                    else
                    {
                        sql = @"UPDATE waste_collector 
                       SET name = @name::varchar, email = @email::varchar, role = @role::varchar, bio = @bio::varchar
                       WHERE collector_id = @id";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("id", UserSession.LoggedInCollectorID.Value);
                    }

                    cmd.Parameters.AddWithValue("name", NpgsqlTypes.NpgsqlDbType.Varchar, tbUsername.Text);
                    cmd.Parameters.AddWithValue("email", NpgsqlTypes.NpgsqlDbType.Varchar, tbEmail.Text);
                    cmd.Parameters.AddWithValue("role", NpgsqlTypes.NpgsqlDbType.Varchar, tbRole.Text);
                    cmd.Parameters.AddWithValue("bio", NpgsqlTypes.NpgsqlDbType.Varchar,
                        string.IsNullOrWhiteSpace(tbBio.Text) ? DBNull.Value : tbBio.Text);

                    cmd.ExecuteNonQuery();

                    // Update the session data
                    UserSession.UpdateUserInfo(tbUsername.Text, tbEmail.Text);

                    MessageBox.Show("Profile updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserData()
        {
            try
            {
                if (!UserSession.LoggedInIndustryID.HasValue && !UserSession.LoggedInCollectorID.HasValue)
                {
                    MessageBox.Show("Session expired. Please login again.", "Session Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NavigatePage.OpenForm<loginPage>(this);
                    return;
                }

                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string sql;
                    NpgsqlCommand cmd;

                    if (UserSession.LoggedInIndustryID.HasValue)
                    {
                        sql = "SELECT name, email, role, bio FROM pelaku_industri WHERE industri_id = @id";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("id", UserSession.LoggedInIndustryID.Value);
                    }
                    else
                    {
                        sql = "SELECT name, email, role, bio FROM waste_collector WHERE collector_id = @id";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("id", UserSession.LoggedInCollectorID.Value);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblProfile.Text = reader["name"].ToString();
                            tbUsername.Text = reader["name"].ToString();
                            tbEmail.Text = reader["email"].ToString();
                            tbRole.Text = reader["role"]?.ToString() ?? "";
                            tbBio.Text = reader["bio"]?.ToString() ?? "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setting_Load(object sender, EventArgs e)
        {
            LoadUserData();
            pnlSetting.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlSetting.Width, pnlSetting.Height, 25, 25));
        }

        private void pnlSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            MessageBox.Show("You have been successfully logged out.", "Logout Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            NavigatePage.OpenForm<loginPage>(this);
        }

        private void btnEditPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
