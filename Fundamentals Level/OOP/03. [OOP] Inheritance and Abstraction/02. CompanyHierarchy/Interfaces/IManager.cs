using System;
using System.Collections.Generic;
using Persons;

namespace Interfaces
{
    public interface IManager : IEmployee
    {
        List<Employee> Subordinates { get; set; }

        void AddSubordinate(Employee subordinate);
    }
}
