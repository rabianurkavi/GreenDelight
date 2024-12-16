using GreenDelight.Application.Interfaces.Token;
using GreenDelight.Infrastructure.Tokens;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Infrastructure
{
    public static class Registration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<TokenSettings>(configuration.GetSection("JWT"));
            services.AddTransient<ITokenService, TokenService>();

            services.AddHttpClient();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                   .AddCookie(options =>
               {
                   options.LoginPath = "/Auth/Login"; // Giriş sayfası
                   options.LogoutPath = "/Auth/Logout"; // Çıkış işlemi
                   options.ExpireTimeSpan = TimeSpan.FromHours(1); // Cookie süresi
                   options.SlidingExpiration = true; // Yenilenen cookie süresi
                   options.AccessDeniedPath = "/Auth/AccessDenied"; // Yetkisiz erişim sayfası
                   options.Cookie.HttpOnly = true; // Güvenlik için
                   options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // HTTPS zorunlu
               });
        }
    }
}
