namespace Te07;

class Program
{
    static int capacity(){
        Console.Write($"Enter the array size >> ");
        int.TryParse(Console.ReadLine(), out int size);
        return size;
    }
    static void disPlay(string message){
        Console.Write($"-----------------------------------------------\n");
        Console.Write($"{message}\n");
    }
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int size;
        size = capacity();
        UserArray<int> gInteger = new UserArray<int>(size);
        for (int i=0; i< size/2; i++){
            gInteger[i] = rnd.Next(10, 100);
        }
        gInteger.add(3, 4, 5);
        disPlay("print integer array");
        Console.Write($"4th : {gInteger[3]}\n");
        gInteger.print();
        size = capacity();
        UserArray<double> gDouble = new UserArray<double>(size);
        for (int i = 0; i < size / 2; i++){
            gDouble[i] = rnd.NextDouble()*10;
        }
        gDouble.add(10.4, 20.9, 31.67);
        disPlay("print double array");
        for (int i = 0; i < gDouble.index; i++) {
            Console.Write($"{gDouble[i]:f2} ");
        }
    }
}