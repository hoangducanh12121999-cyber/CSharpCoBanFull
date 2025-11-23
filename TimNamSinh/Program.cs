public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap vao nam sinh cua ban:");
        int namSinh = Convert.ToInt32(Console.ReadLine());
        int namHienTai = DateTime.Now.Year;
        int tuoi = namHienTai - namSinh;
        Console.WriteLine("Tuoi cua ban la " + tuoi);
    }
}