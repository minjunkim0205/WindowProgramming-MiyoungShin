namespace Te01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ValueAlignment = -7;
            double a = 3, b = 4;
            Console.WriteLine($"1)a = {a} and b= {b}:");
            Console.WriteLine("2)a = {0} and b = {1}:", a, b);
            Console.WriteLine($"3)|{"Arithmetic",12}|{0.5 * (a + b),ValueAlignment:F3}|");
            Console.WriteLine("4)|{0,12}|{1,-7:F3}|", "Arithmetic", 0.5 * (a + b));
            Console.WriteLine("5){0,10:D5}", 123);
            Console.WriteLine($"6){123,10:D5}");

            int X = 2, Y = 3;
            string message = String.Format("7)The point {0}, {1} is {2:F3}", X, Y, Math.Sqrt(X * X + Y * Y));

            //원시 문자열(raw string literals) 리터럴
            string pointMessage = $"""8)The point "{X}, {Y}" is {Math.Sqrt(X * X + Y * Y):F3}""";
            Console.WriteLine(message);
            Console.WriteLine(pointMessage);
            string name = "Hallym";
            int age = 34;
            Console.WriteLine($"9){name} is {age} year{(age == 1 ? "" : "s")} old.");

            Console.ReadKey();
        }
    }
}
