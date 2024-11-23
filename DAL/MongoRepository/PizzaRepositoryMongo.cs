using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Repository;
using DomainModel;
using DTO;
using DAL;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace DAL.MongoRepository
{
    public class PizzaRepositoryMongo :IRepository<Pizza>
    {
        private MongoContext db;

        public PizzaRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Pizza> GetList()
        {
            var builder = new FilterDefinitionBuilder<Pizza>();
            var filter = builder.Empty;

            return new List<Pizza>(db.PizzaCollection.Find(filter).ToList());
        }

        public Pizza GetItem(int id)
        {
            return db.PizzaCollection.Find(i => i.Id == id).FirstOrDefault();

        }

        public void Create(Pizza pizza)
        {
            Pizza last = db.PizzaCollection.Find(new FilterDefinitionBuilder<Pizza>().Empty)
                .SortByDescending(i => i.Id).Limit(1).FirstOrDefault();
            pizza.Id = last != null ? last.Id + 1 : 1;
            db.PizzaCollection.InsertOneAsync(pizza);
        }

        public void Update(Pizza pizza)
        {
            db.PizzaCollection.ReplaceOneAsync(i => i.Id == pizza.Id, pizza);

        }

        public void Delete(int id)
        {
            db.PizzaCollection.DeleteOneAsync(i => i.Id == id);
        }
    }
}
