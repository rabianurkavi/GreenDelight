using GreenDelight.Apllication.DTOs.ProductDtos;
using GreenDelight.Application.Interfaces.Services.ProductServices;
using GreenDelight.Domain.Results;
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
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            try
            {
                // Ürünü ekle
                var response = await _productService.GetAllAsync();
                return Ok(response);
            }
            catch (Exception ex)
            {
                // Hata mesajını döndür
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductUpdateDto productUpdateDto)
        {
            var result = await _productService.UpdateAsync(productUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result= await _productService.RemoveAsync(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }

    }
}
