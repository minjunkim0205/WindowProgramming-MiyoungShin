namespace Te04;

class Member
{
    //Field
    public string name{get;set;}
    public string id{get;set;}
    public int join_year{get;set;}
    public int join_month{get;set;}
    //Construct
    public Member(string _name, string _id)
    /*
    public Member(string _name, string _id, int _join_year = System.DateTime.Now.Year, int _join_month = System.DateTime.Now.Month)
    Q : 다음과 같은 디폴트 파라미터가 불가능한 이유를 설명해 주세요.
    */
    {
        this.name = _name;
        this.id = _id;
        this.join_year = System.DateTime.Now.Year;
        this.join_month = System.DateTime.Now.Month;
    }
    //Method
    public override string ToString()
    {
        return $"Customer [name={this.name}, id={this.id}, year={this.join_year}, month={this.join_month}]";
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Member> member_list = new List<Member>();
        int select;
        do{
            Console.Write($"1:SignUp 2:Withdrawal 3:Exit >> ");
            select = int.Parse(Console.ReadLine());
            string temp_name, temp_id;
            switch(select){
                case 1:
                    Console.Write($"Enter name >> ");
                    temp_name = Console.ReadLine();
                    Console.Write($"Enter id >> ");
                    temp_id = Console.ReadLine();
                    member_list.Add(new Member(temp_name, temp_id));
                    break;
                case 2:
                    Console.Write($"Enter id >> ");
                    temp_id = Console.ReadLine();
                    Member? trg = member_list.Find(element => element.id == temp_id);
                    if(trg != null){
                        member_list.Remove(trg);
                    }else{
                        Console.Write($"Id not found...\n");
                    }
                    break;
                case 3:
                    foreach(var e in member_list){
                        Console.Write($"{e.ToString()}\n");
                    }
                    break;
            }
        }while(select != 3);
    }
}