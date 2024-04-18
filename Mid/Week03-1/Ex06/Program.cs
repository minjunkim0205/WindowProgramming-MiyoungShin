namespace Ex06;

class Program
{
    static private int RandomOdd()
    {
        Random random = new Random();
        int n;
        do
        {
            n = random.Next(1, 101);
        } while (n % 2 == 0);

        return n;
    }

    static void Main(string[] args)
    {
        Console.Write($"\t3x3 Array\n");
        int[,] data = new int[3, 3];
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                data[i, j] = RandomOdd();
            }
        }

        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write($"{data[i, j]}\t");
            }

            Console.Write($"\n");
        }
    }
}