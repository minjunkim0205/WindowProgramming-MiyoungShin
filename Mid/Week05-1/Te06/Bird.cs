namespace Te06;

public class Bird : Animal, Action
{
    // Construct
    public Bird(string name, int age) : base(name, age)
    {
        Console.Write($"Bird constructor\n");
    }
    // Method
    public void move()
    {
        Console.Write($"Bird moves by flying.\n");
    }
    public void sound()
    {
        Console.Write($"Bird chirps.\n");
    }
}