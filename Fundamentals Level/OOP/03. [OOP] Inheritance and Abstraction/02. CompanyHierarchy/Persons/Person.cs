using System;
using Interfaces;

namespace Persons
{
    public abstract class Person : IPerson
    {
        #region Fields

        private string firstName;
        private string lastName;
        private string id;

        #endregion

        #region Constructors

        public Person(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
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

        public string ID
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The first name cannot be null, empty or whitespace.");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,10}", this.FirstName, this.LastName, this.ID);
        }

        #endregion
    }
}
