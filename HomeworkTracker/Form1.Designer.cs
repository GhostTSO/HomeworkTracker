namespace HomeworkTracker
{
    partial class MainForm
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
            this.HomeworkPanel = new System.Windows.Forms.Panel();
            this.Demo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CompletedPanel = new System.Windows.Forms.Panel();
            this.CourseDropDown = new System.Windows.Forms.ComboBox();
            this.SortDropDown = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SortTypeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ObjectTypeDropdown = new System.Windows.Forms.ComboBox();
            this.StudyTrendsButton = new System.Windows.Forms.Button();
            this.StartStudyButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NotificationButton = new System.Windows.Forms.Button();
            this.CustomizeButton = new System.Windows.Forms.Button();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.SortRequestLabel = new System.Windows.Forms.Label();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.StudyPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.CompletedTitlePanel = new System.Windows.Forms.Panel();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HomeworkViewTitlePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.AddCoursePanel = new System.Windows.Forms.Panel();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCourseInstructorTextbox = new System.Windows.Forms.TextBox();
            this.AddCourseCourseShortTextbox = new System.Windows.Forms.TextBox();
            this.AddCourseCourseTexbox = new System.Windows.Forms.TextBox();
            this.AddAssignmentPanel = new System.Windows.Forms.Panel();
            this.AddAssignmentConfirmButton = new System.Windows.Forms.Button();
            this.AddAssignmentDueDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.AddAssignmentDescriptionField = new System.Windows.Forms.RichTextBox();
            this.AddAssignmentPointTextbox = new System.Windows.Forms.TextBox();
            this.AddAssignmentNameTextbox = new System.Windows.Forms.TextBox();
            this.AddAssignmentDateLabel = new System.Windows.Forms.Label();
            this.AddAssignmentDPointLabel = new System.Windows.Forms.Label();
            this.AddAssignmentAssignmentNameLabel = new System.Windows.Forms.Label();
            this.AddAssignmentDescriptionLabel = new System.Windows.Forms.Label();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.DeleteConfirmButton = new System.Windows.Forms.Button();
            this.DeleteAssignmentDropdown = new System.Windows.Forms.ComboBox();
            this.DeleteCourseDropdown = new System.Windows.Forms.ComboBox();
            this.DeleteAssignmentLabel = new System.Windows.Forms.Label();
            this.DeleteCourseLabel = new System.Windows.Forms.Label();
            this.HomeworkPanel.SuspendLayout();
            this.SortPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.StudyPanel.SuspendLayout();
            this.CompletedTitlePanel.SuspendLayout();
            this.HomeworkViewTitlePanel.SuspendLayout();
            this.AddCoursePanel.SuspendLayout();
            this.AddAssignmentPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeworkPanel
            // 
            this.HomeworkPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HomeworkPanel.Controls.Add(this.Demo);
            this.HomeworkPanel.Controls.Add(this.panel5);
            this.HomeworkPanel.Location = new System.Drawing.Point(338, 42);
            this.HomeworkPanel.Name = "HomeworkPanel";
            this.HomeworkPanel.Size = new System.Drawing.Size(909, 297);
            this.HomeworkPanel.TabIndex = 0;
            // 
            // Demo
            // 
            this.Demo.Location = new System.Drawing.Point(304, 94);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(278, 123);
            this.Demo.TabIndex = 21;
            this.Demo.Text = "Demo";
            this.Demo.UseVisualStyleBackColor = true;
            this.Demo.Click += new System.EventHandler(this.Demo_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkBlue;
            this.panel5.Location = new System.Drawing.Point(0, -41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(909, 42);
            this.panel5.TabIndex = 0;
            // 
            // CompletedPanel
            // 
            this.CompletedPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CompletedPanel.Location = new System.Drawing.Point(338, 379);
            this.CompletedPanel.Name = "CompletedPanel";
            this.CompletedPanel.Size = new System.Drawing.Size(909, 272);
            this.CompletedPanel.TabIndex = 1;
            // 
            // CourseDropDown
            // 
            this.CourseDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseDropDown.FormattingEnabled = true;
            this.CourseDropDown.Location = new System.Drawing.Point(108, 45);
            this.CourseDropDown.Name = "CourseDropDown";
            this.CourseDropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CourseDropDown.Size = new System.Drawing.Size(149, 24);
            this.CourseDropDown.TabIndex = 2;
            // 
            // SortDropDown
            // 
            this.SortDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortDropDown.FormattingEnabled = true;
            this.SortDropDown.Location = new System.Drawing.Point(108, 102);
            this.SortDropDown.Name = "SortDropDown";
            this.SortDropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SortDropDown.Size = new System.Drawing.Size(149, 24);
            this.SortDropDown.TabIndex = 3;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(43, 153);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(187, 23);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Generate";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CourseLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.CourseLabel.Location = new System.Drawing.Point(3, 45);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(82, 25);
            this.CourseLabel.TabIndex = 5;
            this.CourseLabel.Text = "Course:";
            // 
            // SortTypeLabel
            // 
            this.SortTypeLabel.AutoSize = true;
            this.SortTypeLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.SortTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortTypeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.SortTypeLabel.Location = new System.Drawing.Point(3, 102);
            this.SortTypeLabel.Name = "SortTypeLabel";
            this.SortTypeLabel.Size = new System.Drawing.Size(104, 25);
            this.SortTypeLabel.TabIndex = 6;
            this.SortTypeLabel.Text = "Sort Type:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(71, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 36);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(202, 26);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(36, 36);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "-";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteLabel.Location = new System.Drawing.Point(114, 29);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(74, 25);
            this.DeleteLabel.TabIndex = 9;
            this.DeleteLabel.Text = "Delete:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add:";
            // 
            // ObjectTypeDropdown
            // 
            this.ObjectTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectTypeDropdown.FormattingEnabled = true;
            this.ObjectTypeDropdown.Items.AddRange(new object[] {
            "Course",
            "Assignment"});
            this.ObjectTypeDropdown.SelectedIndex = 0;
            this.ObjectTypeDropdown.Location = new System.Drawing.Point(71, 86);
            this.ObjectTypeDropdown.Name = "ObjectTypeDropdown";
            this.ObjectTypeDropdown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ObjectTypeDropdown.Size = new System.Drawing.Size(122, 24);
            this.ObjectTypeDropdown.TabIndex = 11;
            // 
            // StudyTrendsButton
            // 
            this.StudyTrendsButton.Location = new System.Drawing.Point(43, 68);
            this.StudyTrendsButton.Name = "StudyTrendsButton";
            this.StudyTrendsButton.Size = new System.Drawing.Size(183, 23);
            this.StudyTrendsButton.TabIndex = 13;
            this.StudyTrendsButton.Text = "View Study Trends";
            this.StudyTrendsButton.UseVisualStyleBackColor = true;
            // 
            // StartStudyButton
            // 
            this.StartStudyButton.Location = new System.Drawing.Point(43, 30);
            this.StartStudyButton.Name = "StartStudyButton";
            this.StartStudyButton.Size = new System.Drawing.Size(183, 23);
            this.StartStudyButton.TabIndex = 14;
            this.StartStudyButton.Text = "Start Study Session";
            this.StartStudyButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(35, 503);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(230, 23);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // NotificationButton
            // 
            this.NotificationButton.Location = new System.Drawing.Point(35, 583);
            this.NotificationButton.Name = "NotificationButton";
            this.NotificationButton.Size = new System.Drawing.Size(230, 23);
            this.NotificationButton.TabIndex = 16;
            this.NotificationButton.Text = "Notification";
            this.NotificationButton.UseVisualStyleBackColor = true;
            // 
            // CustomizeButton
            // 
            this.CustomizeButton.Location = new System.Drawing.Point(35, 543);
            this.CustomizeButton.Name = "CustomizeButton";
            this.CustomizeButton.Size = new System.Drawing.Size(230, 23);
            this.CustomizeButton.TabIndex = 17;
            this.CustomizeButton.Text = "Customize";
            this.CustomizeButton.UseVisualStyleBackColor = true;
            // 
            // SortPanel
            // 
            this.SortPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.SortPanel.Controls.Add(this.SortRequestLabel);
            this.SortPanel.Controls.Add(this.CourseDropDown);
            this.SortPanel.Controls.Add(this.SortDropDown);
            this.SortPanel.Controls.Add(this.SortButton);
            this.SortPanel.Controls.Add(this.SortTypeLabel);
            this.SortPanel.Controls.Add(this.CourseLabel);
            this.SortPanel.Location = new System.Drawing.Point(27, 31);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(267, 196);
            this.SortPanel.TabIndex = 18;
            // 
            // SortRequestLabel
            // 
            this.SortRequestLabel.AutoSize = true;
            this.SortRequestLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.SortRequestLabel.Location = new System.Drawing.Point(82, 11);
            this.SortRequestLabel.Name = "SortRequestLabel";
            this.SortRequestLabel.Size = new System.Drawing.Size(91, 17);
            this.SortRequestLabel.TabIndex = 19;
            this.SortRequestLabel.Text = "Sort Request";
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.EditPanel.Controls.Add(this.label9);
            this.EditPanel.Controls.Add(this.DeleteButton);
            this.EditPanel.Controls.Add(this.AddButton);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.DeleteLabel);
            this.EditPanel.Controls.Add(this.ObjectTypeDropdown);
            this.EditPanel.Location = new System.Drawing.Point(27, 238);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(267, 132);
            this.EditPanel.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(8, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Course and Assignment Management";
            // 
            // StudyPanel
            // 
            this.StudyPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.StudyPanel.Controls.Add(this.label10);
            this.StudyPanel.Controls.Add(this.StartStudyButton);
            this.StudyPanel.Controls.Add(this.StudyTrendsButton);
            this.StudyPanel.Location = new System.Drawing.Point(27, 379);
            this.StudyPanel.Name = "StudyPanel";
            this.StudyPanel.Size = new System.Drawing.Size(267, 104);
            this.StudyPanel.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(82, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Study Tracker";
            // 
            // CompletedTitlePanel
            // 
            this.CompletedTitlePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.CompletedTitlePanel.Controls.Add(this.CompletedLabel);
            this.CompletedTitlePanel.Location = new System.Drawing.Point(338, 338);
            this.CompletedTitlePanel.Name = "CompletedTitlePanel";
            this.CompletedTitlePanel.Size = new System.Drawing.Size(909, 45);
            this.CompletedTitlePanel.TabIndex = 0;
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CompletedLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.CompletedLabel.Location = new System.Drawing.Point(394, 10);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(107, 25);
            this.CompletedLabel.TabIndex = 0;
            this.CompletedLabel.Text = "Completed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(716, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Homework View";
            // 
            // HomeworkViewTitlePanel
            // 
            this.HomeworkViewTitlePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.HomeworkViewTitlePanel.Controls.Add(this.label8);
            this.HomeworkViewTitlePanel.Location = new System.Drawing.Point(338, -1);
            this.HomeworkViewTitlePanel.Name = "HomeworkViewTitlePanel";
            this.HomeworkViewTitlePanel.Size = new System.Drawing.Size(909, 48);
            this.HomeworkViewTitlePanel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(378, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Homework View";
            // 
            // AddCoursePanel
            // 
            this.AddCoursePanel.Controls.Add(this.AddCourseButton);
            this.AddCoursePanel.Controls.Add(this.label5);
            this.AddCoursePanel.Controls.Add(this.label2);
            this.AddCoursePanel.Controls.Add(this.label1);
            this.AddCoursePanel.Controls.Add(this.AddCourseInstructorTextbox);
            this.AddCoursePanel.Controls.Add(this.AddCourseCourseShortTextbox);
            this.AddCoursePanel.Controls.Add(this.AddCourseCourseTexbox);
            this.AddCoursePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddCoursePanel.Location = new System.Drawing.Point(597, 0);
            this.AddCoursePanel.Name = "AddCoursePanel";
            this.AddCoursePanel.Size = new System.Drawing.Size(648, 650);
            this.AddCoursePanel.TabIndex = 21;
            this.AddCoursePanel.Visible = false;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddCourseButton.Location = new System.Drawing.Point(344, 503);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(163, 57);
            this.AddCourseButton.TabIndex = 7;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(90, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Instructor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(64, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course Short Hand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(119, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course Name";
            // 
            // AddCourseInstructorTextbox
            // 
            this.AddCourseInstructorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddCourseInstructorTextbox.Location = new System.Drawing.Point(326, 389);
            this.AddCourseInstructorTextbox.Name = "AddCourseInstructorTextbox";
            this.AddCourseInstructorTextbox.Size = new System.Drawing.Size(196, 34);
            this.AddCourseInstructorTextbox.TabIndex = 2;
            // 
            // AddCourseCourseShortTextbox
            // 
            this.AddCourseCourseShortTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddCourseCourseShortTextbox.Location = new System.Drawing.Point(326, 284);
            this.AddCourseCourseShortTextbox.Name = "AddCourseCourseShortTextbox";
            this.AddCourseCourseShortTextbox.Size = new System.Drawing.Size(196, 34);
            this.AddCourseCourseShortTextbox.TabIndex = 1;
            // 
            // AddCourseCourseTexbox
            // 
            this.AddCourseCourseTexbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddCourseCourseTexbox.Location = new System.Drawing.Point(326, 174);
            this.AddCourseCourseTexbox.Name = "AddCourseCourseTexbox";
            this.AddCourseCourseTexbox.Size = new System.Drawing.Size(196, 34);
            this.AddCourseCourseTexbox.TabIndex = 0;
            // 
            // AddAssignmentPanel
            // 
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentConfirmButton);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentDueDateCalendar);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentDescriptionField);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentPointTextbox);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentNameTextbox);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentDateLabel);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentDPointLabel);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentAssignmentNameLabel);
            this.AddAssignmentPanel.Controls.Add(this.AddAssignmentDescriptionLabel);
            this.AddAssignmentPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddAssignmentPanel.Location = new System.Drawing.Point(0, 0);
            this.AddAssignmentPanel.Name = "AddAssignmentPanel";
            this.AddAssignmentPanel.Size = new System.Drawing.Size(675, 650);
            this.AddAssignmentPanel.TabIndex = 22;
            this.AddAssignmentPanel.Visible = false;
            // 
            // AddAssignmentConfirmButton
            // 
            this.AddAssignmentConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddAssignmentConfirmButton.Location = new System.Drawing.Point(354, 567);
            this.AddAssignmentConfirmButton.Name = "AddAssignmentConfirmButton";
            this.AddAssignmentConfirmButton.Size = new System.Drawing.Size(237, 39);
            this.AddAssignmentConfirmButton.TabIndex = 10;
            this.AddAssignmentConfirmButton.Text = "Add Assignment";
            this.AddAssignmentConfirmButton.UseVisualStyleBackColor = true;
            this.AddAssignmentConfirmButton.Click += new System.EventHandler(this.AddAssignmentConfirmButton_Click);
            // 
            // AddAssignmentDueDateCalendar
            // 
            this.AddAssignmentDueDateCalendar.Location = new System.Drawing.Point(347, 335);
            this.AddAssignmentDueDateCalendar.MaxSelectionCount = 1;
            this.AddAssignmentDueDateCalendar.Name = "AddAssignmentDueDateCalendar";
            this.AddAssignmentDueDateCalendar.TabIndex = 9;
            // 
            // AddAssignmentDescriptionField
            // 
            this.AddAssignmentDescriptionField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddAssignmentDescriptionField.Location = new System.Drawing.Point(354, 117);
            this.AddAssignmentDescriptionField.Name = "AddAssignmentDescriptionField";
            this.AddAssignmentDescriptionField.Size = new System.Drawing.Size(237, 122);
            this.AddAssignmentDescriptionField.TabIndex = 8;
            this.AddAssignmentDescriptionField.Text = "";
            // 
            // AddAssignmentPointTextbox
            // 
            this.AddAssignmentPointTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddAssignmentPointTextbox.Location = new System.Drawing.Point(354, 266);
            this.AddAssignmentPointTextbox.Name = "AddAssignmentPointTextbox";
            this.AddAssignmentPointTextbox.Size = new System.Drawing.Size(237, 34);
            this.AddAssignmentPointTextbox.TabIndex = 7;
            // 
            // AddAssignmentNameTextbox
            // 
            this.AddAssignmentNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddAssignmentNameTextbox.Location = new System.Drawing.Point(354, 53);
            this.AddAssignmentNameTextbox.Name = "AddAssignmentNameTextbox";
            this.AddAssignmentNameTextbox.Size = new System.Drawing.Size(237, 34);
            this.AddAssignmentNameTextbox.TabIndex = 4;
            // 
            // AddAssignmentDateLabel
            // 
            this.AddAssignmentDateLabel.AutoSize = true;
            this.AddAssignmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddAssignmentDateLabel.Location = new System.Drawing.Point(129, 360);
            this.AddAssignmentDateLabel.Name = "AddAssignmentDateLabel";
            this.AddAssignmentDateLabel.Size = new System.Drawing.Size(113, 29);
            this.AddAssignmentDateLabel.TabIndex = 3;
            this.AddAssignmentDateLabel.Text = "Due Date";
            // 
            // AddAssignmentDPointLabel
            // 
            this.AddAssignmentDPointLabel.AutoSize = true;
            this.AddAssignmentDPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddAssignmentDPointLabel.Location = new System.Drawing.Point(130, 271);
            this.AddAssignmentDPointLabel.Name = "AddAssignmentDPointLabel";
            this.AddAssignmentDPointLabel.Size = new System.Drawing.Size(135, 29);
            this.AddAssignmentDPointLabel.TabIndex = 2;
            this.AddAssignmentDPointLabel.Text = "Point Value";
            // 
            // AddAssignmentAssignmentNameLabel
            // 
            this.AddAssignmentAssignmentNameLabel.AutoSize = true;
            this.AddAssignmentAssignmentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddAssignmentAssignmentNameLabel.Location = new System.Drawing.Point(98, 56);
            this.AddAssignmentAssignmentNameLabel.Name = "AddAssignmentAssignmentNameLabel";
            this.AddAssignmentAssignmentNameLabel.Size = new System.Drawing.Size(209, 29);
            this.AddAssignmentAssignmentNameLabel.TabIndex = 1;
            this.AddAssignmentAssignmentNameLabel.Text = "Assignment Name";
            // 
            // AddAssignmentDescriptionLabel
            // 
            this.AddAssignmentDescriptionLabel.AutoSize = true;
            this.AddAssignmentDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddAssignmentDescriptionLabel.Location = new System.Drawing.Point(107, 152);
            this.AddAssignmentDescriptionLabel.Name = "AddAssignmentDescriptionLabel";
            this.AddAssignmentDescriptionLabel.Size = new System.Drawing.Size(135, 29);
            this.AddAssignmentDescriptionLabel.TabIndex = 0;
            this.AddAssignmentDescriptionLabel.Text = "Description";
            // 
            // DeletePanel
            // 
            this.DeletePanel.Controls.Add(this.DeleteConfirmButton);
            this.DeletePanel.Controls.Add(this.DeleteAssignmentDropdown);
            this.DeletePanel.Controls.Add(this.DeleteCourseDropdown);
            this.DeletePanel.Controls.Add(this.DeleteAssignmentLabel);
            this.DeletePanel.Controls.Add(this.DeleteCourseLabel);
            this.DeletePanel.Location = new System.Drawing.Point(375, 133);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(601, 379);
            this.DeletePanel.TabIndex = 11;
            this.DeletePanel.Visible = false;
            // 
            // DeleteConfirmButton
            // 
            this.DeleteConfirmButton.Location = new System.Drawing.Point(325, 276);
            this.DeleteConfirmButton.Name = "DeleteConfirmButton";
            this.DeleteConfirmButton.Size = new System.Drawing.Size(131, 34);
            this.DeleteConfirmButton.TabIndex = 4;
            this.DeleteConfirmButton.Text = "Delete";
            this.DeleteConfirmButton.UseVisualStyleBackColor = true;
            this.DeleteConfirmButton.Click += new System.EventHandler(this.DeleteConfirmButton_Click);
            // 
            // DeleteAssignmentDropdown
            // 
            this.DeleteAssignmentDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteAssignmentDropdown.FormattingEnabled = true;
            this.DeleteAssignmentDropdown.Location = new System.Drawing.Point(325, 191);
            this.DeleteAssignmentDropdown.Name = "DeleteAssignmentDropdown";
            this.DeleteAssignmentDropdown.Size = new System.Drawing.Size(121, 37);
            this.DeleteAssignmentDropdown.TabIndex = 3;
            // 
            // DeleteCourseDropdown
            // 
            this.DeleteCourseDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteCourseDropdown.FormattingEnabled = true;
            this.DeleteCourseDropdown.Location = new System.Drawing.Point(325, 89);
            this.DeleteCourseDropdown.Name = "DeleteCourseDropdown";
            this.DeleteCourseDropdown.Size = new System.Drawing.Size(121, 37);
            this.DeleteCourseDropdown.TabIndex = 2;
            // 
            // DeleteAssignmentLabel
            // 
            this.DeleteAssignmentLabel.AutoSize = true;
            this.DeleteAssignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteAssignmentLabel.Location = new System.Drawing.Point(69, 194);
            this.DeleteAssignmentLabel.Name = "DeleteAssignmentLabel";
            this.DeleteAssignmentLabel.Size = new System.Drawing.Size(212, 29);
            this.DeleteAssignmentLabel.TabIndex = 1;
            this.DeleteAssignmentLabel.Text = "Select Assignment";
            // 
            // DeleteCourseLabel
            // 
            this.DeleteCourseLabel.AutoSize = true;
            this.DeleteCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteCourseLabel.Location = new System.Drawing.Point(69, 92);
            this.DeleteCourseLabel.Name = "DeleteCourseLabel";
            this.DeleteCourseLabel.Size = new System.Drawing.Size(165, 29);
            this.DeleteCourseLabel.TabIndex = 0;
            this.DeleteCourseLabel.Text = "Select Course";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1245, 650);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.CompletedTitlePanel);
            this.Controls.Add(this.HomeworkViewTitlePanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustomizeButton);
            this.Controls.Add(this.NotificationButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.StudyPanel);
            this.Controls.Add(this.CompletedPanel);
            this.Controls.Add(this.HomeworkPanel);
            this.Controls.Add(this.AddCoursePanel);
            this.Controls.Add(this.AddAssignmentPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.HomeworkPanel.ResumeLayout(false);
            this.SortPanel.ResumeLayout(false);
            this.SortPanel.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.StudyPanel.ResumeLayout(false);
            this.StudyPanel.PerformLayout();
            this.CompletedTitlePanel.ResumeLayout(false);
            this.CompletedTitlePanel.PerformLayout();
            this.HomeworkViewTitlePanel.ResumeLayout(false);
            this.HomeworkViewTitlePanel.PerformLayout();
            this.AddCoursePanel.ResumeLayout(false);
            this.AddCoursePanel.PerformLayout();
            this.AddAssignmentPanel.ResumeLayout(false);
            this.AddAssignmentPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HomeworkPanel;
        private System.Windows.Forms.Panel CompletedPanel;
        private System.Windows.Forms.ComboBox CourseDropDown;
        private System.Windows.Forms.ComboBox SortDropDown;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label SortTypeLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox ObjectTypeDropdown;
        private System.Windows.Forms.Button StudyTrendsButton;
        private System.Windows.Forms.Button StartStudyButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button NotificationButton;
        private System.Windows.Forms.Button CustomizeButton;
        private System.Windows.Forms.Panel SortPanel;
        private System.Windows.Forms.Label SortRequestLabel;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Panel StudyPanel;
        private System.Windows.Forms.Panel CompletedTitlePanel;
        private System.Windows.Forms.Label CompletedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel HomeworkViewTitlePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Demo;
        private System.Windows.Forms.Panel AddCoursePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddCourseInstructorTextbox;
        private System.Windows.Forms.TextBox AddCourseCourseShortTextbox;
        private System.Windows.Forms.TextBox AddCourseCourseTexbox;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Panel AddAssignmentPanel;
        private System.Windows.Forms.RichTextBox AddAssignmentDescriptionField;
        private System.Windows.Forms.TextBox AddAssignmentPointTextbox;
        private System.Windows.Forms.TextBox AddAssignmentNameTextbox;
        private System.Windows.Forms.Label AddAssignmentDateLabel;
        private System.Windows.Forms.Label AddAssignmentDPointLabel;
        private System.Windows.Forms.Label AddAssignmentAssignmentNameLabel;
        private System.Windows.Forms.Label AddAssignmentDescriptionLabel;
        private System.Windows.Forms.Button AddAssignmentConfirmButton;
        private System.Windows.Forms.MonthCalendar AddAssignmentDueDateCalendar;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Button DeleteConfirmButton;
        private System.Windows.Forms.ComboBox DeleteAssignmentDropdown;
        private System.Windows.Forms.ComboBox DeleteCourseDropdown;
        private System.Windows.Forms.Label DeleteAssignmentLabel;
        private System.Windows.Forms.Label DeleteCourseLabel;
    }
}

