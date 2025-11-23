public class Program    //nhap 2 so tu ban phim sau do tinh tong
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao so thu nhat");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap vao so thu hai");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a + b;
        Console.WriteLine($"Gia tri tong la {c}");
        byte d = (byte)c;
    }
}