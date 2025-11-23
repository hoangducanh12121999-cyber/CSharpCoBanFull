public class Program
{
    public static void Main (string[] args)
    {

        Console.WriteLine("Nhap so dong");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so cot");
        int n = int.Parse(Console.ReadLine());
        // khai bao mang 2 chieu
        int[,] array = new int[m, n];
        // nhap gia tri cho mang
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"Nhap gia tri cho phan tu o dong {i} cot {j}");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //xuat mang
        Console.WriteLine("Mang 2 chieu vua nhap la: ");
        for (int i = 0;i < m; i++)
        {
            for (int j = 0;j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }


    }


}