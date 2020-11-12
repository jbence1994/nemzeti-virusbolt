using AutoMapper;
using NemzetiVirusbolt.API.Controllers.Resources;
using NemzetiVirusbolt.API.Core.Models;

namespace NemzetiVirusbolt.API.Controllers.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain model to API Resource

            CreateMap<Product, ProductResource>();
            CreateMap<Supplier, SupplierResource>();
        }
    }
}
