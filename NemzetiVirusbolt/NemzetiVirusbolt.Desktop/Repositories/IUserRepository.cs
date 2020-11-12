using NemzetiVirusbolt.Desktop.Models;

namespace NemzetiVirusbolt.Desktop.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void Authenticate(string username, string password);
    }
}
