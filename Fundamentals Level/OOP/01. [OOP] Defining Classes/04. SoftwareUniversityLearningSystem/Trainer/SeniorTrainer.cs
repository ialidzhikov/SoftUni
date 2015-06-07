using System;

namespace SoftwareUniversityLearningSystem.Trainer
{
    public class SeniorTrainer : Trainer
    {
        #region Constructors

        public SeniorTrainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }

        #endregion

        #region

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("The course \"{0}\" has been deleted.");
        }

        #endregion
    }
}
