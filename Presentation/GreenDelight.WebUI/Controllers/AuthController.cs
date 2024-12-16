using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.AuthDtos.RegisterDtos;
using GreenDelight.Application.Interfaces.Services.AuthServices;
using GreenDelight.Domain.Results;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.LoginAsync(loginDto);

                // response veya response.Data null ise, hata mesajını ViewBag'e ekleyerek işlemi devam ettir
                if (!result.Success)
                {
                    ViewBag.ErrorMessage = result?.Message ?? "Giriş sırasında bir hata oluştu.";
                    return View(loginDto);
                }

                // Giriş başarılı ise, kullanıcıyı ana sayfaya veya belirli bir sayfaya yönlendir
                return RedirectToAction("Index", "Product");
            }

            // ModelState geçerli değilse, formu ve hata mesajlarını geri gönder
            return View(loginDto);
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            await _authService.RegisterAsync(registerDto);
            return RedirectToAction("Index", "Product");
        }

    }
}
