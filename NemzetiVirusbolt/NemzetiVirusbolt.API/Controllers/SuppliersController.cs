using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NemzetiVirusbolt.API.Controllers.Resources;
using NemzetiVirusbolt.API.Core.Models;
using NemzetiVirusbolt.API.Core.Repositories;

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
        public IActionResult GetSuppliers()
        {
            var suppliers = _supplierRepository.GetSuppliers();

            var supplierResources =
                _mapper.Map<IEnumerable<Supplier>, IEnumerable<SupplierResource>>(suppliers);

            return Ok(supplierResources);
        }

        [HttpGet("{id}")]
        public IActionResult GetSupplier(int id)
        {
            try
            {
                var supplier = _supplierRepository.GetSupplier(id);
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
