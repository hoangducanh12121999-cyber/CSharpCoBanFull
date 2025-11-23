public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap gia tien USD:");
        double moneyUDS = Convert.ToDouble(Console.ReadLine());
        double rate = 23000;
        double moneyVND = moneyUDS * rate;
        Console.WriteLine($"Gia tri tien te theo VND la: {moneyVND} VND");
    }
}