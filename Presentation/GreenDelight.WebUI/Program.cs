using GreenDelight.Persistence;
using GreenDelight.Infrastructure;
using GreenDelight.Application.Exceptions;
using Mapster;
using GreenDelight.Application;
using GreenDelight.Application.Mapping;
using GreenDelight.WebUI.Helper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("StripeSettings"));
MapsterConfig.RegisterMappings(TypeAdapterConfig.GlobalSettings);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.ConfigureExceptionHandlingMiddleware();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Index}/{id?}");

app.Run();
