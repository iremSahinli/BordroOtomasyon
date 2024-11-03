using BordroOtomasyon.Infrastructure.Context;
using BordroOtomasyon.Infrastructure.Repositories.TediyeRepositories;
using BordroOtomasyon.Infrastructure.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Extentions
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseLazyLoadingProxies();
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<ITediyeRepository, TediyeRepository>();

            //AdminSeed kısmı migrate update için kapatılmalı!!
            AdminSeed.SeedAsync(configuration).GetAwaiter().GetResult();
            return services;
        }
    }
}
