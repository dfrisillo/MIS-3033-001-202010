//@author Adam Ackerman
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParticipation
{
    class Course
    {
        private int _CourseID;
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }

        private string Test;

        public string GetTest()
        {
            return Test;
        }

        public void SetTest(string newValue)
        {
            Test = newValue;
        }

        public Course()
        {
            CourseID = 0;
            CourseNumber = 0;
            CourseName = string.Empty;
            Subject = string.Empty;
            Instructor = string.Empty;
        }

        public override string ToString()
        {
            return $"{CourseID} {Subject} {CourseNumber} ";
            return base.ToString();
        }

    }
}
