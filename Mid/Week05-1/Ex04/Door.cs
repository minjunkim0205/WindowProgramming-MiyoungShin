namespace Ex04;

public class Door : Operation
{
    // Operation 클래스를 상속 
    // 반환값과 매개변수가 없는 close() 메소드를 가지며 구현 내용은 main()과 제시된 결과 참조 
    // Field
    // Construct
    public Door(string name) : base(name)
    {
        Console.Write($"Door class constructor.\n");
    }
    // Method
    public void close()
    {
        Console.Write($"Close {name}.\n");
    }
    public override void open()
    {
        Console.Write($"Open {name}.\n");
    }
}