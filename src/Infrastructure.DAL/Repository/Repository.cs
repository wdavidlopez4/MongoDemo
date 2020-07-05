using Domain.Interfaces;
using Infrastructure.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DAL.Repository
{
    public class Repository : IModels
    {
        private readonly IDbContext db;

        public Repository(IDbContext db)
        {
            this.db = db;
        }

        public async Task<T> Create<T>(T objet) where T : class
        {
            try
            {
                await db.GetCollection<T>().InsertOneAsync(objet);
                return objet;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Task<bool> Delete<T>(T objet) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> Get<T>(string id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Get<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update<T>(T objet) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
