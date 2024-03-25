namespace Te05;

public class Member
{
    /*Static*/
    private static int count;
    /*Dynamic*/
    public string name { get; set; }
    public int age { get; set; }
    private int num;
    /*Constructor*/
    static Member()
    {
        count = 0;
    }
    public Member()
    {
        count++;
        this.name = "none";
        this.age = 0;
        this.num = count;
    }
    public Member(string name, int age)
    {
        count++;
        this.name = name;
        this.age = age;
        this.num = count;
    }
    /*Function*/
    public string InfoMember()
    {
        return $"Name: {this.name}, Age: {this.age}, Num: {this.num}, Count: {count}";
    }
}