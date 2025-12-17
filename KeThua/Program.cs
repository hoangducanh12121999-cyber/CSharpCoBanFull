public class Program
{
    public static void Main(string[] args)
    {
        Animal[] animals = new Animal[]
        {
            new Dog(),
            new Cat(),
            new Cow(),
            new Bird()
        };
        foreach (Animal animal in animals)
        {
            animal.Speak();
        }
    }
}