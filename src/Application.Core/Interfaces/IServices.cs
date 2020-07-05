using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Interfaces
{
    public interface IServices
    {
        public Task<T> Guardar<T>(T registroVM) where T : class;
    }
}
