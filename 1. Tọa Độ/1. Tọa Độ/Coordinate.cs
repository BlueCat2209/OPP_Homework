using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Tọa_Độ
{
    class Coordinate
    {
        private int X;
        private int Y;
        private string Name;

        public void SetX(int x)
        {
            this.X = x;
        }
        public void SetY(int y)
        {
            this.Y = y;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }

        public int GetX()
        {
            return this.X;
        }
        public int GetY()
        {
            return this.Y;
        }
        public string GetName()
        {
            return this.Name;
        }

        public string ToStringForm()
        {
            return $"({this.X}, {this.Y}) ";
        }

        public Coordinate(int x, int y, string name)
        {
            SetX(x);
            SetY(y);
            SetName(name);
        }
        public Coordinate()
        {
            this.X = default;
            this.Y = default;
            this.Name = default;
        }
    }
}
