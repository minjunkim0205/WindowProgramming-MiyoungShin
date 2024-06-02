namespace Te03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Number = 10;
            person.Name = "Minjun";
            Console.Write($"{person.Information}\n");
        }
    }
}
