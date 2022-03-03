using System;
using System.Collections.Generic;
using System.Text;

namespace _11._Students
{
    class Grades
    {
        // Properties
        private double Math;        
        private double English;
        private double Physics;
        private double Biology;
        private double Literature;

        // Setters
        public void SetMath(double math)
        {
            this.Math = math;
        }
        public void SetEnglish(double english)
        {
            this.English = english;
        }
        public void SetPhysics(double physics)
        {
            this.Physics = physics;
        }
        public void SetBiology(double biology)
        {
            this.Biology = biology;
        }
        public void SetLiterature(double literature)
        {
            this.Literature = literature;
        }

        // Getters
        public double GetMath() => this.Math;
        public double GetEnglish() => this.English;
        public double GetPhysics() => this.Physics;
        public double GetBiology() => this.Biology;
        public double GetLiterature() => this.Literature;
        public double GetAverageGrade() => (this.Math + this.English + this.Physics + this.Biology + this.Literature) / 5;         

        // Methods
        public bool IsReExam()
        {
            if ((this.Math < 5)||(this.English < 5)||(this.Physics < 5)||(this.Biology < 5)||(this.Literature < 5))
            {
                return true;
            }
            return false;
        }

        // Contructors
        public Grades()
        {
            this.Math = 0;            
            this.English = 0;
            this.Physics = 0;
            this.Biology = 0;
            this.Literature = 0;
        }
        public Grades(double math, double english, double physics, double biology, double literature)
        {
            this.Math = math > 0 ? math : 0;            
            this.English = english > 0 ? english : 0;
            this.Physics = physics > 0 ? physics : 0;
            this.Biology = biology > 0 ? biology : 0;
            this.Literature = literature > 0 ? literature : 0;
        }
    }
}
