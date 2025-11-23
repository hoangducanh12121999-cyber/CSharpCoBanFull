public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so thu nhat");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu ba");
        int c = Convert.ToInt32(Console.ReadLine());
        int max = Math.Max(a, b);
        int maxS = Math.Max(c, max);
        Console.WriteLine("Gia tri lon nhat cua 3 so la " + maxS);
        int min = Math.Min(a, b);
        int minS = Math.Min(c, min);
        Console.WriteLine("Gia tri nho nhat cua 3 so la " + minS);
    }
}