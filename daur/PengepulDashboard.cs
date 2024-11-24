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
                            guna2HtmlLabel8.Text = firstArticle.Title;    // Display title
                            guna2HtmlLabel7.Text = firstArticle.Description; // Display description
                            linkLabel1.Text = firstArticle.Url; // Display URL
                            linkLabel1.Links.Clear(); // Clear any existing links
                            linkLabel1.Links.Add(0, firstArticle.Url.Length, firstArticle.Url);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
