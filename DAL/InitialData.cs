using DomainModel;
using System;
using System.Windows;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL
{
    public static class InitialData
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            ImageConverter converter = new ImageConverter();
            byte[] xByte = (byte[])converter.ConvertTo(imageIn, typeof(byte[]));
            return xByte;
        }
        public static IList<PizzaSize> PizzaSizeList => new List<PizzaSize> { 
            new PizzaSize(){Id=1, Name="маленькая", Price=200, Weight=250},
            new PizzaSize(){Id=2, Name="средняя", Price=300, Weight=370},
            new PizzaSize(){Id=3, Name="большая", Price=400, Weight=510},
        };
        public static IList<Pizza> PizzaList => new List<Pizza>
        {
            new Pizza() {Id = 23, Name="Ветчина и сыр", Active=true, 
                Description="Вкусная пицца с ветчиной, моцареллой и соусом альфредо",
            Pizzaimage=DAL.Properties.Resources.hamandcheese}
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
        public static IList<DelStatus> DelStatusList => new List<DelStatus> {
            new DelStatus(){Id=1,Description="Не оформлен"},
            new DelStatus(){Id=2,Description="Отменен"},
            new DelStatus(){Id=3,Description="Формируется"},
            new DelStatus(){Id=5,Description="Передан курьеру"},
            new DelStatus(){Id=6,Description="Доставлен"},
            new DelStatus(){Id=7,Description="Не доставлен"},
            new DelStatus(){Id=8,Description="Передается в доставку"}

        };
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
