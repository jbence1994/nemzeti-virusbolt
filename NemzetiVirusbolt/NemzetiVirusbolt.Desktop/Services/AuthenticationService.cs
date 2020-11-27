using System;
using Microsoft.Extensions.Configuration;

namespace NemzetiVirusbolt.Desktop.Services
{
    public class AuthenticationService
    {
        private readonly IConfiguration _configuration;

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Authenticate(string username, string password)
        {
            if (GetUsername() != username &&
                GetPassword() != password)
                throw new Exception("Érvénytelen belépési adatok.");
        }

        private string GetUsername()
        {
            return _configuration.GetSection("Credentials").GetSection("Username").Value;
        }

        private string GetPassword()
        {
            return _configuration.GetSection("Credentials").GetSection("Password").Value;
        }
    }
}
