using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.AboutDtos;
using GreenDelight.Application.Interfaces.Services.AboutServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AboutService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<AboutDto>> GetAbout()
        {
            try
            {
                var result = await _unitOfWork.GetGenericRepository<About>().GetAsync(x => x.Status == true);

                if (result == null)
                {
                    return new ErrorDataResult<AboutDto>("Herhangi bir hakkımızda yazısı bulunmamaktadır.");
                }

                var aboutDto = result.Adapt<AboutDto>();
                return new SuccessDataResult<AboutDto>(aboutDto, Messages.AboutList);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<AboutDto>($"Hakkımızda bilgisi getirilirken bir hata oluştu: {ex.Message}");
            }
        }
    }

}
