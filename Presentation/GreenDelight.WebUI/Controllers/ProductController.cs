using GreenDelight.Application.Interfaces.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
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
            ViewBag.Id = id;
            TempData["BlogId"] = id;
            var values= await _productService.GetByIdAsync(id);
            return View(values);    
        }
    }
}
