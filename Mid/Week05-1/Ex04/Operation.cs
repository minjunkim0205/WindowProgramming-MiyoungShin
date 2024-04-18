namespace Ex04;

public abstract class Operation
{
    //문자열 타입을 갖는 한 개의 필드를 가지며 생성자에서 초기화한다 
    //반환값과 매개변수가 없는 open() 메소드. 단, 몸체를 갖지 않는다 
    // Field
    protected string name;
    // Construct
    public Operation(string name)
    {
        this.name = name;
    }
    // Method
    public abstract void open();
}