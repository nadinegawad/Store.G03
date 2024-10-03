using AutoMapper;
using Store.G03.Core.Dtos.Products;
using Store.G03.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G03.Core.Mapping.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ForMember(d => d.BrandName, options => options.MapFrom(s => s.Brand.Name)).ForMember(d => d.BrandName, options => options.MapFrom(s => s.Type.Name));
            CreateMap< ProductBrand, TypeBrandDto>();
            CreateMap< ProductType, TypeBrandDto>();
            
        }
    }
}
