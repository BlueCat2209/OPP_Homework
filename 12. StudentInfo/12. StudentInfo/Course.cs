using System;
using System.Collections.Generic;
using System.Text;

namespace _12._StudentInfo
{
    class Course
    {
        // Properties
        private string Name;
        private DateTime OpenDate;
        private int CourseLength;
        private Student[] StudentsList;

        // Methods
        public bool IsBegin()
        {
            if (DateTime.Compare(this.OpenDate, DateTime.Now) <= 0)
            {
                return true;
            }
            else return false;
        }

        // Constructors
        public Course(string name, DateTime openDate, int courseLength, Student[] list)
        {
            this.Name = name;
            this.OpenDate = openDate;
            this.CourseLength = courseLength;
            this.StudentsList = list;
            foreach (Student student in list)
            {
                student.SetCourse(name);
            }    
        }
    }
}
