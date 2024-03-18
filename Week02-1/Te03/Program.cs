namespace Te03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("monday:");
        string monday_subject = Console.ReadLine();
        double monday_credit = double.Parse(Console.ReadLine());
        Console.WriteLine("tuesday:");
        string tuesday_subject = Console.ReadLine();
        double tuesday_credit = double.Parse(Console.ReadLine());
        Console.WriteLine("wednesday:");
        string wednesday_subject = Console.ReadLine();
        double wednesday_credit = double.Parse(Console.ReadLine());
        Console.WriteLine("thursday:");
        string thursday_subject = Console.ReadLine();
        double thursday_credit = double.Parse(Console.ReadLine());
        Console.WriteLine("friday:");
        string friday_subject = Console.ReadLine();
        double friday_credit = double.Parse(Console.ReadLine());

        string output = String.Format($"monday:{monday_subject},_credit:{monday_credit}\n"+
                                      $"tuesday:{tuesday_subject},_credit:{tuesday_credit}\n"+
                                      $"wednesday:{wednesday_subject},_credit:{wednesday_credit}\n"+
                                      $"thursday:{thursday_subject},_credit:{thursday_credit}\n"+
                                      $"friday:{friday_subject},_credit:{friday_credit}");
        Console.WriteLine(output);
    }
}