public class Student
{
    private int rollno;
    private string name;
    private static string college = "ITS";
    public Student(int r, string n)
    {
        rollno = r;
        name = n;
    }
    public static void Change()
    {
        college = "CODEGYM";
    }
    public void Display()
    {
        System.Console.WriteLine(rollno + " " + name + " " + college);
    }
}