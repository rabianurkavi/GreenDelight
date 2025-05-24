using GreenDelight.Application.Interfaces.Services.BasketServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<int> GetOrCreateBasketId(Guid userId)
        {
            try
            {
                var sessionBasketId = _httpContextAccessor.HttpContext.Session.GetInt32("BasketID");
                if (sessionBasketId.HasValue)
                    return sessionBasketId.Value;

                var newBasket = new Basket
                {
                    UserID = userId,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };

                await _unitOfWork.GetGenericRepository<Basket>().AddAsync(newBasket);
                await _unitOfWork.CommitAsync();

                var savedBasket = await _unitOfWork.GetGenericRepository<Basket>()
                    .GetAsync(b => b.UserID == userId && b.IsActive);

                if (savedBasket != null)
                {
                    _httpContextAccessor.HttpContext.Session.SetInt32("BasketID", savedBasket.ID);
                    return savedBasket.ID;
                }

                return 0;
            }
            catch (Exception ex)
            {
                return 0; 
            }
        }
    }
}
