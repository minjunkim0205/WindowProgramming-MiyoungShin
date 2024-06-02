namespace Te04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] init_array = { 0, 1, 2, 3, 4, 5 };
            foreach (var element in init_array)
            {
                Console.Write($"{element}\n");
            }
        }
    }
}
