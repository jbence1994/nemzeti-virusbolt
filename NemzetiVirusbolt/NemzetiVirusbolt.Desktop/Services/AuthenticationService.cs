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
            return GetCredentialsSection()
                .GetSection("Username").Value;
        }

        private string GetPassword()
        {
            return GetCredentialsSection()
                .GetSection("Password").Value;
        }

        private IConfigurationSection GetCredentialsSection(string credentialsSection = "Credentials")
        {
            return _configuration.GetSection(credentialsSection);
        }
    }
}
