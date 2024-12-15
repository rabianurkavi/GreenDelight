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
        public async Task<IActionResult> CommentAdd(int productId)
        {
            ViewBag.ProductId = productId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CommentAdd(CommentAddDto commentAddDto)
        {
            var comment = await _commentService.AddAsync(commentAddDto);
            return View();
        }
    }
}
