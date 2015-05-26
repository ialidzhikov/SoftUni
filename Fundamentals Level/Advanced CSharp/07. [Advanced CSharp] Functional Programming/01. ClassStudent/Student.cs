using System;
using System.Collections.Generic;

namespace ClassStudent
{
    public class Student
    {
        public static List<Student> StudentsList = new List<Student>()
        {
            new Student("Ivan", "Ivanov", 18, 4400141, "+359883388303", "i.ivanov@softuni.bg", new List<int>() {3, 2, 3, 6}, 2, "Softuni"),
            new Student("Petur", "Ivanov", 16, 44011, "+359283388304", "p.ivanov@abv.bg", new List<int>() {5, 4, 3, 4}, 1, "Telerik"),
            new Student("Blagoy", "Georgiev", 28, 440012, "+359283388305", "b.georgiev@softuni.bg", new List<int>() {5, 2, 5, 4}, 2, "Softuni"),
            new Student("Mariq", "Pavlova", 19, 440013, "+359 28 338 8306", "m.pavlova@softuni.bg", new List<int>() {5, 6, 6, 6}, 2, "Softuni"),
            new Student("Ivan", "Kolev", 18, 440014, "02 81 80", "i.kolev@softuni.bg", new List<int>() {3, 2, 6, 6}, 3, "Softuni"),
            new Student("Pavel", "Angelov", 18, 440015, "029109", "p.angelov@abv.bg", new List<int>() {3, 2, 2, 6}, 3, "Telerik"),
            new Student("Angel", "Kirilov", 17, 440016, "+359883388308", "a.kirilov@softuni.bg", new List<int>() {2, 2, 4, 4}, 3, "Softuni"),
            new Student("Kiril", "Shishkov", 21, 440114, "+359883388309", "k.shishkov@abv.bg", new List<int>() {3, 2, 2, 2}, 1, "Telerik"),
            new Student("Ivan", "Dobrev", 22, 440018, "+359283388310", "i.dobrev@softuni.bg", new List<int>() {5, 5, 5, 3}, 2, "Softuni"),
            new Student("Ivana", "Mramova", 32, 440214, "+359883388311", "i.mramova@softuni.bg", new List<int>() {2, 4, 6, 2}, 2, "HackBulgaria"),
        };

        #region Constructors

        public Student(string firstName, string lastName, int age, int facultyNumber, string phoneNumber, string email,
            IList<int> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        #endregion

        #region Properties 

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return String.Format("{0,-20}  {1}", this.FirstName + ' ' + this.LastName, this.FacultyNumber);
        }

        #endregion

        static void Main()
        {
            
        }
    }
}

