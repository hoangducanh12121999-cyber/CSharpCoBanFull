public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap mot so co toi da 3 chu so");
        int number = Convert.ToInt32(Console.ReadLine());
        int hangdonvi = number % 10;
        int hangchuc = (number / 10) % 10;
        int hangtram = number / 100;
        string tram = "";
        string chuc = "";
        string donvi ="";
        string read = "";

        switch (hangtram)
        {
            case 1:
                tram = "một trăm";
                break;
            case 2:
                tram = "hai trăm";
                break;
            case 3:
                tram = "ba trăm";
                break;
            case 4:
                tram = "bốn trăm";
                break;
            case 5:
                tram = "năm trăm";
                break;
            case 6:
                tram = "sáu trăm";
                break;
            case 7:
                tram = "bảy trăm";
                break;
            case 8:
                tram = "tám trăm";
                break;
            case 9:
                tram = "chín trăm";
                break;
        }

        if (hangtram != 0 && hangchuc == 0 && hangdonvi != 0)
        {
            chuc = "linh";
        }
        else
        {
            switch (hangchuc)
            {
                case 1:
                    chuc = "mười";
                    break;
                case 2:
                    chuc = "hai mươi";
                    break;
                case 3:
                    chuc = "ba mươi";
                    break;
                case 4:
                    chuc = "bốn mươi";
                    break;
                case 5:
                    chuc = "năm mươi";
                    break;
                case 6:
                    chuc = "sáu mươi";
                    break;
                case 7:
                    chuc = "bảy mươi";
                    break;
                case 8:
                    chuc = "tám mươi";
                    break;
                case 9:
                    chuc = "chín mươi";
                    break;
            }
        }

        switch (hangdonvi)
        {
            case 1:
                if (hangchuc > 1)
                {
                    donvi = "mốt";
                }
                else
                {
                    donvi = "một";
                }
                break;
            case 2:
                donvi = "hai";
                break;
            case 3:
                donvi = "ba";
                break;
            case 4:
                donvi = "bốn";
                break;
            case 5:
                if (hangchuc > 0) 
                {
                    donvi = "lăm";
                }
                else 
                {
                    donvi = "năm";
                }
                break;
            case 6:
                donvi = "sáu";
                break;
            case 7:
                donvi = "bảy";
                break;
            case 8:
                donvi = "tám";
                break;
            case 9:
                donvi = "chín";
                break;
        }

        if (number == 0) read = "Không";
        if (hangtram != 0)
        {
            read = tram + " " + chuc + " " + donvi;
        }
        else if (hangtram == 0)
        {
            if (hangchuc > 0)
            read = chuc + " " + donvi;
            else 
            read = donvi;
        }
        Console.WriteLine("Cach doc: " + read);

    }
}