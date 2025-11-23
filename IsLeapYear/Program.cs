public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap mot nam bat ky:");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = true;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0) isLeapYear = true;
                else isLeapYear = false;
            }
            else isLeapYear = true;
        }
        else isLeapYear = false;

        if (isLeapYear)
        {
            Console.WriteLine($"{year} la nam nhuan");
        }
        else
        {
            Console.WriteLine($"{year} khong phai nam nhuan");
        }
    }
}