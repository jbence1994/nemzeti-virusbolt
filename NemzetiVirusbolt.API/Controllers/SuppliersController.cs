using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Api.Resources;

namespace NemzetiVirusbolt.Api.Controllers
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

        // GET: api/suppliers
        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _supplierRepository.GetSuppliers();

            var supplierResources =
                _mapper.Map<IEnumerable<Supplier>, IEnumerable<GetSupplierResource>>(suppliers);

            return Ok(supplierResources);
        }
    }
}
