using GreenDelight.Application.DTOs.ContactDtos;
using GreenDelight.Application.Interfaces.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(ContactDto contactDto)
        {
            await _contactService.AddAsync(contactDto);
            ViewBag.Message = contactDto.Message;
            return View();
        }
    }
}
