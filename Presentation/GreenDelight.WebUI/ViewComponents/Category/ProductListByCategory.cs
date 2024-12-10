using GreenDelight.Application.Interfaces.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.ViewComponents.Category
{
    public class ProductListByCategory:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public ProductListByCategory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllAsync();
            return View(values);
        }

    }
}
