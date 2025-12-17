public class Program
{
      enum Season
    {
        Spring,
        Summer,
        Autum,
        Winter
    }
    public static void Main(string[] args)
    {
    Season season = Season.Summer;
        switch (season)
        {
            case Season.Spring: Console.WriteLine("Mua xuan");
                break;
            case Season.Summer: Console.WriteLine("Mua ha");
                break;
            case Season.Autum: Console.WriteLine("Mua thu");
                break;
            case Season.Winter: Console.WriteLine("Mua dong");
                break;
        }
    }
}