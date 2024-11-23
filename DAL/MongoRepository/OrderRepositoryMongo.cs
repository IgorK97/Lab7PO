using DomainModel;
using Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoRepository
{
    public class OrderRepositoryMongo :IRepository<Order>
    {
        private MongoContext db;

        public OrderRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Order> GetList()
        {
            var builder = new FilterDefinitionBuilder<Order>();
            var filter = builder.Empty;

            return new List<Order>(db.OrderCollection.Find(filter).ToList());
        }

        public Order GetItem(int id)
        {
            return db.OrderCollection.Find(i => i.Id == id).FirstOrDefault();

        }

        public void Create(Order order)
        {
            Order last = db.OrderCollection.Find(new FilterDefinitionBuilder<Order>().Empty)
                .SortByDescending(i => i.Id).Limit(1).FirstOrDefault();
            order.Id = last != null ? last.Id + 1 : 1;
            db.OrderCollection.InsertOneAsync(order);
        }

        public void Update(Order order)
        {
            db.OrderCollection.ReplaceOneAsync(i => i.Id == order.Id, order);

        }

        public void Delete(int id)
        {
            db.OrderCollection.DeleteOneAsync(i => i.Id == id);

        }
    }
}
