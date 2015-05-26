using System;
using System.Linq;
using ClassStudent;

class StudentsJoinedToSpecialties
{
    static void Main()
    {
        var joinedStudentsWithSpecialties =
            from studentSpecialty in StudentSpecialty.StudentSpecialty.StudentSpecialties
            join student in Student.StudentsList on studentSpecialty.FacultyNumber equals student.FacultyNumber
            orderby student.FirstName, student.LastName ascending 
            select new {student.FirstName, student.LastName, student.FacultyNumber, studentSpecialty.SpecialtyName};

        foreach (var student in joinedStudentsWithSpecialties)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-10} {3,-20}",
                student.FirstName, student.LastName, student.FacultyNumber, student.SpecialtyName);
        }


    }
}

