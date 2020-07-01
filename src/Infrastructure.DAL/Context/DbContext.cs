using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DAL.Context
{
    public class DbContext<T>
    {
        public IMongoCollection<T> Collection { get; }

        public DbContext(IDbSettings dbSettings)
        {
            var cliente = new MongoClient(dbSettings.ConnectionString);
            var database = cliente.GetDatabase(dbSettings.DatabaseName);

            Collection = database.GetCollection<T>(dbSettings.DatabaseName);
        }
    }
}
