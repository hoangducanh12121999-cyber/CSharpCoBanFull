public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> hs = new Dictionary<int, string>()
        {
            { 1, "Anh" }, { 2, "An" }, { 3, "Bao" }, { 4, "Cong"}
        };
        foreach (KeyValuePair<int, string> hsValue in hs)
        {
            Console.WriteLine($"{hsValue.Key} {hsValue.Value}");
        }

        int id = Convert.ToInt32(Console.ReadLine());
        /*if (hs.Remove(id))
        {
            Console.WriteLine("Da xoa danh sach");
        }
        else
        {
            Console.WriteLine("Khong tim thay id");
        }*/
        if (hs.ContainsKey(id))
        {
            Console.WriteLine("Ten moi");
            string name = Console.ReadLine();
            hs[id] = name;
            Console.WriteLine("Cap nhat ten thanh cong");
        }
        else
        {
            Console.WriteLine("Khong co key trong hs");
        }
        
        foreach (int k in hs.Keys)
        {
            Console.WriteLine(k);
        }

        foreach (string item in hs.Values)
        {
            Console.WriteLine(item);
        }

    }
}