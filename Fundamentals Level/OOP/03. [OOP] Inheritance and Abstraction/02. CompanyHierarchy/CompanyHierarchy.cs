using System;
using Persons;
using Projects;
using Sales;

namespace CompanyHierarchy
{
    class CompanyHierarchy
    {
        static void Main()
        {
            Employee employeeOne = new Employee("Ivan", "Ivanov", "9004223664", 340.56, Department.Production);
            Employee employeeTwo = new Employee("Hasan", "Hasanov", "9004223665", 390.56, Department.Sales);
            Employee employeeThree = new Employee("Stamat", "Georgiev", "9004223662", 1000, Department.Marketing);
            Employee employeeFour = new Employee("Velin", "Angelov", "9004223660", 710.11, Department.Marketing);

            Manager managerOne = new Manager("Maria", "Angelova", "9405063102", 450.32, Department.Marketing);
            managerOne.AddSubordinate(employeeOne);
            managerOne.AddSubordinate(employeeTwo);
            Manager managerTwo = new Manager("Lidiq", "Nikolova", "9602010345", 500.02, Department.Sales);
            managerTwo.AddSubordinate(employeeThree);
            managerTwo.AddSubordinate(employeeFour);

            RegularEmployee regularEmployeeOne = new RegularEmployee("Maria", "Dimitrova", "0101032333", 400, Department.Marketing);
            
            SalesEmployee salesEmployeeOne = new SalesEmployee("Ivan", "Pehlivanov", "7808123344", 4322, Department.Sales);
            salesEmployeeOne.AddSale(new Sale("Milak", new DateTime(2015, 6, 17), 12));

            Developer developerOne = new Developer("Dimitur", "Dimitrov", "8909184560", 5000, Department.Accounting);
            developerOne.AddProject(new Project("SoftUni 2.0", new DateTime(2014, 12, 31), "", State.Open));

            Customer customerOne = new Customer("Nadejda", "Petrova", "6711117890", 450);

            Person[] companyArray = new Person[]
            {
                employeeOne, employeeTwo, employeeThree, employeeFour,
                managerOne, managerTwo,
                regularEmployeeOne,
                salesEmployeeOne,
                developerOne,
                customerOne,
            };

            for (int i = 0; i < companyArray.Length; i++)
            {
                Console.WriteLine("{0}.", i);
                Console.WriteLine(companyArray[i]);
            }
        }
    }
}
