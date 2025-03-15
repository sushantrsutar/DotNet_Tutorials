using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceDemo
{
    /*2. Create a class course having cid, cname
Create a class Student having sid, sname, marks , course object
Create objects of this class:
>Now check number of student in each course 
> Display the student names in course wise"*/
    class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }

        public Course(int courseId, string courseName)
        {
            this.courseId = courseId;
            this.courseName = courseName;
        }

        public override string ToString()
        {
            return $"Course Id : {courseId} , Course Name : {courseName}";
        }
    }

    class Student {
        //sid, sname, marks , course object
        public int stuId { get; set; }
        public string stuName { get; set; }

        public int stuMarks { get; set; }
        Course course { get; set; }

        public Student(int stuId,string stuName, int stuMarks, Course course ) {
            this.stuId = stuId;
            this.stuName = stuName;
            this.stuMarks = stuMarks;
            this.course = course;
        }

        public override string ToString() {
            return $"Id : {stuId} , Name : {stuName} , Marks : {stuMarks} , Course : {course}";
        }
    }
}
