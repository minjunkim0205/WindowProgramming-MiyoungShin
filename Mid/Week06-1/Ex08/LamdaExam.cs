namespace Ex08;

public class LamdaExam
{
    public bool IsEven(int n)
    {
        return n % 2 == 0;
    }
    public int Count(int[] num, judgement judge) { // (1)
        int count = 0;
        foreach (var n in num) {
            if (judge(n) == true) {
                count++;
            }
        }
        return count;
        
    }
    public void Do() {
        var array = new int[] { 5, 2, 6, 3, 12, 8, 0, 1, 10, 4 };
        var cnt = Count(array, IsEven);
        Console.WriteLine($"cnt = {cnt}");
    }
}