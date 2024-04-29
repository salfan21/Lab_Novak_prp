using System;

public class Program
{
    public static void Main(string[] args)
    {
        Func<int> daysInCurrentMonth = () => DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

        int days = daysInCurrentMonth();
        Console.WriteLine($"У поточному місяці {days} днів.");
    }
}
