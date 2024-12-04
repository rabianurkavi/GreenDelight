using GreenDelight.Application.DTOs.AddressDtos;
using GreenDelight.Application.Interfaces.Services.AdressServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]AddressAddDto addressAddDto)
        {
            var result= await _addressService.AddAsync(addressAddDto);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var result= await _addressService.GetByIdAsync(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
