using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Npgsql;
using System.Xml.Linq;


namespace DAUR
{
    public partial class send : Form
    {

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
        public send()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void OpenProfile()
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void OpenSetting()
        {
            setting setting = new setting();
            setting.Show();
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
            panelForm.BackColor = Color.FromArgb(255, 250, 250, 250);
            Color borderColor = Color.FromArgb(236, 233, 254); // #ECE9FE

            using (Pen borderPen = new Pen(borderColor, 4)) // 4px border width
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, panelForm.Width, panelForm.Height);
            }

            using (Pen borderPen = new Pen(borderColor, 2)) // 2px border width
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Define the rounded rectangle path
                    path.AddArc(0, 0, 20, 20, 180, 90);  // Top-left corner
                    path.AddArc(panelForm.Width - 20, 0, 20, 20, 270, 90);  // Top-right corner
                    path.AddArc(panelForm.Width - 20, panelForm.Height - 20, 20, 20, 0, 90);  // Bottom-right corner
                    path.AddArc(0, panelForm.Height - 20, 20, 20, 90, 90);  // Bottom-left corner
                    path.CloseFigure();

                    // Draw the border
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void send_Load(object sender, EventArgs e)
        {
            btnKirim.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnKirim.Width, btnKirim.Height, 40, 40));
            tbJenis.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbJenis.Width, tbJenis.Height, 35, 35));
            tbBerat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbBerat.Width, tbBerat.Height, 35, 35));
            panelForm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelForm.Width, panelForm.Height, 25, 25));
            this.BackColor = Color.FromArgb(249, 250, 251);
            tbJenis.Padding = new Padding(10, 0, 10, 0); // Left and Right Padding: 10px, Top and Bottom Padding: 0px
            tbBerat.Padding = new Padding(10, 0, 10, 0); // Same padding for password textbox

            conn = new NpgsqlConnection(connstring);
        }

        private void tbJenis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (!UserSession.LoggedInIndustryID.HasValue)
            {
                MessageBox.Show("Session expired. Please login again.", "Session Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NavigatePage.OpenForm<loginPage>(this);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbJenis.Text) || string.IsNullOrWhiteSpace(tbBerat.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbBerat.Text, out int wasteWeight))
            {
                MessageBox.Show("Please enter a valid number for waste weight.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string sql = @"INSERT INTO waste_send 
                (pelakuindustri_industri_id, wastecollector_collector_id, waste_kind, waste_weight, waste_status)
                VALUES (@industri_id, @collector_id, @waste_kind, @waste_weight, @waste_status)
                RETURNING waste_send_id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("industri_id", UserSession.LoggedInIndustryID.Value);
                        cmd.Parameters.AddWithValue("collector_id", DBNull.Value);
                        cmd.Parameters.AddWithValue("waste_kind", tbJenis.Text);
                        cmd.Parameters.AddWithValue("waste_weight", wasteWeight);
                        cmd.Parameters.AddWithValue("waste_status", "Pending");

                        // Execute the query and get the new waste_send_id
                        int newWasteSendId = (int)cmd.ExecuteScalar();

                        MessageBox.Show($"Waste sent successfully! ID: {newWasteSendId}", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbJenis.Clear();
                        tbBerat.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending waste: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenSetting();
        }
    }
}
