using GreenDelight.Application.DTOs.AddressDtos;
using GreenDelight.Application.DTOs.AddressDtos.City;
using GreenDelight.Application.DTOs.AddressDtos.District;
using GreenDelight.Application.DTOs.AddressDtos.Neighborhood;
using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Domain.Concrete;
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
        #region Adress
        Task<IResult> AddAsync(AddressAddDto addressAddDto);
        Task<IResult> UpdateAsync(AddressUpdateDto addressUpdateDto);
        Task<IDataResult<AddressDetailDto>> GetByIdAsync(int id);
        Task<IDataResult<List<AddressDetailDto>>> GetAllAsync();
        Task<IDataResult<List<AddressDto>>> GetAllByUserIdAsync();
        Task<IResult> RemoveAsync(int id);
        #endregion
        #region AdressSelections
        Task<IDataResult<List<CityDto>>> GetAllCity();
        Task<IDataResult<List<DistrictDto>>> GetAllDistrict(int cityId);
        Task<IDataResult<List<NeighborhoodDto>>> GetAllNeighborhood(int districtId);

        #endregion
    }
}
