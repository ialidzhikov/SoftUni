using System;
using System.Collections.Generic;
using System.Linq;
using ClassStudent;

class StudentsByGroup
{
    static void Main()
    {
        var studentsQuery = from student in Student.StudentsList
                            where student.GroupNumber == 2
                            orderby student.FirstName
                            select student;

        foreach (Student student in studentsQuery)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-3}", student.FirstName, student.LastName, student.GroupNumber);
        }
    }
}

