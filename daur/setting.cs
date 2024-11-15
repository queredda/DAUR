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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
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
            Profile Profile = new Profile();
            Profile.Show();
            this.Hide();
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
