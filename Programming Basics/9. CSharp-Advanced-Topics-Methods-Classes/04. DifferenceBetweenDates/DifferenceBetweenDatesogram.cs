using System;
using System.Globalization;
class DifferenceBetweenDates
{
    static void Main()
    {
        string firstDateAsString = Console.ReadLine();
        string secondDateAsString = Console.ReadLine();

        string format = "d.M.yyyy";
        DateTime firstDate = DateTime.ParseExact(firstDateAsString, format, CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondDateAsString, format, CultureInfo.InvariantCulture);

        TimeSpan difference = secondDate - firstDate;
        Console.WriteLine(difference.TotalDays);
    }
}

