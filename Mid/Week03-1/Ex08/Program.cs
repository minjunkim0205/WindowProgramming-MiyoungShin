namespace Ex08;

class Program
{
    private enum Coffee
    {
        Americano = 1,
        Cappuccino = 2,
        Mocha = 3,
        Latte = 4
    }

    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write($"I would like to recommend a menu\nEnter the number of people >>");
        int number_of_people = int.Parse(Console.ReadLine());

        for (int i = 0; i < number_of_people; i++)
        {
            int n = random.Next(1, 5);
            Coffee coffee = n switch
            {
                1 => Coffee.Americano,
                2 => Coffee.Cappuccino,
                3 => Coffee.Mocha,
                4 => Coffee.Latte
            };
            Console.Write($"Gen number : {n} => Menu : {coffee}\n");
        }
    }
}