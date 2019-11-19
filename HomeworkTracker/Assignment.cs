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

        //Zero Param Constructor
        public Assignment()
        {
            //Blank Assignment
        }

        public Assignment(string AssignmentName, string Course, string Description, float PointValue, int Priority, DateTime DueDate)
        {
            this.assignmentName = AssignmentName;
            this.course = Course;
            this.description = Description;
            this.pointValue = PointValue;
            this.priority = Priority;
            this.dueDate = DueDate;
            this.timeLeft = this.dueDate - DateTime.Now;
            this.saveString = String.Format("{0},{1},{2},{3},{4},{5},{6}",
                this.assignmentName, this.course, this.description, this.pointValue, this.priority, this.dueDate, this.timeLeft);
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

        //Setters
        public void getAssignmentName(string assignmentName)
        {
            this.assignmentName = assignmentName;
        }
        public void getCourse(string course)
        {
            this.course = course;
        }
        public void getDescription(string description)
        {
            this.description = description;
        }
        public void getPointValue(float pointValue)
        {
            this.pointValue = pointValue;
        }
        public void getPriority(int priority)
        {
            this.priority = priority;
        }
        public void getDueDate(DateTime dueDate)
        {
            this.dueDate = dueDate;
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
            string loadInfoDestination = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/course_backUps.txt";

            this.saveString = String.Format("{0},{1},{2},{3},{4},{5},{6}",
                this.assignmentName, this.course, this.description, this.pointValue, this.priority, this.dueDate, this.timeLeft);

            using (StreamWriter sw = File.AppendText(loadInfoDestination))
            {
                sw.WriteLine(this.saveString);
            }
        }

        public void deleteAssignment()
        {
            string assignmentsLocation = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/assignment_backUps.txt";
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

        //Need an Update Function when contents of assignment changes.
        public void updateAssignment()
        {
            //Still Needed
        }
    }
}
