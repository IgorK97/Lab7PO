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
        public IMongoCollection<PizzaSize> PizzaSizeCollection
        {
            get { return database.GetCollection<PizzaSize>("PizzaSize"); }
        }
        public IMongoCollection<Client> ClientCollection
        {
            get { return database.GetCollection<Client>("Client"); }
        }
        public IMongoCollection<Courier> CourierCollection
        {
            get { return database.GetCollection<Courier>("Courier"); }
        }
        public IMongoCollection<DelStatus> DelStatusCollection
        {
            get { return database.GetCollection<DelStatus>("DelStatus"); }
        }
        public IMongoCollection<Ingredient> IngredientCollection
        {
            get { return database.GetCollection<Ingredient>("Ingredient"); }
        }
        public IMongoCollection<Manager> ManagerCollection
        {
            get { return database.GetCollection<Manager>("Manager"); }
        }
        public IMongoCollection<Order> OrderCollection
        {
            get { return database.GetCollection<Order>("Order"); }
        }
        public IMongoCollection<OrderLine> OrderLineCollection
        {
            get { return database.GetCollection<OrderLine>("OrderLine"); }
        }
        public IMongoCollection<User> UserCollection
        {
            get { return database.GetCollection<User>("User"); }
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

            //if (PizzaCollection.CountDocuments(FilterDefinition<Pizza>.Empty) == 0) Seed();
        }
    }
}
