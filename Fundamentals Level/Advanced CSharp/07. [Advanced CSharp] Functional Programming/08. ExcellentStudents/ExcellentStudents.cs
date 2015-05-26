using System;
using System.Linq;
using ClassStudent;

class ExcellentStudents
{
    static void Main()
    {
        var excellentStudents = Student.StudentsList
                                .Select(student => new {student.FirstName, student.Marks})
                                .Where(student => student.Marks.Contains(6));

        foreach (var excellentStudent in excellentStudents)
        {
            Console.WriteLine("{0,-7} {1,-20}", excellentStudent.FirstName, String.Join(", ", excellentStudent.Marks));
        }
    }
}

