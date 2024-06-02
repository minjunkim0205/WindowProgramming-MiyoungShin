namespace Te02;

class Program
{
    static void Main(string[] args)
    {
        // 1)번 
        //두 자리 난수(정수)를 key로, Info 객체를 value로 하는 딕셔너리 객체 map 선언 및 생성 - 본인작성 
        Dictionary<int, Info> map = new Dictionary<int, Info>();
        //2번) 
        //공용 읽기/쓰기 인덱서를 사용하여 딕셔너리 초기화, 키와 id는 난수 사용 
        //5개의 원소를 딕셔너리에 저장한다 – 본인 작성 
        Random random = new Random();
        List<string> name_list = new List<string>() { "p", "d", "t", "g", "p" };
        foreach (string e in name_list)
        {
            int key;
            do
            {
                key = random.Next(10, 100);
            } while (map.ContainsKey(key));
            map[key] = new Info(key.ToString(), e);
        }
        //3번) 
        //딕셔너리에 저장된 원소 개수 출력 – 본인 작성 
        Console.Write($"Number of dictionary elements -> {map.Count}\n");
        //4번) 
        //foreach를 사용하여 딕셔너리에 저장된 모든 원소 출력 – 본인 작성 
        foreach (var e in map)
        {
            Console.Write($"Key -> {e.Key}, Value -> {e.Value.infoString}\n");
        }
        Console.Write($"\n");
        //5번) 
        //Add()를 사용하여 딕셔너리에 원소 추가, 키와 id는 난수 사용 
        //5개의 원소를 딕셔너리에 저장한다 – 본인 작성 
        for (int i = 0; i < 5; i++)
        {
            int key;
            do
            {
                key = random.Next(10, 100);
            } while (map.ContainsKey(key));
            Console.Write($"Enter key : {key} name >> ");
            map.Add(key, new Info(key.ToString(), Console.ReadLine()));
        }
        Console.Write($"\n");
        //6번) 
        //딕셔너리에 저장된 원소 개수 출력 - 본인작성 
        Console.Write($"Number of dictionary elements -> {map.Count}\n");
        //7번) 
        //foreach를 사용하여 딕셔너리에 저장된 모든 원소 출력 - 본인작성 
        foreach (var e in map)
        {
            Console.Write($"Key -> {e.Key}, Value -> {e.Value.infoString}\n");
        }
        Console.Write($"\n");
        //8번)
        //map에 저장된 Info 객체에서 중복되는 이름을 제거한 결과 출력 – 본인작성 
        Dictionary<int, Info> temp_map = map;
        map = new Dictionary<int, Info>();
        foreach (var e_t in temp_map)
        {
            bool flag = false;
            foreach (var e in map)
            {
                if (e_t.Value.Name == e.Value.Name)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                map.Add(e_t.Key, e_t.Value);
            }
        }
        foreach (var e in map)
        {
            Console.Write($"{e.Value.Name}\n");
        }
    }
}