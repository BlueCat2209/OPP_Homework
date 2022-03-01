using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Aggregation_Of_Circle
{
    class Circle
    {
        // Properties
        private Coordinate Center;
        private double Radius;

        // Methods
        public double GetPerimeter() 
        {
            double perimeter = 2 * this.Radius * Math.PI;
            return perimeter;
        }
        public double GetArea()
        {
            double area = this.Radius * this.Radius * Math.PI;
            return area;
        }
        public void InformationToString()
        {
            Console.WriteLine($"The Circle with the center is {this.Center.CoordinteToString()} and the radius is {this.Radius:n2}" +
                              $" has an area of {this.GetArea():n2} and an perimeter of {this.GetPerimeter():n2}.");
        }

        // Setters
        public void SetCenter(Coordinate center)
        {
            this.Center = center;
        }
        public void SetRadius(double radius)
        {
            this.Radius = radius;
        }

        // Getters
        public Coordinate GetCenter() => this.Center;
        public double GetRadius() => this.Radius;

        // Constructors
        public Circle(Coordinate center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }
        public Circle()
        {
            this.Center = new Coordinate(0, 0);
            this.Radius = Math.PI;
        }
    }
}
