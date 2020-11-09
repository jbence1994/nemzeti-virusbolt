using System.Collections.Generic;

namespace NemzetiVirusbolt.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }

        public User()
        {
            Stocks = new List<Stock>();
        }
    }
}
