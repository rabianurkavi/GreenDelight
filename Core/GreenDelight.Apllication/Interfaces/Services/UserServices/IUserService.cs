using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.UserDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.UserServices
{
    public interface IUserService
    {
        Task<UserDto> TakeUserInformation(string userName);
        Task<SuccessDataResult<UserDto>> TakeUserInfo(string username);
    }
}
