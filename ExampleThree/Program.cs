public class Program
{
    public static void Main(string[] args)
    {
        Player player= new Player();
        player.Attack();
        player.Move();
        Player playerAsMoveable = player;
        playerAsMoveable.Move();
    }
}