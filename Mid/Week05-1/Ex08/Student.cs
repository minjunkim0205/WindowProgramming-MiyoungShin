namespace Ex08;

public class Student : Person
{
    private string studentID;
    private string department;

    public Student(string name, string id, string studentID, string department) : base(name, id)
    {
        this.studentID = studentID;
        this.department = department;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Student ID: {studentID}");
        Console.WriteLine($"Department: {department}");
    }
}