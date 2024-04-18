namespace Ex05;

public class Bottle : Operation
{
    // Operation 클래스를 상속
    // 반환값과 매개변수가 없는 clear() 메소드를 가지며 구현 내용은 main()과 제시된 결과 참조
    // Field
    // Construct
    public Bottle(string name) : base(name)
    {
        Console.Write($"Bottle class constructor.\n");
    }
    // Method
    public void clear()
    {
        Console.Write($"Clear {name}.\n");
    }
    public new void open()
    {
        Console.Write($"Open {name}.\n");
    }
}