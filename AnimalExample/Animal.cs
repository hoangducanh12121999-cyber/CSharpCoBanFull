public abstract class Animal
{
    protected string Weight{ get; set; }
    protected string Height{ get; set; }
    public Animal(string weight, string height)
    {
        Weight = weight;
        Height = height;
    }
    public abstract void PrintInfor();
}
public class Cat: Animal
{
    private string Name{ get; set; }
    public Cat(string name, string weight, string height):base(weight, height)
    {
        Name = name;
    }
    public override void PrintInfor()
    {
        System.Console.WriteLine($"Cat name: {Name}, Weight: {Weight}, Height: {Height}");
    }
}