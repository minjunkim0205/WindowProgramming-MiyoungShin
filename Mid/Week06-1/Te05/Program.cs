namespace Te05;

class Program
{
    delegate int evenSum(params int[] values); //익명 메소드를 만들기 위한 델리게이트
    static void Main(string[] args)
    {
        var sequence = new[] { 11,8,6,7,19,22,40,33,56};
        //짝수 원소의 합을 반환하는 익명 메소드를 람다식으로 구현하여 델리게이트로 대입 - 본인작성 
        evenSum even = (values) => { 
            int sum = 0;
            foreach (var value in values){
                if (value % 2 == 0)
                    sum += value;
            }
            return sum;
        };
        Console.Write($"sum even num is {even(sequence)} .\n");
    }
}