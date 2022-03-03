using System;
using System.Collections.Generic;
using System.Text;

namespace _11._Students
{
    class Student
    {
        // Properties
        private string Name;
        private DateTime Birth;
        private Grades StuGrades;

        // Setter
        public void SetName(string name)
        {
            this.Name = name.Trim() == "" ? "#UNDEFINED" : name;
        }
        public void SetBirth(DateTime birth)
        {
            this.Birth = birth == null ? new DateTime() : birth;
        }
        public void SetStuGrades(Grades stuGrades)
        {
            this.StuGrades = stuGrades == null ? new Grades() : stuGrades;
        }

        // Getters
        public string GetName() => this.Name;
        public DateTime GetBirth() => this.Birth;
        public Grades GetStuGrades() => this.StuGrades;     

        // Methods            
        public int GetExamType()
        {
            if (this.StuGrades.IsReExam())
            {
                return 0;
            }
            else
            {
                double average = this.StuGrades.GetAverageGrade();
                if (average > 7) return 1;
                else return -1;
            }
        } // 1: Graduation Essay; 0: Re-Exam; -1: Graduation Test

        // Contructors
        public Student()
        {
            this.Name = "#UNDEFINED";
            this.Birth = default;
            this.StuGrades = new Grades();
        }
        public Student(string name, DateTime birth, Grades stuGrades)
        {
            this.Name = name.Trim() == "" ? "#UNDEFINED" : name;
            this.Birth = birth;
            this.StuGrades = stuGrades;
        }
    }
}
