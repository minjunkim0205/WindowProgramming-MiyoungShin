namespace Te07;

public class UserArray<T>
{
    private T[] array;
    public int index{ get; set; }
    public UserArray(int size)
    {
        array = new T[size];
        index = 0;
    }
    public T this[int i]
    {
        get {
            return array[i];
        }
        set { 
            array[i] = value; // value 질문
            index = i;
        }
    }
    public void add(params T[] args)
    {
        foreach (var e in args)
        {
            if (index < array.Length)
            {
                array[index++] = e;
            }
        }
    }
    public void print()
    {
        for (int i = 0; i < index; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.Write($"\n");
    }
}