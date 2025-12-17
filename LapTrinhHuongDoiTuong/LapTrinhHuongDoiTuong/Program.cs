public class Program
{
    public static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        myClass.MyMethod();
        MyClass yourClass = new MyClass();
        yourClass.MyMethod();
    }

    class MyClass
    {
        int x;
        int y;
        public void Ads(int a, int b)
        {
            this.x = a;
            this.y = b;
            Console.WriteLine(a + b);
        }
        public void MyMethod()
        {
            Console.WriteLine("This is my method");
        }
    }
}