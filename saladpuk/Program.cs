using System;

namespace saladpuk
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var grades = new Grades();
            Console.Write("Enter score : ");
            if (double.TryParse(Console.ReadLine(), out var value) && value <= 100)
            {
                grades.GradeSubject = value.ToString();
                Console.WriteLine("results  : {0}", grades.GradeSubject);
            }
            else
            {
                Console.WriteLine("Please check value");
            }

            Console.ReadKey();
        }
    }
}