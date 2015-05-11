using System;
using System.Globalization;
class ExamSchedule
{
    static void Main()
    {
        string hour = Console.ReadLine();
        string minutes = Console.ReadLine();
        string partOfDay = Console.ReadLine();
        int hourToAdd = int.Parse(Console.ReadLine());
        int minutesToAdd = int.Parse(Console.ReadLine());

        string format = "h:m:tt";
        string inputTime = hour + ':' + minutes + ':' + partOfDay;
        DateTime startTime = DateTime.ParseExact(inputTime, format, CultureInfo.InvariantCulture);
        TimeSpan timeToAdd = new TimeSpan(hourToAdd, minutesToAdd, 0);

        DateTime endTime = startTime.Add(timeToAdd);

        Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}

