using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Sinh_viên
{
    class Student
    {
        // Properties
        private int Id;
        private string Name;
        private double LearningPoint;
        private double PracticePoint;

        // Setter
        public void SetId(int id)
        {
            this.Id = id;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetLearningPoint(double learningPoint)
        {
            this.LearningPoint = learningPoint;
        }
        public void SetPracticePoint(double practicePoint)
        {
            this.PracticePoint = practicePoint;
        }

        // Getter
        public int GetId()
        {
            return this.Id;
        }
        public string GetName()
        {
            return this.Name;
        }
        public double GetLearningPoint()
        {
            return this.LearningPoint;
        }
        public double GetPracticePoint()
        {
            return this.PracticePoint;
        }

        // Methods
        public double GetAveragePoint()
        {
            double averagePoint = (this.PracticePoint + this.LearningPoint) / 2;
            return averagePoint;
        }
        public void InformationToString()
        {
            Console.WriteLine(string.Format($"|{this.Id,-5:n0}|{this.Name,-25}|{this.LearningPoint,10:n2}|{this.PracticePoint,10:n2}|{GetAveragePoint(),10:n2}|"));
        }

        // Constructors
        public Student() // Deafault value
        {
            this.Id = 0;
            this.Name = null;
            this.LearningPoint = -1;
            this.PracticePoint = -1;
        }
        public Student(int id, string name, double learningPoint, double practicePoint) // Full information
        {
            this.Id = id;
            this.Name = name;
            this.LearningPoint = learningPoint;
            this.PracticePoint = practicePoint;
        }
    }
}
