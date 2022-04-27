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

            CreateMap<Merchant, GetSupplierResource>();
            CreateMap<MergedStock, GetMergedStockResource>();
            CreateMap<Product, GetProductResource>();
            CreateMap<StockTotalValue, GetStockTotalValueResource>();
            CreateMap<Supply, GetStockResource>();

            // API Resource to Domain model

            CreateMap<SaveProductResource, Product>();
            CreateMap<SaveStockResource, Supply>();
        }
    }
}
