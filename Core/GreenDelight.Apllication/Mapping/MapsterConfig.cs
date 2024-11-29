using GreenDelight.Apllication.DTOs.ProductDtos;
using GreenDelight.Apllication.DTOs.UserDtos;
using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.AuthDtos.RegisterDtos;
using GreenDelight.Domain.Concrete;
using Mapster;
using Microsoft.AspNetCore.Identity.Data;
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

            TypeAdapterConfig<User, UserAddDto>.NewConfig();
            TypeAdapterConfig<User, UserDetailDto>.NewConfig();
            TypeAdapterConfig<User, UserDto>.NewConfig();
            TypeAdapterConfig<User, UserUpdateDto>.NewConfig();

            TypeAdapterConfig<User, LoginDto>.NewConfig()
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.Password, src => src.PasswordHash);

            TypeAdapterConfig<RegisterDto, User>.NewConfig()
                .Map(dest => dest.FullName, src => src.FullName)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.UserName, src => src.Email); // Email'i UserName olarak ayarlama
        }
    }
}
