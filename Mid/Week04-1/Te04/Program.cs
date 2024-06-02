namespace Te04
{
    internal class Program
    {
        static void MaxArray(out int max, params int[] data)
        {
            max = int.MinValue;
            foreach (int element in data)
            {
                if (element > max)
                {
                    max = element;
                }
            }
        }
        static void MaxArray(out double max, params double[] data)
        {
            max = Double.MinValue;
            foreach (double element in data)
            {
                if (element > max)
                {
                    max = element;
                }
            }
        }
        static void MaxArray(out string max, params string[] data)
        {
            max = null;
            foreach (string element in data)
            {
                if (max == null || String.Compare(element, max) > 0)
                {
                    max = element;
                }
            }
        }
        static void Main(string[] args)
        {
            MaxArray(out int imax, 4, 14, 5, 36, 7, 38, 9);
            Console.WriteLine($"imax = {imax}");

            MaxArray(out double dmax, 20.3, 4.5, 52.45, 94.3, 12.4, 79.5, 80.4);
            Console.WriteLine($"dmax = {dmax}");

            MaxArray(out string smax, "flower", "string", "program", "python", "java", "spring", "value");
            Console.WriteLine($"smax = {smax}");
        }
    }
}
