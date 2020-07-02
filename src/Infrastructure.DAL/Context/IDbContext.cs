using Infrastructure.DAL.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DAL.Context
{
    public interface IDbContext
    {
        public bool Connect<T>(T dbSettings) where T : IDbSettings;

        public IMongoCollection<T> GetCollection<T>() where T : class;
    }
}
