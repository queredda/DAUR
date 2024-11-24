using Guna.UI2.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAUR
{
    public partial class Profile : Form
    {
        private string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
        private NpgsqlConnection conn;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public Profile()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            OpenDashboard();
        }
        private void OpenDashboard()
        {
            IndustriDashboard newDashboard = new IndustriDashboard();
            newDashboard.Show();
            this.Close();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Opensetting();
        }
        private void Opensetting()
        {
            setting setting = new setting();
            setting.Show();
            this.Close();
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

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Opensetting();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            OpenSend();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }

        private void btn_EditProfile_Click(object sender, EventArgs e)
        {
            Opensetting();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                            guna2HtmlLabel3.Text = reader["name"].ToString();
                            lbl_EmailUser.Text = reader["email"].ToString();
                            lbl_RoleUser.Text = reader["role"]?.ToString() ?? "";
                            lbl_BioUser.Text = reader["bio"]?.ToString() ?? "";
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

        private void Profile_Load(object sender, EventArgs e)
        {

            LoadUserData();
        }

        private void btn_EditProfile_Click_1(object sender, EventArgs e)
        {
            Opensetting();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
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

        private void btnSend_Click_1(object sender, EventArgs e)
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

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            NavigatePage.OpenForm<setting>(this);
        }
    }
}
