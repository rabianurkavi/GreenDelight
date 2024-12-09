using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.AuthDtos.RegisterDtos;
using GreenDelight.Application.Helpers.JWT;
using GreenDelight.Application.Interfaces.Services.AuthServices;
using GreenDelight.Application.Interfaces.Token;
using GreenDelight.Application.Rules;
using GreenDelight.Domain.Concrete;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly RoleManager<UserRole> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ITokenService _tokenService;
        private readonly AuthRules _authRules;

        public AuthService(RoleManager<UserRole> roleManager, UserManager<User> userManager, IConfiguration configuration, ITokenService tokenService, AuthRules authRules)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _configuration = configuration;
            _tokenService = tokenService;
            _authRules = authRules;
        }


        public async Task<TokenResponse> LoginAsync(LoginDto loginDto)
        {
            var user= await _userManager.FindByEmailAsync(loginDto.Email);

            bool checkPassword= await _userManager.CheckPasswordAsync(user,loginDto.Password);

            await _authRules.EmailOrPasswordShouldNotBeInvalid(user, checkPassword);

            IList<string> roles= await _userManager.GetRolesAsync(user);

            //JWT TOKEN OLUŞTURMA
            var token = await _tokenService.CreateToken(user, roles);
            string refreshToken = _tokenService.GenerateRefreshToken();
            _ = int.TryParse(_configuration["JWT:RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

            //Refresh token bilgilerini güncelle
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime=DateTime.Now.AddDays(refreshTokenValidityInDays);

            // JWT token'ı string'e çevirme
            string _token = new JwtSecurityTokenHandler().WriteToken(token);

            // Token'ı kullanıcıya atama
            await _userManager.SetAuthenticationTokenAsync(user, "Default", "AccessToken", _token);

            return new TokenResponse
            {
                Token = _token,
                RefreshToken = refreshToken,
                Expiration = token.ValidTo,
            };
        }

        public async Task RegisterAsync(RegisterDto registerDto)
        {
            // Kullanıcı varlığını kontrol et
            await _authRules.UserShouldNotBeExist(await _userManager.FindByEmailAsync(registerDto.Email));

            var user = registerDto.Adapt<User>();
            IdentityResult result = await _userManager.CreateAsync(user, registerDto.Password);
            if (result.Succeeded)
            {
                if (!await _roleManager.RoleExistsAsync("user"))
                {
                    await _roleManager.CreateAsync(new UserRole
                    {
                        Id = Guid.NewGuid(),
                        Name = "user",
                        NormalizedName = "USER",
                        ConcurrencyStamp = Guid.NewGuid().ToString(),
                    });
                }

                await _userManager.AddToRoleAsync(user, "user");
            }
            else
            {
                // Hata yönetimi
                throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
    }
}
