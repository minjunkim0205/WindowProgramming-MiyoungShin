namespace Te08;

class Program
{
    static void Main(string[] args)
    {
        PersonManage pm = new PersonManage();
        char c;
        do {
            Console.Write("1:Save, 2:Find, 3:Print, s:END >> ");
            c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '1':
                    Console.Write("Enter id >> ");
                    string id = Console.ReadLine();
                    pm.Save(id);
                    break;
                case '2':
                    Console.Write("Enter find id >> ");
                    string findId = Console.ReadLine();
                    int pass = pm.FindPass(findId);
                    if (pass != 0)
                    {
                        Console.WriteLine($"Password : {pass}");
                    }
                    else
                    {
                        Console.WriteLine("Id not found!!");
                    }
                    break;
                case '3':
                    pm.PrintAll();
                    break;
                case 's':
                    break;
            }
        } while (c != 's');
    }
}