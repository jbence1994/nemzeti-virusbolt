using NemzetiVirusbolt.DesktopClient.Models;

namespace NemzetiVirusbolt.DesktopClient.Services
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void Authenticate(string username, string password);
    }
}
