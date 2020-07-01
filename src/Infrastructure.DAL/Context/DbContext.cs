using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DAL.Context
{
    public class DbContext<T>
    {
        private readonly IMongoCollection<T> mongoCollection;

        public DbContext(IDbSettings dbSettings)
        {
            var cliente = new MongoClient(dbSettings.ConnectionString);
            var database = cliente.GetDatabase(dbSettings.DatabaseName);

            mongoCollection = database.GetCollection<T>(dbSettings.DatabaseName);
        }
    }
}
