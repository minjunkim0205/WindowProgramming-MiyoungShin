namespace Ex07;

class Program
{
    static void Main(string[] args)
    {
        Car md;
        Console.Write("Enter number of data >> ");
        md = new Car(int.Parse(Console.ReadLine()));
        Console.WriteLine("____________________");
        Console.WriteLine("\n **** Data list **** ");
        for (int i = 0; i < md.Size; i++)
        {
            Console.WriteLine(i + " ) " + md[i]); //정수를 인자로 받는 인덱서 사용
        }
        Console.Write(" Find by car id >> ");
        //문자열 인자로 받는 인덱서 사용
        string result = md[Console.ReadLine()];
        Console.WriteLine("____________________");
        Console.WriteLine(result);
    }
}