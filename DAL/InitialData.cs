using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class InitialData
    {
        public static IList<PizzaSize> PizzaSizeList => new List<PizzaSize> {  };
        public static IList<Pizza> PizzaList => new List<Pizza>
        {
            new Pizza() {Id = 1, Name="Моцарелла" }
        };
        public static IList<Ingredient> IngredientList => new List<Ingredient> { };
        public static IList<Client> ClientList => new List<Client> { };
        public static IList<Courier> CourierList => new List<Courier> { };
        public static IList<Manager> ManagerList => new List<Manager> { };
        public static IList<DelStatus> DelStatusList => new List<DelStatus> { };
        public static IList<Order> OrderList => new List<Order> { };
        public static IList<OrderLine> OrderLineList => new List<OrderLine> { };
        public static IList<User> UserList => new List<User> { };
    }
}
