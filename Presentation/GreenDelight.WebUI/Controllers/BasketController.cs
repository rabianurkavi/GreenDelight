using GreenDelight.Application.DTOs.BasketItemDtos;
using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Application.Interfaces.Services.BasketItemServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{

    public class BasketController : Controller
    {
        private readonly IBasketItemService _basketItemService;
        public BasketController(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
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
       
    }
}
