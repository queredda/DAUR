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
    public partial class PengepulDashboard : Form
    {
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
    }
}
