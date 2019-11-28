using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class MainForm : Form
    {
        private List<Course> courses = new List<Course>();
        Notifications notifications = new Notifications();
        StudySession studySession = new StudySession();
        DisplayThemes themes;
        public MainForm()
        {
            InitializeComponent();
            loadInfo();
            themes = new DisplayThemes(0, 80, 255, "Default");
            addColorChoices();
            UpdateAssignmentDisplay();
        }

        private void addColorChoices()
        {
            foreach(Button button in themes.getColorButtons())
            {
                this.CustomizationPanel.Controls.Add(button);
            }
        }


        //Event handling Confirmed Add Course Button being clicked
        private void AddCourseConfirmButton_Click(object sender, EventArgs e)
        {
            //checks to see if these course boxes have filled values
            if (this.AddCourseCourseTexbox.TextLength > 0 && this.AddCourseCourseShortTextbox.TextLength > 0)
            {
                
                //Parse the boxes and create a course object into our course collection
                Course course = new Course(this.AddCourseCourseTexbox.Text, this.AddCourseCourseShortTextbox.Text,
                                        Color.Black, this.AddCourseInstructorTextbox.Text);
                course.saveCourse();
                courses.Add(course);

                //resetting back to standard display
                this.CourseDropDown.Items.Add(this.AddCourseCourseShortTextbox.Text);
                this.AddCoursePanel.SendToBack();
                this.AddCoursePanel.Visible = false;
                this.CourseDropDown.SelectedIndex = this.CourseDropDown.Items.Count-1;
            }
        }

        //Event handling Confirmed Add Assignment Button being clicked
        private void AddAssignmentConfirmButton_Click(object sender, EventArgs e)
        {
            //checks that an assignment name was typed
                //checks that a course was selected
                    //checks if point value was entered
            if(this.AddAssignmentNameTextbox.TextLength > 0 && 
                this.AddAssignmentCourseDropDown.SelectedIndex > -1 && 
                    this.AddAssignmentPointTextbox.TextLength > 0)
            {
                //try catch to see if point value is actually parseble
                try
                {
                    //adds an assignment object in the selected course by parsing the data inputted
                    Assignment assignment = new Assignment(this.AddAssignmentNameTextbox.Text, 
                                                    this.AddAssignmentCourseDropDown.Text,
                                                    "", 
                                                    float.Parse(this.AddAssignmentPointTextbox.Text),
                                                    Int32.Parse(this.AddAssignmentPriorityTextbox.Text),
                                                    this.AddAssignmentDueDateCalendar.SelectionStart);

                    assignment.saveAssignment();
                    courses.ElementAt(this.AddAssignmentCourseDropDown.SelectedIndex).addAssignment(assignment);

                    //reset display to standard view
                    this.AddAssignmentPanel.SendToBack();
                    this.AddAssignmentPanel.Visible = false;
                    UpdateAssignmentDisplay();
                }
                //debugging error
                catch
                {
                    Console.WriteLine("Improper input in add assignment field");
                }
            }
        }
        

      
        //Event Manage Delete Course button clicked
        private void ManageDeleteCourseButton_Click(object sender, EventArgs e)
        {
            //clear residual data from last attempt and populate current info
            this.DeleteCourseDropDown.Items.Clear();
            foreach (Course course in courses)
            {
                this.DeleteCourseDropDown.Items.Add(course.getCourseName());
            }

            //display and hide appropriate information
            this.DeleteAssignmentDropDown.Visible = false;
            this.DeleteAssignmentLabel.Visible = false;
            this.DeleteItemButton.Text = "Delete Course";
            this.DeletePanel.Visible = true;

        }

        //Event Manage Add Course button clicked
        private void ManageAddCourseButton_Click(object sender, EventArgs e)
        {
            //display and hide appropriate information
            this.AddCourseCourseShortTextbox.Text = "";
            this.AddCourseCourseTexbox.Text = "";
            this.AddCourseInstructorTextbox.Text = "";
            this.AddCoursePanel.BringToFront();
            this.AddCoursePanel.Visible = true;
        }

        //Event Manage Add Assignment button clicked
        private void ManageAddAssignmentButton_Click(object sender, EventArgs e)
        {
            //removes old assignment items and adds current
            this.AddAssignmentCourseDropDown.Items.Clear();
            Object[] temp = new Object[this.CourseDropDown.Items.Count];
            this.CourseDropDown.Items.CopyTo(temp, 0);
            this.AddAssignmentCourseDropDown.Items.AddRange(temp);
            
            //resets to default values
            this.AddAssignmentNameTextbox.Text = "";
            this.AddAssignmentPointTextbox.Text = "";
            this.AddAssignmentPriorityTextbox.Text = "";
            this.AddAssignmentDueDateCalendar.SetDate(DateTime.Today);
            this.AddAssignmentPanel.BringToFront();
            this.AddAssignmentPanel.Visible = true;
        }

        //Event Manage Delete Assignment button clicked
        private void ManageDeleteAssignmentButton_Click(object sender, EventArgs e)
        {
            //removes old course items and adds current
            this.DeleteCourseDropDown.Items.Clear();
            foreach (Course course in courses)
            {
                this.DeleteCourseDropDown.Items.Add(course.getCourseName());
            }

            //makes the appropriate information visible
            this.DeleteAssignmentDropDown.Visible = true;
            this.DeleteAssignmentLabel.Visible = true;
            this.DeletePanel.Visible = true;
            this.DeleteItemButton.Text = "Delete Assignment";
            this.DeletePanel.Visible = true;
        }

        //This method is to update the display entirely
        private void UpdateAssignmentDisplay()
        {
            this.BackColor = this.themes.getPrimaryColor();
            this.SortPanel.BackColor = this.themes.getSecondaryColor();
            this.EditPanel.BackColor = this.themes.getSecondaryColor();
            this.StudyPanel.BackColor = this.themes.getSecondaryColor();
            this.CompletedTitlePanel.BackColor = this.themes.getAccentColor();
            this.HomeworkViewTitlePanel.BackColor = this.themes.getAccentColor();
            this.StudySessionTitlePanel.BackColor = this.themes.getAccentColor();
            this.StudySessionPanel.BackColor = this.themes.getAccentColor();
            this.HomeworkPanel.Controls.Clear();
            this.CompletedPanel.Controls.Clear();
            if (this.CourseDropDown.SelectedIndex > -1)
            {
                foreach (Assignment assignment in courses.ElementAt(this.CourseDropDown.SelectedIndex).getAssignments())
                {
                    if (assignment.getCompleted())
                    {
                        int yPos = 50 * this.CompletedPanel.Controls.Count / 4;
                        assignment.setAssignmentDisplayLabel(
                            new AssignmentDisplayLabel(
                                    assignment.getAssignmentName(),
                                    assignment.getCourse(),
                                    assignment.getDueDate().ToShortDateString(),
                                    yPos));

                        assignment.getAssignmentDisplayLabel().getCompleteButton().Text = "Done!";

                        this.CompletedPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getAssignmentLabel());
                        this.CompletedPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getCourseLabel());
                        this.CompletedPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getDateLabel());
                        this.CompletedPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getCompleteButton());
                    }
                    else
                    {
                        
                        int yPos = 50 * this.HomeworkPanel.Controls.Count / 4;
                        assignment.setAssignmentDisplayLabel(
                            new AssignmentDisplayLabel(
                                    assignment.getAssignmentName(),
                                    assignment.getCourse(),
                                    assignment.getDueDate().ToShortDateString(),
                                    yPos));

                        if (assignment.getNotified())
                        {
                            assignment.getAssignmentDisplayLabel().setAssignmentLabelColor(System.Drawing.Color.Red);
                            assignment.getAssignmentDisplayLabel().setCourseLabelColor(System.Drawing.Color.Red);
                            assignment.getAssignmentDisplayLabel().setDateLabelColor(System.Drawing.Color.Red);
                        }

                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getAssignmentLabel());
                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getCourseLabel());
                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getDateLabel());
                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getCompleteButton());

                    }
                }
            }

        }

        //Event Refresh Button click refreshes the display
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateAssignmentDisplay();
        }

        //Event Delete Cancel Button click hides the delete panel
        private void DeleteCancelButton_Click(object sender, EventArgs e)
        {
            this.DeletePanel.Visible = false;
        }

        //Event Add Assignment Cancel button click hides the add asssignment panel
        private void AddAssignmentCancelButton_Click(object sender, EventArgs e)
        {
            this.AddAssignmentPanel.Visible = false;
        }

        //Event Add Course Cancel button click hides the add course panel
        private void AddCourseCancelButton_Click(object sender, EventArgs e)
        {
            this.AddCoursePanel.Visible = false;
        }

        //Event Delete Course Dropdown change populates the assignment dropdown with the assignments of that course
        private void DeleteCourseDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear old assignments and populate the correct assignments
            this.DeleteAssignmentDropDown.Items.Clear();
            foreach (Assignment assignment in courses.ElementAt(this.DeleteCourseDropDown.SelectedIndex).getAssignments())
            {
                this.DeleteAssignmentDropDown.Items.Add(assignment.getAssignmentName());
            }

        }

        //Event Delete Item button click deletes assignment or courses depending on the state teh delete menu is in
        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            //if true then we are deleteing an assignment, else we are deleting a course
            if (this.DeleteAssignmentDropDown.Visible)
            {
                courses.ElementAt(this.DeleteCourseDropDown.SelectedIndex).removeAssignmentAt(this.DeleteAssignmentDropDown.SelectedIndex);
            }
            else
            {
                courses.RemoveAt(this.DeleteCourseDropDown.SelectedIndex);
            }

            //repopulate the course main dropdown with the current information
            this.CourseDropDown.Items.Clear();
            foreach(Course course in courses)
            {
                this.CourseDropDown.Items.Add(course.getCourseID());
            }

            //reset to default index
            this.CourseDropDown.SelectedIndex = -1;
            //update display
            UpdateAssignmentDisplay();
            //hide delete panel
            this.DeletePanel.Visible = false;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            this.courses.ElementAt(this.CourseDropDown.SelectedIndex).sortAssignments(this.SortDropDown.SelectedIndex);
            UpdateAssignmentDisplay();
        }

        //Reads from the correct files and stores 
        private void loadInfo()
        {
            string line;
            string[] info;
            using (StreamReader sr = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/course_backUp.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    info = line.Split(',');
                    Course course = 
                        new Course(info[0], info[1], Color.FromName(info[2]), info[3], TimeSpan.Parse(info[4]));
                    courses.Add(course);
                }
            }

            //Load Course into the dropdown menu
            foreach(Course course in courses)
            {
                this.CourseDropDown.Items.Add(course.getCourseID());
                this.CourseDropDown.SelectedIndex = this.CourseDropDown.Items.Count - 1;
            }

            //Populates each course with their appropriate assignments
            using (StreamReader sr = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/assignment_backUp.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    info = line.Split(',');
                    Assignment assignment = 
                        new Assignment(info[0], info[1], info[2], float.Parse(info[3]), Int32.Parse(info[4]), 
                                DateTime.Parse(info[5]), TimeSpan.Parse(info[6]), bool.Parse(info[7]));
                    foreach (Course course in courses)
                    {
                        if (assignment.getCourse() == course.getCourseID())
                        {
                            course.addAssignment(assignment);
                            break;
                        }
                    }
                }
            }
        }

        private void NotificationsTimer_Tick(object sender, EventArgs e)
        {
            String assignmentsDue = notifications.checkDueDates(courses);

            if (!assignmentsDue.Equals(""))
            {
                this.NotificationsLabel.Text = assignmentsDue;
                this.NotificationPanel.BringToFront();
                this.NotificationPanel.Visible = true;
                UpdateAssignmentDisplay();
            }
        }

        private void NotificationsCloseButton_Click(object sender, EventArgs e)
        {
            this.NotificationPanel.Visible = false;
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            this.NotificationPanel.Visible = true;
        }

        private void StartStudyButton_Click(object sender, EventArgs e)
        {
            this.StudySessionCourseDropDown.Items.Clear();
            foreach(Course course in courses)
            {
                this.StudySessionCourseDropDown.Items.Add(course.getCourseID());
            }
            this.StudySessionCourseDropDown.SelectedIndex = this.studySession.getStudyCourse();

            this.StudySessionOverlayPanel.BringToFront();
            this.StudySessionOverlayPanel.Visible = true;
        }

        private void StudyTrendsButton_Click(object sender, EventArgs e)
        {
            this.SessionTrendsPanel.BringToFront();
            this.SessionTrendsChart.Series.Clear();
            this.SessionTrendsChart.Series.Add("Courses");
            this.SessionTrendsChart.ChartAreas[0].AxisX.Title = "Courses";
            this.SessionTrendsChart.ChartAreas[0].AxisY.Title = "Hours";
            this.SessionTrendsChart.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.SessionTrendsChart.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            foreach (Course course in courses)
            {
                this.SessionTrendsChart.Series["Courses"].Points.AddXY(course.getCourseID(), course.getStudyTime().TotalHours);
                Console.WriteLine(course.getStudyTime().TotalHours);

            }
            this.SessionTrendsPanel.Visible = true;
        }

        private void StudySessionCloseButton_Click(object sender, EventArgs e)
        {
            if(this.StudySessionStateButton.Text == "Confirm Session")
            {
                this.StudySessionStateButton.Text = "Start Session";
                this.StudySessionLengthDropdown.SelectedIndex = -1;
            }
            this.StudySessionOverlayPanel.SendToBack();
            this.StudySessionOverlayPanel.Visible = false;
        }

        private void SessionStateButton_Click(object sender, EventArgs e)
        {
            if (this.StudySessionCourseDropDown.SelectedIndex != -1 && this.StudySessionLengthDropdown.SelectedIndex != -1 && this.StudySessionStateButton.Text == "Start Session")
            {
                this.StudySessionTimer.Start();
                this.StudySessionStateButton.Text = "End Session";
            }
            else if(this.StudySessionStateButton.Text == "End Session")
            {
                this.StudySessionTimer.Stop();
                this.StudySessionStateButton.Text = "Confirm Session";
            }else if(this.StudySessionStateButton.Text == "Confirm Session")
            {
                this.courses.ElementAt(this.StudySessionCourseDropDown.SelectedIndex).addStudyTime(studySession.getTimeStudied());
                this.StudySessionStateButton.Text = "Start Session";
                this.StudySessionCourseDropDown.SelectedIndex = -1;
                this.StudySessionLengthDropdown.SelectedIndex = -1;
                this.StudySessionTimeLabel.Text = "00:00:00";
            }
        }

        private void StudySessionLengthDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.StudySessionLengthDropdown.SelectedIndex){
                case 0:
                    this.studySession.setSessionTime(new TimeSpan(0, 15, 0));
                    break;
                case 1:
                    this.studySession.setSessionTime(new TimeSpan(0, 30, 0));
                    break;
                case 2:
                    this.studySession.setSessionTime(new TimeSpan(0, 45, 0));
                    break;
                case 3:
                    this.studySession.setSessionTime(new TimeSpan(1, 0, 0));
                    break;
                case 4:
                    this.studySession.setSessionTime(new TimeSpan(1, 30, 0));
                    break;
                case 5:
                    this.studySession.setSessionTime(new TimeSpan(2, 0, 0));
                    break;
            }

            this.studySession.setTimeStudied(new TimeSpan(0,0,0));
            this.StudySessionTimeLabel.Text = (this.studySession.getSessionTime() - this.studySession.getTimeStudied()).ToString();
        }

        private void StudySessionTimer_Tick(object sender, EventArgs e)
        {
            this.studySession.setTimeStudied(this.studySession.getTimeStudied()+ new System.TimeSpan(0,0,1));
            this.StudySessionTimeLabel.Text = (this.studySession.getSessionTime() - this.studySession.getTimeStudied()).ToString();
            if(this.studySession.getSessionTime() <= this.studySession.getTimeStudied())
            {
                this.StudySessionStateButton.Text = "Confirm Session";
                this.StudySessionTimer.Stop();
            }
        }

        private void StudySessionCourseDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.studySession.setStudyCourse(this.CourseDropDown.SelectedIndex);
        }

        private void StudyTrendsCloseButton_Click(object sender, EventArgs e)
        {
            this.SessionTrendsPanel.Visible = false;
            this.SessionTrendsPanel.SendToBack();
        }

        private void CustomizeButton_Click(object sender, EventArgs e)
        {
            this.CustomizationPanel.BringToFront();
            this.CustomizationPanel.Visible = true;
        }

        private void CustomizationConfirmButton_Click(object sender, EventArgs e)
        {
            this.CustomizationPanel.SendToBack();
            this.CustomizationPanel.Visible = false;
            this.UpdateAssignmentDisplay();
        }

        private void CustomizationChangeThemeButton_Click(object sender, EventArgs e)
        {
            this.UpdateAssignmentDisplay();
        }
    }
}
