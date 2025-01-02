using GreenDelight.Application.DTOs.ProductDtos;
using GreenDelight.Application.DTOs.UserDtos;
using GreenDelight.Application.DTOs.AddressDtos;
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
using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Application.DTOs.ContactDtos;
using GreenDelight.Application.DTOs.AboutDtos;

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
            TypeAdapterConfig<User, UserDto>.NewConfig()
                .Map(dest=>dest.ID, src=>src.Id);
            TypeAdapterConfig<User, User>.NewConfig();


            TypeAdapterConfig<Adress, AddressAddDto>.NewConfig();
            TypeAdapterConfig<Adress, AddressDetailDto>.NewConfig()
                .Map(dest=> dest.UserFullName,src=>src.User.FullName)
                .Map(dest=>dest.PhoneNumber, src=>src.User.PhoneNumber);
            TypeAdapterConfig<Adress, AddressDto>.NewConfig();
            TypeAdapterConfig<Adress, AddressUpdateDto>.NewConfig();

            TypeAdapterConfig<User, LoginDto>.NewConfig()
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.Password, src => src.PasswordHash);

            TypeAdapterConfig<Category, CategoryDetailDto>.NewConfig()
                .Map(dest=>dest.ID, src=>src.ID);
            TypeAdapterConfig<Category, CategoryAddDto>.NewConfig();

            TypeAdapterConfig<Contact, ContactDto>.NewConfig();

            TypeAdapterConfig<About, AboutDto>.NewConfig();


            TypeAdapterConfig<Comment, CommentAddDto>.NewConfig();
            TypeAdapterConfig<Comment, CommentDto>.NewConfig()
                .Map(dest => dest.UserName, src => src.User.FullName)
                .Map(dest => dest.UserImageUrl, src => src.User.ImageUrl);
            TypeAdapterConfig<Adress, AddressDto>.NewConfig();

            TypeAdapterConfig<RegisterDto, User>.NewConfig()
                .Map(dest => dest.FullName, src => src.FullName)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.UserName, src => src.UserName); // Email'i UserName olarak ayarlama
        }
    }
}
