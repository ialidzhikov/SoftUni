using System;

namespace SoftwareUniversityLearningSystem.Student
{
    public class OnsiteStudent : CurrentStudent
    {
        #region Fields

        private int numberOfVisits;

        #endregion

        #region Constructors

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade,
            string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            
        }

        #endregion

        #region Properties

        public int NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of visits cannot be negative.");
                }
                else
                {
                    this.numberOfVisits = value;
                }
            }
        }

        #endregion
    }
}
