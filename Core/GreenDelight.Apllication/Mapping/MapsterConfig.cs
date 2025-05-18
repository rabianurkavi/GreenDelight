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
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MesaiDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.PersonelDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.SablonDtos;
using GreenDelight.Application.DTOs.OrderItemDtos;

namespace GreenDelight.Apllication.Mapping
{
    public class MapsterConfig
    {
        public static void RegisterMappings(TypeAdapterConfig config)
        {

            //    config.NewConfig<Product, ProductAddDto>()
            //    .Map(dest => dest.CategoryName, src => src.Category.Name);

            //    config.NewConfig<ProductAddDto, Product>()
            //        .Ignore(dest => dest.Category)
            //        .Ignore(dest => dest.ID);

            config.NewConfig<Product, ProductDetailDto>()
                .Map(dest => dest.CategoryName, src => src.Category.Name);

            config.NewConfig<Product, ProductUpdateDto>()
                .Map(dest => dest.CategoryName, src => src.Category.Name);

            config.NewConfig<Product, ProductDto>()
                .Map(dest => dest.CategoryName, src => src.Category.Name);

            config.NewConfig<User, UserAddDto>();

            config.NewConfig<User, UserDetailDto>();

            config.NewConfig<User, UserDto>()
                .Map(dest => dest.ID, src => src.Id);

            config.NewConfig<User, User>();

            config.NewConfig<Adress, AddressAddDto>();

            config.NewConfig<Adress, AddressDetailDto>()
                .Map(dest => dest.UserFullName, src => src.User.FullName)
                .Map(dest => dest.PhoneNumber, src => src.User.PhoneNumber);

            config.NewConfig<Adress, AddressDto>();

            config.NewConfig<Adress, AddressUpdateDto>();

            config.NewConfig<User, LoginDto>()
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.Password, src => src.PasswordHash);

            config.NewConfig<Category, CategoryDetailDto>()
                .Map(dest => dest.ID, src => src.ID);

            config.NewConfig<Category, CategoryAddDto>();

            config.NewConfig<Contact, ContactDto>();

            config.NewConfig<About, AboutDto>();

            config.NewConfig<Comment, CommentAddDto>();

            config.NewConfig<Comment, CommentDto>()
                .Map(dest => dest.UserName, src => src.User.FullName)
                .Map(dest => dest.UserImageUrl, src => src.User.ImageUrl);

            config.NewConfig<Adress, AddressDto>();

            config.NewConfig<RegisterDto, User>()
                .Map(dest => dest.FullName, src => src.FullName)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.UserName, src => src.UserName);
            config.NewConfig<OrderItemAddDto, OrderItem>()
                .Map(dest => dest.ProductID, src => src.ProductId) 
                .Map(dest => dest.OrderID, src => src.OrderID)
                .Map(dest => dest.Quantity, src => src.Quantity)
                .Map(dest => dest.UnitPrice, src => src.UnitPrice);


            //DEMİRYOLU PROJESİ İÇİN
            //        config.NewConfig<(Masa Masa, List<VardiyaSablonYer> Sablonlar), MasaDto>()
            // .Map(dest => dest.MasaId, src => src.Masa.MasaId)
            // .Map(dest => dest.MasaIsmi, src => src.Masa.Tanim)
            // .Map(dest => dest.Sablonlar, src => src.Sablonlar.Adapt<List<SablonDetayDto>>());

            //        config.NewConfig<VardiyaSablonYer, SablonDetayDto>()
            //            .Map(dest => dest.SablonId, src => src.VardiyaSablonYerId)
            //            .Map(dest => dest.SablonTanim, src => src.Tanim)
            //            .Map(dest => dest.SablonBaslangicTarihi, src => src.GecerlilikBaslangic)
            //            .Map(dest => dest.SablonBitisTarihi, src => src.GecerlilikBitis)
            //            .Map(dest => dest.MaxVardiya, src => src.MaxVardiya)
            //            .Map(dest => dest.GunlukVardiyalar, src => src.Vardiya
            //.SelectMany(v => v.GunlukVardiyaMasa)
            //.GroupBy(gvm => gvm.Tarih)
            //.Select(group => group.Adapt<GunlukVardiyaDto>())
            //.ToList());

            //        config.NewConfig<IGrouping<DateTime, GunlukVardiyaMasa>, GunlukVardiyaDto>()
            //            .Map(dest => dest.GunlukVardiyaTarih, src => src.Key)
            //            .Map(dest => dest.Vardiyalar, src => src.Select(x => x.Adapt<VardiyaDto>()).ToList());

            //        config.NewConfig<GunlukVardiyaMasa, VardiyaDto>()
            //            .Map(dest => dest.BaslangicSaat, src => new TimeOnly(src.Vardiya.BaslangicSaat.Hour, src.Vardiya.BaslangicSaat.Minute))
            //            .Map(dest => dest.BitisSaat, src => new TimeOnly(src.Vardiya.BitisSaat.Hour, src.Vardiya.BitisSaat.Minute))
            //            .Map(dest => dest.Personel, src => src.Personel.Adapt<PersonelFiltreDto>());

            //        config.NewConfig<Personel, PersonelFiltreDto>()
            //            .Map(dest => dest.PersonelAd, src => src.Ad)
            //            .Map(dest => dest.PersonelSoyad, src => src.Soyad);
        }
    }
}
