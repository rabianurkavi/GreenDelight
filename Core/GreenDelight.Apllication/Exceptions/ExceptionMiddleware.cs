using GreenDelight.Application.Interfaces.Services.Logging;
using GreenDelight.Domain.Concrete;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Exceptions
{
    public class ExceptionMiddleware : IMiddleware
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogService _logService;

        public ExceptionMiddleware(IHttpContextAccessor httpContextAccessor, ILogService logService)
        {
            _httpContextAccessor = httpContextAccessor;
            _logService = logService;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                // Hata loglarını veritabanına kaydediyoruz.
                await _logService.AddLogAsync(new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    RequestPath = context.Request.Path,
                    HttpMethod = context.Request.Method,
                    UserIpAddress = context.Connection?.RemoteIpAddress?.ToString(),
                    Timestamp = DateTime.UtcNow
                });

                // Hata yönetimi sonrası istemciye uygun bir yanıt gönderilebilir.
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                {
                    error = "An unexpected error occurred. Please try again later."
                }));
            }
        }
    }
}
