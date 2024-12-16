using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.AuthDtos.RegisterDtos;
using GreenDelight.Application.Interfaces.Services.AuthServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var response = await _authService.LoginAsync(loginDto);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            await _authService.RegisterAsync(registerDto);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _authService.LogoutAsync();
            return RedirectToAction("Login", "Auth");
        }
    }
}
