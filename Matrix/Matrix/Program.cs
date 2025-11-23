public class Program
{
    static void Main (string[] args)
    {
         Console.WriteLine("Nhap so hang ma tran");
         int r = int.Parse(Console.ReadLine());

         Console.WriteLine("Nhap so cot ma tran");
         int c = int.Parse(Console.ReadLine());

         int[,] a = new int[r, c];

        for (int i = 0; i < r; i++)
         {
             for (int j = 0; j < c; j++)
             {
                 a[i, j] = int.Parse(Console.ReadLine());
             }
         }

         Console.WriteLine("Hien thi");
         for (int i = 0; i < r; i++)
         {
             for (int j = 0; j < c; j++)
             {
                 Console.Write(a[i, j] + "\t");
             }
             Console.WriteLine();
         }

         int sum = 0;
         for (int i = 0;i < r; i++)
         {
             for (int j = 0;j < c; j++)
             {
                 sum += a[i, j];
             }
         }
        Console.WriteLine(sum);
    }
}