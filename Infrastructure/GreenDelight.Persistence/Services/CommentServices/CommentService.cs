using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.AddressDtos;
using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Application.Interfaces.Services.CommentServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using IResult = GreenDelight.Domain.Results.IResult;


namespace GreenDelight.Persistence.Services.CommentServices
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CommentService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor= httpContextAccessor;
        }

        public async Task<IResult> AddAsync(CommentAddDto commentAddDto)
        {
            // Oturum açan kullanıcının ID'sini al
            var userIdString = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdString == null)
            {
                return new ErrorResult("Kullanıcı kimliği alınamadı.");
            }
            var comment=commentAddDto.Adapt<Comment>();
            if (Guid.TryParse(userIdString, out Guid userId))
            {
                // userId artık bir Guid türünde kullanılabilir
                comment.UserId = userId;
            }
            await _unitOfWork.GetGenericRepository<Comment>().AddAsync(comment);
            await _unitOfWork.CommitAsync();

            return new SuccessResult(Messages.CommentAdded);
        }

        public async Task<IDataResult<List<CommentDto>>> GetAllAsync(int productId)
        {
            var commentList = await _unitOfWork.GetGenericRepository<Comment>().GetAllAsync(x=>x.ProductId==productId);
            var commentDto = commentList.Adapt<List<CommentDto>>();
            return new SuccessDataResult<List<CommentDto>>(commentDto, "dd");
        }

        public Task<IResult> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
