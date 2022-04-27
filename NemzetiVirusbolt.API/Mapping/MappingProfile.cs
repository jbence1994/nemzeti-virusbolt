using AutoMapper;
using NemzetiVirusbolt.Api.Core.Models;
using NemzetiVirusbolt.Api.Resources;

namespace NemzetiVirusbolt.Api.Mapping
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
            CreateMap<StockTotalValue, GetStockTotalValueResource>();

            // API Resource to Domain model

            CreateMap<SaveProductResource, Product>();
            CreateMap<SaveStockResource, Stock>();
        }
    }
}
