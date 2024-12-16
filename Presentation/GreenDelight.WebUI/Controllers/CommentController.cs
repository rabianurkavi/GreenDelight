using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Application.Interfaces.Services.CommentServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<PartialViewResult> PartialAddComment(int productId)
        {
            var model = new CommentAddDto { ProductId = productId }; // Model'e ProductId'yi set et
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> PartialAddComment(CommentAddDto commentAddDto)
        {
            var comment = await _commentService.AddAsync(commentAddDto);
            return PartialView(commentAddDto); // Modeli ya da yeni view'ı döndür
        }
    }
}
