using System;
using System.Linq;
using ClassStudent;

class SortStudents
{
    static void Main()
    {
        Console.WriteLine("Method syntax: ");
        var sortedStudents = Student.StudentsList
                            .OrderByDescending(student => student.FirstName)
                            .ThenByDescending(student => student.LastName);

        foreach (Student student in sortedStudents)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-7}", student.FirstName, student.LastName, student.FacultyNumber);
        }

        Console.WriteLine();
        Console.WriteLine("Query syntax: ");
        var studentsQuery = from student in Student.StudentsList
                            orderby student.FirstName descending, student.LastName descending
                            select student;

        foreach (Student student in studentsQuery)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-7}", student.FirstName, student.LastName, student.FacultyNumber);
        }

    }
}

