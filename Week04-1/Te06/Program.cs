namespace Te06;

class Program
{
    static void Main(string[] args)
    {
        MyDictionary md = new MyDictionary(new string[] { "choi", "kim", "park", "lee", "hwa" });
        md.disPlay();
        Console.WriteLine("____________________");
        for (int i = 0; i < md.Size; i++){ 
            Console.WriteLine(md[i]); //정수를 인자로 받는 인덱서 사용 
        }
        Console.WriteLine("____________________");
        Console.WriteLine(md["park"]);
    }
}