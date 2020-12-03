using AutoMapper;
using NemzetiVirusbolt.API.Resources;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain model to API Resource

            CreateMap<Supplier, GetSupplierResource>();
            CreateMap<Product, GetProductResource>();
            CreateMap<Stock, GetStockResource>();
            CreateMap<MergedStock, GetMergedStockResource>();

            // API Resource to Domain model

            CreateMap<SaveProductResource, Product>();
        }
    }
}
