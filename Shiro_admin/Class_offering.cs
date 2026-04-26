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
using Shiro_admin.DAL;

namespace Super_Admin_Rolly
{
    public partial class Class_offering : Form
    {
        private string selectedStatus = "Open";
        private int selectedOfferingId = 0;

        public Class_offering()
        {
            InitializeComponent();
            LoadCourse_CO_ComboBox();
            LoadIns_CO_ComboBox();
            SetDefaultStatus();
            LoadOfferingComboBox();

        }

        private void Class_offering_Load(object sender, EventArgs e)
        {
            LoadCourse_CO_ComboBox();
            LoadIns_CO_ComboBox();
            SetDefaultStatus();
            LoadOfferingComboBox();
        }

        private void SetDefaultStatus()
        {
            CO_open.BackColor = Color.FromArgb(45, 189, 133);
            CO_open.ForeColor = Color.White;
            CO_close.BackColor = SystemColors.Control;
            CO_close.ForeColor = SystemColors.ControlText;
        }

        private void ClearFields()
        {
            CO_course.SelectedIndex = -1;
            CO_subject.DataSource = null;
            CO_subject.Items.Clear();
            CO_instructor.SelectedIndex = -1;
            CO_days.SelectedIndex = -1;
            CO_yearLv.SelectedIndex = -1;
            CO_semester.SelectedIndex = -1;
            CO_room.Clear();
            CO_maxStudent.Clear();
            CO_schoolYear.Clear();
            SetDefaultStatus();
        }

        private void LoadCourse_CO_ComboBox()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection()) // changed
                {
                    conn.Open();
                    string sql = "SELECT id, course_name FROM courses ORDER BY course_name";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CO_course.DataSource = dt;
                    CO_course.DisplayMember = "course_name";
                    CO_course.ValueMember = "id";
                    CO_course.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void CO_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CO_course.SelectedValue == null) return;
            if (!(CO_course.SelectedValue is int)) return;

            int courseId = Convert.ToInt32(CO_course.SelectedValue);
            CO_subject.DataSource = null;
            CO_subject.Items.Clear();

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection()) // changed
                {
                    conn.Open();
                    string sql = @"SELECT s.id, s.subject_name 
                                   FROM subjects s
                                   INNER JOIN subject_alignment sa ON s.id = sa.subject_id
                                   WHERE sa.course_id = @courseId
                                   ORDER BY s.subject_name";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CO_subject.DataSource = dt;
                    CO_subject.DisplayMember = "subject_name";
                    CO_subject.ValueMember = "id";
                    CO_subject.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void LoadIns_CO_ComboBox()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection()) // changed
                {
                    conn.Open();
                    string sql = "SELECT id, FullName FROM permanentins ORDER BY FullName";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CO_instructor.DataSource = dt;
                    CO_instructor.DisplayMember = "FullName";
                    CO_instructor.ValueMember = "id";
                    CO_instructor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructors: " + ex.Message);
            }
        }

        private void LoadOfferingComboBox()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection()) // changed
                {
                    conn.Open();
                    string sql = @"SELECT DISTINCT c.id, c.course_name 
                                   FROM courses c
                                   INNER JOIN class_offering co ON c.id = co.course_id
                                   ORDER BY c.course_name";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CO_selectCourse.DataSource = dt;
                    CO_selectCourse.DisplayMember = "course_name";
                    CO_selectCourse.ValueMember = "id";
                    CO_selectCourse.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading offerings: " + ex.Message);
            }
        }

        private void CO_open_Click(object sender, EventArgs e)
        {
            selectedStatus = "Open";
            CO_open.BackColor = Color.FromArgb(46, 139, 87);
            CO_open.ForeColor = Color.White;
            CO_close.BackColor = Color.White;
            CO_close.ForeColor = Color.DimGray;
        }

        private void CO_close_Click(object sender, EventArgs e)
        {
            selectedStatus = "Closed";
            CO_close.BackColor = Color.FromArgb(224, 90, 90);
            CO_close.ForeColor = Color.White;
            CO_open.BackColor = Color.White;
            CO_open.ForeColor = Color.DimGray;
        }

        private void CO_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void CO_CreateOffering_Click(object sender, EventArgs e)
        {
            if (CO_course.SelectedValue == null ||
               CO_subject.SelectedValue == null ||
               CO_instructor.SelectedValue == null ||
               CO_yearLv.SelectedItem == null ||
               CO_semester.SelectedItem == null ||
               string.IsNullOrWhiteSpace(CO_room.Text) ||
               CO_days.SelectedItem == null ||
               string.IsNullOrWhiteSpace(CO_maxStudent.Text) ||
               string.IsNullOrWhiteSpace(CO_schoolYear.Text))
            {
                MessageBox.Show("Please check for missing/wrong input.");
                return;
            }

            TimeSpan timeStart = CO_timeStart.Value.TimeOfDay;
            TimeSpan timeEnd = CO_timeEnd.Value.TimeOfDay;

            if (timeEnd <= timeStart)
            {
                MessageBox.Show("End time must be after start time!");
                return;
            }

            int courseId = Convert.ToInt32(CO_course.SelectedValue);
            int subjectId = Convert.ToInt32(CO_subject.SelectedValue);
            int instructorId = Convert.ToInt32(CO_instructor.SelectedValue);
            int yearLv = Convert.ToInt32(CO_yearLv.SelectedItem);
            int semester = Convert.ToInt32(CO_semester.SelectedItem);
            string room = CO_room.Text.Trim();
            string days = CO_days.SelectedItem.ToString();
            int maxStudents = Convert.ToInt32(CO_maxStudent.Text.Trim());
            string schoolYear = CO_schoolYear.Text.Trim();

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection()) // changed
                {
                    conn.Open();
                    string sql = @"INSERT INTO class_offering 
                                   (course_id, subject_id, instructor_id, year_lv, semester, 
                                    room, days, time_start, time_end, max_student, school_year, status)
                                   VALUES 
                                   (@courseId, @subjectId, @instructorId, @yearLv, @semester,
                                    @room, @days, @timeStart, @timeEnd, @maxStudents, @schoolYear, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseId", courseId);
                        cmd.Parameters.AddWithValue("@subjectId", subjectId);
                        cmd.Parameters.AddWithValue("@instructorId", instructorId);
                        cmd.Parameters.AddWithValue("@yearLv", yearLv);
                        cmd.Parameters.AddWithValue("@semester", semester);
                        cmd.Parameters.AddWithValue("@room", room);
                        cmd.Parameters.AddWithValue("@days", days);
                        cmd.Parameters.AddWithValue("@timeStart", timeStart);
                        cmd.Parameters.AddWithValue("@timeEnd", timeEnd);
                        cmd.Parameters.AddWithValue("@maxStudents", maxStudents);
                        cmd.Parameters.AddWithValue("@schoolYear", schoolYear);
                        cmd.Parameters.AddWithValue("@status", selectedStatus);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Class offering created successfully!");
                ClearFields();
                LoadOfferingComboBox();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("This offering already exists!");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void CO_selectToDisplay_Click(object sender, EventArgs e)
        {
            if (CO_selectCourse.SelectedValue == null) return;
            int courseId = Convert.ToInt32(CO_selectCourse.SelectedValue);

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection()) // changed
                {
                    conn.Open();
                    string sql = @"SELECT 
                                    co.id           AS id,
                                    s.subject_name  AS 'Subject',
                                    p.FullName       AS 'Instructor',
                                    co.year_Lv      AS 'Yr',
                                    co.semester     AS 'Sem',
                                    co.room         AS 'Room',
                                    co.days         AS 'Days',
                                    co.time_start   AS 'Time Start',
                                    co.time_end     AS 'Time End',
                                    co.max_student  AS 'Max Stu.',
                                    co.school_year  AS 'S.Y.',
                                    co.status       AS 'Stat'
                                   FROM class_offering co
                                   INNER JOIN subjects s     ON s.id = co.subject_id
                                   INNER JOIN permanentins p ON p.id = co.instructor_id
                                   WHERE co.course_id = @courseId
                                   ORDER BY co.year_Lv, co.semester, s.subject_name";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Available_offering.DataSource = dt;
                    Available_offering.Columns["id"].Visible = false;
                    Available_offering.RowHeadersVisible = false;
                    Available_offering.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    Available_offering.Columns["Subject"].Width = 150;
                    Available_offering.Columns["Instructor"].Width = 170;
                    Available_offering.Columns["Yr"].Width = 35;
                    Available_offering.Columns["Sem"].Width = 50;
                    Available_offering.Columns["Room"].Width = 65;
                    Available_offering.Columns["Days"].Width = 50;
                    Available_offering.Columns["Time Start"].Width = 95;
                    Available_offering.Columns["Time End"].Width = 90;
                    Available_offering.Columns["Max Stu."].Width = 75;
                    Available_offering.Columns["S.Y."].Width = 85;
                    Available_offering.Columns["Stat"].Width = 60;
                    Available_offering.ClearSelection();
                    Available_offering.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Available_offering_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Available_offering.Rows[e.RowIndex];
                selectedOfferingId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }

        private void CO_dropOffer_Click(object sender, EventArgs e)
        {
            if (selectedOfferingId == 0)
            {
                MessageBox.Show("Please select an offer first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Remove this Offer?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No) return;

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection()) // changed
                {
                    conn.Open();
                    string sql = "DELETE FROM class_offering WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedOfferingId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Offer has been removed.");
                selectedOfferingId = 0;
                LoadOfferingComboBox();
                CO_selectToDisplay_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
