public class Program
{
    public static void Main(string[] args)
    {
        Animal myCat = new Cat("Whiskers", "10 lbs", "12 inches");
        myCat.PrintInfor();
        Cat anotherCat = new Cat("Mittens", "8 lbs", "10 inches");
        anotherCat.PrintInfor();
    }
}