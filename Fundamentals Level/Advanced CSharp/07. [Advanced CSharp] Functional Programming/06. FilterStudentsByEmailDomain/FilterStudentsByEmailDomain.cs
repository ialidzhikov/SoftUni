using System;
using System.Linq;
using ClassStudent;

class FilterStudentsByEmailDomain
{
    static void Main()
    {
        var studentsWithDomainABV = Student.StudentsList.Where(student => student.Email.EndsWith("@abv.bg"));

        foreach (Student student in studentsWithDomainABV)
        {
            Console.WriteLine("{0,-7} {1,-10} {2,-20}", student.FirstName, student.LastName, student.Email);
        }
    }
}

