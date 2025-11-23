public class Program
{
    public static void Main(string[] args)
    {
        int i = 1;
        int sum = 0;
        while (i <= 1000)
        {
            sum += i;
            i++;
        }
        Console.WriteLine(sum);
    }
}
