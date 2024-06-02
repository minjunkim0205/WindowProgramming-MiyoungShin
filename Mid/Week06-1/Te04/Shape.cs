namespace Te04;

public class Shape
{
    public void Area(int x, int y) {
        Console.Write($"Triangle Area => {x * y / 2}\n");
    } 
    public void Volume(int x, int y, int height) {
        Console.Write($"Rectangle => Width :{x}, Depth : {y} Height : {height} => Volume{x * y * height}\n");
    } 
}