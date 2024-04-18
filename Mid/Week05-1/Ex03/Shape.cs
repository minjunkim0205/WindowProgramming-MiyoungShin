namespace Ex03;

public class Shape : IRectangle, ITriangle
{
    void IRectangle.Draw(int x, int y)
    {
        Console.Write($"Draw Rectangle {x}, {y}\n");
    }
    void IRectangle.Volume(int g, int s, int height)
    {
        Console.Write($"Rectangle Volume: {g * s * height}\n");
    }
 
    void ITriangle.Draw(int x, int y)
    {
        Console.Write($"Draw Triangle {x}, {y}\n");
    }
    void ITriangle.Area(int x, int y)
    {
        Console.Write($"Triangle Area : {x * y / 2}\n");
    }
}
