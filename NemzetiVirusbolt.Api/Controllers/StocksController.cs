using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using NemzetiVirusbolt.Api.Core;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Core.Repositories;
using NemzetiVirusbolt.Api.Resources;

namespace NemzetiVirusbolt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly ISupplyRepository _stockRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StocksController(ISupplyRepository stockRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/stocks
        [HttpGet]
        public async Task<IActionResult> GetStocks()
        {
            var stocks = await _stockRepository.GetSupplies();

            var stockResources =
                _mapper.Map<IEnumerable<Supply>, IEnumerable<GetStockResource>>(stocks);

            return Ok(stockResources);
        }

        // GET: api/stocks/merge
        [HttpGet("merge")]
        public async Task<IActionResult> GetMergedStocks()
        {
            var mergedStocks = await _stockRepository.GetMergedStocks();

            _mapper.Map<IEnumerable<MergedStock>, IEnumerable<GetMergedStockResource>>(mergedStocks);

            return Ok(mergedStocks);
        }

        // GET: api/stocks/total
        [HttpGet("total")]
        public async Task<IActionResult> GetTotalStockValue()
        {
            var stockTotalValue = await _stockRepository.GetTotalStockValue();

            var stockTotalValueResource =
                _mapper.Map<StockTotalValue, GetStockTotalValueResource>(stockTotalValue);

            return Ok(stockTotalValueResource);
        }

        // POST: api/stocks
        [HttpPost]
        public async Task<IActionResult> AddStock([FromBody] SaveStockResource stockResource)
        {
            try
            {
                var stock = _mapper.Map<Supply>(stockResource);
                stock.CreatedDateTime = DateTime.Now;

                await _stockRepository.Add(stock);
                await _unitOfWork.CompleteAsync();

                stock = await _stockRepository.GetSupply(stock.Id);

                var result = _mapper.Map<Supply, GetStockResource>(stock);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
