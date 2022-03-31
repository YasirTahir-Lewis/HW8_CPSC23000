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
        int courseCredits; 
        string courseGrade;
        string courseFeedback;

        public string CourseSemester { get => courseSemester; set => courseSemester = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseNumber { get => courseNumber; set => courseNumber = value; }
        public string InstructorName { get => instructorName; set => instructorName = value; }
        public string CourseRequirement { get => courseRequirement; set => courseRequirement = value; }
        public int CourseCredits { get => courseCredits; set => courseCredits = value; }
        public string CourseGrade { get => courseGrade; set => courseGrade = value; }
        public string CourseFeedback { get => courseFeedback; set => courseFeedback = value; }

        public Course()
        {
            courseSemester = "";
            courseName = "";
            courseNumber = "";
            instructorName = "";
            courseRequirement = "";
            courseCredits = 0;
            courseGrade = "";
            courseFeedback = "";
        }

        public Course(string courseSemester, string courseName, string courseNumber, string instructorName, string courseRequirement, int courseCredits, string courseGrade, string courseFeedback)
        {
            CourseSemester = courseSemester;
            CourseName = courseName;
            CourseNumber = courseNumber;
            InstructorName = instructorName;
            CourseRequirement = courseRequirement;
            CourseCredits = courseCredits;
            CourseGrade = courseGrade;
            CourseFeedback = courseFeedback;
        }

        // Calculates grade points for each course by multiplying course credits by their grade by points
        public double CalculateGradePoints()
        {
            string grade;
            int courseCred;
            float gradePoint = 0;
            
            grade = CourseGrade;
            courseCred = CourseCredits;

            if (grade == "A")
            {
                gradePoint = (courseCred) * 4;
            }
            else if (grade == "A-")
            {
                gradePoint = (float)((courseCred) * 3.7);
            }
            else if (grade == "B+")
            {
                gradePoint = (float)((courseCred) * 3.3);
            }
            else if (grade == "B")
            {
                gradePoint = (courseCred) * 3;
            }
            else if (grade == "B-")
            {
                gradePoint = (float)((courseCred) * 2.7);
            }
            else if (grade == "C+")
            {
                gradePoint = (float)((courseCred) * 2.3);
            }
            else if (grade == "C")
            {
                gradePoint = (courseCred) * 2;
            }
            else if (grade == "C-")
            {
                gradePoint = (float)((courseCred) * 1.7);
            }
            else if (grade == "D+")
            {
                gradePoint = (float)(courseCred * 1.3);
            }
            else if (grade == "D")
            {
                gradePoint = (courseCred) * 1;
            }
            return gradePoint;
        }
        

        public override string ToString()
        {
            return String.Format("Semester = {0} \t Course Name = {1} \t Course Number = {2} \t Instructor Name = {3} \t Course Requirement = {4} \t Course Credits = {5} \t Course Grade = {6} \t Course Feedback = {7} \t Grade Points = {8:F2}\n",
                CourseSemester, CourseName, CourseNumber, InstructorName, CourseRequirement, CourseCredits, CourseGrade, CourseFeedback, CalculateGradePoints()); 
        }


    }




}
