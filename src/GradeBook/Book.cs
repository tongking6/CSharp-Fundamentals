using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;

        private string name;

        public Book(string name)
        {
            this.grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var average = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach(double grade in grades) 
            {
                average += grade;
                highestGrade = Math.Max(highestGrade, grade);
                lowestGrade = Math.Min(lowestGrade, grade);
            }
            average /= grades.Count;
            Console.WriteLine($"The average grade is: {average:N1}");
            Console.WriteLine($"The highest grade is: {highestGrade:N1}");
            Console.WriteLine($"The lowest grade is: {lowestGrade:N1}");
        }
    }
}