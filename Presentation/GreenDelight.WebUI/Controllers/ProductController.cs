using GreenDelight.Application.Interfaces.Services.ProductServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response= await _productService.GetAllAsync();
            return View(response);
        }
        public async Task<IActionResult> ProductDetail(int id)
        {
            TempData["ProductId"] = id;
            var values= await _productService.GetByIdAsync(id);
            return View(values);    
        }
        public async Task<IActionResult> ProductListByCategory(int categoryId)
        {
            var response= await _productService.ProductListByCategory(categoryId);

            if(response==null || response.Data==null) 
               ViewBag.ErrorMessage = response?.Message ?? "Ürünler listelenirken bir hata oluştu.";

            return View(response.Data);
        }
    }
}
