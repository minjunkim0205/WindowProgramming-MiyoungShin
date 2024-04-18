namespace Ex06;

class Program
{
    delegate string strConcat(string str1, string str2);
    static void result(strConcat strcat){
        Console.Write($"{strcat("C#", "window program")}\n");
    } 
    static void Main(string[] args)
    {
        result( (string str1,string str2) => { return str1 + str2; } );
    }
}