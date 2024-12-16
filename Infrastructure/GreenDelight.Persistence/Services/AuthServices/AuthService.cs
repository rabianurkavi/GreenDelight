using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.AuthDtos.RegisterDtos;
using GreenDelight.Application.Helpers.JWT;
using GreenDelight.Application.Interfaces.Services.AuthServices;
using GreenDelight.Application.Interfaces.Token;
using GreenDelight.Application.Rules;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GreenDelight.Persistence.Services.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly RoleManager<UserRole> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ITokenService _tokenService;
        private readonly AuthRules _authRules;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthService(RoleManager<UserRole> roleManager, UserManager<User> userManager, IConfiguration configuration, ITokenService tokenService, AuthRules authRules, IHttpContextAccessor httpContextAccessor)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _configuration = configuration;
            _tokenService = tokenService;
            _authRules = authRules;
            _httpContextAccessor = httpContextAccessor;
        }
        //public async Task<IDataResult<TokenResponse>> LoginAsync(LoginDto loginDto)
        //{

        //    var user = await _userManager.FindByEmailAsync(loginDto.Email);
        //    if (user == null) return new ErrorDataResult<TokenResponse>("E-posta adresi bulunamadı.");

        //    if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
        //        return new ErrorDataResult<TokenResponse>("Girdiğiniz şifre yanlıştır.");

        //    //bool checkPassword= await _userManager.CheckPasswordAsync(user,loginDto.Password);
        //    //await _authRules.EmailOrPasswordShouldNotBeInvalid(user, checkPassword);

        //    IList<string> roles = await _userManager.GetRolesAsync(user);

        //    //JWT TOKEN OLUŞTURMA
        //    var token = await _tokenService.CreateToken(user, roles);
        //    string refreshToken = _tokenService.GenerateRefreshToken();
        //    _ = int.TryParse(_configuration["JWT:RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

        //    //Refresh token bilgilerini güncelle
        //    user.RefreshToken = refreshToken;
        //    user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

        //    // JWT token'ı string'e çevirme
        //    string _token = new JwtSecurityTokenHandler().WriteToken(token);

        //    // Token'ı kullanıcıya atama
        //    await _userManager.SetAuthenticationTokenAsync(user, "Default", "AccessToken", _token);

        //    var tokenResponse = new TokenResponse
        //    {
        //        Token = _token,
        //        RefreshToken = refreshToken,
        //        Expiration = token.ValidTo
        //    };
        //    return new SuccessDataResult<TokenResponse>(tokenResponse, "Giriş başarılı.");
        //}

        public async Task<IDataResult<bool>> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
                return new ErrorDataResult<bool>("E-posta adresi bulunamadı.");

            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return new ErrorDataResult<bool>("Girdiğiniz şifre yanlıştır.");

            IList<string> roles = await _userManager.GetRolesAsync(user);

            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Name, user.UserName),
        new Claim(ClaimTypes.Email, user.Email)
    };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            foreach (var claim in claims)
            {
                var existingClaim = await _userManager.GetClaimsAsync(user);
                if (!existingClaim.Any(c => c.Type == claim.Type && c.Value == claim.Value))
                {
                    await _userManager.AddClaimAsync(user, claim);
                }
            }

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true, //oturum kalıcı
                ExpiresUtc = DateTime.UtcNow.AddHours(1)
            };

            await _httpContextAccessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return new SuccessDataResult<bool>(true, "Giriş başarılı.");
        }
        public async Task LogoutAsync()
        {
            await _httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
        public async Task RegisterAsync(RegisterDto registerDto)
        {
            // Kullanıcı varlığını kontrol et
            await _authRules.UserShouldNotBeExist(await _userManager.FindByEmailAsync(registerDto.Email));

            var user = registerDto.Adapt<User>();
            IdentityResult result = await _userManager.CreateAsync(user, registerDto.Password);
            if (result.Succeeded)
            {
                // Varsayılan 'user' rolünü oluştur
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

                // Kullanıcıyı 'user' rolüne ekle
                await _userManager.AddToRoleAsync(user, "user");

                // Kullanıcının Claims'lerini oluştur
                var roles = await _userManager.GetRolesAsync(user);
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.Email, user.Email)
        };

                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                foreach (var claim in claims)
                {
                    var existingClaims = await _userManager.GetClaimsAsync(user);
                    if (!existingClaims.Any(c => c.Type == claim.Type && c.Value == claim.Value))
                    {
                        await _userManager.AddClaimAsync(user, claim);
                    }
                }


                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(1)
                };

                await _httpContextAccessor.HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
            }
            else
            {

                throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
    }
}
