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
        public static IList<Client> ClientList => new List<Client> { 
            new Client(){Address="г. Иваново, пл. Победы, д. 65",Id=3, FirstName="Никита", LastName="Крылов", Surname="Романович",
            Login="myname2", Password="mypassword", Phone="89003376723", Email="email100@dfr.ru"
            }
        };
        public static IList<Courier> CourierList => new List<Courier> {
            new Courier(){Id=10, FirstName="Николай", LastName="Морев", Surname="Валерьевич",
            Login="mylogin1", Password="mypassword", Phone="89003318989", Email="email3@dfr.ru"}
        };
        public static IList<Manager> ManagerList => new List<Manager> {
        new Manager(){Id=2, FirstName="Игорь", LastName="Хайрдинов", Surname="Юрьевич",
            Login="myname", Password="mypassword",Phone="89003334545", Email="email@dfr.ru"}
        };
        public static IList<DelStatus> DelStatusList => new List<DelStatus> { };
        public static IList<Order> OrderList => new List<Order> { };
        public static IList<OrderLine> OrderLineList => new List<OrderLine> { };
        public static IList<User> UserList => new List<User> {
            new User(){Id=2, FirstName="Игорь", LastName="Хайрдинов", Surname="Юрьевич",
            Login="myname", Password="mypassword",Phone="89003334545", Email="email@dfr.ru"
            },
            new User(){Id=3, FirstName="Никита", LastName="Крылов", Surname="Романович",
            Login="myname2", Password="mypassword", Phone="89003376723", Email="email100@dfr.ru"},
            new User(){Id=10, FirstName="Николай", LastName="Морев", Surname="Валерьевич",
            Login="mylogin1", Password="mypassword", Phone="89003318989", Email="email3@dfr.ru"}
        
        };
    }
}
