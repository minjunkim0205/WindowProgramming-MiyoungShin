namespace Te09;

public class Graduate : Individual
{
    protected int enter;
    protected double pay;
    protected int num;

    public Graduate()
    {
        name = "anonymous";
        age = 0;
        enter = 0;
        pay = 0;
        num = 0;
    }

    public Graduate(string name, int age, int enter, int num) : base(name, age)
    {
        this.enter = enter;
        this.num = num;
        Job job = new Job();
        pay = job.getPay(num);
    }

    public override void infoPrint()
    {
        //base.infoPrint();
        Console.WriteLine($"Graduate [name = {name}, age = {age}, enter = {enter}, pay = {pay}, num = {num}]");
    }
}