namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        Func<int> func_1 = () => 34; 
        Func<int, int> func_2 = (a) => a*a; 
        Console.Write($"{func_1() + func_2(15)}");   
    }
}