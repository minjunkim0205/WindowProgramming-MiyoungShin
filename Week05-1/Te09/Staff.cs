namespace Te09;

public class Staff : Individual, IJob
{
    protected double pay;
    protected int num;

    public Staff()
    {
        name = "anonymous";
        age = 0;
        pay = 0;
        num = 0;
    }

    public Staff(string name, int age, int num) : base(name, age)
    {
        this.num = num;
        Job job = new Job();
        pay = job.getPay(num);
    }

    public double getPay(double hour)
    {
        return hour * 10000;
    }

    public override void infoPrint()
    {
        //base.infoPrint();
        Console.WriteLine($"Staff [name = {name}, age = {age}, pay = {pay}, num = {num}]");
    }

    public void printPay(double hour)
    {
        Console.WriteLine($"excluding staff {hour}hour amount is : {getPay(hour) - pay}");
    }
}