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
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
