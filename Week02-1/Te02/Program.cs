namespace Te02;

class Program
{
    static void Main(string[] args)
    {
        char ch;
        Console.Write("1. Enter char >>");
        int value = Console.Read();
        Console.ReadLine(); //또는 Console.Read(), 입력 버퍼 지우기
        //ch=(char)Console.Read(); 형변환
        ch = Convert.ToChar(value); //형변환
        Console.WriteLine($"char : {ch}");
        if (char.IsNumber(ch)) {
            //변수 ch에 저장된 값이 숫자이면
            Console.WriteLine("Number");
        }
        else if (char.IsLetter(ch)) {
            //문자이면
            Console.WriteLine("Letter");
        }
        else {
            Console.WriteLine("Other");
        }
        int digit;
        Console.Write("2. Enter int >>");
        digit = int.Parse(Console.ReadLine());
        Console.WriteLine($"int : {digit}");
        double dvalue;
        Console.Write("3. Enter float >>");
        dvalue = double.Parse(Console.ReadLine());
        Console.WriteLine($"float  : {dvalue}");
    }
}