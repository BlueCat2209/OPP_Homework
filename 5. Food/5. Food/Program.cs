using System;

namespace _5._Food
{
    class Program
    {
        static void Main(string[] args)
        {
            Food rice = new Food("M1", "Rice", 10000, new DateTime(1 , 1 , 1), new DateTime(2022 , 2 , 23));
            Food meat = new Food("M2", "Meat", 20000, new DateTime(1 , 1 , 1), new DateTime(2022 , 2 , 20));
            Food soup = new Food("M3", "Soup", 10000, new DateTime(1 , 1 , 10), new DateTime(1 , 1 , 2));

            Console.WriteLine("|ID |Name                |Price          |Create Date    |Expiry Date    |Note           |");
            rice.InformationToString();
            meat.InformationToString();
            soup.InformationToString();
        }
    }
}
