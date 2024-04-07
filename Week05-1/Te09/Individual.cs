namespace Te09;

public class Individual
{
    protected string name;
    protected int age;

    public Individual()
    {
        name = "anonymous";
        age = 0;
    }

    public Individual(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void infoPrint()
    {
        Console.WriteLine($"name = {name}, age = {age}");
    }
}