using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> CourseId { get; set; }
        public List<Course> CourseName { get; set; }
        public List<Enrollement> Enrollments { get; set; }

        /*
        List<Student> students = new List<Student>() {
            new Student {StudentId=20, Name="John Bender"},
            new Student {StudentId=21, Name="Claire Standish"},
            new Student {StudentId=22, Name="Andrew Clarke"}
        };
        */
    }
}