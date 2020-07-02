using Infrastructure.DAL.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DAL.Context
{
    //falta utilizar el parametro CollectionName
    public class DbContext : IDbContext
    {
        //atributo que representa el cliente "servidor"
        private IMongoClient cliente;

        //atributo que representa la db 
        private IMongoDatabase database;

        //atributo que representa el nombre de la coleccion
        private string collectionName;

        //constructor "llama al connet para conectarse"
        public DbContext(IDbSettings dbSettings)
        {
            Connect<IDbSettings>(dbSettings);
        }

        //nos conectamos a la db "en lo que sea en lo que se comvierte T, eso debe implementar IDbSettings"
        public bool Connect<T>(T dbSettings) where T : IDbSettings
        {
            //nos conectamos a la db
            cliente = new MongoClient(dbSettings.ConnectionString);
            database = cliente.GetDatabase(dbSettings.DatabaseName);

            //obtenemos el nombre de la coleccion
            collectionName = dbSettings.CollectionName;

            if(database != null)
            {
                return true;
            }
            return false;
        }

        //debolvemos la colleccion
        public IMongoCollection<U> GetCollection<U> () where U : class
        {
            IMongoCollection<U> Collection = database.GetCollection<U>(collectionName);
            return Collection;
        }

    }
}
