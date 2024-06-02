namespace Te10
{
    internal class Program
    {
        private enum Menu
        {
            KeepWarm = 1,
            Tea = 2,
            DoubleBoiler = 3,
            RapidHeating = 4
        };
        static void Main(string[] args)
        {
            Menu p;
            int[] time = { 60, 5, 10, 30 };
            Console.Write($"1: KeepWarm(60Min)\t2: Tea(5Min)\t3:DoubleBoiler(10Min)\t4:apidHeating(30Min)\n");
            Console.Write($"Select >>> ");
            int.TryParse(Console.ReadLine(), out int choice);
            var t = time[choice - 1];
            p = (Menu)choice;
            for (int i = 1; i <= t; i++)
            {
                Console.Write($"@");
                if (i % 20 == 0)
                {
                    Console.Write($"\n");
                }
                Thread.Sleep(500);
            }
            Console.Write($"\n");
            Console.Write($"{p} : {t}(Min) Heating ends\n");
        }
    }
}
