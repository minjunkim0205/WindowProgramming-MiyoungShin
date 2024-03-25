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
        string prev_word = null;
        int count = 0;
        foreach (string word in words) {
            if (word == prev_word) {
                count++;
            }
            else {
                if (count > 1) {
                    Console.Write($"{prev_word}: {count}\n");
                }
                prev_word = word;
                count = 1;
            }
        }
        if (count > 1) {
            Console.Write($"{prev_word}: {count}\n");
        }
    }
}