public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap chieu dai HCN");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hay nhap chieu cao HCN");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = width * height;
        double rect = (width + height) * 2;
        Console.WriteLine($"Dien tich HCN la {area}");
        Console.WriteLine("Chu vi HCN la " + rect);
    }
}
