using GreenDelight.Application.Interfaces.Services.BasketServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.BasketServices
{
    public class BasketService : IBasketService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BasketService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IDataResult<Basket>> BasketIsActiveFalse(int basketId)
        {
            try
            {
                var basketRepo = _unitOfWork.GetGenericRepository<Basket>();
                var userIdStr = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userIdStr))
                    return new ErrorDataResult<Basket>("Kullanıcı kimliği alınamadı.");

                var userId = Guid.Parse(userIdStr);

                var basket = await basketRepo.GetAsync(x => x.ID == basketId && x.IsActive == true && x.UserID == userId);

                if (basket == null)
                    return new ErrorDataResult<Basket>("Aktif sepet bulunamadı.");

                basket.IsActive = false;

                await basketRepo.UpdateAsync(basket);
                await _unitOfWork.CommitAsync();

                return new SuccessDataResult<Basket>(basket, "Sepet başarıyla kapatıldı.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Basket>($"Sepet kapatılırken bir hata oluştu: {ex.Message}");
            }
        }


        public async Task<Domain.Results.IResult> ConfirmBasketAsync(int basketId)
        {
            try
            {
                var basket = await _unitOfWork.GetGenericRepository<Basket>().GetAsync(x => x.ID == basketId);

                if (basket == null)
                    return new ErrorResult("Sepet bulunamadı.");

                basket.IsActive = false;
                await _unitOfWork.GetGenericRepository<Basket>().UpdateAsync(basket);
                await _unitOfWork.CommitAsync();

                _httpContextAccessor.HttpContext.Session.Remove("BasketID");

                return new SuccessResult("Sepet başarıyla onaylandı.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Sepet onaylanırken bir hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<Basket>> GetBasketAsync(int basketId)
        {
            try
            {
                var basket = await _unitOfWork.GetGenericRepository<Basket>().GetAsync(x => x.ID == basketId);
                if (basket == null)
                    return new ErrorDataResult<Basket>("Sepet bulunamadı.");

                return new SuccessDataResult<Basket>(basket, "Sepet başarıyla getirildi.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Basket>($"Sepet getirilirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<int> GetOrCreateBasketId()
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var existingBasket = await _unitOfWork.GetGenericRepository<Basket>()
                    .GetAsync(b => b.UserID == Guid.Parse(userId) && b.IsActive);

                if (existingBasket != null)
                {
                    return existingBasket.ID;
                }

                var newBasket = new Basket
                {
                    UserID = Guid.Parse(userId),
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };

                await _unitOfWork.GetGenericRepository<Basket>().AddAsync(newBasket);
                await _unitOfWork.CommitAsync();

                return newBasket.ID; 
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
