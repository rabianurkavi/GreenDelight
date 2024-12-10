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


namespace GreenDelight.Persistence.Services.AdressServices
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpClientFactory _httpclientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AddressService(IUnitOfWork unitOfWork, IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpclientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IResult> AddAsync(AddressAddDto addressAddDto)
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return new ErrorResult("Kullanıcı bulunamadı.");
            }
            var addressDto = addressAddDto.Adapt<Adress>();
            addressDto.UserId = Guid.Parse(userId);
            await _unitOfWork.GetGenericRepository<Adress>().AddAsync(addressDto);
            await _unitOfWork.CommitAsync();

            return new SuccessResult(Messages.AddressAdded);
        }

        public async Task<IDataResult<List<AddressDto>>> GetAllAsync()
        {
            var addresses = await _unitOfWork.GetGenericRepository<Adress>().GetAllAsync();

            var addressDto = addresses.Adapt<List<AddressDto>>();

            return new SuccessDataResult<List<AddressDto>>(addressDto, Messages.CategorysListed);
        }

        public async Task<IDataResult<AddressDetailDto>> GetByIdAsync(int id)
        {
            var address = await _unitOfWork.GetGenericRepository<Adress>().GetAsync(x => x.ID == id, include: query => query.Include(a => a.User), enableTracking: false);
            if (address == null)
            {
                return new ErrorDataResult<AddressDetailDto>("Adres bulunamadı");
            }
            var addressDto = address.Adapt<AddressDetailDto>();

            return new SuccessDataResult<AddressDetailDto>(addressDto, Messages.AddressesListed);

        }
        public async Task<IResult> RemoveAsync(int id)
        {
            var adress = await _unitOfWork.GetGenericRepository<Adress>().GetAsync(x => x.ID == id);
            if (adress == null)
            {
                return new ErrorResult("Adres silme işlemi başarısız.");
            }

            await _unitOfWork.GetGenericRepository<Adress>().DeleteAsync(adress);
            await _unitOfWork.CommitAsync();
            return new SuccessResult(Messages.AddressDeleted);
        }

        public async Task<IResult> UpdateAsync(AddressUpdateDto addressUpdateDto)
        {

            var adress = await _unitOfWork.GetGenericRepository<Adress>().GetAsync(x => x.ID == addressUpdateDto.ID);
            if (adress == null)
            {
                return new ErrorResult("Güncellenecek adres bulunamadı.Başarısız.");
            }
            var adressDto = addressUpdateDto.Adapt(adress);
            await _unitOfWork.GetGenericRepository<Adress>().UpdateAsync(adressDto);
            await _unitOfWork.CommitAsync();
            return new SuccessResult(Messages.AddressUpdated);

        }
    }
}
