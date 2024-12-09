using GreenDelight.Application.Interfaces.Services.Logging;
using GreenDelight.Domain.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        // HTTP bağlam erişimi, log servisi ve logger için bağımlılık enjeksiyonu
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogService _logService;

        public ExceptionMiddleware(IHttpContextAccessor httpContextAccessor,ILogService logService)
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
                var (statusCode, errorResponse) = DetermineErrorResponse(ex);

                var userName = context.User?.Identity?.Name ?? "Anonim Kullanıcı";
                await _logService.AddLogAsync(new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace ?? "Yığın izleme bilgisi mevcut değil.", 
                    ErrorCode = statusCode, 
                    ErrorDetails = $"Kullanıcı: {userName} {DateTime.UtcNow} tarihinde bir hatayla karşılaştı.", 
                    RequestPath = context.Request.Path, 
                    HttpMethod = context.Request.Method, 
                    UserIpAddress = context.Connection?.RemoteIpAddress?.ToString(), 
                    Timestamp = DateTime.UtcNow 
                });

                // Konsol/dosya günlüğü için hata kaydı
                //_logger.LogError(ex, "İstek işlenirken bir hata oluştu");

                context.Response.StatusCode = statusCode;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonConvert.SerializeObject(errorResponse));
            }
        }

        private (int StatusCode, object ErrorResponse) DetermineErrorResponse(Exception ex)
        {
            return ex switch
            {
                UnauthorizedAccessException _ =>
                    (StatusCodes.Status401Unauthorized,
                     new { error = "Bu kaynağa erişim yetkiniz bulunmamaktadır." }),

                KeyNotFoundException _ =>
                    (StatusCodes.Status404NotFound,
                     new { error = "İstenen kaynak bulunamadı." }),

                ArgumentException _ =>
                    (StatusCodes.Status400BadRequest,
                     new { error = "Geçersiz istek parametreleri." }),

                DbUpdateException _ =>
                    (StatusCodes.Status409Conflict,
                     new { error = "Veritabanı işleminde bir çakışma oluştu." }),

                HttpRequestException _ =>
                    (StatusCodes.Status503ServiceUnavailable,
                     new { error = "Dış servis şu anda kullanılamıyor." }),

                _ => (StatusCodes.Status500InternalServerError,
                      new { error = "Beklenmedik bir hata oluştu. Lütfen daha sonra tekrar deneyin." })
            };
        }
    }
}
