public interface IAttackable
{
    void Attack();
    int damage {get;}
}
public interface Imoveable
{
    void Move();
    int speed {get;}
}
public interface IHealable
{
    void Heal();
    int health {get;}
}
public interface IDefendable
{
    void Defend();
    int armor {get;}
}
public class Warrior : IAttackable, Imoveable
{
    public int damage => 25;

    public void Attack() => System.Console.WriteLine("Warrior attacked with damage: " + damage + "damage");
    public int speed => 10;
    public void Move() => System.Console.WriteLine("Warrior moved with speed: " + speed);
}
class Mage : IAttackable, IHealable
{
    public int damage => 15;

    public void Attack() => System.Console.WriteLine("Mage attacked with damage: " + damage + "damage");
    public int health => 30;
    public void Heal() => System.Console.WriteLine("Mage healed with health: " + health);
}
class Archer : IAttackable, IDefendable
{
    public int damage => 20;

    public void Attack() => System.Console.WriteLine("Archer attacked with damage: " + damage + "damage");
    public int armor => 5;
    public void Defend() => System.Console.WriteLine("Archer defended with armor: " + armor);
}