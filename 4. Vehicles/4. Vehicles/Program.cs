using System;

namespace _4._Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle xe1 = new Vehicle("Nguyen Duc Thuan", "Sirius", 100, 100);
            Vehicle xe2 = new Vehicle("Ai Thanh", "Xe dien", 200, 100);
            Vehicle xe3 = new Vehicle("", "", -100, 0);

            // Print Information
            Console.WriteLine($"|Owner Name          |Type           |CylinderCap|Price          |Tax      |");
            xe1.InformationToString();
            xe2.InformationToString();
            xe3.InformationToString();
        }
    }
}
