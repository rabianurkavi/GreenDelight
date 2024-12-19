using GreenDelight.Application.DTOs.UserDtos;
using GreenDelight.Application.Interfaces.Services.UserServices;
using GreenDelight.WebUI.Models.ViewModel;
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
        public async Task<IActionResult> UserProfile(UserVM userVM)
        {
            var userName = User.Identity.Name;
            var user = await _userService.TakeUserInfo(userName);
            if (userVM.ImageUrl != null && userVM.ImageUrl.Length > 0)
            {
                var extension = Path.GetExtension(userVM.ImageUrl.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    userVM.ImageUrl.CopyTo(stream);
                }

                user.Data.ImageUrl = newImageName;
            }
            user.Data.FullName = userVM.FullName;
            user.Data.PhoneNumber = userVM.PhoneNumber;
            user.Data.Password = userVM.Password;
            user.Data.DateOfBirth = userVM.DateOfBirth;
            user.Data.Email = userVM.Email;

            //gelen userdto verilerini gönder ve serviste gerçek verilerle eşleştirecek şekilde ayarla
            await _userService.UpdateProfile(user.Data);
           return RedirectToAction("UserProfile","User");
        }

    }
}
