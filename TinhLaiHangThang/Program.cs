public class Program
{
    public static void Main(string[] args)
    {
        double money;
        int month;
        double interset_rate;
        Console.WriteLine("Yeu cau nhap so tien");
        money = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yeu cau nhap so thang");
        month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yeu cau nhap so lai");
        interset_rate = Convert.ToDouble(Console.ReadLine());
        double total_interset = 0;
        for (int i = 0; i <= month; i++)
        {
            total_interset = money * (interset_rate / 100) / 12 * 3;
        }   
        Console.WriteLine("Gia tri tong la " + total_interset);
    }
}