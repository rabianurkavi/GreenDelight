using GreenDelight.Apllication.DTOs.UserDtos;
using GreenDelight.Application.Interfaces.Token;
using GreenDelight.Domain.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Infrastructure.Tokens
{
    public class TokenService : ITokenService
    {
        private readonly UserManager<User> _userManager;
        private readonly TokenSettings _tokenSettings;

        public TokenService(UserManager<User> userManager, IOptions<TokenSettings> options)
        {
            _userManager = userManager;
            _tokenSettings = options.Value;
        }
        public async Task<JwtSecurityToken> CreateToken(User user, IList<string> roles)
        {

            //hem uygulamaya girişimiz için claim lazım authentitation işlemleri için lazım olacak
            //
            var claims = new List<Claim>()
            {
                //jti bu claimnames tarafındaki jwt idimizi temsil ediyor
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                //jwt id ile beraber 
                //sistemimize giriş yapan kişilerin id sini göreceğiz bununla birlikte hem jwt idsi ile beraber tokenımızın güvenliğini arttıracağız
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenSettings.SecretKey));

            var token = new JwtSecurityToken(
                issuer: _tokenSettings.Issuer, // Token'ın üreticisi
                audience: _tokenSettings.Audience, // Token'ın hedef kitlesi
                expires: DateTime.Now.AddMinutes(_tokenSettings.TokenValidityInMinutes),
                claims: claims,
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            await _userManager.AddClaimsAsync(user, claims);

            return token;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        //tokena istek attıktan sonra son tokenıma erişiyor olmam lazım buna göre bu son access tokenın süresinin dolup dolmadığını kontrol etmem gerekiyor
        //Süresi dolmuş bir token’dan kullanıcı bilgilerini (ClaimsPrincipal) almak.
        //ValidateIssuer, ValidateAudience, ValidateLifetime: Geçersiz (false) ayarlanır çünkü süresi dolmuş bir token’ı doğruluyoruz.

        public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
        {
            TokenValidationParameters tokenValidationParameters = new()
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateIssuerSigningKey = false,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenSettings.SecretKey)),
                ValidateLifetime = false,
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            if (securityToken is not JwtSecurityToken jwtSecurityToken
                || !jwtSecurityToken.Header.Alg
                .Equals(SecurityAlgorithms.HmacSha256,
                StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Token bulunamadı.");

            return principal;
        }
    }
}
