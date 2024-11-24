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
    public partial class PengepulDashboard : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
        public static NpgsqlCommand cmd;
        private string sql = null;
        public PengepulDashboard()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }

        private void OpenProfile()
        {
            Profile Profile = new Profile();
            Profile.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenSetting();
        }

        private void OpenSetting()
        {
            setting setting = new setting();
            setting.Show();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            OpenWasteList();
        }

        private void OpenWasteList()
        {
            WasteList WasteList = new WasteList();
            WasteList.Show();
            this.Close();
        }

        private void FetchWasteCollectedData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();

                    string sql = @"
        SELECT COUNT(*) AS total_sent, 
               COALESCE(SUM(waste_weight), 0) AS total_weight
        FROM waste_send
        WHERE waste_status = @status;";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Tambahkan parameter untuk "Accepted" waste_status
                        cmd.Parameters.AddWithValue("@status", "Accepted");

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int totalSent = reader.GetInt32(reader.GetOrdinal("total_sent"));
                                decimal totalWeight = reader.GetDecimal(reader.GetOrdinal("total_weight"));

                                // Update the labels
                                guna2HtmlLabel2.Text = $"{totalSent} Times";
                                guna2HtmlLabel4.Text = $"{totalWeight} Kg";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching waste data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PengepulDashboard_Load(object sender, EventArgs e)
        {
            if (UserSession.LoggedInCollectorID.HasValue)
            {
                FetchWasteCollectedData();
                guna2HtmlLabel6.Text = $"Welcome, {UserSession.LoggedInName}!";
            }
            else
            {
                MessageBox.Show("Session expired. Please login again.", "Session Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NavigatePage.OpenForm<loginPage>(this);
            }
        }
    }
}
