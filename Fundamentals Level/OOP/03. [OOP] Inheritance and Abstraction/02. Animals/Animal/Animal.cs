using System;

namespace Animals.Animal
{
    public abstract class Animal 
    {
        #region Fields

        private string name;
        private int age;
        private string gender;

        #endregion

        #region Constructors

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        #endregion


        #region Properties

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be null, empty or whitespace.");
                }
                else
                {
                    this.name = value;
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
                    throw new ArgumentOutOfRangeException("The age cannot be negative.");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The gender cannot be null, empry or whitespace.");
                }
                else
                {
                    this.gender = value;
                }
            }
        }

        #endregion

    }
}
