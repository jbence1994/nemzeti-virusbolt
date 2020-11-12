using NemzetiVirusbolt.Desktop.Models;

namespace NemzetiVirusbolt.Desktop.Persistence.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void Authenticate(string username, string password);
    }
}
