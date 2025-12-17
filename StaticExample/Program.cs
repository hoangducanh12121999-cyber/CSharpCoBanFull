public class Program
{
    public static void Main(string[] args)
    {
        Student.Change();
        Student s1 = new Student(111, "Karan");
        Student s2 = new Student(222, "Aryan");
        Student s3 = new Student(333, "Jame");
        s1.Display();
        s2.Display();
        s3.Display();
    }
}
