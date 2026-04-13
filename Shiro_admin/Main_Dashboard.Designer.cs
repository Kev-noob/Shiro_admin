namespace Super_Admin_Rolly
{
    partial class Main_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Enrollment_ = new System.Windows.Forms.Panel();
            this.courses_ = new System.Windows.Forms.Panel();
            this.courses_DataGridView = new System.Windows.Forms.DataGridView();
            this.course_Code = new System.Windows.Forms.TextBox();
            this.course_Name = new System.Windows.Forms.TextBox();
            this.department_ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addCourse = new System.Windows.Forms.Button();
            this.editCourse = new System.Windows.Forms.Button();
            this.delateCourse = new System.Windows.Forms.Button();
            this.clear_inputs = new System.Windows.Forms.Button();
            this.subjects_ = new System.Windows.Forms.Panel();
            this.subject_code = new System.Windows.Forms.TextBox();
            this.subjects_name = new System.Windows.Forms.TextBox();
            this.subjects_unit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delate = new System.Windows.Forms.Button();
            this.subject_clear = new System.Windows.Forms.Button();
            this.subjects_dataGridView = new System.Windows.Forms.DataGridView();
            this.side_panel = new System.Windows.Forms.Panel();
            this.subject_switch = new System.Windows.Forms.Button();
            this.course_switch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Main_Container = new System.Windows.Forms.Panel();
            this.Contents = new System.Windows.Forms.Panel();
            this.Instructor_ = new System.Windows.Forms.Panel();
            this.drop_permanent = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.approved_INS = new System.Windows.Forms.DataGridView();
            this.drop_pend = new System.Windows.Forms.Button();
            this.approve_pend = new System.Windows.Forms.Button();
            this.pending_INS = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Admins_ = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Billing_ = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Buttons = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.enrollment = new System.Windows.Forms.Button();
            this.instructor = new System.Windows.Forms.Button();
            this.billing = new System.Windows.Forms.Button();
            this.admins = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Home_ = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Dashboard_ = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Enrollment_.SuspendLayout();
            this.courses_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courses_DataGridView)).BeginInit();
            this.subjects_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_dataGridView)).BeginInit();
            this.side_panel.SuspendLayout();
            this.Main_Container.SuspendLayout();
            this.Contents.SuspendLayout();
            this.Instructor_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approved_INS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pending_INS)).BeginInit();
            this.Admins_.SuspendLayout();
            this.Billing_.SuspendLayout();
            this.Buttons.SuspendLayout();
            this.Home_.SuspendLayout();
            this.Dashboard_.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enrollment_
            // 
            this.Enrollment_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enrollment_.Controls.Add(this.courses_);
            this.Enrollment_.Controls.Add(this.subjects_);
            this.Enrollment_.Controls.Add(this.side_panel);
            this.Enrollment_.Location = new System.Drawing.Point(0, 0);
            this.Enrollment_.Name = "Enrollment_";
            this.Enrollment_.Size = new System.Drawing.Size(900, 524);
            this.Enrollment_.TabIndex = 10;
            // 
            // courses_
            // 
            this.courses_.BackColor = System.Drawing.Color.AliceBlue;
            this.courses_.Controls.Add(this.courses_DataGridView);
            this.courses_.Controls.Add(this.course_Code);
            this.courses_.Controls.Add(this.course_Name);
            this.courses_.Controls.Add(this.department_);
            this.courses_.Controls.Add(this.label10);
            this.courses_.Controls.Add(this.label9);
            this.courses_.Controls.Add(this.label8);
            this.courses_.Controls.Add(this.addCourse);
            this.courses_.Controls.Add(this.editCourse);
            this.courses_.Controls.Add(this.delateCourse);
            this.courses_.Controls.Add(this.clear_inputs);
            this.courses_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courses_.Location = new System.Drawing.Point(174, 0);
            this.courses_.Name = "courses_";
            this.courses_.Size = new System.Drawing.Size(726, 524);
            this.courses_.TabIndex = 36;
            // 
            // courses_DataGridView
            // 
            this.courses_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courses_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courses_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.courses_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses_DataGridView.Location = new System.Drawing.Point(13, 228);
            this.courses_DataGridView.Name = "courses_DataGridView";
            this.courses_DataGridView.Size = new System.Drawing.Size(701, 283);
            this.courses_DataGridView.TabIndex = 24;
            this.courses_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesDataGridView_CellClick);
            // 
            // course_Code
            // 
            this.course_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_Code.Location = new System.Drawing.Point(186, 39);
            this.course_Code.Multiline = true;
            this.course_Code.Name = "course_Code";
            this.course_Code.Size = new System.Drawing.Size(438, 25);
            this.course_Code.TabIndex = 25;
            // 
            // course_Name
            // 
            this.course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_Name.Location = new System.Drawing.Point(186, 89);
            this.course_Name.Multiline = true;
            this.course_Name.Name = "course_Name";
            this.course_Name.Size = new System.Drawing.Size(438, 25);
            this.course_Name.TabIndex = 26;
            // 
            // department_
            // 
            this.department_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_.Location = new System.Drawing.Point(186, 134);
            this.department_.Multiline = true;
            this.department_.Name = "department_";
            this.department_.Size = new System.Drawing.Size(438, 25);
            this.department_.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(51, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Course name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(57, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Course code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(64, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Department:";
            // 
            // addCourse
            // 
            this.addCourse.BackColor = System.Drawing.Color.Transparent;
            this.addCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.addCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourse.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addCourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCourse.Location = new System.Drawing.Point(289, 192);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(141, 29);
            this.addCourse.TabIndex = 31;
            this.addCourse.Text = "Add Course";
            this.addCourse.UseVisualStyleBackColor = false;
            this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // editCourse
            // 
            this.editCourse.BackColor = System.Drawing.Color.Transparent;
            this.editCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.editCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.editCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCourse.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.editCourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.editCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editCourse.Location = new System.Drawing.Point(436, 193);
            this.editCourse.Name = "editCourse";
            this.editCourse.Size = new System.Drawing.Size(131, 29);
            this.editCourse.TabIndex = 32;
            this.editCourse.Text = "Edit Course";
            this.editCourse.UseVisualStyleBackColor = false;
            this.editCourse.Click += new System.EventHandler(this.editCourse_Click);
            // 
            // delateCourse
            // 
            this.delateCourse.BackColor = System.Drawing.Color.Transparent;
            this.delateCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.delateCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.delateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delateCourse.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delateCourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.delateCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delateCourse.Location = new System.Drawing.Point(573, 193);
            this.delateCourse.Name = "delateCourse";
            this.delateCourse.Size = new System.Drawing.Size(141, 29);
            this.delateCourse.TabIndex = 33;
            this.delateCourse.Text = "Delete Course";
            this.delateCourse.UseVisualStyleBackColor = false;
            this.delateCourse.Click += new System.EventHandler(this.delateCourse_Click);
            // 
            // clear_inputs
            // 
            this.clear_inputs.BackColor = System.Drawing.Color.Transparent;
            this.clear_inputs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.clear_inputs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.clear_inputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_inputs.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clear_inputs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clear_inputs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_inputs.Location = new System.Drawing.Point(152, 192);
            this.clear_inputs.Name = "clear_inputs";
            this.clear_inputs.Size = new System.Drawing.Size(131, 29);
            this.clear_inputs.TabIndex = 35;
            this.clear_inputs.Text = "Clear";
            this.clear_inputs.UseVisualStyleBackColor = false;
            this.clear_inputs.Click += new System.EventHandler(this.clear_inputs_Click);
            // 
            // subjects_
            // 
            this.subjects_.BackColor = System.Drawing.Color.AliceBlue;
            this.subjects_.Controls.Add(this.subject_code);
            this.subjects_.Controls.Add(this.subjects_name);
            this.subjects_.Controls.Add(this.subjects_unit);
            this.subjects_.Controls.Add(this.label1);
            this.subjects_.Controls.Add(this.label2);
            this.subjects_.Controls.Add(this.label3);
            this.subjects_.Controls.Add(this.add);
            this.subjects_.Controls.Add(this.edit);
            this.subjects_.Controls.Add(this.delate);
            this.subjects_.Controls.Add(this.subject_clear);
            this.subjects_.Controls.Add(this.subjects_dataGridView);
            this.subjects_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjects_.Location = new System.Drawing.Point(174, 0);
            this.subjects_.Name = "subjects_";
            this.subjects_.Size = new System.Drawing.Size(726, 524);
            this.subjects_.TabIndex = 36;
            // 
            // subject_code
            // 
            this.subject_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_code.Location = new System.Drawing.Point(186, 40);
            this.subject_code.Multiline = true;
            this.subject_code.Name = "subject_code";
            this.subject_code.Size = new System.Drawing.Size(438, 25);
            this.subject_code.TabIndex = 37;
            // 
            // subjects_name
            // 
            this.subjects_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjects_name.Location = new System.Drawing.Point(186, 90);
            this.subjects_name.Multiline = true;
            this.subjects_name.Name = "subjects_name";
            this.subjects_name.Size = new System.Drawing.Size(438, 25);
            this.subjects_name.TabIndex = 38;
            // 
            // subjects_unit
            // 
            this.subjects_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjects_unit.Location = new System.Drawing.Point(186, 135);
            this.subjects_unit.Multiline = true;
            this.subjects_unit.Name = "subjects_unit";
            this.subjects_unit.Size = new System.Drawing.Size(438, 25);
            this.subjects_unit.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Subject name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(57, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Subject code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(115, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Units:";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.add.ForeColor = System.Drawing.Color.MidnightBlue;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(289, 193);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(141, 29);
            this.add.TabIndex = 43;
            this.add.Text = "Add Subject";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(436, 194);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(131, 29);
            this.edit.TabIndex = 44;
            this.edit.Text = "Edit Subject";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delate
            // 
            this.delate.BackColor = System.Drawing.Color.Transparent;
            this.delate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.delate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.delate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delate.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.delate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delate.Location = new System.Drawing.Point(573, 194);
            this.delate.Name = "delate";
            this.delate.Size = new System.Drawing.Size(141, 29);
            this.delate.TabIndex = 45;
            this.delate.Text = "Delete Subject";
            this.delate.UseVisualStyleBackColor = false;
            this.delate.Click += new System.EventHandler(this.delate_Click);
            // 
            // subject_clear
            // 
            this.subject_clear.BackColor = System.Drawing.Color.Transparent;
            this.subject_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.subject_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.subject_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_clear.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subject_clear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.subject_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subject_clear.Location = new System.Drawing.Point(152, 193);
            this.subject_clear.Name = "subject_clear";
            this.subject_clear.Size = new System.Drawing.Size(131, 29);
            this.subject_clear.TabIndex = 47;
            this.subject_clear.Text = "Clear";
            this.subject_clear.UseVisualStyleBackColor = false;
            this.subject_clear.Click += new System.EventHandler(this.subject_clear_Click);
            // 
            // subjects_dataGridView
            // 
            this.subjects_dataGridView.AllowUserToAddRows = false;
            this.subjects_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjects_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjects_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.subjects_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjects_dataGridView.Location = new System.Drawing.Point(13, 229);
            this.subjects_dataGridView.Name = "subjects_dataGridView";
            this.subjects_dataGridView.Size = new System.Drawing.Size(701, 283);
            this.subjects_dataGridView.TabIndex = 36;
            this.subjects_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.side_panel.Controls.Add(this.subject_switch);
            this.side_panel.Controls.Add(this.course_switch);
            this.side_panel.Controls.Add(this.label4);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(174, 524);
            this.side_panel.TabIndex = 48;
            // 
            // subject_switch
            // 
            this.subject_switch.BackColor = System.Drawing.Color.Transparent;
            this.subject_switch.FlatAppearance.BorderSize = 0;
            this.subject_switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.subject_switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.subject_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_switch.Font = new System.Drawing.Font("Noto Sans JP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subject_switch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.subject_switch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subject_switch.Location = new System.Drawing.Point(0, 203);
            this.subject_switch.Name = "subject_switch";
            this.subject_switch.Size = new System.Drawing.Size(174, 62);
            this.subject_switch.TabIndex = 48;
            this.subject_switch.Text = "Subject";
            this.subject_switch.UseVisualStyleBackColor = false;
            this.subject_switch.Click += new System.EventHandler(this.subject_switch_Click);
            // 
            // course_switch
            // 
            this.course_switch.BackColor = System.Drawing.Color.Transparent;
            this.course_switch.FlatAppearance.BorderSize = 0;
            this.course_switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.course_switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.course_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course_switch.Font = new System.Drawing.Font("Noto Sans JP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.course_switch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.course_switch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.course_switch.Location = new System.Drawing.Point(0, 135);
            this.course_switch.Name = "course_switch";
            this.course_switch.Size = new System.Drawing.Size(174, 62);
            this.course_switch.TabIndex = 47;
            this.course_switch.Text = "Course";
            this.course_switch.UseVisualStyleBackColor = false;
            this.course_switch.Click += new System.EventHandler(this.course_switch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans JP Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(21, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 39);
            this.label4.TabIndex = 46;
            this.label4.Text = "Options";
            // 
            // Main_Container
            // 
            this.Main_Container.Controls.Add(this.Contents);
            this.Main_Container.Controls.Add(this.Buttons);
            this.Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Container.Location = new System.Drawing.Point(0, 0);
            this.Main_Container.Name = "Main_Container";
            this.Main_Container.Size = new System.Drawing.Size(900, 600);
            this.Main_Container.TabIndex = 48;
            // 
            // Contents
            // 
            this.Contents.Controls.Add(this.Instructor_);
            this.Contents.Controls.Add(this.Home_);
            this.Contents.Controls.Add(this.Enrollment_);
            this.Contents.Controls.Add(this.Admins_);
            this.Contents.Controls.Add(this.Billing_);
            this.Contents.Controls.Add(this.Dashboard_);
            this.Contents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Contents.Location = new System.Drawing.Point(0, 68);
            this.Contents.Name = "Contents";
            this.Contents.Size = new System.Drawing.Size(900, 532);
            this.Contents.TabIndex = 0;
            // 
            // Instructor_
            // 
            this.Instructor_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Instructor_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Instructor_.Controls.Add(this.drop_permanent);
            this.Instructor_.Controls.Add(this.label26);
            this.Instructor_.Controls.Add(this.approved_INS);
            this.Instructor_.Controls.Add(this.drop_pend);
            this.Instructor_.Controls.Add(this.approve_pend);
            this.Instructor_.Controls.Add(this.pending_INS);
            this.Instructor_.Controls.Add(this.label6);
            this.Instructor_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Instructor_.Location = new System.Drawing.Point(0, 0);
            this.Instructor_.Name = "Instructor_";
            this.Instructor_.Size = new System.Drawing.Size(900, 532);
            this.Instructor_.TabIndex = 12;
            // 
            // drop_permanent
            // 
            this.drop_permanent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drop_permanent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.drop_permanent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.drop_permanent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_permanent.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.drop_permanent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.drop_permanent.Location = new System.Drawing.Point(674, 483);
            this.drop_permanent.Name = "drop_permanent";
            this.drop_permanent.Size = new System.Drawing.Size(77, 28);
            this.drop_permanent.TabIndex = 24;
            this.drop_permanent.Text = "Delate";
            this.drop_permanent.UseVisualStyleBackColor = false;
            this.drop_permanent.Click += new System.EventHandler(this.drop_permanent_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Noto Sans JP Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label26.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label26.Location = new System.Drawing.Point(12, 238);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(220, 27);
            this.label26.TabIndex = 19;
            this.label26.Text = "Permanent Instructors";
            // 
            // approved_INS
            // 
            this.approved_INS.AllowUserToAddRows = false;
            this.approved_INS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.approved_INS.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.approved_INS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approved_INS.Location = new System.Drawing.Point(12, 271);
            this.approved_INS.Name = "approved_INS";
            this.approved_INS.ReadOnly = true;
            this.approved_INS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.approved_INS.Size = new System.Drawing.Size(656, 240);
            this.approved_INS.TabIndex = 18;
            this.approved_INS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.approved_INS_CellClick);
            // 
            // drop_pend
            // 
            this.drop_pend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drop_pend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.drop_pend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.drop_pend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_pend.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.drop_pend.ForeColor = System.Drawing.Color.MidnightBlue;
            this.drop_pend.Location = new System.Drawing.Point(674, 192);
            this.drop_pend.Name = "drop_pend";
            this.drop_pend.Size = new System.Drawing.Size(77, 28);
            this.drop_pend.TabIndex = 17;
            this.drop_pend.Text = "Delate";
            this.drop_pend.UseVisualStyleBackColor = false;
            this.drop_pend.Click += new System.EventHandler(this.drop_pend_Click);
            // 
            // approve_pend
            // 
            this.approve_pend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.approve_pend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.approve_pend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.approve_pend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve_pend.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.approve_pend.ForeColor = System.Drawing.Color.MidnightBlue;
            this.approve_pend.Location = new System.Drawing.Point(674, 155);
            this.approve_pend.Name = "approve_pend";
            this.approve_pend.Size = new System.Drawing.Size(77, 28);
            this.approve_pend.TabIndex = 16;
            this.approve_pend.Text = "Approve";
            this.approve_pend.UseVisualStyleBackColor = false;
            this.approve_pend.Click += new System.EventHandler(this.approve_pend_Click);
            // 
            // pending_INS
            // 
            this.pending_INS.AllowUserToAddRows = false;
            this.pending_INS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pending_INS.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.pending_INS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pending_INS.Location = new System.Drawing.Point(12, 53);
            this.pending_INS.Name = "pending_INS";
            this.pending_INS.ReadOnly = true;
            this.pending_INS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pending_INS.Size = new System.Drawing.Size(656, 168);
            this.pending_INS.TabIndex = 15;
            this.pending_INS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pending_INS_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans JP Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pending Instructors";
            // 
            // Admins_
            // 
            this.Admins_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admins_.Controls.Add(this.label11);
            this.Admins_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admins_.Location = new System.Drawing.Point(0, 0);
            this.Admins_.Name = "Admins_";
            this.Admins_.Size = new System.Drawing.Size(900, 532);
            this.Admins_.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(301, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "Billing";
            // 
            // Billing_
            // 
            this.Billing_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Billing_.Controls.Add(this.label7);
            this.Billing_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Billing_.Location = new System.Drawing.Point(0, 0);
            this.Billing_.Name = "Billing_";
            this.Billing_.Size = new System.Drawing.Size(900, 532);
            this.Billing_.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(301, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "BiIling";
            // 
            // Buttons
            // 
            this.Buttons.BackColor = System.Drawing.Color.DimGray;
            this.Buttons.Controls.Add(this.home);
            this.Buttons.Controls.Add(this.dashboard);
            this.Buttons.Controls.Add(this.enrollment);
            this.Buttons.Controls.Add(this.instructor);
            this.Buttons.Controls.Add(this.billing);
            this.Buttons.Controls.Add(this.admins);
            this.Buttons.Controls.Add(this.logout);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.Buttons.Location = new System.Drawing.Point(0, 0);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(900, 70);
            this.Buttons.TabIndex = 8;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(311, 15);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(83, 38);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(386, 15);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(94, 38);
            this.dashboard.TabIndex = 2;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // enrollment
            // 
            this.enrollment.BackColor = System.Drawing.Color.Transparent;
            this.enrollment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enrollment.FlatAppearance.BorderSize = 0;
            this.enrollment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.enrollment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.enrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollment.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollment.ForeColor = System.Drawing.Color.White;
            this.enrollment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrollment.Location = new System.Drawing.Point(487, 15);
            this.enrollment.Name = "enrollment";
            this.enrollment.Size = new System.Drawing.Size(88, 38);
            this.enrollment.TabIndex = 3;
            this.enrollment.Text = "Enrollment";
            this.enrollment.UseVisualStyleBackColor = false;
            this.enrollment.Click += new System.EventHandler(this.enrollment_Click);
            // 
            // instructor
            // 
            this.instructor.BackColor = System.Drawing.Color.Transparent;
            this.instructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.instructor.FlatAppearance.BorderSize = 0;
            this.instructor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.instructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.instructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructor.ForeColor = System.Drawing.Color.White;
            this.instructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instructor.Location = new System.Drawing.Point(579, 15);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(88, 38);
            this.instructor.TabIndex = 4;
            this.instructor.Text = "Instructor";
            this.instructor.UseVisualStyleBackColor = false;
            this.instructor.Click += new System.EventHandler(this.instructor_Click);
            // 
            // billing
            // 
            this.billing.BackColor = System.Drawing.Color.Transparent;
            this.billing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.billing.FlatAppearance.BorderSize = 0;
            this.billing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.billing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billing.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing.ForeColor = System.Drawing.Color.White;
            this.billing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billing.Location = new System.Drawing.Point(657, 15);
            this.billing.Name = "billing";
            this.billing.Size = new System.Drawing.Size(88, 38);
            this.billing.TabIndex = 5;
            this.billing.Text = "Billing";
            this.billing.UseVisualStyleBackColor = false;
            this.billing.Click += new System.EventHandler(this.button4_Click);
            // 
            // admins
            // 
            this.admins.BackColor = System.Drawing.Color.Transparent;
            this.admins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admins.FlatAppearance.BorderSize = 0;
            this.admins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.admins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.admins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admins.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admins.ForeColor = System.Drawing.Color.White;
            this.admins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admins.Location = new System.Drawing.Point(740, 14);
            this.admins.Name = "admins";
            this.admins.Size = new System.Drawing.Size(82, 38);
            this.admins.TabIndex = 6;
            this.admins.Text = "Admins";
            this.admins.UseVisualStyleBackColor = false;
            this.admins.Click += new System.EventHandler(this.button5_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(809, 15);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(88, 38);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Home_
            // 
            this.Home_.BackgroundImage = global::Super_Admin_Rolly.Properties.Resources._2;
            this.Home_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home_.Controls.Add(this.label13);
            this.Home_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_.Location = new System.Drawing.Point(0, 0);
            this.Home_.Name = "Home_";
            this.Home_.Size = new System.Drawing.Size(900, 532);
            this.Home_.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Noto Sans JP Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(67, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(374, 139);
            this.label13.TabIndex = 1;
            this.label13.Text = "Admin";
            // 
            // Dashboard_
            // 
            this.Dashboard_.BackgroundImage = global::Super_Admin_Rolly.Properties.Resources.white_tip;
            this.Dashboard_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dashboard_.Controls.Add(this.label5);
            this.Dashboard_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard_.Location = new System.Drawing.Point(0, 0);
            this.Dashboard_.Name = "Dashboard_";
            this.Dashboard_.Size = new System.Drawing.Size(900, 532);
            this.Dashboard_.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(336, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dashboard";
            // 
            // Main_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Main_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Dashboard";
            this.Enrollment_.ResumeLayout(false);
            this.courses_.ResumeLayout(false);
            this.courses_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courses_DataGridView)).EndInit();
            this.subjects_.ResumeLayout(false);
            this.subjects_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_dataGridView)).EndInit();
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            this.Main_Container.ResumeLayout(false);
            this.Contents.ResumeLayout(false);
            this.Instructor_.ResumeLayout(false);
            this.Instructor_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approved_INS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pending_INS)).EndInit();
            this.Admins_.ResumeLayout(false);
            this.Admins_.PerformLayout();
            this.Billing_.ResumeLayout(false);
            this.Billing_.PerformLayout();
            this.Buttons.ResumeLayout(false);
            this.Home_.ResumeLayout(false);
            this.Home_.PerformLayout();
            this.Dashboard_.ResumeLayout(false);
            this.Dashboard_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button enrollment;
        private System.Windows.Forms.Button instructor;
        private System.Windows.Forms.Button billing;
        private System.Windows.Forms.Button admins;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel Buttons;
        private System.Windows.Forms.Panel Dashboard_;
        private System.Windows.Forms.Panel Enrollment_;
        private System.Windows.Forms.Panel Home_;
        private System.Windows.Forms.Button clear_inputs;
        private System.Windows.Forms.Button delateCourse;
        private System.Windows.Forms.Button editCourse;
        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox department_;
        private System.Windows.Forms.TextBox course_Name;
        private System.Windows.Forms.TextBox course_Code;
        private System.Windows.Forms.DataGridView courses_DataGridView;
        private System.Windows.Forms.Panel courses_;
        private System.Windows.Forms.Panel subjects_;
        private System.Windows.Forms.TextBox subject_code;
        private System.Windows.Forms.TextBox subjects_name;
        private System.Windows.Forms.TextBox subjects_unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button subject_clear;
        private System.Windows.Forms.DataGridView subjects_dataGridView;
        private System.Windows.Forms.Panel Main_Container;
        private System.Windows.Forms.Panel Contents;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button subject_switch;
        private System.Windows.Forms.Button course_switch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Billing_;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Instructor_;
        private System.Windows.Forms.Panel Admins_;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button drop_permanent;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView approved_INS;
        private System.Windows.Forms.Button drop_pend;
        private System.Windows.Forms.Button approve_pend;
        private System.Windows.Forms.DataGridView pending_INS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
    }
}