using System;
using System.Collections.Specialized;

namespace SoftwareUniversityLearningSystem.Student
{
    using SoftwareUniversityLearningSystem.Person;
    public class Student : Person
    {
        #region Fields

        private int studentNumber;
        private double averageGrade;

        #endregion

        #region Constructors

        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        #endregion

        #region Properties

        public int StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The student number cannot be negative.");
                }
                else
                {
                    this.studentNumber = value;
                }
            }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The average grade cannot be nagative.");
                }
                else
                {
                    this.averageGrade = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-3} {3,-6} {4,-3:F2}",
                this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade);
        }

        #endregion
    }
}
