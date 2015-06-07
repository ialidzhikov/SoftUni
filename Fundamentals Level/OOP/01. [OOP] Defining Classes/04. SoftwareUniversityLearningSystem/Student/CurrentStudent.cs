using System;

namespace SoftwareUniversityLearningSystem.Student
{
    public class CurrentStudent : Student
    {
        #region Fields

        private string currentCourse;

        #endregion

        #region Constructors

        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade,
            string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        #endregion

        #region Properties

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The current course cannot be null, empty or whitespace.");
                }
                else
                {
                    this.currentCourse = value;
                }
            }
        }

        #endregion
    }
}
