using System;

namespace _7._Aggregation_Of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Center's X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Center's Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter Center's Radius: ");
            double radius = double.Parse(Console.ReadLine());

            Circle tron = new Circle(new Coordinate(x, y), radius);
            tron.InformationToString();
        }
    }
}
