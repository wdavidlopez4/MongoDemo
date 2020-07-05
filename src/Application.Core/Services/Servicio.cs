using Application.Core.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Services
{
    public class Servicio : IServices
    {
        private readonly IModels models;

        public Servicio(IModels models)
        {
            this.models = models;
        }

        public async Task<T> Guardar<T>(T objeto) where T : class
        {
            return await models.Create<T>(objeto);
        }

    }
}
