using System;
using System.Collections.Generic;
using System.Text;

namespace _12._StudentInfo
{
    class Student
    {
        // Properties
        private string Name;
        private string Address;
        private string Phone;
        private string CourseName;

        // Setters
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetAddress(string address)
        {
            this.Address = address;
        }
        public void SetPhone(string phone)
        {
            this.Phone = phone;
        }
        public void SetCourse(string courseName)
        {
            this.CourseName = courseName;
        }

        // Getters
        public string GetName() => this.Name;
        public string GetAddress() => this.Address;
        public string GetPhone() => this.Phone;
        public string GetCourse() => this.CourseName;

        // Constructors
        public Student()
        {
            this.Name = "#UNDEFINED";
            this.Address = "#UNDEFINED";
            this.Phone = "#UNDEFINED";
            this.CourseName = "#UNDEFINED";
        }
        public Student(string name, string address, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
    }
}
