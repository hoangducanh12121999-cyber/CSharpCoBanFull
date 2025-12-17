public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        myDictionary.Add ("one", 1);
        myDictionary.Add ("two", 2);
        myDictionary.Add ("three", 3);

        Console.WriteLine(myDictionary["one"]);
        Console.WriteLine(myDictionary["two"]);

        bool isKey = myDictionary.ContainsKey ("one");
        Console.WriteLine (isKey);

        bool isKey2 = myDictionary.ContainsKey ("four");
        Console.WriteLine (isKey2);

        bool isValue = myDictionary.ContainsValue (1);
        Console.WriteLine (isValue);

        bool isValue2 = myDictionary.ContainsValue (4);
        Console.WriteLine (isValue2);

        if (myDictionary.ContainsKey("one"))
        {
            int value = myDictionary["one"];
            Console.WriteLine (value);
        }
        if (myDictionary.ContainsValue(2))
        {
            int value = myDictionary["two"];
            Console.WriteLine (value);
        }

        myDictionary.Remove ("three");

        foreach (KeyValuePair<string, int> mykeyvalue in myDictionary)
        {
            Console.WriteLine (mykeyvalue.Key + " " + mykeyvalue.Value);
        }
        // cach khac
         foreach (var mykeyvalue in myDictionary)
        {
            Console.WriteLine (mykeyvalue.Key + " " + mykeyvalue.Value);
        }

    }
}