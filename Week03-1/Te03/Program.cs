namespace Te03;

class Program
{
    static void Main(string[] args)
    {
        var int_data = Console.ReadLine();
        var float_data = Console.ReadLine();

        if (int.TryParse(int_data, out int _int_data)) {
            Console.Write($"Int : {_int_data}\n");
        } else {
            Console.Write($"Err\n");
        }

        if (float.TryParse(float_data, out float _float_data)) {
            Console.Write($"Float : {_float_data}\n");
        } else {
            Console.Write($"Err\n");
        }
    }
}