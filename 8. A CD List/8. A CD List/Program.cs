using System; 
using System.Collections.Generic;
using System.Text;

namespace _8._A_CD_List
{
    class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("CD INFORMATION CENTER");
            Console.WriteLine("=====================");           
            Console.WriteLine("1. Create a CD with fully information.");
            Console.WriteLine("2. Create a CD With ID and name.");
            Console.WriteLine("3. Show the number of CDs in the list.");
            Console.WriteLine("4. Show total price of CDs in the list.");
            Console.WriteLine("5. Show total information of CDs in the list");
            Console.WriteLine("6. Sort the CDs by price.");
            Console.WriteLine("7. Sort the CDs by name.");
            Console.WriteLine("8. Find a CD");
            Console.WriteLine("9. Exit");
            Console.WriteLine("=====================");
            Console.Write("Enter your command: ");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the List: ");
            int n = int.Parse(Console.ReadLine());
            CDList myList = new CDList(n);

            int command = 0;
            CD tmp;
            int id; string name; int songsNumber; double price;
            while (command != 9)
            { 
                PrintMenu();
                command = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (command)
                {
                    case 1:                       
                        Console.Write("Enter ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter number of Songs: ");
                        songsNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        price = double.Parse(Console.ReadLine());

                        tmp = new CD(id, name, songsNumber, price);
                        if (myList.Add(tmp))
                        {
                            Console.WriteLine("CD has been successfully added into the List!");
                        }
                        break;
                    case 2:
                        Console.Write("Enter ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();

                        tmp = new CD(id, name);
                        if (myList.Add(tmp))
                        {
                            Console.WriteLine("CD has been successfully added into the List!");
                        }                    
                        break;
                    case 3:
                        Console.Write($"The number of CDs in the List is: {myList.GetCurlength()}");
                        break;
                    case 4:
                        Console.Write($"The total price of CDs in the List is: {myList.GetTotalPrice()}");
                        break;
                    case 5:
                        Console.WriteLine("|ID   |NAME                |SONGs NUMBER|PRICE|");
                        myList.InformationToString();
                        break;
                    case 6:
                        myList.SortListByPrice(myList);
                        Console.WriteLine("The List has been sorted by price!");
                        break;
                    case 7:
                        myList.SortListByName(myList);
                        Console.WriteLine("The List has been sorted by name!");
                        break;
                    case 8:
                        Console.Write("Enter ID of the CD you want to find: ");
                        id = int.Parse(Console.ReadLine());
                        if(myList.Find(id) >= 0)
                        {
                            tmp = myList.GetCDInformation(id);
                            Console.WriteLine("This is the fullly-information about the CD you have been looking for!");
                            Console.WriteLine("|ID   |NAME                |SONGs NUMBER|PRICE|");
                            tmp.InformationToString();
                        }
                        break;
                    case 9:
                        Console.WriteLine("Thank you for using my Program!");
                        break;

                }
                Console.ReadKey();
                Console.Clear(); 
            }
        }
    }
}
