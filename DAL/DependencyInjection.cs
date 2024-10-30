using DAL.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectDataAccesLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IDbContextIntializer), typeof(UrlDbContextIntilalizer));
            return services;
        }
    }
}
