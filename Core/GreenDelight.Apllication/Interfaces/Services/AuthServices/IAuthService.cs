using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.AuthDtos.RegisterDtos;
using GreenDelight.Application.Helpers.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.AuthServices
{
    public interface IAuthService
    {
        Task<TokenResponse> LoginAsync(LoginDto loginDto);
        Task RegisterAsync(RegisterDto registerDto);
    }
}
