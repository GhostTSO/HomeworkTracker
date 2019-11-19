using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void removeAssingment(Assignment removedAssignment)
        {
            this.assignments.Remove(removedAssignment);
        }
    }
}
