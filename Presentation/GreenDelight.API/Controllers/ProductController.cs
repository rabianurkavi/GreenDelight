using GreenDelight.Apllication.DTOs.ProductDtos;
using GreenDelight.Application.Interfaces.Services.ProductServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductAddDto productAddDto)
        {
            var result = await _productService.AddAsync(productAddDto);

            if (result.Success)
            {
                return Ok(result.Message);  // SuccessResult, HTTP 200 döner
            }

            return BadRequest(result.Message);  // ErrorResult, HTTP 400 döner
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            try
            {
                // Ürünü ekle
               var response =  await _productService.GetAllAsync();
                return Ok(response);
            }
            catch (Exception ex)
            {
                // Hata mesajını döndür
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
