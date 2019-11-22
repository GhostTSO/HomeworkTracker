using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    class Assignment
    {
        private string assignmentName;
        private string course;
        private string description;
        private float pointValue;
        private int priority;
        private DateTime dueDate;
        private TimeSpan timeLeft;
        private string saveString;
        private bool completed;
        private AssignmentDisplayLabel assignmentLabel;

        //Zero Param Constructor
        public Assignment()
        {
            //Blank Assignment
        }

        //Used for creating intial assignment
        public Assignment(string AssignmentName, string Course, string Description, float PointValue, int Priority, DateTime DueDate)
        {
            this.assignmentName = AssignmentName;
            this.course = Course;
            this.description = Description;
            this.pointValue = PointValue;
            this.priority = Priority;
            this.dueDate = DueDate;
            this.timeLeft = this.dueDate - DateTime.Now;
            this.completed = false;
            this.saveString = String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                this.assignmentName, this.course, this.description, this.pointValue, 
                this.priority, this.dueDate, this.timeLeft, this.completed);
            this.assignmentLabel = new AssignmentDisplayLabel();
        }
        
        //8 parameter constructor... used for loading information
        public Assignment(string AssignmentName, string Course, string Description, 
            float PointValue, int Priority, DateTime DueDate, TimeSpan timeLeft, bool completed)
        {
            this.assignmentName = AssignmentName;
            this.course = Course;
            this.description = Description;
            this.pointValue = PointValue;
            this.priority = Priority;
            this.dueDate = DueDate;
            this.timeLeft = timeLeft;
            this.completed = completed;
            this.saveString = String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                this.assignmentName, this.course, this.description, this.pointValue, 
                this.priority, this.dueDate, this.timeLeft, this.completed);
            
            this.assignmentLabel = new AssignmentDisplayLabel();
        }

        //getters
        public string getAssignmentName()
        {
            return this.assignmentName;
        }
        public string getCourse()
        {
            return this.course;
        }
        public string getDescription()
        {
            return this.description;
        }
        public float getPointValue()
        {
            return this.pointValue;
        }
        public int getPriority()
        {
            return this.priority;
        }
        public DateTime getDueDate()
        {
            return this.dueDate;
        }
        public TimeSpan getTimeLeft()
        {
            return this.timeLeft;
        }
        public bool getCompleted()
        {
            return this.completed;
        }
        public AssignmentDisplayLabel getAssignmentDisplayLabel()
        {
            return this.assignmentLabel;
        }

        //Setters
        public void setAssignmentName(string assignmentName)
        {
            this.assignmentName = assignmentName;
        }
        public void setCourse(string course)
        {
            this.course = course;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void setPointValue(float pointValue)
        {
            this.pointValue = pointValue;
        }
        public void setPriority(int priority)
        {
            this.priority = priority;
        }
        public void setDueDate(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }
        public void setAssignmentDisplayLabel(AssignmentDisplayLabel label)
        {
            this.assignmentLabel = label;
            this.assignmentLabel.getCompleteButton().Click += new System.EventHandler(this.completeButton_Clicked);
        }

        public void toggleCompleted()
        {
            this.completed = !this.completed;
            //call update function here
        }

        //Events
        private void completeButton_Clicked(object sender, EventArgs e)
        {
            toggleCompleted();
            if (this.completed)
            {
                this.assignmentLabel.getCompleteButton().Text = "Done!";
            }
            else
            {
                this.assignmentLabel.getCompleteButton().Text = "Complete?";
            }
        }

        //Modifiers

        //Whenever this method is called, the assignment timeLeft is rechecked for more accurate deadLine information
        public void resetTimeLeft()
        {
            this.timeLeft = this.dueDate - DateTime.Now;
        }

        //DB functions*****************************************************************************************************

        //??? -- This might better be placed internal to another class that focuses on saving and loading info in.
        public void saveAssignment()
        {
            string loadInfoDestination = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/assignment_backUp.txt";

            this.saveString = String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
               this.assignmentName, this.course, this.description, this.pointValue,
               this.priority, this.dueDate, this.timeLeft, this.completed);

            using (StreamWriter sw = File.AppendText(loadInfoDestination))
            {
                sw.WriteLine(this.saveString);
            }
        }

        //NEEDS TO BE TESTED
        public void deleteAssignment()
        {
            string assignmentsLocation = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/assignment_backUp.txt";
            string tempFile = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/tempFile.txt";

            //For this to be correct with the database, we consistently need to update the DB as we make changes.
            //Might want to to make the update function a private function, and place it into each setter.
            this.saveString = String.Format("{0},{1},{2},{3},{4},{5},{6}",
                this.assignmentName, this.course, this.description, this.pointValue, this.priority, this.dueDate, this.timeLeft);

            using (var sr = new StreamReader(assignmentsLocation))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != this.saveString)
                        sw.WriteLine(line);
                }
            }

            File.Delete("file.txt");
            File.Move(tempFile, "file.txt");
        }

        //NEEDS TO BE TESTED
        private void updateAssignment()
        {
            //Still Needed
            string assignmentsLocation = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/assignment_backUp.txt";
            string tempFile = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/tempFile.txt";

            //For this to be correct with the database, we consistently need to update the DB as we make changes.
            //Might want to to make the update function a private function, and place it into each setter.

            using (var sr = new StreamReader(assignmentsLocation))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != this.saveString)
                    {
                        //If line isn't the one that needs to be updated, then no revision needed
                        sw.WriteLine(line);
                    } 
                    else
                    {
                        //If line is the one that needs to be updated, then create revision
                        this.saveString = String.Format("{0},{1},{2},{3},{4},{5},{6}",
                            this.assignmentName, this.course, this.description, this.pointValue, 
                            this.priority, this.dueDate, this.timeLeft);
                        sw.WriteLine(this.saveString);
                    }
                }
            }
            File.Delete("file.txt");
            File.Move(tempFile, "file.txt");
        }
    }
}
