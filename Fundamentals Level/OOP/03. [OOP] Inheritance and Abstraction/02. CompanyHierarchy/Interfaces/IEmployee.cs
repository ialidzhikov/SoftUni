using System;
using Persons;

namespace Interfaces
{
    public interface IEmployee : IPerson
    {
        double Salary { get; set; }

        Department Department { get; set; }
    }
}
