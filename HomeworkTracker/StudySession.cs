using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    class StudySession
    {
        //variables
        private string sessionName;
        private TimeSpan timeStudied;
        private TimeSpan sessionTime;
        private int studyCourse;
        private bool validSession;
        // default constructor
        public StudySession() { }

        //getter methods
       public string getSessionName()
        {
            return this.sessionName;
        }

        public TimeSpan getTimeStudied()
        {
            return this.timeStudied;
        }

        public TimeSpan getSessionTime()
        {
            return this.sessionTime;
        }

        public int getStudyCourse()
        {
            return this.studyCourse;
        }

        public bool getValidSession()
        {
            return this.validSession;
        }
        //setter methods
        public void setSessionName(string newSessionName)
        {
            this.sessionName = newSessionName;
        }

        public void setTimeStudied(TimeSpan newStudyTime)
        {
            this.timeStudied = newStudyTime;
        }

        public void setSessionTime(TimeSpan time)
        {
            this.sessionTime = time;
        }

        public void setStudyCourse(int newStudyCourse)
        {
            this.studyCourse = newStudyCourse;
        }

        public void setValidSession(bool newValid)
        {
            this.validSession = newValid;
        }

    }
}
