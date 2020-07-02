using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModels
    {
        public Task<T> Get<T>(string id) where T : class;

        public Task<IEnumerable<T>> Get<T>() where T : class;

        public Task<T> Create<T>(T objet) where T : class;

        public Task<bool> Delete<T>(T objet) where T : class;

        public Task<bool> Update<T>(T objet) where T : class;
    }
}
