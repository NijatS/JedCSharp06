using System.Text.Json.Serialization;
using CarRent.Context;
using CarRent.Models;
using CarRent.Repositories;
using CarRent.Repositories.Interfaces;
using CarRent.Services;
using CarRent.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarRent;

public static class ServiceRegister
{
    public static void Register(this IServiceCollection services,IConfiguration configuration)
    {
         services.AddControllersWithViews().AddJsonOptions(x =>
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
         
         
         services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
         services.AddScoped<IMailService, MailService>();
         services.AddScoped<IAccountService, AccountService>();
         
        
         services.AddDbContext<CarRentDbContext>(opt =>
         {
             opt.UseSqlServer(configuration.GetConnectionString("Develop"));
         }, ServiceLifetime.Singleton);
         
         
        services.AddIdentity<AppUser,IdentityRole>(options =>
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
    }
}