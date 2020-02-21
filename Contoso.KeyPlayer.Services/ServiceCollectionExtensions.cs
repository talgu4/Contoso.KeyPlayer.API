using Contoso.KeyPlayer.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.KeyPlayer.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            return service.AddScoped<IPlayerService, PlayerService>();
        }
    }
}
