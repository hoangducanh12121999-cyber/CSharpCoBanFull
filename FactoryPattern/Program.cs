using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}
class Vector2
{
    float x, y;
    public Vector2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public static Vector2 operator + (Vector2 a, Vector2 b)
    {
        return new Vector2(a.x + b.x, a.y + b.y);
    }
}