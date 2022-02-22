using System;

namespace _1._Tọa_Độ
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Create a point
            Coordinate point = new Coordinate();

            // Set data for coordinate of the point
            Console.Write("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            point.SetX(x);

            Console.Write("Enter Y: ");
            int y = int.Parse(Console.ReadLine());
            point.SetY(y);

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            point.SetName(name);

            // Get the information about the point for the user
            Console.WriteLine($"This is the name of the point: {point.GetName()}");
            Console.WriteLine($"This is the x position of {point.GetName()}: {point.GetX()}");
            Console.WriteLine($"This is the y position of {point.GetName()}: {point.GetY()}");

            // Print the point coordinate 
            Console.WriteLine($"This is the coordinate of the { point.GetName()}: {point.ToStringForm()}");
        }
    }
}
