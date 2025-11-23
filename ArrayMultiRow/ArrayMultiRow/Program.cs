public class MyClass            //Nhap 1 mang sau do tinh tong hang
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Hay nhap 1 mang 2 chieu: ");
        Console.WriteLine("Nhap so hang: ");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so cot: ");
        int c = int.Parse(Console.ReadLine());

        int[,] a = new int[r, c];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Tinh tong cac hang");
        for (int i = 0;i < r; i++)
        {
            int sumRow = 0;
            for (int j = 0;j < c; j++)
            {
                sumRow += a[i, j];
            }
            Console.WriteLine($"Tong hang {i} la: {sumRow}");
        }

        //Dem so chan
        Console.WriteLine("Dem so chan co trong mang");
        int countevent = 0;
        for(int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (a[i, j] % 2 == 0) countevent++;
            }
        }
        Console.WriteLine("So chan co trong mang la: " + countevent);
    }
}