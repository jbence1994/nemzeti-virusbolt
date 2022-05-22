using AutoMapper;
using NemzetiVirusbolt.Api.Resources;
using NemzetiVirusbolt.Core.Models;

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
