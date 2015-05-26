using System;
using System.Collections.Generic;
using System.Linq;
using ClassStudent;

class StudentsByAge
{
    static void Main()
    {
        var studentsQuery = from student in Student.StudentsList
                            where student.Age >= 18 && student.Age <= 24
                            select new {student.FirstName, student.LastName, student.Age};

        foreach (var student in studentsQuery)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-3}", student.FirstName, student.LastName, student.Age);
        }
    }
}

