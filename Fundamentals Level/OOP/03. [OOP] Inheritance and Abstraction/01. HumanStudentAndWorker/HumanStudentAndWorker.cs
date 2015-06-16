using System;
using System.Collections.Generic;
using System.Linq;
using HumanStudentAndWorker.Human;

namespace HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "51240"),
                new Student("Angel", "Andreev", "51238"),
                new Student("Stanimir", "Smith", "54212"),
                new Student("Valentin", "Petrov", "51909"),
                new Student("Stamat", "Ivanov", "51244"),
                new Student("Nikolay", "Kolev", "51242"),
                new Student("Nikolay", "Konstantinov", "51241"),
                new Student("Ivan", "Lqpchev", "51567"),
                new Student("Ivana", "Ivanova", "78129"),
                new Student("Aleksandra", "Aleksandrova", "51240"),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Bat Georgi", "Ivanov", 499, 12),
                new Worker("Bay Ivan", "Angelov", 499.87, 11),
                new Worker("Aleksandur", "Ivanov", 100, 2),
                new Worker("Ivan", "Goranov", 150.5, 1.4),
                new Worker("Branimir", "Stoychev", 1000, 7),
                new Worker("Andrey", "Peychev", 1201.1, 9),
                new Worker("Desislava", "Peycheva", 788, 10),
                new Worker("Lilqna", "Stoeva", 600, 8),
                new Worker("Marina", "Siderova", 567, 7),
                new Worker("Hasan", "Ivedik", 499, 12),
            };

            var studentsQuery = from student in students
                                orderby student.FacultyNumber ascending
                                select student;

            Console.WriteLine("Students query: ");
            foreach (Student student in studentsQuery)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            var workersQuery = from worker in workers
                                orderby worker.WeekSalary/(worker.WorkHoursPerDay*5)
                                select worker;

            Console.WriteLine("Workers query: ");
            foreach (Worker worker in workersQuery)
            {
                Console.WriteLine("{0} {1,-5:F2}", worker, worker.WeekSalary / (worker.WorkHoursPerDay * 5));
            }
            Console.WriteLine();

            List<Human.Human> mergedList = students.Cast<Human.Human>().Concat(workers.Cast<Human.Human>()).ToList();
            var mergedQuery = from human in mergedList
                                orderby human.FirstName, human.LastName
                                select human;

            Console.WriteLine("Merged query: ");
            foreach (Human.Human human in mergedQuery)
            {
                Console.WriteLine(human);
            }
        }
    }
}
