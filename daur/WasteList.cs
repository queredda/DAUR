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
    public partial class WasteList : Form
    {
        public WasteList()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WasteList_Shown(object sender, EventArgs e)
        {
            table_list.Rows.Add(
                new object[]
                {
                    "Hafidh husna",
                    "hafidh@gmail.com",
                    "Plastik",
                    10,
                    "Pending",
                    "Here",
                }
                );
        }
    }
}
