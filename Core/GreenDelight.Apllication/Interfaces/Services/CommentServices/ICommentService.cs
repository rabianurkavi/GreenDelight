using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Application.DTOs.CommentDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.CommentServices
{
    public interface ICommentService
    {
        Task<IResult> AddAsync(CommentAddDto commentAddDto);
        Task<IDataResult<List<CommentDto>>> GetAllAsync(int productId);
        Task<IResult> RemoveAsync(int productId);
    }
}
