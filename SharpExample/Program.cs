public class Program
{
    public static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Area of circle: {circle.Area()}");
        Console.WriteLine($"Area of rectangle: {rectangle.Area()}");
    }
}