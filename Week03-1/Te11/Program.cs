namespace Te11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Enter sentence : ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        Array.Sort(words);
        Console.Write($"[ Repeating words ]\n");
        string prevWord = null;
        int count = 0;
        foreach (string word in words) {
            if (word == prevWord) {
                count++;
            }
            else {
                if (count > 1) {
                    Console.Write($"{prevWord}: {count}\n");
                }
                prevWord = word;
                count = 1;
            }
        }
        if (count > 1) {
            Console.Write($"{prevWord}: {count}\n");
        }
    }
}