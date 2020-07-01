using Domain.Interfaces;
using Infrastructure.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DAL.Repository
{
    public class Repository<T> : IModels<T> where T : class
    {
        private readonly DbContext<T> db;

        public Repository(DbContext<T> db)
        {
            this.db = db;
        }

        public async Task<T> Create(T objet)
        {
            await db.Collection.InsertOneAsync(objet);
            return objet;
        }

        public Task<bool> Delete(T objet)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T objet)
        {
            throw new NotImplementedException();
        }
    }
}
