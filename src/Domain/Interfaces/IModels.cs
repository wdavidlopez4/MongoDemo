using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModels<T>
    {
        public T Get(string id);

        public IEnumerable<T> Get();

        public T Create(T objet);

        public bool Delete(T objet);

        public bool Update(T objet);
    }
}
