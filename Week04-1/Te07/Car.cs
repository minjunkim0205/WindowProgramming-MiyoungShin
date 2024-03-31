namespace Te07;

class Car
{
    private string[] car_id;
    private string[] owners;
    private string[] number;
    // 생성자에서 배열을 초기화
    public Car(int size)
    {
        car_id = new string[size];
        owners = new string[size];
        number = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Owner : ");
            owners[i] = Console.ReadLine();

            Console.Write("Id : ");
            car_id[i] = Console.ReadLine();

            Console.Write("Number : ");
            number[i] = Console.ReadLine();
            Console.WriteLine();
        }
    }
    // 문자열 인덱스를 매개변수로 받아 처리하는 인덱서 구현
    public string this[int index]
    {
        get
        {
            return ($"Id : {car_id[index]} = owner : {owners[index]}, number : {number[index]}");
        }
    }
    public string this[String id]
    {
        get
        {
            for (int i = 0; i < car_id.Length; i++)
            {
                if (car_id[i] == id)
                {
                    return ($"owner : {owners[i]}, number : {number[i]}");
                }
            }
            return "Can't find Car id";
        }
    }
    // 배열 크기를 반환하는 속성
    public int Size
    {
        get { return car_id.Length; }
    }
}