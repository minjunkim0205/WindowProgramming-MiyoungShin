namespace Ex08;

public class Person
{
    protected string name;
    protected string id;

    public Person(string name, string id)
    {
        this.name = name;
        this.id = id;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {id}");
    }
}