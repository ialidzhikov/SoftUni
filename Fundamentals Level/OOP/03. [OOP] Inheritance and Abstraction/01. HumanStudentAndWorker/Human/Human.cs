using System;

namespace HumanStudentAndWorker.Human
{
    public abstract class Human
    {
        #region Fields

        private string firstName;
        private string lastName;

        #endregion

        #region Constructors

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        #endregion


        #region Properties

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The first name canno be null, empty or whitespace.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The last name canno be null, empty or whitespace.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-16}", this.FirstName, this.LastName);
        }

        #endregion

    }
}
