using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Core.Repositories;

namespace NemzetiVirusbolt.Api.Persistence.Repositories
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly ApplicationDbContext _context;

        public MerchantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Merchant>> GetMerchants()
        {
            return await _context.Merchants.ToListAsync();
        }
    }
}
