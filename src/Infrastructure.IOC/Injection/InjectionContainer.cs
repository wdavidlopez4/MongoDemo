﻿using Application.Core.Interfaces;
using Application.Core.Services;
using Domain.Interfaces;
using Infrastructure.DAL.Context;
using Infrastructure.DAL.Repository;
using Infrastructure.DAL.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Infrastructure.IOC.Injection
{
    public class InjectionContainer
    {
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

        //inyecta la configuracion de la db 
        public static void InyectarDbSettings(IServiceCollection services, IConfiguration Configuration)
        {
            //configura y selecciona el fracmento del json
            services.Configure<DbSettings>(
                Configuration.GetSection(nameof(DbSettings)));

            //inyecta la los datos a la clase dbsettings
            services.AddSingleton<IDbSettings>(sp =>
                sp.GetRequiredService<IOptions<DbSettings>>().Value);
        }

    }
}
