using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    /** This class creates the labels and clickable button for assignments to be displayed onto the UI **/
    class AssignmentDisplayLabel
    {
        private Label assignmentNameLabel { get; set; } = new Label();
        private Label courseNameLabel { get; set; } = new Label();
        private Label DateLabel { get; set; } = new Label();
        private Button completeButton { get; set; } = new Button();
        
        /**Default Constructor to initialize the empty item**/
        public AssignmentDisplayLabel(){}

        /**Constructor to create new item with values (NOTE: This is the only way to fill information)**/
        public AssignmentDisplayLabel(String assignmentName, String courseName, String dueDate, int yPos)
        {
            
            assignmentNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            assignmentNameLabel.Size = new System.Drawing.Size(200, 40);
            assignmentNameLabel.Location = new System.Drawing.Point(110, yPos);
            assignmentNameLabel.Text = assignmentName;

            courseNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            courseNameLabel.Size = new System.Drawing.Size(200, 40);
            courseNameLabel.Location = new System.Drawing.Point(320, yPos);
            courseNameLabel.Text = courseName;

            DateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            DateLabel.Size = new System.Drawing.Size(140, 40);
            DateLabel.Location = new System.Drawing.Point(520, yPos);
            DateLabel.Text = dueDate;

            completeButton.Size = new System.Drawing.Size(100, 40);
            completeButton.Location = new System.Drawing.Point(0, yPos);
            completeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            completeButton.Text = "Complete?";

        }

        //getters
        public Label getAssignmentLabel()
        {
            return this.assignmentNameLabel;
        }

        public Label getCourseLabel()
        {
            return this.courseNameLabel;
        }

        public Label getDateLabel()
        {
            return this.DateLabel;
        }

        public Button getCompleteButton()
        {
            return this.completeButton;
        }

        //setters
        public void setAssignmentLabelColor(System.Drawing.Color color)
        {
            this.assignmentNameLabel.ForeColor = color;
        }

        public void setCourseLabelColor(System.Drawing.Color color)
        {
            this.courseNameLabel.ForeColor = color;
        }

        public void setDateLabelColor(System.Drawing.Color color)
        {
            this.DateLabel.ForeColor = color;
        }

        public void setCompleteButtonColor(System.Drawing.Color color)
        {
            this.completeButton.ForeColor = color;
        }
    }
}
