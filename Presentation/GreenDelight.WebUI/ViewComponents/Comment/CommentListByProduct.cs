using GreenDelight.Application.Interfaces.Services.CommentServices;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.ViewComponents.Comment
{
    public class CommentListByProduct:ViewComponent
    {
        //productidsini al ona göre yorumları listele
        private readonly ICommentService _commentService;

        public CommentListByProduct(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var comments = await _commentService.GetAllAsync(productId);
            if (comments.Data.Count==0)
                ViewBag.ErrorMessage = "Henüz yorum yapılmadı. İlk yorumu siz yapın.";
            return View(comments);
        }
    }
}
