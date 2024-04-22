namespace As08;

class Program
{
    static public void fillArray(out int[] array)
    {
        //Initialize the array, 출력 전용 매개변수에 반드시 값이 저장되어야 함
        array = new int[5] { 1, 2, 3, 4, 5 };
    }
    static void Main(string[] args)
    {
        int[] my_array; //초기화 필요 없음
        fillArray(out my_array);
        Console.Write($"Array elements are : ");
        foreach (var data in my_array){
            Console.Write($"{data} ");
        }
    }
}