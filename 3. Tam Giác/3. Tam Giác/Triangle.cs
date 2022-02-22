using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Tam_Giác
{
    class Triangle
    {
        // Properties
        private double A;
        private double B;
        private double C;

        // Methods
        public double GetPerimeter()
        {
            return this.A + this.B + this.C;
        }
        public double GetAcreage()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }
        public string GetTriangleType()
        {
            string triangleType = "";
            if (this.A * this.B * this.C <= 0)
            {
                triangleType = "Not a Triangle";
            }
            else if ((this.A == this.B) & (this.B == this.C))
            {
                triangleType = "Equilateral Triangle";
            }
            else if ((this.A == this.B) || (this.B == this.C) || (this.C == this.A))
            {
                triangleType = "Isosceles Triangle";
            }
            else if ((this.A * this.A == this.B * this.B + this.C * this.C) || (this.B * this.B == this.C * this.C + this.A * this.A) || (this.C * this.C == this.A * this.A + this.B * this.B))
            {
                triangleType = "Right-Angled Triangle";
            }
            else
            {
                triangleType = "Normal Triangle";
            }
            return triangleType;
        }
        public void InformationToString()
        {
            string triangleType = this.GetTriangleType();
            double perimeter = this.GetPerimeter();
            double acreage = this.GetAcreage();

            Console.WriteLine(string.Format($"|{this.A:n2}, {this.B:n2}, {this.C:n2}|{triangleType,-25}|{perimeter,-10:n2}|{acreage,-8:n2}|"));
        }
        // Setter
        public void SetA(double a)
        {
            if (a > 0) this.A = a;    
        }
        public void SetB(double b)
        {
            if (b > 0) this.B = b;
        }
        public void SetC(double c)
        {
            if (c > 0) this.C = c;
        }

        // Getter
        public double GetA()
        {
            return this.A;
        }
        public double GetB()
        {
            return this.B;
        }
        public double GetC()
        {
            return this.C;
        }

        // Constructor
        public Triangle()
        {
            this.A = default;
            this.B = default;
            this.C = default;              
        }
        public Triangle(double a, double b, double c)
        {
            if (a * b * c <= 0)
            {
                this.A = default;
                this.B = default;
                this.C = default;
            }
            else if ((a + b <= c)||(b + c <= a)||(c + a <= b))
            {
                this.A = default;
                this.B = default;
                this.C = default; 
            }
            else
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
        }
    }
}
