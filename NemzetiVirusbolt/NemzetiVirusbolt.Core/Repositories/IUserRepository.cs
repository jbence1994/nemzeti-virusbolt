using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Core.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void Authenticate(string username, string password);
    }
}
