using NemzetiVirusbolt.Models;

namespace NemzetiVirusbolt.Services
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void Authenticate(string username, string password);
    }
}
