namespace As03;

class Program
{
    static void Main(string[] args)
    {
        int pos_x = 0;
        do{
            Console.Clear();
            Console.SetCursorPosition(pos_x, 0);
            switch(pos_x%3){
                case 0:
                    Console.Write($"___@\n");
                    break;
                case 1:
                    Console.Write($"__^@\n");
                    break;
                case 2:
                    Console.Write($"_^_@\n");
                    break;
            }
            pos_x++;
            Thread.Sleep(500);
        }while(pos_x <= 50);
    }
}