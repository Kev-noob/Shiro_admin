namespace Super_Admin_Rolly
{
    partial class Class_offering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CO_container = new System.Windows.Forms.Panel();
            this.CO_dropOffer = new System.Windows.Forms.Label();
            this.Select_course = new System.Windows.Forms.Label();
            this.CO_selectToDisplay = new System.Windows.Forms.Label();
            this.CO_selectCourse = new System.Windows.Forms.ComboBox();
            this.Available_offering = new System.Windows.Forms.DataGridView();
            this.CO_sidePanel = new System.Windows.Forms.Panel();
            this.CO_Clear = new System.Windows.Forms.Button();
            this.CO_CreateOffering = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.CO_close = new System.Windows.Forms.Button();
            this.CO_open = new System.Windows.Forms.Button();
            this.School_Year = new System.Windows.Forms.Label();
            this.CO_schoolYear = new System.Windows.Forms.TextBox();
            this.maximum_student = new System.Windows.Forms.Label();
            this.CO_maxStudent = new System.Windows.Forms.TextBox();
            this.Time_end = new System.Windows.Forms.Label();
            this.Time_start = new System.Windows.Forms.Label();
            this.CO_timeEnd = new System.Windows.Forms.DateTimePicker();
            this.CO_timeStart = new System.Windows.Forms.DateTimePicker();
            this.Days = new System.Windows.Forms.Label();
            this.CO_days = new System.Windows.Forms.ComboBox();
            this.Room = new System.Windows.Forms.Label();
            this.CO_room = new System.Windows.Forms.TextBox();
            this.Semester = new System.Windows.Forms.Label();
            this.CO_semester = new System.Windows.Forms.ComboBox();
            this.Year_Level = new System.Windows.Forms.Label();
            this.CO_yearLv = new System.Windows.Forms.ComboBox();
            this.instructor = new System.Windows.Forms.Label();
            this.CO_instructor = new System.Windows.Forms.ComboBox();
            this.Subject = new System.Windows.Forms.Label();
            this.CO_subject = new System.Windows.Forms.ComboBox();
            this.course = new System.Windows.Forms.Label();
            this.CO_course = new System.Windows.Forms.ComboBox();
            this.LINE = new System.Windows.Forms.Panel();
            this.CO_topPanel = new System.Windows.Forms.Panel();
            this.classOffering = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CO_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Available_offering)).BeginInit();
            this.CO_sidePanel.SuspendLayout();
            this.CO_topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CO_container);
            this.panel1.Controls.Add(this.CO_sidePanel);
            this.panel1.Controls.Add(this.CO_topPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 681);
            this.panel1.TabIndex = 13;
            // 
            // CO_container
            // 
            this.CO_container.BackColor = System.Drawing.Color.White;
            this.CO_container.Controls.Add(this.CO_dropOffer);
            this.CO_container.Controls.Add(this.Select_course);
            this.CO_container.Controls.Add(this.CO_selectToDisplay);
            this.CO_container.Controls.Add(this.CO_selectCourse);
            this.CO_container.Controls.Add(this.Available_offering);
            this.CO_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CO_container.Font = new System.Drawing.Font("Noto Sans JP", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CO_container.ForeColor = System.Drawing.Color.Maroon;
            this.CO_container.Location = new System.Drawing.Point(0, 223);
            this.CO_container.Name = "CO_container";
            this.CO_container.Size = new System.Drawing.Size(939, 458);
            this.CO_container.TabIndex = 11;
            // 
            // CO_dropOffer
            // 
            this.CO_dropOffer.BackColor = System.Drawing.Color.Transparent;
            this.CO_dropOffer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CO_dropOffer.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_dropOffer.ForeColor = System.Drawing.Color.Black;
            this.CO_dropOffer.Location = new System.Drawing.Point(589, 70);
            this.CO_dropOffer.Name = "CO_dropOffer";
            this.CO_dropOffer.Size = new System.Drawing.Size(98, 24);
            this.CO_dropOffer.TabIndex = 47;
            this.CO_dropOffer.Text = "Drop";
            this.CO_dropOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CO_dropOffer.Click += new System.EventHandler(this.CO_dropOffer_Click);
            // 
            // Select_course
            // 
            this.Select_course.AutoSize = true;
            this.Select_course.Font = new System.Drawing.Font("Noto Sans JP Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Select_course.ForeColor = System.Drawing.Color.Black;
            this.Select_course.Location = new System.Drawing.Point(37, 32);
            this.Select_course.Name = "Select_course";
            this.Select_course.Size = new System.Drawing.Size(119, 24);
            this.Select_course.TabIndex = 46;
            this.Select_course.Text = "Select course";
            // 
            // CO_selectToDisplay
            // 
            this.CO_selectToDisplay.BackColor = System.Drawing.Color.Transparent;
            this.CO_selectToDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CO_selectToDisplay.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_selectToDisplay.ForeColor = System.Drawing.Color.Black;
            this.CO_selectToDisplay.Location = new System.Drawing.Point(693, 70);
            this.CO_selectToDisplay.Name = "CO_selectToDisplay";
            this.CO_selectToDisplay.Size = new System.Drawing.Size(98, 24);
            this.CO_selectToDisplay.TabIndex = 45;
            this.CO_selectToDisplay.Text = "Select";
            this.CO_selectToDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CO_selectToDisplay.Click += new System.EventHandler(this.CO_selectToDisplay_Click);
            // 
            // CO_selectCourse
            // 
            this.CO_selectCourse.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_selectCourse.ForeColor = System.Drawing.Color.Black;
            this.CO_selectCourse.FormattingEnabled = true;
            this.CO_selectCourse.Location = new System.Drawing.Point(162, 29);
            this.CO_selectCourse.Name = "CO_selectCourse";
            this.CO_selectCourse.Size = new System.Drawing.Size(629, 27);
            this.CO_selectCourse.TabIndex = 44;
            // 
            // Available_offering
            // 
            this.Available_offering.AllowUserToAddRows = false;
            this.Available_offering.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Available_offering.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Available_offering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Available_offering.ColumnHeadersHeight = 40;
            this.Available_offering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Available_offering.Location = new System.Drawing.Point(3, 107);
            this.Available_offering.MultiSelect = false;
            this.Available_offering.Name = "Available_offering";
            this.Available_offering.ReadOnly = true;
            this.Available_offering.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Available_offering.Size = new System.Drawing.Size(936, 348);
            this.Available_offering.TabIndex = 1;
            this.Available_offering.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Available_offering_CellClick);
            // 
            // CO_sidePanel
            // 
            this.CO_sidePanel.BackColor = System.Drawing.Color.White;
            this.CO_sidePanel.Controls.Add(this.CO_Clear);
            this.CO_sidePanel.Controls.Add(this.CO_CreateOffering);
            this.CO_sidePanel.Controls.Add(this.Status);
            this.CO_sidePanel.Controls.Add(this.CO_close);
            this.CO_sidePanel.Controls.Add(this.CO_open);
            this.CO_sidePanel.Controls.Add(this.School_Year);
            this.CO_sidePanel.Controls.Add(this.CO_schoolYear);
            this.CO_sidePanel.Controls.Add(this.maximum_student);
            this.CO_sidePanel.Controls.Add(this.CO_maxStudent);
            this.CO_sidePanel.Controls.Add(this.Time_end);
            this.CO_sidePanel.Controls.Add(this.Time_start);
            this.CO_sidePanel.Controls.Add(this.CO_timeEnd);
            this.CO_sidePanel.Controls.Add(this.CO_timeStart);
            this.CO_sidePanel.Controls.Add(this.Days);
            this.CO_sidePanel.Controls.Add(this.CO_days);
            this.CO_sidePanel.Controls.Add(this.Room);
            this.CO_sidePanel.Controls.Add(this.CO_room);
            this.CO_sidePanel.Controls.Add(this.Semester);
            this.CO_sidePanel.Controls.Add(this.CO_semester);
            this.CO_sidePanel.Controls.Add(this.Year_Level);
            this.CO_sidePanel.Controls.Add(this.CO_yearLv);
            this.CO_sidePanel.Controls.Add(this.instructor);
            this.CO_sidePanel.Controls.Add(this.CO_instructor);
            this.CO_sidePanel.Controls.Add(this.Subject);
            this.CO_sidePanel.Controls.Add(this.CO_subject);
            this.CO_sidePanel.Controls.Add(this.course);
            this.CO_sidePanel.Controls.Add(this.CO_course);
            this.CO_sidePanel.Controls.Add(this.LINE);
            this.CO_sidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CO_sidePanel.Location = new System.Drawing.Point(0, 47);
            this.CO_sidePanel.Name = "CO_sidePanel";
            this.CO_sidePanel.Size = new System.Drawing.Size(939, 644);
            this.CO_sidePanel.TabIndex = 9;
            // 
            // CO_Clear
            // 
            this.CO_Clear.BackColor = System.Drawing.Color.Transparent;
            this.CO_Clear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CO_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CO_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CO_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CO_Clear.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CO_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CO_Clear.Location = new System.Drawing.Point(829, 136);
            this.CO_Clear.Name = "CO_Clear";
            this.CO_Clear.Size = new System.Drawing.Size(105, 28);
            this.CO_Clear.TabIndex = 35;
            this.CO_Clear.Text = "Clear ";
            this.CO_Clear.UseVisualStyleBackColor = false;
            this.CO_Clear.Click += new System.EventHandler(this.CO_Clear_Click);
            // 
            // CO_CreateOffering
            // 
            this.CO_CreateOffering.BackColor = System.Drawing.Color.DimGray;
            this.CO_CreateOffering.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CO_CreateOffering.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CO_CreateOffering.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CO_CreateOffering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CO_CreateOffering.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CO_CreateOffering.ForeColor = System.Drawing.Color.White;
            this.CO_CreateOffering.Location = new System.Drawing.Point(705, 136);
            this.CO_CreateOffering.Name = "CO_CreateOffering";
            this.CO_CreateOffering.Size = new System.Drawing.Size(103, 28);
            this.CO_CreateOffering.TabIndex = 34;
            this.CO_CreateOffering.Text = "Create Offering";
            this.CO_CreateOffering.UseVisualStyleBackColor = false;
            this.CO_CreateOffering.Click += new System.EventHandler(this.CO_CreateOffering_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(701, 15);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(53, 19);
            this.Status.TabIndex = 33;
            this.Status.Text = "Status";
            // 
            // CO_close
            // 
            this.CO_close.BackColor = System.Drawing.Color.Transparent;
            this.CO_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CO_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CO_close.Font = new System.Drawing.Font("Noto Sans JP Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CO_close.ForeColor = System.Drawing.Color.Black;
            this.CO_close.Location = new System.Drawing.Point(705, 86);
            this.CO_close.Name = "CO_close";
            this.CO_close.Size = new System.Drawing.Size(230, 27);
            this.CO_close.TabIndex = 32;
            this.CO_close.Text = "Close";
            this.CO_close.UseVisualStyleBackColor = false;
            this.CO_close.Click += new System.EventHandler(this.CO_close_Click);
            // 
            // CO_open
            // 
            this.CO_open.BackColor = System.Drawing.Color.Transparent;
            this.CO_open.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CO_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CO_open.Font = new System.Drawing.Font("Noto Sans JP Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CO_open.ForeColor = System.Drawing.Color.Black;
            this.CO_open.Location = new System.Drawing.Point(704, 37);
            this.CO_open.Name = "CO_open";
            this.CO_open.Size = new System.Drawing.Size(230, 27);
            this.CO_open.TabIndex = 0;
            this.CO_open.Text = "Open";
            this.CO_open.UseVisualStyleBackColor = false;
            this.CO_open.Click += new System.EventHandler(this.CO_open_Click);
            // 
            // School_Year
            // 
            this.School_Year.AutoSize = true;
            this.School_Year.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.School_Year.ForeColor = System.Drawing.Color.Black;
            this.School_Year.Location = new System.Drawing.Point(525, 117);
            this.School_Year.Name = "School_Year";
            this.School_Year.Size = new System.Drawing.Size(79, 19);
            this.School_Year.TabIndex = 31;
            this.School_Year.Text = "Shool Year";
            // 
            // CO_schoolYear
            // 
            this.CO_schoolYear.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_schoolYear.ForeColor = System.Drawing.Color.Black;
            this.CO_schoolYear.Location = new System.Drawing.Point(530, 139);
            this.CO_schoolYear.Name = "CO_schoolYear";
            this.CO_schoolYear.Size = new System.Drawing.Size(160, 26);
            this.CO_schoolYear.TabIndex = 30;
            // 
            // maximum_student
            // 
            this.maximum_student.AutoSize = true;
            this.maximum_student.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximum_student.ForeColor = System.Drawing.Color.Black;
            this.maximum_student.Location = new System.Drawing.Point(525, 69);
            this.maximum_student.Name = "maximum_student";
            this.maximum_student.Size = new System.Drawing.Size(140, 19);
            this.maximum_student.TabIndex = 29;
            this.maximum_student.Text = "Maximum Students";
            // 
            // CO_maxStudent
            // 
            this.CO_maxStudent.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_maxStudent.ForeColor = System.Drawing.Color.Black;
            this.CO_maxStudent.Location = new System.Drawing.Point(530, 88);
            this.CO_maxStudent.Name = "CO_maxStudent";
            this.CO_maxStudent.Size = new System.Drawing.Size(160, 26);
            this.CO_maxStudent.TabIndex = 28;
            // 
            // Time_end
            // 
            this.Time_end.AutoSize = true;
            this.Time_end.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_end.ForeColor = System.Drawing.Color.Black;
            this.Time_end.Location = new System.Drawing.Point(612, 18);
            this.Time_end.Name = "Time_end";
            this.Time_end.Size = new System.Drawing.Size(71, 19);
            this.Time_end.TabIndex = 27;
            this.Time_end.Text = "Time End";
            // 
            // Time_start
            // 
            this.Time_start.AutoSize = true;
            this.Time_start.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_start.ForeColor = System.Drawing.Color.Black;
            this.Time_start.Location = new System.Drawing.Point(526, 16);
            this.Time_start.Name = "Time_start";
            this.Time_start.Size = new System.Drawing.Size(79, 19);
            this.Time_start.TabIndex = 26;
            this.Time_start.Text = "Time Start";
            // 
            // CO_timeEnd
            // 
            this.CO_timeEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_timeEnd.CalendarForeColor = System.Drawing.Color.Maroon;
            this.CO_timeEnd.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.CO_timeEnd.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.CO_timeEnd.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.CO_timeEnd.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.CO_timeEnd.CustomFormat = "hh:mm tt";
            this.CO_timeEnd.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CO_timeEnd.Location = new System.Drawing.Point(611, 39);
            this.CO_timeEnd.Name = "CO_timeEnd";
            this.CO_timeEnd.ShowUpDown = true;
            this.CO_timeEnd.Size = new System.Drawing.Size(79, 26);
            this.CO_timeEnd.TabIndex = 25;
            // 
            // CO_timeStart
            // 
            this.CO_timeStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_timeStart.CalendarForeColor = System.Drawing.Color.Maroon;
            this.CO_timeStart.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.CO_timeStart.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.CO_timeStart.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.CO_timeStart.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.CO_timeStart.CustomFormat = "hh:mm tt";
            this.CO_timeStart.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CO_timeStart.Location = new System.Drawing.Point(529, 38);
            this.CO_timeStart.Name = "CO_timeStart";
            this.CO_timeStart.ShowUpDown = true;
            this.CO_timeStart.Size = new System.Drawing.Size(79, 26);
            this.CO_timeStart.TabIndex = 0;
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.ForeColor = System.Drawing.Color.Black;
            this.Days.Location = new System.Drawing.Point(260, 115);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(41, 19);
            this.Days.TabIndex = 24;
            this.Days.Text = "Days";
            // 
            // CO_days
            // 
            this.CO_days.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_days.ForeColor = System.Drawing.Color.Black;
            this.CO_days.FormattingEnabled = true;
            this.CO_days.Items.AddRange(new object[] {
            "MWF ",
            "TTHS ",
            "S "});
            this.CO_days.Location = new System.Drawing.Point(265, 137);
            this.CO_days.Name = "CO_days";
            this.CO_days.Size = new System.Drawing.Size(243, 27);
            this.CO_days.TabIndex = 23;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.ForeColor = System.Drawing.Color.Black;
            this.Room.Location = new System.Drawing.Point(261, 67);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(47, 19);
            this.Room.TabIndex = 22;
            this.Room.Text = "Room";
            // 
            // CO_room
            // 
            this.CO_room.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_room.ForeColor = System.Drawing.Color.Black;
            this.CO_room.Location = new System.Drawing.Point(265, 86);
            this.CO_room.Name = "CO_room";
            this.CO_room.Size = new System.Drawing.Size(242, 26);
            this.CO_room.TabIndex = 21;
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semester.ForeColor = System.Drawing.Color.Black;
            this.Semester.Location = new System.Drawing.Point(389, 15);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(73, 19);
            this.Semester.TabIndex = 20;
            this.Semester.Text = "Semester";
            // 
            // CO_semester
            // 
            this.CO_semester.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_semester.ForeColor = System.Drawing.Color.Black;
            this.CO_semester.FormattingEnabled = true;
            this.CO_semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CO_semester.Location = new System.Drawing.Point(393, 37);
            this.CO_semester.Name = "CO_semester";
            this.CO_semester.Size = new System.Drawing.Size(115, 27);
            this.CO_semester.TabIndex = 19;
            // 
            // Year_Level
            // 
            this.Year_Level.AutoSize = true;
            this.Year_Level.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_Level.ForeColor = System.Drawing.Color.Black;
            this.Year_Level.Location = new System.Drawing.Point(261, 15);
            this.Year_Level.Name = "Year_Level";
            this.Year_Level.Size = new System.Drawing.Size(78, 19);
            this.Year_Level.TabIndex = 18;
            this.Year_Level.Text = "Year Level";
            // 
            // CO_yearLv
            // 
            this.CO_yearLv.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_yearLv.ForeColor = System.Drawing.Color.Black;
            this.CO_yearLv.FormattingEnabled = true;
            this.CO_yearLv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CO_yearLv.Location = new System.Drawing.Point(265, 37);
            this.CO_yearLv.Name = "CO_yearLv";
            this.CO_yearLv.Size = new System.Drawing.Size(115, 27);
            this.CO_yearLv.TabIndex = 17;
            // 
            // instructor
            // 
            this.instructor.AutoSize = true;
            this.instructor.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructor.ForeColor = System.Drawing.Color.Black;
            this.instructor.Location = new System.Drawing.Point(5, 114);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(78, 19);
            this.instructor.TabIndex = 16;
            this.instructor.Text = "Instructor";
            // 
            // CO_instructor
            // 
            this.CO_instructor.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_instructor.ForeColor = System.Drawing.Color.Black;
            this.CO_instructor.FormattingEnabled = true;
            this.CO_instructor.Location = new System.Drawing.Point(9, 136);
            this.CO_instructor.Name = "CO_instructor";
            this.CO_instructor.Size = new System.Drawing.Size(243, 27);
            this.CO_instructor.TabIndex = 15;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.ForeColor = System.Drawing.Color.Black;
            this.Subject.Location = new System.Drawing.Point(5, 64);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(60, 19);
            this.Subject.TabIndex = 14;
            this.Subject.Text = "Subject";
            // 
            // CO_subject
            // 
            this.CO_subject.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_subject.ForeColor = System.Drawing.Color.Black;
            this.CO_subject.FormattingEnabled = true;
            this.CO_subject.Location = new System.Drawing.Point(9, 86);
            this.CO_subject.Name = "CO_subject";
            this.CO_subject.Size = new System.Drawing.Size(243, 27);
            this.CO_subject.TabIndex = 13;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Noto Sans JP Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.Black;
            this.course.Location = new System.Drawing.Point(7, 14);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(56, 19);
            this.course.TabIndex = 12;
            this.course.Text = "Course";
            // 
            // CO_course
            // 
            this.CO_course.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_course.ForeColor = System.Drawing.Color.Black;
            this.CO_course.FormattingEnabled = true;
            this.CO_course.Location = new System.Drawing.Point(10, 36);
            this.CO_course.Name = "CO_course";
            this.CO_course.Size = new System.Drawing.Size(243, 27);
            this.CO_course.TabIndex = 11;
            this.CO_course.SelectedIndexChanged += new System.EventHandler(this.CO_course_SelectedIndexChanged);
            // 
            // LINE
            // 
            this.LINE.BackColor = System.Drawing.Color.LightGray;
            this.LINE.Location = new System.Drawing.Point(31, 183);
            this.LINE.Name = "LINE";
            this.LINE.Size = new System.Drawing.Size(910, 3);
            this.LINE.TabIndex = 10;
            // 
            // CO_topPanel
            // 
            this.CO_topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CO_topPanel.Controls.Add(this.classOffering);
            this.CO_topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CO_topPanel.Location = new System.Drawing.Point(0, 0);
            this.CO_topPanel.Name = "CO_topPanel";
            this.CO_topPanel.Size = new System.Drawing.Size(939, 47);
            this.CO_topPanel.TabIndex = 8;
            // 
            // classOffering
            // 
            this.classOffering.AutoSize = true;
            this.classOffering.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.classOffering.ForeColor = System.Drawing.Color.White;
            this.classOffering.Location = new System.Drawing.Point(349, 6);
            this.classOffering.Name = "classOffering";
            this.classOffering.Size = new System.Drawing.Size(177, 35);
            this.classOffering.TabIndex = 0;
            this.classOffering.Text = "Class Offering";
            // 
            // Class_offering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Class_offering";
            this.Text = "Class_offering";
            this.panel1.ResumeLayout(false);
            this.CO_container.ResumeLayout(false);
            this.CO_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Available_offering)).EndInit();
            this.CO_sidePanel.ResumeLayout(false);
            this.CO_sidePanel.PerformLayout();
            this.CO_topPanel.ResumeLayout(false);
            this.CO_topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CO_container;
        private System.Windows.Forms.Label CO_dropOffer;
        private System.Windows.Forms.Label Select_course;
        private System.Windows.Forms.Label CO_selectToDisplay;
        private System.Windows.Forms.ComboBox CO_selectCourse;
        private System.Windows.Forms.DataGridView Available_offering;
        private System.Windows.Forms.Panel CO_sidePanel;
        private System.Windows.Forms.Button CO_Clear;
        private System.Windows.Forms.Button CO_CreateOffering;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button CO_close;
        private System.Windows.Forms.Button CO_open;
        private System.Windows.Forms.Label School_Year;
        private System.Windows.Forms.TextBox CO_schoolYear;
        private System.Windows.Forms.Label maximum_student;
        private System.Windows.Forms.TextBox CO_maxStudent;
        private System.Windows.Forms.Label Time_end;
        private System.Windows.Forms.Label Time_start;
        private System.Windows.Forms.DateTimePicker CO_timeEnd;
        private System.Windows.Forms.DateTimePicker CO_timeStart;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.ComboBox CO_days;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.TextBox CO_room;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.ComboBox CO_semester;
        private System.Windows.Forms.Label Year_Level;
        private System.Windows.Forms.ComboBox CO_yearLv;
        private System.Windows.Forms.Label instructor;
        private System.Windows.Forms.ComboBox CO_instructor;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.ComboBox CO_subject;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.ComboBox CO_course;
        private System.Windows.Forms.Panel LINE;
        private System.Windows.Forms.Panel CO_topPanel;
        private System.Windows.Forms.Label classOffering;
    }
}