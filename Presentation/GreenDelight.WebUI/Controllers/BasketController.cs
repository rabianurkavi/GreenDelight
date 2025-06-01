using GreenDelight.Application.DTOs.BasketItemDtos;
using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Application.Interfaces.Services.BasketItemServices;
using GreenDelight.Application.Interfaces.Services.BasketServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{

    public class BasketController : Controller
    {
        private readonly IBasketItemService _basketItemService;
        private readonly IBasketService _basketService;
        public BasketController(IBasketItemService basketItemService, IBasketService basketService)
        {
            _basketItemService = basketItemService;
            _basketService = basketService;
        }
        [HttpGet]
        public async Task<PartialViewResult> PartialAddBasketItem(int productId, decimal unitPrice)
        {
            var model = new BasketItemAddDto { ProductId = productId, UnitPrice = unitPrice };
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> PartialAddBasketItem(BasketItemAddDto basketItemAddDto)
        {
            var comment = await _basketItemService.AddAsync(basketItemAddDto);
            return PartialView(basketItemAddDto);
        }

        [HttpGet]
        public async Task<PartialViewResult> PartialGetBasketItem()
        {
            var result = await _basketItemService.GetBasketItemAsync();
            if (result.Data!=null)
            {
                ViewBag.BasketItemCount = result.Data.Count;
                ViewBag.BasketId = _basketService.GetOrCreateBasketId().Result;
                return PartialView(result.Data);
            }
            
            ViewBag.ErrorMessage = result.Message;
            ViewBag.BasketItemCount = 0;
            return PartialView(result.Data);
        }
        [HttpDelete]
        public async Task<IActionResult> BasketItemRemove(int basketItemId)
        {
            var result = await _basketItemService.BasketItemRemove(basketItemId);
            if (result.Success)
            {
                return Json(new { success = true, message = "Ürün başarıyla silindi." });
            }

            return Json(new { success = false, message = "Ürün silinemedi." });
        }

    }
}
