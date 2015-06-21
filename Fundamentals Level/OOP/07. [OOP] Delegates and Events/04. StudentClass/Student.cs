using System;

namespace StudentClass
{
    public delegate void OnPropertyChangeEventHandler(Student sender, PropertyChangedEventArgs args);
    public class Student
    {
        public event OnPropertyChangeEventHandler PropertyChange;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        { 
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be null, empty or whitespace.");
                }

                if (this.PropertyChange != null)
                {
                    this.PropertyChange(this, new PropertyChangedEventArgs("Name", this.Name, value));
                }

                this.name = value;
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

                if (this.PropertyChange != null)
                {
                    this.PropertyChange(this, new PropertyChangedEventArgs("Age", this.Age, value));
                }

                this.age = value;
            }
        }
    }
}
