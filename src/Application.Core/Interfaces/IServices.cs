using Application.Core.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Interfaces
{
    public interface IServices<T>
    {
        public Task<RegistroVM<T>> Guardar(RegistroVM<T> registroVM);
    }
}
