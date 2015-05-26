using System;
using System.Collections.Generic;
using System.Linq;
using ClassStudent;

class StudentsByFirstAndLastName
{
    static void Main()
    {
        var studentsQuery = from student in Student.StudentsList
                            where String.Compare(student.FirstName, student.LastName, StringComparison.InvariantCulture) < 0
                            select student;

        foreach (Student student in studentsQuery)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-7}", student.FirstName, student.LastName, student.FacultyNumber);
        }

    }
}

