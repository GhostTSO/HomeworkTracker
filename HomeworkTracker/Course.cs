using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    class Course
    {
        private string courseName;
        private Color colorID;
        private string courseID;
        private string instructorName;
        private TimeSpan studyTime;
        private List<Assignment> assignments;
        private string saveString;

        //0-param constructor
        public Course()
        {
            //Creates a blank Course
        }

        //4 param Constructor. No studyTime should be allocated to a brand new Course, as well as no assingments should be existing yet.
        public Course(string CourseName, string CourseID, Color ColorID, string InstructorName)
        {
            this.courseName = CourseName;
            this.courseID = CourseID;
            this.colorID = ColorID;
            this.instructorName = InstructorName;
            this.studyTime = TimeSpan.Zero;
            this.assignments = new List<Assignment>();
            this.saveString = String.Format("{0},{1},{2},{3},{4}", 
                this.courseName, this.courseID, this.colorID.ToString(), this.instructorName, this.studyTime);
        }

        //getters
        public string getCourseName()
        {
            return this.courseName;
        }

        public Color getColorId()
        {
            return this.colorID;
        }

        public string getCourseID()
        {
            return this.courseID;
        }

        public string getInstructorName()
        {
            return this.instructorName;
        }

        public TimeSpan getStudyTime()
        {
            return this.studyTime;
        }

        public List<Assignment> getAssignments()
        {
            return this.assignments;
        }

        //setters
        public void setCourseName(string CourseName)
        {
            this.courseName = CourseName;
        }

        public void setColorID(Color ColorID)
        {
            this.colorID = ColorID;
        }

        public void setCourseID(string CourseID)
        {
            this.courseID = CourseID;
        }

        public void sortAssignments(int sortType)
        {
            Sorts sorts = new Sorts();

            switch (sortType)
            {

                case 0:
                    this.assignments = sorts.mostEfficientSort(this.assignments);
                    break;
                case 1:
                    this.assignments = sorts.prioritySort(this.assignments);
                    break;
                case 2:
                    this.assignments = sorts.deadLineSort(this.assignments);
                    break;
                default:
                    break;


            }
        }

        //Modifiers to accumulate studyTime and to add/remove Assingments

        //Might want to make this an int. Depends on how we want to use the StopWatch Function.
        public void addStudyTime(TimeSpan additionalTime)
        {
            this.studyTime.Add(additionalTime);
        }

        public void addAssignment(Assignment newAssingment)
        {
            this.assignments.Add(newAssingment);
        }

        public void removeAssignmentAt(int index)
        {
            this.assignments.RemoveAt(index);
        }

        public void removeAssingment(Assignment removedAssignment)
        {
            this.assignments.Remove(removedAssignment);
        }

        //DB Functions ******************************************************************************************

        //??? -- This might better be placed internal to another class that focuses on saving and loading info in.
        public void saveAssignment()
        {
            string loadInfoDestination = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/course_backUps.txt";
            this.saveString = String.Format("{0},{1},{2},{3},{4}",
                this.courseName, this.courseID, this.colorID.ToString(), this.instructorName, this.studyTime);

            using (StreamWriter sw = File.AppendText(loadInfoDestination))
            {
                sw.WriteLine(saveString);
            }
        }

        public void deleteAssignment()
        {
            string assignmentsLocation = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/assignment_backUps.txt";
            string tempFile = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/tempFile.txt";

            //For this to be correct with the database, we consistently need to update the DB as we make changes.
            //Might want to to make the update function a private function, and place it into each setter.
            this.saveString = String.Format("{0},{1},{2},{3},{4}",
                this.courseName, this.courseID, this.colorID.ToString(), this.instructorName, this.studyTime);

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
