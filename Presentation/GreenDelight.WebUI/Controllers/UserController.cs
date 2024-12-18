using GreenDelight.Application.DTOs.UserDtos;
using GreenDelight.Application.Interfaces.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> UserProfile()
        {
            var userName = User.Identity.Name;
            var user = await _userService.TakeUserInfo(userName);
            return View(user.Data);
        }
        [HttpPost]
        public async Task<IActionResult> UserProfile(UserDto userDto)
        {
           return View();
        }

    }
}
