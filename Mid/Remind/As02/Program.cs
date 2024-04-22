namespace As02;

class Program{
    static private int randomOddNumber(int min, int max)
    {
        Random random = new Random();
        int n;
        do
        {
            n = random.Next(min, max+1);
        } while (n % 2 == 0);
        return n;
    }

    static void Main(string[] args){
        Console.Write($"[Make random odd number array]\n");
        Console.Write($"Enter array size >> ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for(int i = 0; i < size; i++){
            array[i] = randomOddNumber(1, 100);
        }
        foreach(int e in array){
            Console.Write($"{e} ");
        }
    }
}