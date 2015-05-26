using System;
using System.Collections.Generic;
using System.Linq;
using ClassStudent;

class WeakStudents
{
    static void Main()
    {
        var weakStudents = Student.StudentsList.Where(student => student.Marks.Count(mark => mark == 2) == 2);

        foreach (Student weakStudent in weakStudents)
        {
            Console.WriteLine("{0,-7} {1,-20}", weakStudent.FirstName, String.Join(", ", weakStudent.Marks));
        }
    }
}

