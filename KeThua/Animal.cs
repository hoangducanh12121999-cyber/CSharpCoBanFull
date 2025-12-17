public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog goes go.");
    }
}
public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat goes meow.");
    }
}
public class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cow goes moo.");
    }
}
public class Bird : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The bird goes chirp.");
    }
}