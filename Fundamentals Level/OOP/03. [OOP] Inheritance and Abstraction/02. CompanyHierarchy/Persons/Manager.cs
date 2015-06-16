using System;
using System.Collections.Generic;
using Interfaces;

namespace Persons
{
    public class Manager : Employee, IManager
    {
        #region Fields

        private List<Employee> subordinates;

        #endregion

        #region Constructors

        public Manager(string firstName, string lastName, string id, double salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
            this.Subordinates = new List<Employee>();
        }

        #endregion

        #region Properties

        public List<Employee> Subordinates
        {
            get { return this.subordinates; }
            set { this.subordinates = value; }
        }

        #endregion

        #region Methods

        public void AddSubordinate(Employee subordinate)
        {
            this.Subordinates.Add(subordinate);
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0}{1}Subordinates: {2}", base.ToString(), Environment.NewLine, string.Join(", ", this.Subordinates));
        }

        #endregion
    }
}
