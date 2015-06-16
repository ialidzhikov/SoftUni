using System;
using Interfaces;

namespace Persons
{
    public class RegularEmployee : Employee, IRegularEmployee
    {
        #region Constructors

        public RegularEmployee(string firstName, string lastName, string id, double salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
            
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
