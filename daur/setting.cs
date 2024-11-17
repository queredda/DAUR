using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            Color shadowColor = Color.FromArgb(255, 0, 0, 0); // A semi-transparent dark color for shadow effect
            panelForm.BackColor = Color.FromArgb(255, 250, 250, 250);
            Color borderColor = Color.FromArgb(236, 233, 254); // #ECE9FE

            using (Pen borderPen = new Pen(borderColor, 4)) // 4px border width
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, panelForm.Width, panelForm.Height);
            }

            using (Pen borderPen = new Pen(borderColor, 4)) // 2px border width
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
    }
}
