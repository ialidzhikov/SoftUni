using System;
using System.Linq;
using ClassStudent;

class StudentsByGroups
{
    static void Main()
    {
        var groupedStudents = from student in Student.StudentsList
                                group student by student.GroupName into studentGroup
                                orderby studentGroup.Key
                                select studentGroup;

        foreach (IGrouping<string, Student> studentGroup in groupedStudents)
        {
            Console.WriteLine("Group name: {0}", studentGroup.Key);
            foreach (Student student in studentGroup)
            {
                Console.WriteLine("-> {0,-7} {1,-10} {2,-10}", student.FirstName, student.LastName, student.FacultyNumber);
            }
        }
    }
}

