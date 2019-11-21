using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class MainForm : Form
    {
        private List<Course> courses = new List<Course>();
        public MainForm()
        {
            InitializeComponent();
        }

        
        //Event handling Confirmed Add Course Button being clicked
        private void AddCourseConfirmButton_Click(object sender, EventArgs e)
        {
            //checks to see if these course boxes have filled values
            if (this.AddCourseCourseTexbox.TextLength > 0 && this.AddCourseCourseShortTextbox.TextLength > 0)
            {

                //Parse the boxes and create a course object into our course collection
                courses.Add(new Course( this.AddCourseCourseTexbox.Text, 
                                        this.AddCourseCourseShortTextbox.Text, 
                                        System.Drawing.Color.Black, 
                                        this.AddCourseInstructorTextbox.Text));

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
                    courses.ElementAt(this.AddAssignmentCourseDropDown.SelectedIndex).addAssignment(
                                    new Assignment( this.AddAssignmentNameTextbox.Text,
                                                    this.CourseDropDown.Text, 
                                                    "", 
                                                    float.Parse(this.AddAssignmentPointTextbox.Text), 
                                                    0, 
                                                    this.AddAssignmentDueDateCalendar.SelectionStart));

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

            this.HomeworkPanel.Controls.Clear();
            this.CompletedPanel.Controls.Clear();
            if (this.CourseDropDown.SelectedIndex > -1)
            {
                foreach (Assignment assignment in courses.ElementAt(this.CourseDropDown.SelectedIndex).getAssignments())
                {

                    Console.WriteLine(assignment.getAssignmentName());

                    if (assignment.getCompleted())
                    {
                        int yPos = 45 * this.CompletedPanel.Controls.Count / 4 + 30;
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
                        Console.WriteLine(this.HomeworkPanel.Controls.Count);
                        int yPos = 45 * this.HomeworkPanel.Controls.Count / 4 + 30;
                        assignment.setAssignmentDisplayLabel(
                            new AssignmentDisplayLabel(
                                    assignment.getAssignmentName(),
                                    assignment.getCourse(),
                                    assignment.getDueDate().ToShortDateString(),
                                    yPos));

                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getAssignmentLabel());
                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getCourseLabel());
                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getDateLabel());
                        this.HomeworkPanel.Controls.Add(assignment.getAssignmentDisplayLabel().getCompleteButton());

                    }
                }
            }
            Console.WriteLine("Items in Completed Panel: " + this.CompletedLabel.Controls.Count/4);
            Console.WriteLine("Items in Homework Panel: " + this.HomeworkPanel.Controls.Count/4);

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
    }
}
