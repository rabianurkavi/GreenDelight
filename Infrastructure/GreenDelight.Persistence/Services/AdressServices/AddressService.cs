using GreenDelight.Application.DTOs.ProductDtos;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.AddressDtos;
using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Application.Interfaces.Services.AdressServices;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using IResult = GreenDelight.Domain.Results.IResult;
using GreenDelight.Application.DTOs.AddressDtos.City;
using GreenDelight.Application.DTOs.AddressDtos.District;
using GreenDelight.Application.DTOs.AddressDtos.Neighborhood;


namespace GreenDelight.Persistence.Services.AdressServices
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpClientFactory _httpclientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;

        #region Adress
        public AddressService(IUnitOfWork unitOfWork, IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpclientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IResult> AddAsync(AddressAddDto addressAddDto)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (userId == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                var addressDto = addressAddDto.Adapt<Adress>();
                addressDto.UserId = Guid.Parse(userId);
                await _unitOfWork.GetGenericRepository<Adress>().AddAsync(addressDto);
                await _unitOfWork.CommitAsync();

                return new SuccessResult(Messages.AddressAdded);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.AddressNotAdded);
            }
        }

        public async Task<IDataResult<List<AddressDetailDto>>> GetAllAsync()
        {
            try
            {
                var addresses = await _unitOfWork.GetGenericRepository<Adress>().GetAllAsync(
                    include: query => query
                        .Include(a => a.User)
                        .Include(a => a.Neighborhood)
                            .ThenInclude(m => m.District)
                                .ThenInclude(d => d.City),
                    enableTracking: false);

                var addressDto = addresses.Adapt<List<AddressDetailDto>>();
                return new SuccessDataResult<List<AddressDetailDto>>(addressDto, Messages.AddressesListed);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<AddressDetailDto>>("Adresler listelenirken bir hata oluştu.");
            }
        }

        public async Task<IDataResult<List<AddressDto>>> GetAllByUserIdAsync()
        {
            try
            {
                var claimUserId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (claimUserId == null)
                    return new ErrorDataResult<List<AddressDto>>("Kullanıcı bulunamadı.");

                var addresses = await _unitOfWork.GetGenericRepository<Adress>().GetAllAsync(
                    x => x.UserId == Guid.Parse(claimUserId),
                    include: query => query.Include(a => a.User));

                var addressDto = addresses.Adapt<List<AddressDto>>();
                return new SuccessDataResult<List<AddressDto>>(addressDto, Messages.AddressesListed);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<AddressDto>>("Adresler getirilirken hata oluştu.");
            }
        }

        public async Task<IDataResult<AddressDetailDto>> GetByIdAsync(int id)
        {
            try
            {
                var address = await _unitOfWork.GetGenericRepository<Adress>().GetAsync(
                    x => x.ID == id,
                    include: query => query
                        .Include(a => a.User)
                        .Include(a => a.Neighborhood)
                            .ThenInclude(m => m.District)
                                .ThenInclude(d => d.City),
                    enableTracking: false);

                if (address == null)
                    return new ErrorDataResult<AddressDetailDto>("Adres bulunamadı");

                var addressDto = address.Adapt<AddressDetailDto>();
                return new SuccessDataResult<AddressDetailDto>(addressDto, Messages.AddressesListed);
            }
            catch (Exception)
            {
                return new ErrorDataResult<AddressDetailDto>("Adres bilgisi alınırken hata oluştu.");
            }
        }

        public async Task<IResult> RemoveAsync(int id)
        {
            try
            {
                var adress = await _unitOfWork.GetGenericRepository<Adress>().GetAsync(x => x.ID == id);
                if (adress == null)
                    return new ErrorResult(Messages.AddressNotDeleted);

                await _unitOfWork.GetGenericRepository<Adress>().DeleteAsync(adress);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(Messages.AddressDeleted);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.AddressNotDeleted);
            }
        }

        public async Task<IResult> UpdateAsync(AddressUpdateDto addressUpdateDto)
        {
            try
            {
                var adress = await _unitOfWork.GetGenericRepository<Adress>().GetAsync(x => x.ID == addressUpdateDto.ID);
                if (adress == null)
                    return new ErrorResult("Güncellenecek adres bulunamadı.");

                var adressDto = addressUpdateDto.Adapt(adress);
                await _unitOfWork.GetGenericRepository<Adress>().UpdateAsync(adressDto);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(Messages.AddressUpdated);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.AddressNotUpdated);
            }
        }
        #endregion

        #region AdressSelections
        public async Task<IDataResult<List<CityDto>>> GetAllCity()
        {
            try
            {
                var cities = await _unitOfWork.GetGenericRepository<City>().GetAllAsync();
                var dto = cities.Adapt<List<CityDto>>();
                return new SuccessDataResult<List<CityDto>>(dto, Messages.CityListed);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<CityDto>>("Şehirler getirilirken hata oluştu.");
            }
        }

        public async Task<IDataResult<List<DistrictDto>>> GetAllDistrict(int cityId)
        {
            try
            {
                var districts = await _unitOfWork.GetGenericRepository<District>().GetAllAsync(x => x.CityId == cityId);
                var dto = districts.Adapt<List<DistrictDto>>();
                return new SuccessDataResult<List<DistrictDto>>(dto, Messages.DistrictListed);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<DistrictDto>>("İlçeler getirilirken hata oluştu.");
            }
        }

        public async Task<IDataResult<List<NeighborhoodDto>>> GetAllNeighborhood(int districtId)
        {
            try
            {
                var neighborhoods = await _unitOfWork.GetGenericRepository<Neighborhood>().GetAllAsync(x => x.DistrictId == districtId);
                var dto = neighborhoods.Adapt<List<NeighborhoodDto>>();
                return new SuccessDataResult<List<NeighborhoodDto>>(dto, Messages.NeighborhoodListed);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<NeighborhoodDto>>("Mahalleler getirilirken hata oluştu.");
            }
        }

        #endregion
    }
}
