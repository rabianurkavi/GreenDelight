using GreenDelight.Application.DTOs.AddressDtos;
using GreenDelight.Application.Interfaces.Services.AdressServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    public class AdressController : Controller
    {
        private readonly ILogger<AdressController> _logger;
        private readonly IAddressService _addressService;

        public AdressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _addressService.GetAllByUserIdAsync();
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> AddAdress()
        {
            var citiesResult = await _addressService.GetAllCity();
            ViewBag.Cities = citiesResult.Data;
            return View(new AddressAddDto());
        }
        [HttpPost]
        public async Task<IActionResult> AddAdress(AddressAddDto addressAddDto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Cities = await _addressService.GetAllCity(); 
                return View(addressAddDto);
            }

            var result = await _addressService.AddAsync(addressAddDto);
            if (result.Success)
            {
                TempData["ToastType"] = "success";
                TempData["ToastMessage"] = result.Message;
                return RedirectToAction("Index", "Adress");
            }
            else
            {
                TempData["ToastType"] = "error";
                TempData["ToastMessage"] = result.Message;
            }
            ViewBag.Cities = await _addressService.GetAllCity();
            ViewBag.Error = result.Message;
            return View(addressAddDto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAdress(int id)
        {
            var result = await _addressService.GetByIdAsync(id);
            if (!result.Success)
                return NotFound();
            ViewBag.Cities = (await _addressService.GetAllCity()).Data;
            return View(result.Data); 
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAdress(AddressUpdateDto dto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Cities = (await _addressService.GetAllCity()).Data;
                return View(dto);
            }

            var result = await _addressService.UpdateAsync(dto);
            if (result.Success)
                return RedirectToAction("Index");

            ViewBag.Cities = (await _addressService.GetAllCity()).Data;
            ViewBag.Error = result.Message;
            return View(dto);
        }
        [HttpGet]
        public async Task<JsonResult> GetDistricts(int cityId)
        {
            var districts = await _addressService.GetAllDistrict(cityId);
            return Json(districts.Data);
        }

        [HttpGet]
        public async Task<JsonResult> GetNeighborhoods(int districtId)
        {
            var neighborhoods = await _addressService.GetAllNeighborhood(districtId);
            return Json(neighborhoods.Data);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveAdress(int id)
        {
            var neighborhoods = await _addressService.RemoveAsync(id);
            TempData["ToastType"] = "success";
            TempData["ToastMessage"] = neighborhoods.Message;
            return RedirectToAction("Index", "Adress");
        }
    }
}
