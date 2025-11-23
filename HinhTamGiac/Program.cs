using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu cao hinh tam giac");
        int h = Convert.ToInt32(Console.ReadLine());
        /*for (int i = 0; i < h; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }*/
        int i = 1;
        while (i < h)
        {
             int j = 1;
            while (j <= i)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            i++;
        }
    }
}