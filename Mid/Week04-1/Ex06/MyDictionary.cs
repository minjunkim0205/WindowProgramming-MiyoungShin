namespace Ex06;

public class MyDictionary
{
    private string[] keys;
    private int[] values;

    public MyDictionary(string[] keys)
    {
        this.keys = keys;
        this.values = new int[keys.Length];
        for (int i = 0; i < keys.Length; i++)
        {
            values[i] = 100 + i * 100;
        }
    }

    public void disPlay()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            Console.WriteLine($"{keys[i]} = pass:{values[i]}");
        }
    }

    public int this[int index]
    {
        get
        {
            return values[index];
        }
    }

    public int this[string key]
    {
        get
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] == key)
                {
                    return values[i];
                }
            }
            return -1;
        }
    }

    public int Size {
        get { return this.keys.Length; }
    }
}