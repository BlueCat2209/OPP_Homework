using System;

namespace _9._Workers
{
    class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("WELCOM TO MY WORKER LIST!");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Add a new worker into the List.");
            Console.WriteLine("2. Find a worker with their ID.");
            Console.WriteLine("3. Print the total worker are existing in the List.");
            Console.WriteLine("4. Print the workers with equal or more KPI than you want.");
            Console.WriteLine("5. Print the total Workers in the List.");
            Console.WriteLine("6. Sort the List by KPI ascending.");
            Console.WriteLine("7. Exit.");
            Console.WriteLine("=========================");
            Console.Write("Enter your command: ");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Worker you want to make a List: ");
            int length = int.Parse(Console.ReadLine());
            Console.Clear();

            WorkersList myList = new WorkersList(length);
            int command = 0;
            int id; string name; int kpi; int tmp;

            while (command != 7)
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
                        Console.Write("Enter KPI: ");
                        kpi = int.Parse(Console.ReadLine());

                        if (myList.Add(new Worker(id, name, kpi)))
                        {
                            Console.WriteLine("The Worker has been successfully added into the List!");
                        }
                        break;
                    case 2:
                        Console.Write("Enter the ID you want to find: ");
                        id = int.Parse(Console.ReadLine());

                        tmp = myList.Find(id);
                        if (tmp >= 0)
                        {
                            Console.WriteLine("This is the full-information of the worker you have looking for!");
                            Console.WriteLine("|ID   |Name                |KPI  |Salary   |");
                            myList.List[tmp].InformationToString();
                        }
                        else
                        {
                            Console.WriteLine("The ID you have looking for isn't exist in the List!");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"The number of workers in the List is: {myList.GetTotalWorker()}");
                        break;
                    case 4:
                        Console.Write("Enter the KPI you want to filtered: ");
                        kpi = int.Parse(Console.ReadLine());
                        Console.WriteLine("|ID   |Name                |KPI  |Salary   |");
                        myList.OnKPIToString(kpi);
                        break;
                    case 5:
                        Console.WriteLine("|ID   |Name                |KPI  |Salary   |");
                        myList.TotalInformationToString();
                        break;
                    case 6:
                        myList.SortListByKPI(myList);
                        Console.WriteLine("The List has been successfully sorted by KPI!");
                        break;
                    case 7:
                        Console.WriteLine("Thank you for using my program!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
