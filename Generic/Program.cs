public class Program
{
    public static void Main(string[] args)
    {
        User user = new User {Id = 1};
        BaseRepo<User> userRepo = new BaseRepo<User>();
        userRepo.Printid(user);
    }
}
public interface IEntity
{
    int Id {get; set; }
}
public class User: IEntity
{
    public int Id {get; set; }
}
public class BaseRepo<T> where T: IEntity
{
    public void Printid(T entity)
    {
        System.Console.WriteLine(entity.Id);
    }
}