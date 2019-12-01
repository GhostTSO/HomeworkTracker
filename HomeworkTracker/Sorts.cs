using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    public class Sorts
    {
        public Sorts()
        {
            // No parameters, only a collection of functions
        }

        //This sort organizes each list by the most necessary assignment first.
        public List<Assignment> mostEfficientSort(List<Assignment> assignments)
        {
            //Highest Number will be first... This assignment has the highest priority
            assignments = assignments.OrderByDescending(t => (t.getPointValue()*t.getPriority())/(t.getTimeLeft().TotalHours)).ToList();
            return assignments;
        }

        public List<Assignment> deadLineSort(List<Assignment> assignments)
        {
            //The assignment with the longest time left will be the last in the list
            assignments = assignments.OrderBy(t => t.getTimeLeft()).ToList();
            return assignments;
        }

        public List<Assignment> prioritySort(List<Assignment> assignments)
        {
            //The highest priority will be first, the lowest priority will be last
            assignments = assignments.OrderByDescending(t => t.getPriority()).ToList();
            return assignments;
        }
    }
}
