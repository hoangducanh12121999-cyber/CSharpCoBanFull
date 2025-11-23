public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap gia tien USD:");
        double moneyUDS = Convert.ToDouble(Console.ReadLine());
        double moneyVND = moneyUDS * 23000;
        Console.WriteLine($"Gia tri tien te theo VND la: {moneyVND} VND");
    }
}