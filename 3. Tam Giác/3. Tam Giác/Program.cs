using System;

namespace _3._Tam_Giác
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(3, 3, 5);
            Triangle triangle3 = new Triangle(5, 5, 5);
            Triangle triangle4 = new Triangle(0, 1, 3);
            Triangle triangle5 = new Triangle(-1, -2, -4);
            Console.WriteLine("|Egde            |Type                     |Perimeter |Acreage |");
            Console.WriteLine("________________________________________________________________");
            triangle1.InformationToString();
            triangle2.InformationToString();
            triangle3.InformationToString();
            triangle4.InformationToString();
            triangle5.InformationToString();
        }
    }
}
