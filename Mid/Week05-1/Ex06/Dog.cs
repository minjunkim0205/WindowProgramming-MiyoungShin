namespace Ex06;

public class Dog : Animal, Action
{
    // Construct
    public Dog(string name, int age) : base(name, age)
    {
        Console.Write($"Dog constructor\n");
    }
    // Method
    public void move()
    {
        Console.Write($"Dog moves by running.\n");
    }
    public void sound()
    {
        Console.Write($"Dog barks.\n");
    }
}