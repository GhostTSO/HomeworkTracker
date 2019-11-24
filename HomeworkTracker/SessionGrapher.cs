using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    class SessionGrapher
    {
        //variables
        private string sessionGrapherName;
        private string sessionTrendSeries;

        //default constructor
        public SessionGrapher()
        {

        }

        //getter methods
        public string getSessionTrendName()
        {
            return this.sessionGrapherName;
        }

        public string getSessionTrendSeries()
        {
            return this.sessionTrendSeries;
        }

        //setter methods
        public void setSessionTrendName(string newTrendName)
        {
            this.sessionGrapherName = newTrendName;
        }

        public void setSessionTrendSeries(string newSeriesName)
        {
            this.sessionTrendSeries = newSeriesName;
        }

        //generate graph
        public void generateGraph(int graphType)
        {

        }
    }
}
