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

        //5 param Constructor. This includes load objects that require to persist studyTime
        public Course(string CourseName, string CourseID, Color ColorID, string InstructorName, TimeSpan studyTime)
        {
            this.courseName = CourseName;
            this.courseID = CourseID;
            this.colorID = ColorID;
            this.instructorName = InstructorName;
            this.studyTime = studyTime;
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
        public void addStudyTime(TimeSpan additionalTime)
        {
            this.studyTime += additionalTime;
            updateAssignment();
        }

        public void addAssignment(Assignment newAssingment)
        {
            this.assignments.Add(newAssingment);
        }
         
        //************************************* We should settle on one if the other isnt used ***********// 
        public void removeAssignmentAt(int index)
        {
            assignments[index].deleteAssignment();
            this.assignments.RemoveAt(index);
        }

        public void removeAssingment(Assignment removedAssignment)
        {
            this.assignments.Remove(removedAssignment);
        }
        //************************************************************************************************//



        //DB Functions ******************************************************************************************

        public void resetSaveInfo()
        {
            this.saveString = String.Format("{0},{1},{2},{3},{4}",
                this.courseName, this.courseID, this.colorID.ToString(), this.instructorName, this.studyTime);
        }

        //??? -- This might better be placed internal to another class that focuses on saving and loading info in.
        public void saveCourse()
        {
            string loadInfoDestination = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/course_backUp.txt";
            this.saveString = String.Format("{0},{1},{2},{3},{4}",
                this.courseName, this.courseID, this.colorID.ToString(), this.instructorName, this.studyTime);

            using (StreamWriter sw = File.AppendText(loadInfoDestination))
            {
                sw.WriteLine(saveString);
            }
        }

        //NOT POINTING TO CORRECT FILE PATHS YET.
        public void deleteCourse()
        {
            string courseLocation = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/course_backUp.txt";
            string tempFile = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/tempFile.txt";
            using (var sr = new StreamReader(courseLocation))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                string [] info;
                while ((line = sr.ReadLine()) != null)
                {
                    info = line.Split(',');
                    if (info[0] != this.courseName || info[1] != this.courseID)
                    {
                        sw.WriteLine(line);
                    }
                }
            }

            File.Delete(courseLocation);
            File.Move(tempFile, courseLocation);
            File.WriteAllText(tempFile, string.Empty);
        }

        //Need an Update Function when contents of assignment changes.
        public void updateAssignment()
        {
            string loadCourseLocation = AppDomain.CurrentDomain.BaseDirectory + @"textFileBackups/course_backUp.txt";
            string tempFile = AppDomain.CurrentDomain.BaseDirectory + @"textFIleBackups/tempFile.txt";

            //For this to be correct with the database, we consistently need to update the DB as we make changes.
            //Might want to to make the update function a private function, and place it into each setter

            using (var sr = new StreamReader(loadCourseLocation))
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
                        resetSaveInfo();
                        sw.WriteLine(saveString);
                    }
                }
            }
            //Removes content in Score Location
            File.Delete(loadCourseLocation);
            //Transfers temp content into Score Location
            File.Copy(tempFile, loadCourseLocation);
            //Removes content in tempFile
            File.WriteAllText(tempFile, string.Empty);
        }
    }
}
