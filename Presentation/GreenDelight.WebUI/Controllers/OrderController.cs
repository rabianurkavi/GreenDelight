using GreenDelight.Application.DTOs.OrderDtos;
using GreenDelight.Application.Interfaces.Services.AdressServices;
using GreenDelight.Application.Interfaces.Services.BasketItemServices;
using GreenDelight.Application.Interfaces.Services.OrderServices;
using GreenDelight.Persistence.Services.AdressServices;
using GreenDelight.WebUI.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IAddressService _adressService;
        private readonly IBasketItemService _basketItemService;
        public OrderController(IOrderService orderService,IAddressService addressService,IBasketItemService basketItemService)
        {
            _orderService = orderService;
            _adressService = addressService;
            _basketItemService = basketItemService;
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrder(int basketId)
        {
            var adresResult = await _adressService.GetAllByUserIdAsync();

            var basketResult = await _basketItemService.GetBasketItemAsync();

            if (!adresResult.Success || !basketResult.Success)
            {
                TempData["Error"] = "Sipariş verisi alınamadı.";
                return RedirectToAction("Index", "Basket");
            }

            var model = new OrderPageVM
            {
                BasketId = basketId,
                Adresses = adresResult.Data,
                BasketItems = basketResult.Data,
                TotalPrice = basketResult.Data.Sum(x => x.Quantity * x.UnitPrice)
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(int basketId, int adressId)
        {
            var orderDto = new OrderAddDto
            {
                AdressId = adressId
            };

            var result = await _orderService.CreateOrderAsync(orderDto, basketId);

            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.Message;
                return RedirectToAction("CreateOrder", new { basketId });
            }

            var orderId = result.Data;

            // Ödeme sayfasına yönlendir
            return RedirectToAction("CreateCheckoutSession", "Payment", new { id = orderId });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrderByUser()
        {
            var result = await _orderService.GetListOrdersAsync();
            return View(result);
        }

    }
}
