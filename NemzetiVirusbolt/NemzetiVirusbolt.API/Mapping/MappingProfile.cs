using AutoMapper;
using NemzetiVirusbolt.API.Models;
using NemzetiVirusbolt.API.Resources;

namespace NemzetiVirusbolt.API.Mapping
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
