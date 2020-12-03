using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepository.GetProducts();

            var productResources =
                _mapper.Map<IEnumerable<Product>, IEnumerable<GetProductResource>>(products);

            return Ok(productResources);
        }

        // GET: api/products/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productRepository.GetProduct(id);

            var productResource = _mapper.Map<Product, GetProductResource>(product);

            return Ok(productResource);
        }

        // POST: api/products
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] SaveProductResource productResource)
        {
            var product = _mapper.Map<Product>(productResource);

            await _productRepository.AddProduct(product);
            await _unitOfWork.CompleteAsync();

            return Ok();
        }
    }
}
