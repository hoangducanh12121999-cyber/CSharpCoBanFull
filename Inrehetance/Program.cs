public class Program
{
    public static void Main(string[] args)
    {
        A obj1 = new C();
        obj1.Show();

        B obj2 = new B();
        obj2.Show();
    }
}
public class A
{
    public virtual void Show()
    {
        System.Console.WriteLine("Class A Show Method");
    }
}
public class B: A
{
    public override void Show()
    {
        System.Console.WriteLine("Class B Show Method");
    }
}
public class C: B
{
    public new void Show()
    {
        System.Console.WriteLine("Class C Show Method");
    }
}