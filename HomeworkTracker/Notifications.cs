using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    public class Notifications
    {
        private Boolean enabledNotifications;

        public Notifications()
        {
            enabledNotifications = true;
        }

        public void toggleNotifications()
        {
            this.enabledNotifications = !this.enabledNotifications;
        }

        public string checkDueDates(List<Course> courses)
        {
            String assignmentsToDo = "";
            foreach(Course course in courses)
            {

                foreach(Assignment assignment in course.getAssignments())
                {
                    assignment.updateTimeLeft();
                    if(assignment.getTimeLeft() < System.TimeSpan.FromDays(1) && !assignment.getCompleted() && !assignment.getNotified())
                    {
                        string temp = string.Format("{0,-20}{1,20}\n", assignment.getAssignmentName(), assignment.getCourse());
                        assignment.getAssignmentDisplayLabel().setAssignmentLabelColor(System.Drawing.Color.Red);
                        assignment.getAssignmentDisplayLabel().setCourseLabelColor(System.Drawing.Color.Red);
                        assignment.getAssignmentDisplayLabel().setDateLabelColor(System.Drawing.Color.Red);
                        assignment.setNotified(true);
                        assignmentsToDo += temp;
                    }
                }

            }
            return assignmentsToDo;
        }

    }
}
