using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using NemzetiVirusbolt.API.Resources;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;

namespace NemzetiVirusbolt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;

        public StocksController(IStockRepository stockRepository, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
        }

        // GET: api/stocks
        [HttpGet]
        public async Task<IActionResult> GetStocks()
        {
            var stocks = await _stockRepository.GetStocks();

            var stockResources =
                _mapper.Map<IEnumerable<Stock>, IEnumerable<GetStockResource>>(stocks);

            return Ok(stockResources);
        }

        // POST: api/stocks
        [HttpPost]
        public async Task<IActionResult> AddStock([FromBody] SaveStockResource stockResource)
        {
            return Ok();
        }
    }
}
