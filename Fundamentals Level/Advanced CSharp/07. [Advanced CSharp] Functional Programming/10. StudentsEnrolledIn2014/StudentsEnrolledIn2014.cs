using System;
using System.Linq;
using ClassStudent;

class StudentsEnrolledIn2014
{
    static void Main()
    {
        var studentsEnrolledIn2014 = Student.StudentsList
            .Where(student => student.FacultyNumber.ToString().Length >= 6 && student.FacultyNumber.ToString().Substring(4, 2) == "14")
            .Select(student => new { student.FirstName, student.LastName, student.FacultyNumber, student.Marks});

        foreach (var student in studentsEnrolledIn2014)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-10} {3,-20}", 
                student.FirstName, student.LastName, student.FacultyNumber, String.Join(", ", student.Marks));
        }
    }
}

