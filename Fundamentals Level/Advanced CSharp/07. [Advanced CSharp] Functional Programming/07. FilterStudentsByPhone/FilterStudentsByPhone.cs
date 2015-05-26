using System;
using System.Linq;
using System.Text.RegularExpressions;
using ClassStudent;

class FilterStudentsByPhone
{
    static void Main()
    {
        var studentsFilteredByPhone = Student.StudentsList
            .Where(student => Regex.IsMatch(student.PhoneNumber, @"^(02|\+3592|\+359 2)", RegexOptions.CultureInvariant));

        foreach (Student student in studentsFilteredByPhone)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-20}", student.FirstName, student.LastName, student.PhoneNumber);
        }
    }
}

