using MySql.Data.MySqlClient;
using Shiro_admin.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Admin_Rolly
{
    public partial class Main_Dashboard : Form
    {
        private int selectedAlignmentId = 0;

        private void subjectAlign_Click(object sender, EventArgs e)
        {
            Enroll_AlignSubject.BringToFront();
            LoadCourseComboBox();
            LoadSubjectsComboBox();
            LoadCourseFilter();
        }



        //-----------------------------------------------LOAD COURSE/SUBJECT TO THE COMBOCOX-----------------------------------------------------------------

        //REFRESH BUTTON
        private void AlignReload_Click(object sender, EventArgs e)
        {
            subjectAlign_Click(sender, e);
        }

        //LOADS COURSES
        private void LoadCourseComboBox()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, course_name FROM courses ORDER BY course_name";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    course_combobx.DataSource = dt;
                    course_combobx.DisplayMember = "course_name";
                    course_combobx.ValueMember = "id";
                    course_combobx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }
        //LOADS SUBJECTS
        private void LoadSubjectsComboBox()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, subject_name FROM subjects ORDER BY subject_name";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    subject_combobx.DataSource = dt;
                    subject_combobx.DisplayMember = "subject_name";
                    subject_combobx.ValueMember = "id";
                    subject_combobx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjecets: " + ex.Message);
            }
        }
        //-----------------------------------------------ALIGN SUBJECT TO COURSE-----------------------------------------------------------------

        // CHECKS IF THE ALIGNMENT ALREADY EXISTS IN THE DATABASE TO AVOID DUPLICATE ENTRIES
        private bool AlignmentExists(int courseId, int subjectId, int yearLv, int semester)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT COUNT(*) FROM subject_alignment 
                       WHERE course_id  = @courseId 
                       AND subject_id   = @subjectId 
                       AND year_level   = @yearLv 
                       AND semester     = @semester";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@yearLv", yearLv);
                cmd.Parameters.AddWithValue("@semester", semester);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        //ALIGN BUTTON
        private void AlignSub_Click(object sender, EventArgs e)
        {
            //input verification-->
            if (subject_combobx.Text == null ||
                   course_combobx.Text == null ||
                   yearLv_combobx.SelectedItem == null ||
                   semester_combobx.SelectedItem == null
               )
            {
                MessageBox.Show("Please check for missing/wrong input.");
                return;
            }//<--


            //get the values from the form-->
            int subjectID = subject_combobx.SelectedItem != null ?
                  Convert.ToInt32(subject_combobx.SelectedValue) : 0;
            int courseID = course_combobx.SelectedItem != null ?
                   Convert.ToInt32(course_combobx.SelectedValue) : 0;
            int yearLv = yearLv_combobx.SelectedItem != null ?
                   Convert.ToInt32(yearLv_combobx.SelectedItem) : 0;
            int semester = semester_combobx.SelectedItem != null ?
                   Convert.ToInt32(semester_combobx.SelectedItem) : 0;

            //CALL THE CHECK FUNCTION TO SEE IF THE ALIGNMENT ALREADY EXISTS
            if (AlignmentExists(courseID, subjectID, yearLv, semester))
            {
                MessageBox.Show("This subject is already aligned to this Course, Year and Semester!",
                                "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //IF EVERYTHING IS GOOD, INSERT THE ALIGNMENT INTO THE DATABASE
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO subject_alignment (course_id, subject_id, year_level, semester) 
                           VALUES (@courseId, @subjectId, @yearLv, @semester)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseId", courseID);
                        cmd.Parameters.AddWithValue("@subjectId", subjectID);
                        cmd.Parameters.AddWithValue("@yearLv", yearLv);
                        cmd.Parameters.AddWithValue("@semester", semester);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Subject aligned successfully!");


                course_combobx.SelectedIndex = -1;
                subject_combobx.SelectedIndex = -1;
                yearLv_combobx.SelectedIndex = -1;
                semester_combobx.SelectedIndex = -1;


            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("This alignment already exists!");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
        }

        //------------------------------------------------SEE ALIGNED SUBJECTS-----------------------------------------------------------------

        //GRID CELL CLICK
        private void current_aligned_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = current_aligned_view.Rows[e.RowIndex];
                selectedAlignmentId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }
        //FILTER COURSES WITH AN ALIGNED SUBJECT
        private void LoadCourseFilter()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // Only get courses that have at least one subject aligned
                    string sql = @"SELECT DISTINCT c.id, c.course_name 
                           FROM courses c
                           INNER JOIN subject_alignment sa ON c.id = sa.course_id
                           ORDER BY c.course_name";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    aligned_combobx.DataSource = dt;
                    aligned_combobx.DisplayMember = "course_name";
                    aligned_combobx.ValueMember = "id";
                    aligned_combobx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //LOAD BUTTON
        private void SelectLoadCourse_Click(object sender, EventArgs e)
        {
            if (aligned_combobx.SelectedValue == null) return;

            int courseId = Convert.ToInt32(aligned_combobx.SelectedValue);

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // Get subject name, year level and semester for selected course
                    string sql = @"SELECT 
                        sa.id           AS id,
                        s.subject_name  AS 'Subject Name',
                        sa.year_level   AS 'Year Level',
                        sa.semester     AS 'Semester'
                       FROM subject_alignment sa
                       INNER JOIN subjects s ON s.id = sa.subject_id
                       WHERE sa.course_id = @courseId
                       ORDER BY sa.year_level, sa.semester, s.subject_name";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@courseId", courseId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    current_aligned_view.DataSource = dt;
                    current_aligned_view.ClearSelection();
                    current_aligned_view.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DropAligned_Click(object sender, EventArgs e)
        {
            if (selectedAlignmentId == 0)
            {
                MessageBox.Show("Please select a Subject first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Remove this Subject?",
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
                    string sql = "DELETE FROM subject_alignment WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedAlignmentId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Subject has been removed.");
                selectedAlignmentId = 0;
                SelectLoadCourse_Click(sender, e);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
