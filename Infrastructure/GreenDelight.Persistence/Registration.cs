using GreenDelight.Application.Interfaces.Repositories;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Application.Interfaces.Services.AdressServices;
using GreenDelight.Application.Interfaces.Services.AuthServices;
using GreenDelight.Application.Interfaces.Services.CategoryServices;
using GreenDelight.Application.Interfaces.Services.Logging;
using GreenDelight.Application.Interfaces.Services.ProductServices;
using GreenDelight.Domain.Concrete;
using GreenDelight.Persistence.Contexts;
using GreenDelight.Persistence.Repositories;
using GreenDelight.Persistence.Services.AdressServices;
using GreenDelight.Persistence.Services.AuthServices;
using GreenDelight.Persistence.Services.CategoryServices;
using GreenDelight.Persistence.Services.Logging;
using GreenDelight.Persistence.Services.ProductServices;
using GreenDelight.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenDelight.Application.Interfaces.Services.CommentServices;
using GreenDelight.Persistence.Services.CommentServices;
using GreenDelight.Application.Interfaces.Services.UserServices;
using GreenDelight.Persistence.Services.UserServices;
using GreenDelight.Application.Interfaces.Services.ContactServices;
using GreenDelight.Persistence.Services.ContactServices;
using GreenDelight.Application.Interfaces.Services.AboutServices;
using GreenDelight.Persistence.Services.AboutServices;

namespace GreenDelight.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GreenDelightDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ILogService, LogService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IAboutService, AboutService>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, GreenDelightDbContext>();

            services.AddHttpContextAccessor();
            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 2;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;
            }).AddRoles<UserRole>().AddEntityFrameworkStores<GreenDelightDbContext>();
        }
    }
}
