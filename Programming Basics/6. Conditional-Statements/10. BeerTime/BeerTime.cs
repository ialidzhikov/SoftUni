using System;
using System.Globalization;
class BeerTime
{
    static void Main()
    {
        string input = Console.ReadLine();
        string format = "h:mm tt";
        DateTime time = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);

        DateTime startTime = DateTime.ParseExact("1:00 PM", format, CultureInfo.InvariantCulture);
        DateTime endTime = DateTime.ParseExact("3:00 AM", format, CultureInfo.InvariantCulture);
        endTime = endTime.AddDays(1);
        
        if (time.ToString("tt") == "AM")
        {
            time = time.AddDays(1);
        }

        if (time >= startTime && time < endTime)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

