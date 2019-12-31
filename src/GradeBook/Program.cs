using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Tong's Grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.0);
            book.AddGrade(95.8);

            var statistic = book.GetStatistics();

            Console.WriteLine($"The average grade is {statistic.Average:N1}");
            Console.WriteLine($"The highest grade is {statistic.HighestGrade:N1}");
            Console.WriteLine($"The lowest grade is {statistic.LowestGrade:N1}");
        }
    }
}
