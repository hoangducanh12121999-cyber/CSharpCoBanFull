public class Program
{
    public static void Main(string[] args)
    {
        
    }
}
public abstract class DataParser
{
    public void ProcessData(string data)
    {
        
    }
    protected abstract void ParseData(string data);
    protected abstract void SaveData(string data);
}