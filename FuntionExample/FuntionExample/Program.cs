public class Program
{
    public static void Main()
    {
        int number = 10;
        SampleFunction();
        bool isEven = IsEven(number);
        DisplayMessage($"Is {number} even? {isEven}");
    }
    public static void SampleFunction()
    {
        Console.WriteLine("This is a sample function.");
    }
    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    protected static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}