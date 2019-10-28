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
            this.panel5 = new System.Windows.Forms.Panel();
            this.CompletedPanel = new System.Windows.Forms.Panel();
            this.CourseDropDown = new System.Windows.Forms.ComboBox();
            this.SortDropDown = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SortTypeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnknownDropbox1 = new System.Windows.Forms.ComboBox();
            this.UnknownDropbox2 = new System.Windows.Forms.ComboBox();
            this.StudyTrendsButton = new System.Windows.Forms.Button();
            this.StartStudyButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NotificationButton = new System.Windows.Forms.Button();
            this.CustomizeButton = new System.Windows.Forms.Button();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.SortRequestLabel = new System.Windows.Forms.Label();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.StudyPanel = new System.Windows.Forms.Panel();
            this.CompletedTitlePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HomeworkViewTitlePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Demo = new System.Windows.Forms.Button();
            this.HomeworkPanel.SuspendLayout();
            this.SortPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.StudyPanel.SuspendLayout();
            this.CompletedTitlePanel.SuspendLayout();
            this.HomeworkViewTitlePanel.SuspendLayout();
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
            this.AddButton.Location = new System.Drawing.Point(8, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 36);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(50, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delete:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(53, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add:";
            // 
            // UnknownDropbox1
            // 
            this.UnknownDropbox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnknownDropbox1.FormattingEnabled = true;
            this.UnknownDropbox1.Location = new System.Drawing.Point(130, 28);
            this.UnknownDropbox1.Name = "UnknownDropbox1";
            this.UnknownDropbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UnknownDropbox1.Size = new System.Drawing.Size(122, 24);
            this.UnknownDropbox1.TabIndex = 11;
            // 
            // UnknownDropbox2
            // 
            this.UnknownDropbox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnknownDropbox2.FormattingEnabled = true;
            this.UnknownDropbox2.Location = new System.Drawing.Point(130, 81);
            this.UnknownDropbox2.Name = "UnknownDropbox2";
            this.UnknownDropbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UnknownDropbox2.Size = new System.Drawing.Size(122, 24);
            this.UnknownDropbox2.TabIndex = 12;
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
            this.EditPanel.Controls.Add(this.button2);
            this.EditPanel.Controls.Add(this.AddButton);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.UnknownDropbox2);
            this.EditPanel.Controls.Add(this.UnknownDropbox1);
            this.EditPanel.Location = new System.Drawing.Point(27, 238);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(267, 132);
            this.EditPanel.TabIndex = 19;
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
            // CompletedTitlePanel
            // 
            this.CompletedTitlePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.CompletedTitlePanel.Controls.Add(this.label6);
            this.CompletedTitlePanel.Location = new System.Drawing.Point(338, 335);
            this.CompletedTitlePanel.Name = "CompletedTitlePanel";
            this.CompletedTitlePanel.Size = new System.Drawing.Size(909, 45);
            this.CompletedTitlePanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(405, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Completed";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1245, 650);
            this.Controls.Add(this.HomeworkViewTitlePanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CompletedTitlePanel);
            this.Controls.Add(this.CustomizeButton);
            this.Controls.Add(this.NotificationButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CompletedPanel);
            this.Controls.Add(this.HomeworkPanel);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.StudyPanel);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox UnknownDropbox1;
        private System.Windows.Forms.ComboBox UnknownDropbox2;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel HomeworkViewTitlePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Demo;
    }
}

