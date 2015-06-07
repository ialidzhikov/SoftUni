using System;

namespace SoftwareUniversityLearningSystem.Person
{
    public class Person
    {
        #region Fields

        private string firstName;
        private string lastName;
        private int age;

        #endregion

        #region Constructors

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
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
                    throw new ArgumentException("The first name cannot be null, empty or whitespace.");
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
                    throw new ArgumentException("The last name cannot be null, empty or whitespace.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be less than zero.");
                }
                else
                {
                    this.age = value;
                }
            }
        }


        #endregion
    }
}
