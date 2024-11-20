using GreenDelight.Apllication.DTOs.ProductDtos;
using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<IResult> AddAsync(CategoryAddDto categoryAddDto);
        Task<IResult> UpdateAsync(CategoryDetailDto categoryDetailDto);
        Task<IDataResult<CategoryDetailDto>> GetByIdAsync(int id);
        Task<IDataResult<List<CategoryDetailDto>>> GetAllAsync();
        Task<IResult> RemoveAsync(int id);
    }
}
