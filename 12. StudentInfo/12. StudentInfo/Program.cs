using System;

namespace _12._StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int n = int.Parse(Console.ReadLine());

            Student[] list = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Get student information!");
                Console.Write("Enter Name:");
                string name = Console.ReadLine();

                Console.Write("Enter Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter Phone: ");
                string phone = Console.ReadLine();

                Console.Clear();
                list[i] = new Student(name, address, phone);
            }
            Console.Write("Enter \"Y\" to create a Course with these students: ");
            string command = Console.ReadLine();
            if ((command == "y")||(command == "Y"))
            {
                Console.Clear();
                Console.WriteLine("Get course information!");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter open day: ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("Enter open month: ");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Enter open year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Enter Course length: ");
                int length = int.Parse(Console.ReadLine());

                Console.Clear();
                Course myCourse = new Course(name, new DateTime(year, month, day), length, list);

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{list[i].GetName()} is learning in the course: {list[i].GetCourse()}");
                }
            }
        }
    }
}
