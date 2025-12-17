public abstract class Shape
{
    public abstract double Area();
}
public class Circle: Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}