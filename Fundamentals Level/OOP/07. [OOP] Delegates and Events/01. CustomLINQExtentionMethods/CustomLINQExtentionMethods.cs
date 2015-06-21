using System;
using System.Collections.Generic;
using ExtentionMethods;
using StudentClass;

namespace CustomLINQExtentionMethods
{
    public class CustomLINQExtentionMethods
    {
        static void Main()
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var filteredCollection = numbers.WhereNot(number => number % 2 == 0);
            Console.WriteLine(string.Join(", ", filteredCollection));

            List<Student> students = new List<Student>()
            {
                new Student("Mariyka", 4.50),
                new Student("Ivancho", 3.40),
                new Student("Goshko", 4.55),
                new Student("Penka", 3.21)
            };

            Console.WriteLine(students.Max(student => student.Grade));
        }
    }
}
