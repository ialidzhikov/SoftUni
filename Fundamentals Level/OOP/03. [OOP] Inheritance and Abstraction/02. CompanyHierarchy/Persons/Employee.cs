using System;
using Interfaces;

namespace Persons
{
    public enum Department
    {
        Production, Accounting, Sales, Marketing,
    }

    public class Employee : Person, IEmployee
    {
        #region Fields

        private double salary;
        private Department department;

        #endregion

        #region Constructors

        public Employee(string firstName, string lastName, string id, double salary, Department department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        #endregion

        #region Properties

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary cannot be negative.");
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} {1,-10:C2} {2,-10}", base.ToString(), this.Salary, this.Department) ;
        }

        #endregion
    }
}
