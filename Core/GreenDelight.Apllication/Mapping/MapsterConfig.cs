using GreenDelight.Apllication.DTOs.ProductDtos;
using GreenDelight.Domain.Concrete;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Apllication.Mapping
{
    public class MapsterConfig
    {
        public static void RegisterMappings()
        {
            // Product -> ProductAddDto mapping
            TypeAdapterConfig<Product, ProductAddDto>.NewConfig()
                .Map(dest => dest.CategoryName, src => src.Category.Name);

            //// ProductAddDto -> Product mapping
            //TypeAdapterConfig<ProductAddDto, Product>.NewConfig()
            //    .Ignore(dest => dest.Category)  // Category'yi ignore et
            //    .Ignore(dest => dest.ID);       // ID'yi de ignore et
            TypeAdapterConfig<Product, ProductDetailDto>.NewConfig()
            .Map(dest => dest.CategoryName, src => src.Category.Name);

            TypeAdapterConfig<Product, ProductUpdateDto>.NewConfig()
            .Map(dest => dest.CategoryName, src => src.Category.Name);
            TypeAdapterConfig<Product, ProductDto>.NewConfig()
            .Map(dest => dest.CategoryName, src => src.Category.Name);

        }
    }
}
