using Application.Core.Interfaces;
using Application.Core.Services;
using Domain.Interfaces;
using Infrastructure.DAL.Context;
using Infrastructure.DAL.Repository;
using Infrastructure.DAL.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IOC.Injection
{
    public class InjectionContainer
    {
        public static void InyectarDbSettings(IServiceCollection services)
        {
            services.AddSingleton<IDbSettings, DbSettings>();
        }

        public static void InyectarDbContext(IServiceCollection services)
        {
            services.AddSingleton<IDbContext, DbContext>();
        }

        public static void InyectarModelos(IServiceCollection services)
        {
            services.AddScoped<IModels, Repository>();
        }

        public static void InyectarServicios(IServiceCollection services)
        {
            services.AddScoped<IServices, Servicio>();
        }
    }
}
