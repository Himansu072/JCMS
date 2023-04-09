using ExceptionHandling.Middlewares;
using JCMS.Repository.Container;
using JCMS.Repository.Context;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddCustomContainer(builder.Configuration);
builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Admin/Home/Index";
                options.AccessDeniedPath = "/Admin/Home/Index";
                options.Cookie.Name = ".AspNetCore.Cookies";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.SlidingExpiration = true;

            });
builder.Services.AddAntiforgery();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//app.UseSecurityHeadersMiddleware(new SecurityHeadersBuilder().AddDefaultSecurePolicy());
//Code here
app.UseStaticFiles();
DataSeed.Seed(app.Services).Wait();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.Run();
