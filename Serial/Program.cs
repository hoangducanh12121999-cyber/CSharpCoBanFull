public class Program
{
    private string path = "numbers.txt";
    public static void Main(string[] args)
    {
        Program example = new Program();
        example.ReadTextFile(path);
    }
    void ReadTextFile(string filePath)
    {
        try
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException("The specified file was not found.", filePath);
            }
            StreamReader reader = new StreamReader(filePath);
            string line = "";
            int sum = 0;
            while ((line = reader.ReadLine()) != null)
            {
                sum += int.Parse(line);
            }
            reader.Close();
            Console.WriteLine($"The sum of the numbers in the file is: {sum}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format error: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            
        }
    }
}