public class MyClass
{
    public static void Main(string[] args)
    {
        /*int[][] multiArray = new int[3][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        for (int i = 0; i < multiArray.Length; i++) 
        { 
            for (int j = 0; j < multiArray[i].Length; j++)
            {
                Console.WriteLine(multiArray[i][j] + " ");
            }
            Console.WriteLine();
        }*/

        /*
        int[,] multiArray =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 },
        };
        for (int i = 0; i < multiArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiArray.GetLength(1); j++)
            {
                Console.Write(multiArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        */

        int[,] matrix = new int[10, 10];
        Random rand = new Random();
        for (int i = 0;  i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(0, 100);
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}