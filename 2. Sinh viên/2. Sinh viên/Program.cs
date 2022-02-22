using System;

namespace _2._Sinh_viên
{
    class Program
    {
        static void Main(string[] args)
        {
            // Giving students's information
            Student sv1 = new Student(1, "Duc Thuan", 9.9, 9.9);
            Student sv2 = new Student(2, "Ai Thanh", 10, 10);
            Student sv3 = new Student();

            Console.Write("Enter the student's Id of sv3: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the student's Name of sv3: ");
            string name = Console.ReadLine();
            Console.Write("Enter the student's Learning Point: ");
            double learningPoint = double.Parse(Console.ReadLine());
            Console.Write("Enter the student's Practice Point: ");
            double practicePoint = double.Parse(Console.ReadLine());

            sv3.SetId(id); sv3.SetName(name); sv3.SetLearningPoint(learningPoint); sv3.SetPracticePoint(practicePoint);

            // Print students's information list
            const string fieldName1 = "ID";
            const string fieldName2 = "NAME";
            const string fieldName3 = "LEARNING";
            const string fieldName4 = "PRACTICE";
            const string fieldName5 = "AVERAGE";

            Console.WriteLine(string.Format($"|{fieldName1,-5:n}|{fieldName2,-25:g}|{fieldName3,10:n2}|{fieldName4,10:n2}|{fieldName5,10:n2}|"));
            sv1.InformationToString();
            sv2.InformationToString();
            sv3.InformationToString();
        }
    }
}
