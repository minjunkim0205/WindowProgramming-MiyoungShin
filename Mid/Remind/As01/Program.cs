namespace As01;

class Program
{
    enum Block{
        none = 2,
        dirt,
        stone,
        wood,
        glass
    }
    static void Main(string[] args){
        Block hand = Block.none;
        while(true){
            Console.Write($"Cur item : {hand}\n");
            Console.Write($"[Item bar ( 0:exit, 1:left, 2:right)] >> ");
            int select = int.Parse(Console.ReadLine());
            if(select == 0){
                break;
            }else if(select == 1){
                hand = hand - 1;
            }else if(select == 2){
                hand = hand + 1;
            }
        }
    }
}