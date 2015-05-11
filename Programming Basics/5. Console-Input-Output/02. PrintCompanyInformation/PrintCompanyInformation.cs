using System;
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("{0,-25}", "Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("{0,-25}", "Company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("{0,-25}", "Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("{0,-25}", "Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("{0,-25}", "Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("{0,-25}", "Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("{0,-25}", "Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("{0,-25}", "Manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("{0,-25}", "Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
            companyName, companyAdress, phoneNumber, (String.IsNullOrWhiteSpace(faxNumber) ? "(no fax)" : faxNumber), webSite,
            firstName, lastName, age, managerPhone);
    }
}

