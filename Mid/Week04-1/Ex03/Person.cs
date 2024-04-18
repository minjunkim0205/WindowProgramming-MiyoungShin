namespace Ex03;

public class Person
{
    public int Number { get; set; }  
    public string Name { get; set; }
    public string Information => $"name = {Name}  number = {Number} ";
}