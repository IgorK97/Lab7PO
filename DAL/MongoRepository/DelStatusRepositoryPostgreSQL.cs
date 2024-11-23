using DomainModel;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoRepository
{
    public class DelStatusRepositoryMongo :IRepository<DelStatus>
    {
        private PizzaDeliveryContext db;

        public DelStatusRepositoryMongo(PizzaDeliveryContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<DelStatus> GetList()
        {
            return db.DelStatuses.ToList();
        }

        public DelStatus GetItem(int id)
        {
            return db.DelStatuses.Find(id);
        }

        public void Create(DelStatus ds)
        {
            db.DelStatuses.Add(ds);
        }

        public void Update(DelStatus ds)
        {
            db.Entry(ds).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(int id)
        {
            DelStatus ds = db.DelStatuses.Find(id);
            if (ds != null)
                db.DelStatuses.Remove(ds);
        }
    }
}
