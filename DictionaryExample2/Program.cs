public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, double> score = new Dictionary<int, double>()
        {
            { 1, 1.5 }, { 2, 2.5 }, { 3, 9.5 }
        };
        int maxKey = score.Keys.Min();
        Console.WriteLine(score[maxKey]);
    }
}