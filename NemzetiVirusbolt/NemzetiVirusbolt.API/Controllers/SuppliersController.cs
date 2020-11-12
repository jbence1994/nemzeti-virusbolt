using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NemzetiVirusbolt.API.Models;
using NemzetiVirusbolt.API.Persistence.Repositories;
using NemzetiVirusbolt.API.Resources;

namespace NemzetiVirusbolt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public SuppliersController(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _supplierRepository.GetSuppliers();

            var supplierResources =
                _mapper.Map<IEnumerable<Supplier>, IEnumerable<SupplierResource>>(suppliers);

            return Ok(supplierResources);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplier(int id)
        {
            try
            {
                var supplier = await _supplierRepository.GetSupplier(id);
                var supplierResource = _mapper.Map<Supplier, SupplierResource>(supplier);

                return Ok(supplierResource);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
