using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Courses
{
    public class Course
    {
        string courseSemester;
        string courseName;
        string courseNumber;
        string instructorName;
        string courseRequirement;
        string courseGrade;
        string courseFeedback;

        public string CourseSemester { get => courseSemester; set => courseSemester = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseNumber { get => courseNumber; set => courseNumber = value; }
        public string InstructorName { get => instructorName; set => instructorName = value; }
        public string CourseRequirement { get => courseRequirement; set => courseRequirement = value; }
        public string CourseGrade { get => courseGrade; set => courseGrade = value; }
        public string CourseFeedback { get => courseFeedback; set => courseFeedback = value; }

        public Course()
        {
            courseSemester = "";
            courseName = "";
            courseNumber = "";
            instructorName = "";
            courseRequirement = "";
            courseGrade = "";
            courseFeedback = "";
        }

        public Course(string courseSemester, string courseName, string courseNumber, string instructorName, string courseRequirement, string courseGrade, string courseFeedback)
        {
            CourseSemester = courseSemester;
            CourseName = courseName;
            CourseNumber = courseNumber;
            InstructorName = instructorName;
            CourseRequirement = courseRequirement;
            CourseGrade = courseGrade;
            CourseFeedback = courseFeedback;
        }

        public override string ToString()
        {
            return String.Format("Semester = {0} \t Course Name = {1} \t Course Number = {2} \t Instructor Name = {3} \t Course Requirement = {4} \t Course Grade = {5} \t Course Feedback = {6}\n",
                CourseSemester, CourseName, CourseNumber, InstructorName, CourseRequirement, CourseGrade, CourseFeedback); 
        }


    }




}
