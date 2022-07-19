using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application;
using Vuelos.Domain.Repositories;
using Vuelos.Infraestructure.EF;
using Vuelos.Infraestructure.EF.Contexts;
using Vuelos.Infraestructure.EF.Repository;
using Vuelos.Infraestructure.MemoryRepository;

namespace Vuelos.Infraestructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddApplication();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            /*
            var connectionString =
                configuration.GetConnectionString("VueloDbConnectionString");

            services.AddDbContext<ReadDbContext>(context =>
                context.UseSqlServer(connectionString));
            services.AddDbContext<WriteDbContext>(context =>
                context.UseSqlServer(connectionString));
            */
            services.AddScoped<IItinerarioRepository, ItinerarioRepository>();
            services.AddScoped<IVueloRepository, VueloRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            /*
            services.AddScoped<IVueloRepository, VueloRepository>();
            services.AddScoped<IItinerarioRepository, ItinerarioRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            */
            //TODO: Eliminar despues. Solo para proposito de pruebas
            //services.AddSingleton<MemoryDatabase>();
            //services.AddScoped<IVueloRepository, MemoryVueloRepository>();



            return services;
        }

    }
}
