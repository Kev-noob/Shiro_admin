using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Super_Admin_Rolly
{
    public partial class Main_Dashboard : Form
    {
        private int selectedCourseId = 0;
        public Main_Dashboard()
        {
            InitializeComponent();
        }

        //DATABASE CONNECTION--->
        private MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;" +
                             "port=3306;" +
                             "database=BCT_db;" +
                             "user=root;" +
                             "password=;";
            return new MySqlConnection(connStr);
        }//<----
        private void coursesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= courses_DataGridView.Rows.Count - 1)
                return;
            {
                DataGridViewRow row = courses_DataGridView.Rows[e.RowIndex];

                // Fill textboxes with selected row data
                course_Code.Text = row.Cells["course_code"].Value.ToString();
                course_Name.Text = row.Cells["course_name"].Value.ToString();
                department_.Text = row.Cells["department"].Value?.ToString() ?? "";

                // Store the ID for updating
                selectedCourseId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }

      
        public void LoadCourses()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, course_code, course_name, department FROM courses ORDER BY course_name";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    courses_DataGridView.DataSource = dt;

                    // Optional: Hide the ID column
                    courses_DataGridView.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            Home_.BringToFront();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard_.BringToFront();
        }

        private void enrollment_Click(object sender, EventArgs e)
        {
            Enrollment_.BringToFront();
            LoadCourses();
            LoadSubjects();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 Admin = new Form1();
            this.Hide();
            Admin.Show();
        }

        private void course_switch_Click(object sender, EventArgs e)
        {
            courses_.BringToFront();
            LoadCourses();
        }

        private void subject_switch_Click(object sender, EventArgs e)
        {
            subjects_.BringToFront();
            LoadSubjects();
        }

        private void clear_inputs_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            course_Code.Clear();
            course_Name.Clear();
            department_.Clear();

            // Reset selected course ID
            selectedCourseId = 0;

            // Optional: Deselect row in DataGridView
            courses_DataGridView.ClearSelection();
        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            string courseCode = course_Code.Text.Trim();
            string courseName = course_Name.Text.Trim();
            string department = department_.Text.Trim();

            if (string.IsNullOrEmpty(courseCode) || string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please Complete Inputs!");
                return;
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO courses (course_code, course_name, department) VALUES (@code, @name, @dept)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", courseCode);
                        cmd.Parameters.AddWithValue("@name", courseName);
                        cmd.Parameters.AddWithValue("@dept", department);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course added successfully!");
                LoadCourses(); // Refresh GRID

                // Clear textboxes
                course_Code.Clear();
                course_Name.Clear();
                department_.Clear();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("Course code already exists!");
                else
                    MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editCourse_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Please select a course from the list to edit!");
                return;
            }

            // Get values from textboxes
            string courseCode = course_Code.Text.Trim();
            string courseName = course_Name.Text.Trim();
            string department = department_.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(courseCode) || string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please fill in Course Code and Course Name!");
                return;
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Update the course in database
                    string sql = "UPDATE courses SET course_code=@code, course_name=@name, department=@dept WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", courseCode);
                        cmd.Parameters.AddWithValue("@name", courseName);
                        cmd.Parameters.AddWithValue("@dept", department);
                        cmd.Parameters.AddWithValue("@id", selectedCourseId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course updated successfully!");

                // Refresh the DataGridView
                LoadCourses();

                // Clear textboxes
                course_Code.Clear();
                course_Name.Clear();
                department_.Clear();

                // Reset selected ID
                selectedCourseId = 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Course code already exists!");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delateCourse_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Please select a course from the list to delete!");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this course?\nThis action cannot be undone!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return; // User cancelled
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Delete the course from database
                    string sql = "DELETE FROM courses WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedCourseId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course deleted successfully!");

                // Refresh the DataGridView
                LoadCourses();

                // Clear textboxes
                course_Code.Clear();
                course_Name.Clear();
                department_.Clear();

                // Reset selected ID
                selectedCourseId = 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451) // Foreign key constraint error
                {
                    MessageBox.Show("Cannot delete this course! Students are enrolled in it or subjects are aligned to it.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void instructor_Click(object sender, EventArgs e)
        {
            Instructor_.BringToFront();
            LoadINS_pending();
            LoadINS_permanent();
        }

        private void classOffering__Click(object sender, EventArgs e)
        {
            Class_offering form = new Class_offering();
            form.Show();
        }
    }
}
