using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Application.DTOs.OrderItemDtos;
using GreenDelight.Application.Interfaces.Services.OrterItemServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{

    public class BasketController : Controller
    {
        private readonly IOrderItemService _orderItemService;
        public BasketController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }
        [HttpGet]
        public async Task<PartialViewResult> PartialAddOrderItem(int productId, decimal unitPrice)
        {
            var model = new OrderItemAddDto { ProductId = productId, UnitPrice = unitPrice };
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> PartialAddOrderItem(OrderItemAddDto orderItemAddDto)
        {
            orderItemAddDto.OrderID = 1;
            var comment = await _orderItemService.AddAsync(orderItemAddDto);
            return PartialView(orderItemAddDto);
        }
       
    }
}
