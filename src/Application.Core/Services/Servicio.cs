using Application.Core.Interfaces;
using Application.Core.ViewModels;
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

        public async Task<RegistroVM<T>> Guardar<T>(RegistroVM<T> registroVM) where T : class
        {
            var objeto = registroVM.Objet;

            return new RegistroVM<T>()
            {
                Objet = await models.Create(objeto)
            };

        }

    }
}
