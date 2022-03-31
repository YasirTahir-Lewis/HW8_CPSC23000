using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Courses
{
    public class CourseController
    {
        private List<Course> courses;
        
        public CourseController()
        {
            courses = null;
        }

        public CourseController(List<Course> courses)
        {
            this.courses = courses;
        }

        public void AddCourse(string courseSemester, string courseName, string courseNumber, string instructorName, string courseRequirement, int courseCredits, string courseGrade, string courseFeedback)
        {
            Course course = new Course(courseSemester, courseName, courseNumber, instructorName, courseRequirement, courseCredits, courseGrade, courseFeedback);
            courses.Add(course);
        }

        public string GetCoursesAsString()
        {
            string result = "";
            foreach(Course course in courses)
            {
                result = result + course + "\n";
            }
            return result;
        }

        public List<String> GetCourseNames()
        {
            List<String> result = new List<string>();
            foreach(Course course in courses)
            {
                result.Add(course.CourseName);
            }
            return result;
        }

        public Dictionary<string, string> GetCourseDetailsForCourseByName(string courseName)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (Course course in courses)
            {
                if (course.CourseName.Equals(courseName))
                {
                    result.Add("semester", course.CourseSemester);
                    result.Add("courseName", course.CourseName);
                    result.Add("courseNumber", course.CourseNumber);
                    result.Add("instructorName", course.InstructorName);
                    result.Add("courseRequirement", course.CourseRequirement);
                    result.Add("courseCredits", (course.CourseCredits).ToString());
                    result.Add("courseGrade", course.CourseGrade);
                    result.Add("courseFeedback", course.CourseFeedback);
                    return result;
                }
            }
            return null;
        }

        public void WriteCoursesToTextFile(string fname)
        {
            using (StreamWriter writer = new StreamWriter(fname))
            {
                foreach (Course course in courses)
                {
                    writer.WriteLine(course);
                }
            }
        }

        public string ReadCoursesFromTextFile(string fname)
        {
            String text;
            using (StreamReader reader = new StreamReader(fname))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }

    }
}
