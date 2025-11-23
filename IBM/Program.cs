public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap can nang:");
        double canNang = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap chieu cao:");
        double chieuCao = Convert.ToDouble(Console.ReadLine());
        double bmi = canNang / (chieuCao * chieuCao);
        Console.WriteLine("Chi so BMI ");
        if (bmi < 18.5) Console.WriteLine("Ban gay");
        else if (bmi < 24.9) Console.WriteLine("Ban binh thuong");
        else if (bmi < 29.9) Console.WriteLine("Ban bi thua can");
        else Console.WriteLine("Ban beo lam roi");
    }
}