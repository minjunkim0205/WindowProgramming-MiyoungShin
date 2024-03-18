namespace Te05;

class Program
{
    private enum DayOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Main(string[] args)
    {
        DayOfTheWeek today = DayOfTheWeek.Wednesday;

        Console.Write($"Today is {today}.\n");
        Console.Write($"Yesterday is {today-1}.\n");
        Console.Write($"Tomorrow is {today+1}.\n");
    }
}