namespace NemzetiVirusbolt.Desktop.Authentication
{
    public interface IAuthenticationService
    {
        void Authenticate(string username, string password);
    }
}
