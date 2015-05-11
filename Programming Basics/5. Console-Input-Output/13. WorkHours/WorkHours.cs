using System;
class WorkHours
{
    static void Main()
    {
        double requiredHours = double.Parse(Console.ReadLine());
        double availableDays = double.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());

        double workingDays = availableDays * 0.9;
        double workingHours = (workingDays * 12.0) * (productivity / 100.0);
        workingHours = Math.Floor(workingHours);

        double difference = workingHours - requiredHours;
        if (difference >= 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(difference);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(difference);
        }
    }
}

