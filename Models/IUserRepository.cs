namespace PersonManagement.Models
{
    public interface IUserRepository
    {
        Pm03User Login(string username, string password);
    }
}
