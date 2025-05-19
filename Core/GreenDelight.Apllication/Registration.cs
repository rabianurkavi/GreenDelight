using GreenDelight.Application.Exceptions;
using GreenDelight.Application.Rules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ExceptionMiddleware>();
            services.AddScoped<AuthRules>();
        }
    }
}
