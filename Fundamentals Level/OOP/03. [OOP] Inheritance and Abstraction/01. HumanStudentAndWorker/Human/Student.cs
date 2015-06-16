using System;
using System.Text.RegularExpressions;

namespace HumanStudentAndWorker.Human
{
    public class Student : Human
    {
        #region Fields

        private string facultyNumber;

        #endregion

        #region Constructors

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        #endregion

        #region Properties

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]{5,10}$", RegexOptions.CultureInvariant))
                {
                    throw new ArgumentException("The faculty number sould contain only [5..10] letters/numbers.");
                }
                else
                {
                    this.facultyNumber = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} {1,-10}", base.ToString(), this.FacultyNumber);
        }

        #endregion
    }
}
