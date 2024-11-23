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
<<<<<<< HEAD
=======
using System.Xml.Linq;
>>>>>>> ed45a1ca7596b15229ffd944d5c908d9bf55328a


namespace DAUR
{
    public partial class send : Form
    {

        private NpgsqlConnection conn;
        string connstring = "Host = 192.168.225.243; Port = 5432; Username = postgres; Password = HusnaYTB223; Database = DAUR";
        public static NpgsqlCommand cmd;
        private string sql = null;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
<<<<<<< HEAD

(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
        private NpgsqlConnection conn;
        string connstring = "Host = localhost; Port = 5432; Username = postgres; Password = HusnaYTB223; Database = DAUR";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
=======
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
>>>>>>> ed45a1ca7596b15229ffd944d5c908d9bf55328a
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
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }

        private void OpenProfile()
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            OpenSetting();

        }

        private void OpenSetting()
        {
            setting setting = new setting();
            setting.Show();
            this.Hide();
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
<<<<<<< HEAD
=======

>>>>>>> ed45a1ca7596b15229ffd944d5c908d9bf55328a
            conn = new NpgsqlConnection(connstring);
        }

        private void tbJenis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"select * from waste_send(:_waste_kind, :_waste_weight)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_waste_kind", tbJenis.Text);
            cmd.Parameters.AddWithValue("_waste_weight", int.Parse(tbBerat.Text));
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Waste Sent Successfully!", "Waste Send Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                tbBerat = tbJenis = null;
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = @"select * from waste_send(:_waste_kind, :_waste_weight)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                // Adding parameter values
                cmd.Parameters.AddWithValue("_waste_kind", tbJenis.Text);
                cmd.Parameters.AddWithValue("_waste_weight", int.Parse(tbBerat.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Waste Sent Successfully!", "Waste Send Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields after successful sign-up
                    tbJenis.Text = tbBerat.Text = null;
                }
                else
                {
                    MessageBox.Show("Waste Failed to Sent. Please try again.", "Waste Send Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
