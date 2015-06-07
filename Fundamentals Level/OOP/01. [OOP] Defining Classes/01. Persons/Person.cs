using System;

namespace Persons
{
    public class Person
    {
        #region Fields

        private string name;
        private int age;
        private string email;

        #endregion

        #region Constructors

        public Person(string name, int age) : this(name, age, null)
        {
            
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The value to assign cannot be null, empty or whitespace.");
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
                if (value < 1 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("The age sould be in the range [1..100].");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null)
                {
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("The email cannot be empty or whitespace.");
                    }
                    else if (!value.Contains("@"))
                    {
                        throw new ArgumentException("The email should contain '@'.");
                    }
                    else
                    {
                        this.email = value;
                    }
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("|{0,-16}|{1,-4}|{2,-20}|", this.Name, this.Age, this.Email ?? "(missing)");
        }

        #endregion

        static void Main()
        {
            Person[] persons = new Person[]
            {
                new Person("Ivan Ivanov", 19, "i.ivanov@abv.bg"),
                new Person("Ivanka Ivanova", 29, "i.ivanova@email.bg"),
                new Person("Georgi Popov", 21),
                new Person("Delqn Petrov", 25, "d.petrov@softuni.bg"), 
            };

            Console.WriteLine("|{0,-16}|{1,-4}|{2,-20}|", "Name", "Age", "Email");
            Console.WriteLine(new string('-', 44));
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
