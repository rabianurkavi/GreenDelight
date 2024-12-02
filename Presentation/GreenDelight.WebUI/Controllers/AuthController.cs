﻿using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.Interfaces.Services.AuthServices;
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

        [HttpPost]
        public async Task<IActionResult> Index(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _authService.LoginAsync(loginDto);

                if (response != null && !string.IsNullOrEmpty(response.Token))
                {
                    // Giriş başarılı ise, kullanıcıyı ana sayfaya veya belirli bir sayfaya yönlendir
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Giriş başarısız ise, hata mesajını görüntüle
                    ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı.");
                }
            }

            // Giriş formunu yeniden göster ve kullanıcıya hata mesajlarını ilet
            return View(loginDto);
        }

    }
}
