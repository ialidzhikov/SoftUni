using System;
class AgeAfterTenYears
{ 
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        int currentAge = (int)((DateTime.Now - birthday).TotalDays / 365.242199);

        Console.WriteLine("You are {0} years old.", currentAge);
        Console.WriteLine("Your age after ten years will be: {0}", currentAge + 10);
    }
}

