namespace Te09;

class Program
{
    static void Main(string[] args)
    {
        Individual[] per = new Individual[6]; 
        per[0] = new Individual(); 
        per[1] = new Individual("benny", 20); 
        per[2] = new Graduate(); 
        per[3] = new Graduate("graduate", 25, 2024, 3); 
        per[4] = new Staff(); 
        per[5] = new Staff("staff", 32, 8); 

        //객체 모든 정보 출력 – 본인 작성 
        Console.Write($"==============================================================================\n");
        foreach (var person in per)
        {
            person.infoPrint();
        }
        Console.Write($"==============================================================================\n");
        //per[5] 객체의 7시간 일한 페이 출력 – 본인 작성 
        if (per[5] is Staff)
        {
            Staff staff = (Staff)per[5];
            staff.printPay(7);
        }
        Console.Write($"==============================================================================\n");
    }
}