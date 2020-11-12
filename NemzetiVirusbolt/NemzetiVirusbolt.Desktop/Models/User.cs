using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NemzetiVirusbolt.Desktop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Stock> Stocks { get; set; }

        public User()
        {
            Stocks = new Collection<Stock>();
        }
    }
}
