namespace As05;

class Program
{
    static void Main(string[] args) { 
        Console.Write($"[1:apple, 2:orange, 3:pear]\n"); 
        Console.Write($"Select >>> "); 
        int.TryParse(Console.ReadLine(), out int choice);
        string type = choice switch{
            1 => "apple",
            2 => "orange",
            3 => "pear"
        };
        Console.Write($"Eat {type}!\n");
    } 
}