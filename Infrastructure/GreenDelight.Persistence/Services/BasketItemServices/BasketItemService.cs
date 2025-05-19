using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.BasketItemDtos;
using GreenDelight.Application.DTOs.ContactDtos;
using GreenDelight.Application.Interfaces.Services.BasketItemServices;
using GreenDelight.Application.Interfaces.Services.BasketServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.BasketItemServices
{
    public class BasketItemService : IBasketItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBasketService _basketService;


        public BasketItemService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IBasketService basketService)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor= httpContextAccessor;
            _basketService = basketService;
        }

        public async Task<Domain.Results.IResult> AddAsync(BasketItemAddDto basketItemAddDto)
        {
            try
            {
                var userIdString = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out Guid userId))
                {
                    return new ErrorResult("Kullanıcı kimliği alınamadı veya geçersiz.");
                }
                int basketId = await _basketService.GetOrCreateBasketId(userId);
                var basketItem = basketItemAddDto.Adapt<BasketItem>();
                basketItem.BasketId = basketId;
                await _unitOfWork.GetGenericRepository<BasketItem>().AddAsync(basketItem);
                await _unitOfWork.CommitAsync();

                return new SuccessDataResult<bool>(true, Messages.OrderItemAdded);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sepete ekleme hatası: {ex.Message}");
                return new ErrorDataResult<bool>("Ürün sepete eklenirken bir hata oluştu.");
            }
        }

    }
}
