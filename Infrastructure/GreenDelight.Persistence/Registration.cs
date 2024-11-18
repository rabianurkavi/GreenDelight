using GreenDelight.Apllication.Interfaces.Repositories;
using GreenDelight.Apllication.Interfaces.UnitofWorks;
using GreenDelight.Application.Interfaces.Services.ProductServices;
using GreenDelight.Persistence.Contexts;
using GreenDelight.Persistence.Repositories;
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

namespace GreenDelight.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GreenDelightDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
