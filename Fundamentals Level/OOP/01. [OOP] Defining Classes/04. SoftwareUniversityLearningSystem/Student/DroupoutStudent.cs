using System;

namespace SoftwareUniversityLearningSystem.Student
{
    public class DropoutStudent : Student
    {
        #region Fields

        private string dropoutReason;

        #endregion

        #region Constructors

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade,
            string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DroupoutReason = dropoutReason;
        }

        #endregion

        #region Properties

        public string DroupoutReason
        {
            get { return this.dropoutReason; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The dropout reason cannot be null, empty or whitespace.");
                }
                else
                {
                    this.dropoutReason = value;
                }
            }
        }

        #endregion
    }
}
