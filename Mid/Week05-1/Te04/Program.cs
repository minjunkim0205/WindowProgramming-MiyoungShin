namespace Te04;

class Program
{
    static void Main(string[] args)
    {
        Operation[] operaitons = { new Bottle("Beer bottle"),
                                    new Door("Glass door"),
                                    new Bottle("Carbonated water bottle"),
                                    new Door("Entrance door") };
        Door? door;
        Bottle? bottle;
        foreach (var operaiton in operaitons)
        {
            door = operaiton as Door; // is 타입 변화 가능성만 판단, as 는 타입 변화 가능성 그리고 가능하다면 변환해줌.
            bottle = operaiton as Bottle;
            operaiton.open();
            door?.close();
            bottle?.clear();
        }
    }
}