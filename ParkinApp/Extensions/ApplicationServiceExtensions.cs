using Microsoft.EntityFrameworkCore;
using ParkinApp.Domain.Abstractions.Services;
using ParkinApp.Persistence.Data;
using ParkinApp.Services;

namespace ParkinApp.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration config)
    {
        services.AddDbContext<ParkingDbContext>(opt =>
        {
            opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }); 
        services.AddCors();
        services.AddScoped<ITokenService, TokenService>();

        return services;
    }
}
    
