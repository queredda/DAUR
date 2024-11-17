﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

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
            newDashboard newDashboard = new newDashboard();
            newDashboard.Show();
            this.Close();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Opensetting();
        }
        private void Opensetting()
        {
            setting setting = new setting();
            setting.Show();
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            OpenSend();
        }
        private void OpenSend()
        {
            send send = new send();
            send.Show();
            this.Close();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Opensetting();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            OpenSend();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }
    }
}
