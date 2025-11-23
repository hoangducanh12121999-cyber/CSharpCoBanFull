public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        
        int result = (int)GcdResult(a, b);
        Console.WriteLine($"Uoc so chung lon nhat cua {a} {b} la: {result}");
    }
    static long GcdResult (long a, long b)
    {
        a = Math.Abs (a);
        b = Math.Abs (b);
        if (b == 0) return a;
        return GcdResult(b, a % b);
    }
}