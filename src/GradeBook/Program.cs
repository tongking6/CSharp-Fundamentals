﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.7 };
            var result = 0.0;
            foreach(double number in grades) 
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N1}");

            if(args.Length > 0) 
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                   Console.WriteLine("Hello!");
            }
        }
    }
}
