using System;

namespace SoftwareUniversityLearningSystem.Trainer
{
    using Person;
    public class Trainer : Person
    {
        #region Constructors

        public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }

        #endregion

        #region Methods

        public void CraateCourse(string courseName)
        {
            Console.WriteLine("The course \"{0}\" has been created by {1}.", courseName, this.FirstName + ' ' + this.LastName);
        }

        #endregion
    }
}
