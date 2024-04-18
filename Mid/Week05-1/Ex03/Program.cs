namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        int x = 10, y = 10;
        IRectangle r = new Shape();
        ITriangle t = new Shape();
        r.Draw(x, y);
        r.Volume(x, y, 5);
        t.Draw(x, y);
        t.Area(x, y);
    }
}