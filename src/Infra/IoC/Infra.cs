using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.IoC
{
    public static class Infra
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<Context>(opt =>
            opt.UseSqlServer(config.GetConnectionString("Dev"), x =>
            x.MigrationsAssembly(typeof(Context).Assembly.FullName)));

            return services;
        }
    }
}
