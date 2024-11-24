using Npgsql;
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
        private string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
        private NpgsqlConnection conn;
        public WasteList()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            // Add this in the InitializeComponent method or Form_Load
            table_list.Columns.Clear();
            table_list.Columns.AddRange(new DataGridViewColumn[] {
            new DataGridViewTextBoxColumn() { Name = "IndustryName", HeaderText = "Industry Name" },
            new DataGridViewTextBoxColumn() { Name = "Email", HeaderText = "Email" },
            new DataGridViewTextBoxColumn() { Name = "WasteKind", HeaderText = "Waste Type" },
            new DataGridViewTextBoxColumn() { Name = "WasteWeight", HeaderText = "Weight (kg)" },
            new DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Status" },
            new DataGridViewButtonColumn() { Name = "Action", HeaderText = "Action", Text = "Details", UseColumnTextForButtonValue = true }
            });
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void WasteList_Shown(object sender, EventArgs e)
        //{
        //    table_list.Rows.Add(
        //        new object[]
        //        {
        //            "Hafidh husna",
        //            "hafidh@gmail.com",
        //            "Plastik",
        //            10,
        //            "Pending",
        //            "Here",
        //        }
        //        );
        //}



        public void RefreshData()
        {
            LoadWasteData();
        }

        private void LoadWasteData()
        {
            try
            {
                conn.Open();
                string sql = @"
                    SELECT 
                        pi.industri_id,
                        pi.name,
                        pi.email,
                        ws.waste_kind,
                        ws.waste_weight,
                        ws.waste_status,
                        ws.waste_send_id
                    FROM waste_send ws
                    JOIN pelaku_industri pi ON ws.pelakuindustri_industri_id = pi.industri_id
                    ORDER BY ws.waste_send_id DESC";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                    {
                        table_list.Rows.Clear();

                        while (reader.Read())
                        {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(table_list);
                        row.Cells[0].Value = reader["name"].ToString();
                        row.Cells[1].Value = reader["email"].ToString();
                        row.Cells[2].Value = reader["waste_kind"].ToString();
                        row.Cells[3].Value = Convert.ToInt32(reader["waste_weight"]);
                        row.Cells[4].Value = reader["waste_status"].ToString();
                        row.Cells[5].Value = "Details";
                        row.Tag = reader["waste_send_id"].ToString(); // Store waste_send_id in row's Tag property

                        table_list.Rows.Add(row);
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading waste data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void WasteList_Load(object sender, EventArgs e)
        {
            LoadWasteData();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (UserSession.LoggedInIndustryID.HasValue)
            {
                NavigatePage.OpenForm<IndustriDashboard>(this);
            }
            else
            {
                NavigatePage.OpenForm<PengepulDashboard>(this);
            }
        }
        private void OpenProfile()
        {
            Profile Profile = new Profile();
            Profile.Show();
            this.Close();
        }

        private void OpenSetting()
        {
            setting setting = new setting();
            setting.Show();
            this.Close();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenSetting();
        }

        private void table_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == table_list.Columns["Action"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = table_list.Rows[e.RowIndex];

                // Create new wasteDetail form and pass the necessary data
                wasteDetail detailForm = new wasteDetail(
                    selectedRow.Cells["IndustryName"].Value.ToString(),
                    selectedRow.Cells["WasteKind"].Value.ToString(),
                    Convert.ToInt32(selectedRow.Cells["WasteWeight"].Value),
                    Convert.ToInt32(selectedRow.Tag)
                );

                this.Hide();
                detailForm.ShowDialog();
                this.Show();
                LoadWasteData(); // Refresh the data when returning from detail form
            }
        }
    }
}
