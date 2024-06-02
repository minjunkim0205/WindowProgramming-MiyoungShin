namespace Te06;

class Program
{
    static void action(Action animal)
    {
        animal.move();
        animal.sound();
    }
    static void Main(string[] args)
    {
        Action dog = new Dog("dog", 3);
        Action bird = new Bird("bird", 3);
        action(dog); //action()는 본인 작성 
        action(bird);
    }
}