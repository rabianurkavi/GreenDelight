using GreenDelight.Application.DTOs.AboutDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.AboutServices
{
    public interface IAboutService
    {
        Task<IDataResult<AboutDto>> GetAbout();
    }
}
