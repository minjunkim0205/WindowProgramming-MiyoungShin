namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> abbreviation = new Dictionary<string, string>();
        int select;
        do
        {
            Console.Write($"1.Add 2.Search 3.print 4.exit\n >> ");
            select = int.Parse(Console.ReadLine());
            switch(select){
                case 1:
                    string temp_key, temp_value;
                    Console.Write($"Abbreviation > ");
                    temp_key = Console.ReadLine();
                    Console.Write($"Meaning > ");
                    temp_value = Console.ReadLine();
                    abbreviation.Add(temp_key, temp_value);
                    break;
                case 2:
                    string temp;
                    Console.Write($"Abbreviation > ");
                    temp = Console.ReadLine();
                    if(abbreviation.ContainsKey(temp)){
                        Console.Write($"Meaning : {abbreviation[temp]}\n");
                    }else{
                        Console.Write($"{temp} not found...\n");
                    }
                    break;
                case 3:
                    foreach(var e in abbreviation){
                        Console.Write($"Abbreviation : {e.Key} = Meaning : {e.Value}\n");
                    }
                    break;
            }
        } while (select != 4);
    }
}