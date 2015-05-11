using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        ulong personalID = ulong.Parse(Console.ReadLine());
        uint employeeNumber = uint.Parse(Console.ReadLine());

        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique employee number: {5}",
            firstName, lastName, age, gender, personalID, employeeNumber);
    }
}

