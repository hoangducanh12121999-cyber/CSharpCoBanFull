public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot so tu ban phim");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Mang vua nhap la: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + " ");
        }
    }
}