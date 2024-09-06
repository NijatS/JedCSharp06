using CarRent.Context;
using CarRent.Models;
using CarRent.Repositories;
using CarRent.Repositories.Interfaces;
using CarRent.Services;
using CarRent.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped<IMailService, MailService>();


builder.Services.AddDbContext<CarRentDbContext>(opt =>
{
    opt.UseSqlServer("Server=localhost;Database=CarRent;User Id=sa;Password=DB_Password;Encrypt=false;");
}, ServiceLifetime.Transient);


builder.Services.AddIdentity<AppUser,IdentityRole>(options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = true;
        options.Password.RequiredLength = 8;
        options.User.RequireUniqueEmail = true;
        options.Lockout.MaxFailedAccessAttempts = 3;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        options.SignIn.RequireConfirmedEmail = true;
    })
    .AddEntityFrameworkStores<CarRentDbContext>()
    .AddDefaultTokenProviders();

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

app.UseAuthorization();

app.UseEndpoints(endpoint =>
{
    endpoint.MapAreaControllerRoute(
        name: "admin",
        pattern: "admin/{controller=Account}/{action=Login}/{id?}",
        areaName: "admin"
    );

    endpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();