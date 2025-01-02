using GreenDelight.Application.Interfaces.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public async Task<IActionResult> AboutView()
        {
            var about = await _aboutService.GetAbout();
            return View(about.Data);
        }
    }
}
