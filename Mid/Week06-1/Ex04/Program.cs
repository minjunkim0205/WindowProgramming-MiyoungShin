namespace Ex04;

class Program
{
    public delegate void DelegateArea(int x, int y);
    public delegate void DelegateVolume(int x, int y, int height);
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        DelegateArea da = new DelegateArea(shape.Area);
        DelegateVolume dv = new DelegateVolume(shape.Volume);
        da(3, 5);
        dv(3, 5, 7);
    }
}