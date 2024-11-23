using DomainModel;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoRepository
{
    public class IngredientRepositoryMongo : IRepository<Ingredient>
    {
        private PizzaDeliveryContext db;

        public IngredientRepositoryMongo(PizzaDeliveryContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Ingredient> GetList()
        {
            return db.Ingredients.ToList();
        }

        public Ingredient GetItem(int id)
        {
            return db.Ingredients.Find(id);
        }

        public void Create(Ingredient ingredient)
        {
            db.Ingredients.Add(ingredient);
        }

        public void Update(Ingredient ingredient)
        {
            db.Entry(ingredient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(int id)
        {
            Ingredient ingredient = db.Ingredients.Find(id);
            if (ingredient != null)
                db.Ingredients.Remove(ingredient);
        }
    }
}
