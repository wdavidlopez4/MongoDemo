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
    public class Servicio<T> : IServices<T> where T : class
    {
        private readonly IModels<T> models;

        public Servicio(IModels<T> models)
        {
            this.models = models;
        }

        public async Task<RegistroVM<T>> Guardar(RegistroVM<T> registroVM)
        {
            var objeto = registroVM.Objet;

            return new RegistroVM<T>()
            {
                Objet = await models.Create(objeto)
            };

        }
    }
}
