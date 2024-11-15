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
    public partial class send : Form
    {
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
    }
}
