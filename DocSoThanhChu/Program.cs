public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap mot so co toi da 3 chu so");
        int number = Convert.ToInt32(Console.ReadLine());
        string donvi;
        string chuc;
        string tram;
        if (number >= 0 && number < 100)
        {
            int i = number / 10;
            int j = number % 10;
            if (i == 0)
            {
                switch (j)
                {
                    case 0:
                        donvi = "Khong";
                        Console.WriteLine(donvi);
                        break;
                    case 1:
                        donvi = "Mot";
                        Console.WriteLine(donvi);
                        break;
                    case 2:
                        donvi = "Hai";
                        Console.WriteLine(donvi);
                        break;
                    case 3:
                        donvi = "Ba";
                        Console.WriteLine(donvi);
                        break;
                    case 4:
                        donvi = "Bon";
                        Console.WriteLine(donvi);
                        break;
                    case 5:
                        donvi = "Nam";
                        Console.WriteLine(donvi);
                        break;
                    case 6:
                        donvi = "Sau";
                        Console.WriteLine(donvi);
                        break;
                    case 7:
                        donvi = "Bay";
                        Console.WriteLine(donvi);
                        break;
                    case 8:
                        donvi = "Tam";
                        Console.WriteLine(donvi);
                        break;
                    case 9:
                        donvi = "Chin";
                        Console.WriteLine(donvi);
                        break;
                }
            }
            else if (1 <= i && i <= 9)
            {
                if (j == 0)
                {
                    switch (i)
                    {
                        case 1:
                        chuc = "Muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 2:
                        chuc = "Hai muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 3:
                        chuc = "Ba muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 4:
                        chuc = "Bon muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 5:
                        chuc = "Nam muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 6:
                        chuc = "Sau muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 7:
                        chuc = "Bay muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 8:
                        chuc = "Tam muoi";
                        Console.WriteLine(chuc);
                        break;
                        case 9:
                        chuc = "Chin muoi";
                        Console.WriteLine(chuc);
                        break;
                        default:
                        break;
                    }
                }

                else
                {
                    switch (j)
                    {
                        case 1:
                        Console.WriteLine($"{chuc} {donvi}");
                        break;
                    }
                }
            }

        }
        
    }
}