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
        private TimeSpan studyTime;
        private string studyCourse;
        private bool validSession;
        // default constructor
        public StudySession() { }

        //getter methods
       public string getSessionName()
        {
            return this.sessionName;
        }

        public TimeSpan getStudyTime()
        {
            return this.studyTime;
        }

        public string getStudyCourse()
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

        public void setStudyTime(TimeSpan newStudyTime)
        {
            this.studyTime = newStudyTime;
        }

        public void setStudyCourse(string newStudyCourse)
        {
            this.studyCourse = newStudyCourse;
        }

        public void setValidSession(bool newValid)
        {
            this.validSession = newValid;
        }

    }
}
