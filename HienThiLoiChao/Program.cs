public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string yourName = Convert.ToString(Console.ReadLine());
        Console.WriteLine($"Hello {yourName}");
    }
}