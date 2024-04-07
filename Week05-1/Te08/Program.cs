namespace Te08;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of objects to create: ");
        int numObjects = int.Parse(Console.ReadLine());
        Person[] people = new Person[numObjects];
        for (int i = 0; i < numObjects; i++)
        {
            Console.Write("Enter 1 for student, 2 for professor: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            if (choice == 1)
            {
                Console.Write("Enter student ID: ");
                string studentID = Console.ReadLine();
                Console.Write("Enter department: ");
                string department = Console.ReadLine();
                people[i] = new Student(name, id, studentID, department);
            }
            else if (choice == 2)
            {
                Console.Write("Enter employee ID: ");
                string employeeID = Console.ReadLine();
                Console.Write("Enter major: ");
                string major = Console.ReadLine();
                people[i] = new Professor(name, id, employeeID, major);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        Console.WriteLine("========================================");
        foreach (var person in people)
        {
            person.Display();
            Console.WriteLine("========================================");
        }
    }
}