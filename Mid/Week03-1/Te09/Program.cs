namespace Te09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter row : ");
            int row_count = int.Parse(Console.ReadLine());
            Console.Write($"Enter col : ");
            int column_count = int.Parse(Console.ReadLine());
            int[,] array = new int[row_count, column_count];
            int num = 1;
            for (int i = 0; i < row_count; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < column_count; j++)
                    {
                        array[i, j] = num;
                        num++;
                    }
                }
                else
                {
                    for (int j = column_count - 1; j >= 0; j--)
                    {
                        array[i, j] = num;
                        num++;
                    }
                }
            }
            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < column_count; j++)
                {
                    Console.Write($"\t{array[i, j]}");
                }
                Console.Write($"\n");
            }
        }
    }
}
