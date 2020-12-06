using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using NemzetiVirusbolt.API.Resources;
using NemzetiVirusbolt.Core;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;

namespace NemzetiVirusbolt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StocksController(IStockRepository stockRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _unitOfWork = unitOfWork;
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
            return Ok(await _stockRepository.GetTotalStockValue());
        }

        // POST: api/stocks
        [HttpPost]
        public async Task<IActionResult> AddStock([FromBody] SaveStockResource stockResource)
        {
            try
            {
                var stock = _mapper.Map<Stock>(stockResource);
                stock.DateRecorded = DateTime.Now;

                await _stockRepository.AddStock(stock);
                await _unitOfWork.CompleteAsync();

                stock = await _stockRepository.GetStock(stock.Id);

                var result = _mapper.Map<Stock, GetStockResource>(stock);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
