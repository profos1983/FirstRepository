partial class Program
{
    public class User
    {

    }

    public class Account : User
    {

    }
    //Реализуйте данный интерфейс в классе UserService, и продемонстрируйте 
    //контравариацию интерфейса в базовом классе Program.
    public class UserService : IUpdater<User>
    {
        void IUpdater<User>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }
}
