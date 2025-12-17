public class Player: Imoveable, IAttack
{
    public void Attack()
    {
        Console.WriteLine("Player Attack");
    }
    public void Move()
    {
        Console.WriteLine("Player Move");
    }
}
interface Imoveable
{
    void Move();
}
interface IAttack
{
    void Attack();
}