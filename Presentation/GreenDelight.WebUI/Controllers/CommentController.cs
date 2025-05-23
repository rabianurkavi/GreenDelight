﻿using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Application.Interfaces.Services.CommentServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.WebUI.Controllers
{
    [Authorize]
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
            var model = new CommentAddDto { ProductId = productId };
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> PartialAddComment(CommentAddDto commentAddDto)
        {
            var comment = await _commentService.AddAsync(commentAddDto);
            return PartialView(commentAddDto); 
        }
    }
}
