using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Core.Repositories;
using NemzetiVirusbolt.Api.Resources;

namespace NemzetiVirusbolt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly IMerchantRepository _supplierRepository;
        private readonly IMapper _mapper;

        public SuppliersController(IMerchantRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        // GET: api/suppliers
        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _supplierRepository.GetMerchants();

            var supplierResources =
                _mapper.Map<IEnumerable<Merchant>, IEnumerable<GetSupplierResource>>(suppliers);

            return Ok(supplierResources);
        }
    }
}
