using System;
class Volleyball
{
    const int WEEKENDS = 48;
    static void Main()
    {
        string year = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometownWeekends = double.Parse(Console.ReadLine());

        double normalWeekends = WEEKENDS - hometownWeekends;
        double plays = normalWeekends * (3.0 / 4.0) + holidays * (2.0 / 3.0) + hometownWeekends;

        if (year == "leap")
        {
            plays += plays * 0.15;
        }

        Console.WriteLine("{0}", Math.Floor(plays));
    }
}

