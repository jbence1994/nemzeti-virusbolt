using NemzetiVirusbolt.Core.Repositories;
using System;
using System.Linq;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetUser(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
                throw new Exception("Ismeretlen felhasználó.");

            return user;
        }

        public void Authenticate(string username, string password)
        {
            if (!_context.Users.Any(u =>
                u.Username == username && u.Password == password))
                throw new Exception("Helytelen felhasználónév vagy jelszó.");
        }
    }
}
