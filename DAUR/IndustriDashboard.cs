using Guna.UI2.WinForms;
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
using System.Text.Json.Serialization;
using System.Text.Json;

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
            if (UserSession.LoggedInIndustryID.HasValue)
            {
                guna2HtmlLabel6.Text = $"Welcome, {UserSession.LoggedInName}!";
                FetchWasteData();
            }
            else
            {
                MessageBox.Show("Session expired. Please login again.", "Session Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NavigatePage.OpenForm<loginPage>(this);
            }
        }

        private void FetchWasteData()
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
                WHERE pelakuindustri_industri_id = @industri_id;";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@industri_id", UserSession.LoggedInIndustryID.Value);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int totalSent = reader.GetInt32(reader.GetOrdinal("total_sent"));
                                decimal totalWeight = reader.GetDecimal(reader.GetOrdinal("total_weight"));

                                // Update the labels
                                waste_sent_lbl.Text = $"{totalSent} Times";
                                weight_lbl.Text = $"{totalWeight} Kg";
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

        private void notif_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka koneksi ke database
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();

                    // Query untuk mengambil data waste_send yang sesuai dengan industri_id
                    string sql = @"
                SELECT waste_kind, waste_status 
                FROM waste_send 
                WHERE pelakuindustri_industri_id = @industri_id AND 
                      (waste_status = 'Accepted' OR waste_status = 'Declined');";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@industri_id", UserSession.LoggedInIndustryID.Value);

                        using (var reader = cmd.ExecuteReader())
                        {
                            List<string> notifications = new List<string>();

                            while (reader.Read())
                            {
                                string wasteKind = reader["waste_kind"].ToString();
                                string status = reader["waste_status"].ToString();

                                if (status == "Accepted")
                                {
                                    notifications.Add($"Waste '{wasteKind}' has been accepted.");
                                }
                                else if (status == "Declined")
                                {
                                    notifications.Add($"Waste '{wasteKind}' has been declined.");
                                }
                            }

                            // Menampilkan notifikasi
                            if (notifications.Count > 0)
                            {
                                MessageBox.Show(string.Join(Environment.NewLine, notifications), "Notifications",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No new notifications.", "Notifications",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching notifications: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string baseUrl = "https://newsapi.org/v2/everything";
            string userInput = guna2TextBox1.Text;  // User input
            string apiKey = "c67becea8a4044cf8db088767ee8fe86";  // Your valid API key

            // Construct the URL, ensure query parameter is properly encoded
            var url = $"{baseUrl}?q={Uri.EscapeDataString(userInput)}&apiKey={apiKey}";

            // Print the generated URL for debugging purposes
            Console.WriteLine($"Generated URL: {url}");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Add necessary headers, including User-Agent
                    client.DefaultRequestHeaders.Add("User-Agent", "C# App");

                    // Send GET request
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if request is successful
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var newsResponse = JsonSerializer.Deserialize<NewsResponse>(json);

                        if (newsResponse?.Articles != null && newsResponse.Articles.Count > 0)
                        {
                            var firstArticle = newsResponse.Articles[0];
                            guna2HtmlLabel2.Text = firstArticle.Title;    // Display title
                            guna2HtmlLabel7.Text = firstArticle.Description; // Display description
                            linkLabel2.Text = firstArticle.Url; // Display URL
                            linkLabel2.Links.Clear(); // Clear any existing links
                            linkLabel2.Links.Add(0, firstArticle.Url.Length, firstArticle.Url);
                        }
                        else
                        {
                            MessageBox.Show("No articles found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if LinkData is not null before attempting to open
            try
            {
                // Ensure LinkData is not null
                if (e.Link.LinkData != null)
                {
                    string url = e.Link.LinkData.ToString();

                    // Make sure the URL starts with "http://" or "https://"
                    if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                    {
                        url = "https://" + url;  // Add "https://" if missing
                    }

                    // Use ProcessStartInfo to open the URL with the default browser
                    var processStartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true // This ensures the URL is opened in the default browser
                    };

                    System.Diagnostics.Process.Start(processStartInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the URL: " + ex.Message);
            }
        }
    }
}
