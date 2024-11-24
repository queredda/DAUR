using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DAUR
{
    public partial class wasteDetail : Form
    {
        private string connstring = "Host=daur.postgres.database.azure.com;Port=5432;Username=daur;Password=Junprokontol!123;Database=DAUR;SSL Mode=Require;Trust Server Certificate=true;";
        private NpgsqlConnection conn;

        public wasteDetail()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wasteDetail_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
        public wasteDetail(string industriName, string wasteKind, int wasteWeight, int wasteSendId)
        {
            InitializeComponent();

            name_lbl.Text = industriName;
            jenis_lbl.Text = wasteKind;
            berat_lbl.Text = wasteWeight.ToString();
            this.wasteSendId = wasteSendId; // Store the waste_send_id in a private variable
        }

        private int wasteSendId;


        private void UpdateWasteStatus(string status)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    string sql = @"
                UPDATE waste_send 
                SET waste_status = @status 
                WHERE waste_send_id = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", wasteSendId); // Assuming `name_lbl.Text` holds the `waste_send_id`

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Status successfully updated to {status}", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tolak_btn_Click(object sender, EventArgs e)
        {
            UpdateWasteStatus("Declined");
            this.Close();
        }

        private void terima_btn_Click(object sender, EventArgs e)
        {
            UpdateWasteStatus("Accepted");
            this.Close();
        }
    }
}
