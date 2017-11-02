using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>(){
                new Course() {CourseId=100, CourseName="History 100", Students=new List<Student>() {
                    new Student() {StudentId=20, Name="John Bender"},
                    new Student() {StudentId=21, Name="Claire Standish"}}},
                new Course() {CourseId=104, CourseName="Math 104", Students=new List<Student>(){
                    new Student() {StudentId=22, Name="Andrew Clarke"},
                    new Student() {StudentId=23, Name="Brian Johnson"}}},
                new Course() {CourseId=101, CourseName="English 101", Students=new List<Student>(){
                    new Student() {StudentId=24, Name="Allison Reynolds"},
                    new Student() {StudentId=25, Name="Richard Vernon" }}}
        };
            foreach (var course in courses)
            {
                resultLabel.Text += string.Format("Course: {0} - {1}</br>", course.CourseId, course.CourseName);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += string.Format("Student: {0} - {1}</br>", student.StudentId, student.Name);
                }
                resultLabel.Text += "</br>";
            }
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {

            Course math200 = new Course() { CourseId = 20, CourseName = "Advanced Math 200" };
            Course chem250 = new Course() { CourseId = 25, CourseName = "Chemistry 250" };
            Course robo275 = new Course() { CourseId = 27, CourseName = "Robotics 275" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {20, new Student{StudentId=20, Name="John Bender", CourseId= new List<Course> {math200, robo275} } },
                {21, new Student{StudentId=21, Name="Claire Standish", CourseId= new List<Course> {chem250, math200} } },
                {22, new Student{StudentId=22, Name="Andrew Clarke", CourseId= new List<Course> {robo275, chem250 } } }
            };

            foreach (var student in students)
            {
                resultLabel.Text += string.Format("Student Name: {0} - Student Id: {1}</br>", student.Value.Name, student.Value.StudentId);
                foreach (var course in student.Value.CourseId)
                {
                    resultLabel.Text += string.Format("   Course Id: {0} - {1}</br>", course.CourseId, course.CourseName);
                }
                resultLabel.Text += "</br>";
            }
            

            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */ 

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = 20;
            student.Name = "John Bender";
            student.Enrollments = new List<Enrollement>()
            {
                new Enrollement {CourseGrade=45, Course = new Course() {CourseId = 20, CourseName="Advanced Math 200" } },
                new Enrollement {CourseGrade=65, Course = new Course() {CourseId = 27, CourseName = "Robotics 275" } }
            };
            resultLabel.Text += String.Format("Student Id: {0} - {1}</br>", student.StudentId, student.Name);
            foreach (var Enrollment in student.Enrollments)    
            {
                resultLabel.Text += String.Format("Enrolled In: {0} - Grade: {1}</br>", Enrollment.Course.CourseName, Enrollment.CourseGrade);
            }
            resultLabel.Text += "</br>";

            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */


        }
    }
}   