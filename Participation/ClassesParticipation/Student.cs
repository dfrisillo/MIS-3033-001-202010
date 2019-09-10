using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParticipation
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public List<Course> Courses { get; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentID = 0;
            Courses = new List<Course>();
        }

        public Student(string FirstName, string lName, int id) : this()
        {
            this.FirstName = FirstName;
            LastName = lName;
            StudentID = id;
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName} ({StudentID}) is taking {Courses.Count}";
        }
    }
}
