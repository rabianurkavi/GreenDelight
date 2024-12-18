using GreenDelight.Application.Interfaces.Services.AuthServices;
using GreenDelight.Application.Interfaces.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.ViewComponents.User
{
    public class LoginUserNotification : ViewComponent
    {     
        private readonly IUserService _userService;

        public LoginUserNotification(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userName = User.Identity.Name;
            //username i gönderen bir metot yaz ve userın diğer özelliklerini buradan al.

            var userDto= await _userService.TakeUserInformation(userName);
            ViewBag.UserName = userDto.FullName; 
            return View();
        }
    }
}
