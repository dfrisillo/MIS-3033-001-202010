//@author Adam Ackerman
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            c.CourseID = 1;
            c.CourseName = "Non procedural programming";
            c.CourseNumber = 3033;
            c.Instructor = "Adam Ackerman";
            c.Subject = "MIS";

            Student katie = new Student("Katie", "Harris", 1);
            katie.AddCourse(c);

            Console.ReadKey();
        }
    }
}
