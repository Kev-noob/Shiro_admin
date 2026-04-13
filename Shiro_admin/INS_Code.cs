using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Admin_Rolly
{
    public partial class Main_Dashboard 
    {
        //FOR EDITING SUBJECT
        private int selectedINS_Id = 0;

        //LOAD INSTRUCTOR TO DATAGRIDVIEW (pending)
        private void LoadINS_pending()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, FullName, Email, Phone, Department FROM pendinginstructor ORDER BY FullName";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    pending_INS.DataSource = dt;
                    pending_INS.Columns["id"].Visible = false;

                    pending_INS.ClearSelection();
                    pending_INS.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }

        }


        // CLICK TABLE TO SHOW IN THE TEXTBOXES
        private void pending_INS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = pending_INS.Rows[e.RowIndex];

                // Store the ID for updating
                selectedINS_Id = Convert.ToInt32(row.Cells["id"].Value);
            }
        }

        private void approved_INS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = approved_INS.Rows[e.RowIndex];

                // Store the ID for updating
                selectedINS_Id = Convert.ToInt32(row.Cells["id"].Value);
            }
        }
        

       

        //------------------------------------------ACCEPT AND REJECT BUTTON BOUNDRY------------------------------------

        private void LoadINS_permanent()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, FullName, Email, Phone, Department FROM permanentins ORDER BY FullName";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    approved_INS.DataSource = dt;
                    approved_INS.Columns["id"].Visible = false;

                    approved_INS.ClearSelection();
                    approved_INS.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //---------------------------------------------------------------------------------LOAD GRID METHOD AND BUTTONS BOUNDRY-----------------------------------------------



        // APPROVE PENDING INSTRUCTOR BUTTON
        private void approve_pend_Click(object sender, EventArgs e)
        {
            if (selectedINS_Id == 0)
            {
                MessageBox.Show("Please select an instructor first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Approve this instructor?",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No) return;

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // COPY DATA FROM pendinginstructor TO permanentins
                        string insertSQL = @"INSERT INTO permanentins (FullName, Email, Phone, Department, Password)
                                     SELECT FullName, Email, Phone, Department, Password 
                                     FROM pendinginstructor WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(insertSQL, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedINS_Id);
                            cmd.ExecuteNonQuery();
                        }

                        // DELATE DATA FROM pendinginstructor AFTER DATA COPY
                        string deleteSQL = "DELETE FROM pendinginstructor WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(deleteSQL, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedINS_Id);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Instructor approved successfully!");
                        selectedINS_Id = 0;

                        //REFRESH THE TWO DATAGRID
                        LoadINS_pending();
                        LoadINS_permanent();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //------------------------------------------ACCEPT AND REJECT BUTTON BOUNDRY------------------------------------

        // REJECT PENDING INSTRUCTOR BUTTON
        private void drop_pend_Click(object sender, EventArgs e)
        {
            if (selectedINS_Id == 0)
            {
                MessageBox.Show("Please select an instructor first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Reject and remove this instructor?",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No) return;

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM pendinginstructor WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedINS_Id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Instructor rejected and removed.");
                selectedINS_Id = 0;
                LoadINS_pending();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //-----------------------PERMANENT DATAGRIDVIEW
        private void drop_permanent_Click(object sender, EventArgs e)
        {
            if (selectedINS_Id == 0)
            {
                MessageBox.Show("Please select an instructor first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Remove this Instructor?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No) return;

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM permanentins WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedINS_Id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Instructor has been Fired/Removed.");
                selectedINS_Id = 0;
                LoadINS_permanent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       
        
    }
}
