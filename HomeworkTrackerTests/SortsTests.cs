using Xunit;
using HomeworkTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker.Tests
{
    public class SortsTests
    {
        [Fact()]
        public void DueDateSortTest()
        {
            Sorts sort = new Sorts();
            List<Assignment> assignments = new List<Assignment>();
            List<Assignment> expectedList = new List<Assignment>();

            //public Assignment(string AssignmentName, string Course, string Description, float PointValue, int Priority, DateTime DueDate)
            Assignment assignment1 = new Assignment("assignment 1", "course 1", "description", 100, 5, DateTime.Now);
            Assignment assignment2 = new Assignment("assignment 2", "course 1", "description", 100, 5, DateTime.Now.AddHours(24));
            Assignment assignment3 = new Assignment("assignment 2", "course 1", "description", 100, 5, DateTime.Now.AddHours(48));

            assignments.Add(assignment3);
            assignments.Add(assignment2);
            assignments.Add(assignment1);

            expectedList.Add(assignment1);
            expectedList.Add(assignment2);
            expectedList.Add(assignment3);

            Assert.Equal(expectedList.ToArray(), sort.deadLineSort(assignments).ToArray());
        }

        [Fact()]
        public void PrioritySortTest()
        {
            Sorts sort = new Sorts();
            List<Assignment> assignments = new List<Assignment>();
            List<Assignment> expectedList = new List<Assignment>();

            //public Assignment(string AssignmentName, string Course, string Description, float PointValue, int Priority, DateTime DueDate)
            Assignment assignment1 = new Assignment("assignment 1", "course 1", "description", 100, 5, DateTime.Now);
            Assignment assignment2 = new Assignment("assignment 2", "course 1", "description", 100, 10, DateTime.Now);
            Assignment assignment3 = new Assignment("assignment 2", "course 1", "description", 100, 15, DateTime.Now);

            assignments.Add(assignment1);
            assignments.Add(assignment2);
            assignments.Add(assignment3);

            expectedList.Add(assignment3);
            expectedList.Add(assignment2);
            expectedList.Add(assignment1);

            Assert.Equal(expectedList.ToArray(), sort.prioritySort(assignments).ToArray());
        }

        [Fact()]
        public void MostEfficientSortTest()
        {
            Sorts sort = new Sorts();
            List<Assignment> assignments = new List<Assignment>();
            List<Assignment> expectedList = new List<Assignment>();

            //public Assignment(string AssignmentName, string Course, string Description, float PointValue, int Priority, DateTime DueDate)
            Assignment assignment1 = new Assignment("assignment 1", "course 1", "description", 100, 5, DateTime.Now.AddHours(48));
            Assignment assignment2 = new Assignment("assignment 2", "course 1", "description", 200, 10, DateTime.Now.AddHours(24));
            Assignment assignment3 = new Assignment("assignment 2", "course 1", "description", 300, 15, DateTime.Now);

            assignments.Add(assignment1);
            assignments.Add(assignment2);
            assignments.Add(assignment3);

            expectedList.Add(assignment3);
            expectedList.Add(assignment2);
            expectedList.Add(assignment1);

            Assert.Equal(expectedList.ToArray(), sort.mostEfficientSort(assignments).ToArray());
        }
    }
}