using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(92.1);

            var grades = new List<double>() { 12.7,32.2, 12.9, 1.1 };
            grades.Add(56.1);

            var result = 0.0;
            foreach(double number in grades)
            {
                result += number;
                
            }
            result /= grades.Count;
            Console.WriteLine($"The Average grade is {result:N1}");
            //N3 is a formatting element that says we want 3 numbers after a decimal
        }
    }
}
