using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using NemzetiVirusbolt.Core;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Api.Resources;

namespace NemzetiVirusbolt.Api.Controllers
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

        // POST: api/products
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] SaveProductResource productResource)
        {
            try
            {
                var product = _mapper.Map<Product>(productResource);

                await _productRepository.AddProduct(product);
                await _unitOfWork.CompleteAsync();

                product = await _productRepository.GetProduct(product.Id);

                var result = _mapper.Map<Product, GetProductResource>(product);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
