using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Aggregation_Of_Circle
{
    class Coordinate
    {
        // Properties
        private string Name;
        private double X;
        private double Y;

        // Method
        public string CoordinteToString() => $"({this.X}, {this.Y})";        

        // Setters
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetX(double x)
        {
            this.X = x;
        }
        public void SetY(double y)
        {
            this.Y = y;
        }

        // Getters
        public double GetX() => this.X;
        public double GetY() => this.Y;
        public string GetName() => this.Name;
        // Constructors
        public Coordinate()
        {
            this.Name = "#UNDEFINED";
            this.X = 0;
            this.Y = 0;
        }
        public Coordinate(double x, double y)
        {          
            this.X = x;
            this.Y = y;
        }
    }
}
