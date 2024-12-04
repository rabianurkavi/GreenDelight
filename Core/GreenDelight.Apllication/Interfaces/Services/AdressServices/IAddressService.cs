using GreenDelight.Application.DTOs.AddressDtos;
using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.AdressServices
{
    public interface IAddressService
    {
        Task<IResult> AddAsync(AddressAddDto addressAddDto);
        Task<IResult> UpdateAsync(AddressUpdateDto addressUpdateDto);
        Task<IDataResult<AddressDetailDto>> GetByIdAsync(int id);
        Task<IDataResult<List<AddressDto>>> GetAllAsync();
        Task<IResult> RemoveAsync(int id);
    }
}
