using GreenDelight.Application.DTOs.ProductDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.ProductServices
{
    public interface IProductService
    {
        Task<IResult> AddAsync(ProductAddDto productAddDto);
        Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto);
        Task<IDataResult<ProductDetailDto>> GetByIdAsync(int id);
        Task<IDataResult<List<ProductDetailDto>>> GetAllAsync();
        Task<IResult> RemoveAsync(int id);
    }
}
