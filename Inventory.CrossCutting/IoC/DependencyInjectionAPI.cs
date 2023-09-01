using Inventory.Application.Mappings;
using Inventory.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Inventory.Infrastructure.Repositories.Interfaces;
using Inventory.Infrastructure.Repositories;
using Inventory.Application.Services;
using Inventory.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Inventory.CrossCutting.IoC;

public static class DependencyInjectionAPI
{
    public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<InventoryContext>(options =>
           options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                 new MySqlServerVersion(new Version(8, 0, 33))));

        services.AddIdentity<IdentityUser, IdentityRole>(options =>
        {
            //User
            options.SignIn.RequireConfirmedPhoneNumber = false;
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedAccount = false;

            //Password
            options.Password.RequireDigit = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 4;
        })
                .AddEntityFrameworkStores<InventoryContext>()
                .AddDefaultTokenProviders();

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["TokenKey"])),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });

        //Auto Mapper
        services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

        //Services
        services.AddScoped<IAddressingInventoryService, AddressingInventoryService>();
        services.AddScoped<IInventoryMovementService, InventoryMovementService>();
        services.AddScoped<IPerishableItemCountingService, PerishableItemCountingService>();
        services.AddScoped<IStockTakingService, StockTakingService>();

        //Repositories
        services.AddScoped<IGeneralRepository, GeneralRepository>();
        services.AddScoped<IAddressingInventoryRepository, AddressingInventoryRepository>();
        services.AddScoped<IInventoryMovementRepository, InventoryMovementRepository>();
        services.AddScoped<IPerishableItemCountingRepository, PerishableItemCountingRepository>();
        services.AddScoped<IStockTakingRepository, StockTakingRepository>();

        return services;
    }
}
