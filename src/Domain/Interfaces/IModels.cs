using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModels<T>
    {
        public Task<T> Get(string id);

        public Task<IEnumerable<T>> Get();

        public Task<T> Create(T objet);

        public Task<bool> Delete(T objet);

        public Task<bool> Update(T objet);
    }
}
