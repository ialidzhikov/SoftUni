using System;
using System.Linq;

namespace SoftwareUniversityLearningSystem
{
    using Trainer;
    using Student;
    using Person;
    public class SULSTest
    {
        static void Main()
        {
            JuniorTrainer fil = new JuniorTrainer("Filip", "Kolev", 22);
            SeniorTrainer nasko = new SeniorTrainer("Nasko", "Rusenov", 18);

            fil.CraateCourse("C# Advanced");
            nasko.CraateCourse("OOP");

            Student.Student[] students = new Student.Student[]
            {   
                new GraduateStudent("Petya", "Petrova", 29, 12003, 5.90), 
                new CurrentStudent("Ivan", "Adamov", 24, 71432, 3.54, "OOP"),
                new DropoutStudent("Ivan", "Angelov", 33, 12003, 2.54, "Week results."), 
                new CurrentStudent("Georgi", "Popov", 22, 71433, 4.14, "OOP"),
                new DropoutStudent("Angel", "Georgiev", 32, 12006, 4.40, "Discipline problems."),
                new CurrentStudent("Stamat", "Strahilov", 32, 71412, 5.52, "Java Basics"),
                new CurrentStudent("Goran", "Ivanov", 19, 71434, 3.54, "PHP"),
                new CurrentStudent("Ivana", "Lyubenova", 44, 71439, 3.00, "OOP"),
                new OnlineStudent("Zdaravko", "Zdravchev", 22, 12032, 4.80, "OOP"), 
                new OnsiteStudent("Lyuba", "Staykova", 45, 32001, 3.55, "JavaScript"),
            };

            Student.Student[] studentsQuery = students
                .Where(student => student is CurrentStudent )
                .OrderBy(student => student.AverageGrade)
                .ToArray();

            Console.WriteLine();
            foreach (Student.Student student in studentsQuery)
            {
                Console.WriteLine(student);
            }
        }
    }
}
