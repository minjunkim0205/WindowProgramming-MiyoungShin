namespace Te01;

class Program
{
    static void str_print(List<string> list)
    {
        Console.WriteLine("-------------------------------------------------------------");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void menu(out int choice)
    {
        Console.WriteLine("1.추가하기\t2.포함여부\t3.검색\t4.삭제\t5.종료 >> ");
        int.TryParse(Console.ReadLine(), out choice);
    }

    static void str_insert(List<string> list)
    {
        Console.Write("삽입할 문자열을 입력하세요 >> ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            list.Add(input);
        }
    }

    static void str_contains(List<string> list)
    {
        Console.Write("확인할 문자열을 입력하세요 >> ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            if (list.Contains(input))
            {
                Console.WriteLine($"{input}은(는) 리스트에 포함되어 있습니다.");
            }
            else
            {
                Console.WriteLine($"{input}은(는) 리스트에 포함되어 있지 않습니다.");
            }
        }
    }

    static void str_find(List<string> list)
    {
        Console.Write("찾을 문자열을 입력하세요 >> ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            List<string> result = list.FindAll(item => item.Contains(input));
            if (result.Count > 0)
            {
                Console.WriteLine($"\"{input}\"을(를) 포함하는 원소들:");
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"\"{input}\"을(를) 포함하는 원소가 없습니다.");
            }
        }
    }

    static void str_remove(List<string> list)
    {
        Console.Write("삭제할 문자열을 입력하세요 >> ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            bool removed = list.Remove(input);
            if (removed)
            {
                Console.WriteLine($"{input}을(를) 삭제하였습니다.");
            }
            else
            {
                Console.WriteLine($"{input}은(는) 리스트에 존재하지 않습니다.");
            }
        }
    }
    static void Main(string[] args)
    {
        List<string> list = new List<string> { "apple", "instrument", "account", "promise", "address", "morning" }; 
        str_print(list); 
        Console.WriteLine("--------- 선택한 메뉴에 따라 리스트에 저장된 원소 다루기 ------------"); 
        while (true) { 
            menu(out int choice);
            if (choice == 5){ 
                break;
            }
            switch (choice) {
                case 1:
                    str_insert(list);
                    str_print(list);
                    break;
                case 2:
                    str_contains(list);
                    break;
                case 3:
                    str_find(list);
                    break;
                case 4:
                    str_remove(list);
                    str_print(list);
                    break;
            }
        }
    }
}