using AutoMapper;
using ChiSell.Domain;

namespace ChiSell.Application.Products.Models.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductModel>();
        }
    }
}
