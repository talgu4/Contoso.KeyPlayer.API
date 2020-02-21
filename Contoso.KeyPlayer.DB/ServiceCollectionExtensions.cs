using Contoso.KeyPlayer.Common.Interfaces;
using Contoso.KeyPlayer.DB.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.KeyPlayer.DB
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            return services.AddScoped<IPlayerRepository, PlayerRepository>();
        }

        public static IServiceCollection RegisterDomainContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<KeyPlayerContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("KeyPlayerConnectionString"));
            });
        }
    }
}
