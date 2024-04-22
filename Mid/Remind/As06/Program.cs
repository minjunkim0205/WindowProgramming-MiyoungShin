namespace Ex09;

class Program
{
    static void Main(string[] args)
    {
        // R,C(행,열)(y,x)
        Console.Write($"Enter row : ");
        int row = int.Parse(Console.ReadLine());
        Console.Write($"Enter col : ");
        int col = int.Parse(Console.ReadLine());
        int[,] array = new int[row, col];
        int n = 1;
        for(int r = 0; r < row; r++){
            for(int c = 0; c < col; c++){
                array[r, c] = n;
                n++;
            }
        }
        for(int r = 0; r < row; r++){
            for(int c = 0; c < col; c++){
                Console.Write($"{array[r, c]} ");
            }
            Console.Write($"\n");
        }
    }
}