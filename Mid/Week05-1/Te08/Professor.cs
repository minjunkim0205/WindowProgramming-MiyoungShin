namespace Te08;

public class Professor : Person
{
    private string employeeID;
    private string major;

    public Professor(string name, string id, string employeeID, string major) : base(name, id)
    {
        this.employeeID = employeeID;
        this.major = major;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Employee ID: {employeeID}");
        Console.WriteLine($"Major: {major}");
    }

}