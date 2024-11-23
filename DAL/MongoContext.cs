using DomainModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MongoContext
    {
        string connectionString;
        MongoClient client;
        IMongoDatabase database;

        public IMongoCollection<Pizza> PizzaCollection
        {
            get { return database.GetCollection<Pizza>("Pizza"); }
        }
        public void Seed()
        {
            PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
            //PizzaCollection.InsertMany(InitialData.PizzaList);
        }
        public MongoContext(string cs)
        {
            connectionString = cs;
            var connection = new MongoUrlBuilder(connectionString);
            MongoClient client = new MongoClient(connectionString);
            database = client.GetDatabase(connection.DatabaseName);

            if (PizzaCollection.CountDocuments(FilterDefinition<Pizza>.Empty) == 0) Seed();
        }
    }
}
