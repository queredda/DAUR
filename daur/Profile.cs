using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAUR
{
    public partial class Profile : Form
    {
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
            MakePanelRounded();
        }
        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        private void MakePanelRounded()
        {
            int radius = 30;
            IntPtr roundedRegionWaste = CreateRoundRectRgn(
                0, 0, pnl_profile.Width, pnl_profile.Height, radius, radius
            );

            pnl_profile.Region = System.Drawing.Region.FromHrgn(roundedRegionWaste);

            DeleteObject(roundedRegionWaste);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pnl_profile_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel == null) return;

            int cornerRadius = 20; // Radius lengkungan sudut
            int strokeWidth = 2; // Ketebalan garis stroke
            Color strokeColor = Color.Gray; // Warna garis stroke

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Membuat path untuk panel dengan sudut melengkung
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Kiri atas
            path.AddArc(panel.Width - cornerRadius - strokeWidth, 0, cornerRadius, cornerRadius, 270, 90); // Kanan atas
            path.AddArc(panel.Width - cornerRadius - strokeWidth, panel.Height - cornerRadius - strokeWidth, cornerRadius, cornerRadius, 0, 90); // Kanan bawah
            path.AddArc(0, panel.Height - cornerRadius - strokeWidth, cornerRadius, cornerRadius, 90, 90); // Kiri bawah
            path.CloseFigure();

            // Menggambar stroke (outline) di sisi kanan dan bawah
            using (Pen pen = new Pen(strokeColor, strokeWidth))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                g.DrawPath(pen, path);
            }

            // Mengisi panel dengan warna
            using (SolidBrush brush = new SolidBrush(panel.BackColor))
            {
                g.FillPath(brush, path);
            }
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
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Opensetting();
        }
        private void Opensetting()
        {
            setting setting = new setting();
            setting.Show();
            this.Hide();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            OpenSend();
        }
        private void OpenSend()
        {
            send send = new send();
            send.Show();
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
    }
}
