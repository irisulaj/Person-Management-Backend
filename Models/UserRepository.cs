namespace PersonManagement.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly PersonManagementContext _personManagementContext;

        public UserRepository(PersonManagementContext personManagementContext)
        {
            _personManagementContext = personManagementContext;
        }

        public Pm03User Login(string username, string password)
        {
          
                
           var user = _personManagementContext.Pm03Users.FirstOrDefault(i => i.Username == username && i.Password == password);

            if (user != null)
            {
                return user;
            }

            else
            {
                return null;
            }

        }
    }
}
