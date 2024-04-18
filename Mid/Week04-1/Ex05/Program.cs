namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        Member member1 = new Member();
        Member member2 = new Member("hallym", 40);
        Console.Write($"{member1.InfoMember()}\n");
        Console.Write($"{member2.InfoMember()}\n");
        
        Console.Write($"member2 name is {member2.name}.\n");
        Console.Write($"member2 enter change age >> ");
        member2.age = int.Parse(Console.ReadLine());
        Console.Write($"{member2.InfoMember()}\n");
    }
}