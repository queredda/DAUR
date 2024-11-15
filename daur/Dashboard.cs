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
    public partial class Dashboard : Form
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
        bool sidebarExpand;
        public Dashboard()
        {
            InitializeComponent();
            MakeTextBoxRounded();
            CreateRoundedPanels();
        }


        private void CreateRoundedPanels()
        {
            int radius = 30;
            IntPtr roundedRegionWaste = CreateRoundRectRgn(
                0, 0, pnl_waste.Width, pnl_waste.Height, radius, radius
            );

            pnl_waste.Region = System.Drawing.Region.FromHrgn(roundedRegionWaste);

            DeleteObject(roundedRegionWaste);

            IntPtr roundedRegionWeather = CreateRoundRectRgn(
                0, 0, pnl_weather.Width, pnl_weather.Height, radius, radius
            );

            pnl_weather.Region = System.Drawing.Region.FromHrgn(roundedRegionWeather);

            DeleteObject(roundedRegionWeather);

            IntPtr roundedRegionPanel2 = CreateRoundRectRgn(
                0, 0, panel2.Width, panel2.Height, radius, radius
            );

            panel2.Region = System.Drawing.Region.FromHrgn(roundedRegionPanel2);

            DeleteObject(roundedRegionPanel2);

        }
        private void MakeTextBoxRounded()
        {
            int radius = 30;

            IntPtr roundedRegion = CreateRoundRectRgn(
                0, 0, textBox1.Width, textBox1.Height, radius, radius
            );

            textBox1.Region = System.Drawing.Region.FromHrgn(roundedRegion);

            DeleteObject(roundedRegion);
        }

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        private void nav_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }





        private void Dashboard_Load(object sender, EventArgs e)
        {
            textBox1.SelectionLength = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void pnl_artikel_Paint_1(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int borderWidth = 1;
            Color borderColor = ColorTranslator.FromHtml("#48CFCB");

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
        }

        private void logoBtn_Click(object sender, EventArgs e)
        {
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

        private void pnl_waste_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {



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
    }
}