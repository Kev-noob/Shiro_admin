using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Super_Admin_Rolly
{
    public partial class Main_Dashboard : Form
    {
        int SelectedIndex = 0;

        //BILLING BRING TO FRONT
        private void button4_Click(object sender, EventArgs e)
        {
            Billing_.BringToFront();
            LoadToCourseComboBox();
        }
        

        //LOAD BILLING GRID
        private void LoadBillingGrid(string statusFilter = "All status")
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string whereClause = statusFilter == "All status" ? "" : "AND b.status = @status";

                    string sql = $@"SELECT 
                                b.id            AS id,
                                i.full_name      AS 'Student',
                                c.course_name   AS 'Course',
                                b.year_level    AS 'Year',
                             
                                b.total_units   AS 'Units',
                                b.total_amount  AS 'Total Bill',
                                b.amount_paid   AS 'Paid',
                                b.balance       AS 'Balance',
                                b.status        AS 'Status'
                            FROM billing b
                            INNER JOIN inputs i   ON i.student_id = b.student_id
                            INNER JOIN courses c  ON c.id         = b.course_id
                            WHERE 1=1 {whereClause}
                            ORDER BY c.course_name, b.year_level, i.full_name";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (statusFilter != "All status")
                        cmd.Parameters.AddWithValue("@status", statusFilter);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView_billedStudents.DataSource = dt;
                    GridView_billedStudents.Columns["id"].Visible = false;
                    GridView_billedStudents.RowHeadersVisible = false;
                    GridView_billedStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    GridView_billedStudents.Columns["Student"].Width = 150;
                    GridView_billedStudents.Columns["Course"].Width = 150;
                    GridView_billedStudents.Columns["Year"].Width = 40;
                  //  GridView_billedStudents.Columns["Sem"].Width = 40;
                    GridView_billedStudents.Columns["Units"].Width = 50;
                    GridView_billedStudents.Columns["Total Bill"].Width = 90;
                    GridView_billedStudents.Columns["Paid"].Width = 90;
                    GridView_billedStudents.Columns["Balance"].Width = 90;
                    GridView_billedStudents.Columns["Status"].Width = 70;

                    GridView_billedStudents.ClearSelection();
                    GridView_billedStudents.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //CLEAR METHOD FOR REFRRESHING
        private void ClearINputs()
        { 
            Semester_cmbx.SelectedIndex = -1;
            PricePerUnit.Clear();
            SchoolYear.Clear();
           
        }

        //LOAD COURSE TO THE COURSE COMBOBOX
        private void LoadToCourseComboBox()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // Get courses that have at least one offering
                    string sql = @"SELECT DISTINCT c.id, c.course_name 
                           FROM courses c
                           INNER JOIN class_offering co ON c.id = co.course_id
                           ORDER BY c.course_name";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Course_cmbx.DataSource = dt;
                    Course_cmbx.DisplayMember = "course_name";
                    Course_cmbx.ValueMember = "id";
                    Course_cmbx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        //SET PRICE BUTTON
        private void SaveRate_Click(object sender, EventArgs e)
        {
            //input verification-->
            if (string.IsNullOrWhiteSpace(PricePerUnit.Text) || 
                  string.IsNullOrWhiteSpace(SchoolYear.Text) ||
                   Semester_cmbx.SelectedItem == null 
               )
            {
                MessageBox.Show("Please complete inputs.");
                return;
            }//<--

            //yearLV verify
            if (!int.TryParse(SchoolYear.Text, out int year))
            {
                MessageBox.Show("School year must be a number.");
                SchoolYear.Focus();
                return;
            }

            if (year < 1 || year > 4)
            {
                MessageBox.Show("School year must be between 1 and 4.");
                SchoolYear.Focus();
                return;
            }

            //validate decimal input 
            if (!decimal.TryParse(PricePerUnit.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid decimal number.");
                PricePerUnit.Focus();
                return;
            }

            //revent negative values
            if (price < 0)
            {
                MessageBox.Show("Price cannot be negative.");
                PricePerUnit.Focus();
                return;
            }

           


            //get the values from the form-->
            decimal Price_per_unit = Convert.ToDecimal(PricePerUnit.Text.Trim());
            string School_year = SchoolYear.Text.Trim();
            int semester =  Convert.ToInt32(Semester_cmbx.SelectedItem);


            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO tuition_rate 
                            (price, school_year, semester)
                           VALUES 
                            (@Price, @SchoolYear, @Semester)
                             ON DUPLICATE KEY UPDATE price = @Price";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Price", Price_per_unit);
                        cmd.Parameters.AddWithValue("@SchoolYear", School_year);
                        cmd.Parameters.AddWithValue("@Semester", semester);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Price has been recorded.");
                ClearINputs();       // clear all inputs

            }
            catch (Exception ex)
            {
               MessageBox.Show("Database error: " + ex.Message);
            }

            LoadToCourseComboBox();
        }

        //SELECT YEARLV THEN AUTOMATICALLY DISPLAY INFOS
        private void YearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Course_cmbx.SelectedValue == null ||
            YearLevel.SelectedItem == null) return;

            int courseId = Convert.ToInt32(Course_cmbx.SelectedValue);
            int yearLevel = Convert.ToInt32(YearLevel.SelectedItem);

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Get total subjects and total units for this course and year level
                    string subjectSQL = @"SELECT COUNT(s.id) AS total_subjects,
                                         SUM(s.units) AS total_units
                                  FROM subject_alignment sa
                                  INNER JOIN subjects s ON s.id = sa.subject_id
                                  WHERE sa.course_id  = @courseId
                                  AND   sa.year_level = @yearLevel";

                    MySqlCommand subCmd = new MySqlCommand(subjectSQL, conn);
                    subCmd.Parameters.AddWithValue("@courseId", courseId);
                    subCmd.Parameters.AddWithValue("@yearLevel", yearLevel);

                    MySqlDataReader reader = subCmd.ExecuteReader();
                    int totalSubjects = 0;
                    int totalUnits = 0;

                    if (reader.Read())
                    {
                        totalSubjects = Convert.ToInt32(reader["total_subjects"]);
                        totalUnits = reader["total_units"] == DBNull.Value ? 0 :
                                        Convert.ToInt32(reader["total_units"]);
                    }
                    reader.Close();

                    // Get students found for this course
                    string studentSQL = @"SELECT COUNT(*) FROM inputs 
                                  WHERE course_id = @courseId";

                    MySqlCommand stuCmd = new MySqlCommand(studentSQL, conn);
                    stuCmd.Parameters.AddWithValue("@courseId", courseId);
                    int studentsFound = Convert.ToInt32(stuCmd.ExecuteScalar());

                    // Get latest price per unit
                    string priceSQL = @"SELECT price FROM tuition_rate 
                                ORDER BY created_at DESC LIMIT 1";

                    MySqlCommand priceCmd = new MySqlCommand(priceSQL, conn);
                    object priceResult = priceCmd.ExecuteScalar();
                    decimal pricePerUnit = priceResult == null ? 0 :
                                           Convert.ToDecimal(priceResult);

                    // Compute bill per student
                    decimal billPerStudent = totalUnits * pricePerUnit;

                    // Update labels
                    TotalSubject.Text = totalSubjects.ToString();
                    TotalUnits.Text = totalUnits.ToString();
                    PricePerUnits.Text = pricePerUnit.ToString("C",
                                              new System.Globalization.CultureInfo("fil-PH"));
                    TotalStudents.Text = studentsFound.ToString();
                    PricePerStudents.Text = billPerStudent.ToString("C",
                                              new System.Globalization.CultureInfo("fil-PH"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //GENERATE BILLING BUTTON
        private void GenerateBilling_Click(object sender, EventArgs e)
        {
            if (Course_cmbx.SelectedValue == null ||
       YearLevel.SelectedItem == null)
            {
                MessageBox.Show("Please select a course and year level!");
                return;
            }

            int courseId = Convert.ToInt32(Course_cmbx.SelectedValue);
            int yearLevel = Convert.ToInt32(YearLevel.SelectedItem);
            int totalUnits = Convert.ToInt32(TotalUnits.Text);
            decimal price = Convert.ToDecimal(PricePerUnits.Text.Replace("₱", "").Replace(",", "").Trim());
            decimal bill = totalUnits * price;

            // Get school year and semester from tuition rate settings
            string schoolYear = SchoolYear.Text.Trim();
            int semester = Convert.ToInt32(Semester_cmbx.SelectedItem);

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Get all students in this course
                    string getStudents = "SELECT student_id FROM inputs WHERE course_id = @courseId";
                    MySqlCommand getCmd = new MySqlCommand(getStudents, conn);
                    getCmd.Parameters.AddWithValue("@courseId", courseId);

                    MySqlDataReader reader = getCmd.ExecuteReader();
                    List<string> studentIds = new List<string>();
                    while (reader.Read())
                        studentIds.Add(reader["student_id"].ToString());
                    reader.Close();

                    if (studentIds.Count == 0)
                    {
                        MessageBox.Show("No students found for this course!");
                        return;
                    }

                    // Insert bill for each student — skip if already billed
                    string insertSQL = @"INSERT IGNORE INTO billing 
                                 (student_id, course_id, year_level, 
                                  school_year, total_units, total_amount, 
                                  amount_paid, balance, status)
                                 VALUES 
                                 (@studentId, @courseId, @yearLevel,
                                  @schoolYear, @totalUnits, @totalAmount,
                                  0, @totalAmount, 'Unpaid')";

                    int generated = 0;
                    foreach (string studentId in studentIds)
                    {
                        using (MySqlCommand cmd = new MySqlCommand(insertSQL, conn))
                        {
                            cmd.Parameters.AddWithValue("@studentId", studentId);
                            cmd.Parameters.AddWithValue("@courseId", courseId);
                            cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                           // cmd.Parameters.AddWithValue("@semester", semester);
                            cmd.Parameters.AddWithValue("@schoolYear", schoolYear);
                            cmd.Parameters.AddWithValue("@totalUnits", totalUnits);
                            cmd.Parameters.AddWithValue("@totalAmount", bill);
                            cmd.ExecuteNonQuery();
                            generated++;
                        }
                    }

                    MessageBox.Show($"{generated} bills generated successfully!");
                    LoadBillingGrid(); // refresh grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //FILTER COMBOBOX
        private void Filter_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filter_cmbx.SelectedItem == null) return;
            string selected = Filter_cmbx.SelectedItem.ToString();
            LoadBillingGrid(selected);
        }

        //------------------------------------------------------------------------------GRID--------------------------------------------------------

        private int selectedBillingId = 0;

         private void GridView_billedStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridView_billedStudents.Rows[e.RowIndex];
                selectedBillingId = Convert.ToInt32(row.Cells["id"].Value);
            }

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (selectedBillingId == 0)
            {
                MessageBox.Show("Please select a student first!");
                return;
            }

            // Validate payment amount
            if (!decimal.TryParse(PayBills.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount!");
                return;
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // 1. Insert into payments table
                        string insertPayment = @"INSERT INTO payments (billing_id, amount)
                                         VALUES (@billingId, @amount)";

                        using (MySqlCommand cmd = new MySqlCommand(insertPayment, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@billingId", selectedBillingId);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update billing table
                        string updateBilling = @"UPDATE billing 
                                         SET amount_paid = amount_paid + @amount,
                             balance     = balance - @amount,
                             status      = CASE
                                            WHEN (balance - @amount) <= 0 THEN 'Paid'
                                            WHEN (amount_paid + @amount) > 0 THEN 'Partial'
                                            ELSE 'Unpaid'
                                           END
                         WHERE id = @billingId";

                        using (MySqlCommand cmd = new MySqlCommand(updateBilling, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@billingId", selectedBillingId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Payment recorded successfully!");

                        selectedBillingId = 0;
                        PayBills.Clear();
                        LoadBillingGrid(Filter_cmbx.SelectedItem?.ToString() ?? "All");
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


    }
}
