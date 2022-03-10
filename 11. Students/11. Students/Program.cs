using System;

namespace _11._StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Student in the List: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            Student[] myStudent = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"INFORMATION OF STUDENT {i+1}");
                Console.Write("+ Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("+ Enter Day of Birth: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("+ Enter Month of Birth: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("+ Enter Year of Birth");
                int year = int.Parse(Console.ReadLine());
                DateTime birth = new DateTime(year, month, day);

                Console.Write("+ Enter Math's grades: ");
                double math = double.Parse(Console.ReadLine());
                Console.Write("+ Enter English's grades: ");
                double english = double.Parse(Console.ReadLine());
                Console.Write("+ Enter Physics's grades: ");
                double physics = double.Parse(Console.ReadLine());
                Console.Write("+ Enter Biology's grades: ");
                double biology = double.Parse(Console.ReadLine());
                Console.Write("+ Enter Literature's grades: ");
                double literature = double.Parse(Console.ReadLine());
                Grades stuGrades = new Grades(math, english, physics, biology, literature);

                myStudent[i] = new Student(name, birth, stuGrades);
                Console.Clear();
            }

            int isEssay = 0; int isReExam = 0; int isTest = 0;
            for (int i = 0; i < n; i++)
            {
                int type = myStudent[i].GetExamType();
                if (type == 1)
                {
                    isEssay++;
                }
                else if (type == -1)
                {
                    isTest++;
                }
                else if (type == 0)
                {
                    isReExam++;
                }
            }

            Console.WriteLine($"There are {isEssay} students have to do the Graduation Essay!");
            Console.WriteLine($"There are {isTest} students have to do the Graduation Test!");
            Console.WriteLine($"There are {isReExam} students have to do the Re-Examination");
        }
    }
}
