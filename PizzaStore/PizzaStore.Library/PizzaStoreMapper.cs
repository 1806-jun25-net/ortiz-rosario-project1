using PizzaStore.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace PizzaStore.Library
{
    public class PizzaStoreMapper
    {

        /*
         * Users Mapper
         */
        public static PizzaStore.Library.User Map(Users user) => new User
        {
            Id = user.UserIds,
            LName = user.LastName,
            FName = user.FirstName,
            PhoneNumber = user.PhoneNumber,
            //Usuarios = Map(user.Locations).ToList() 
        };

        public static PizzaStore.Data.Users Map(User user) => new Data.Users
        {
             UserIds = user.Id,
                LastName = user.LName,
            FirstName = user.FName,
            PhoneNumber = user.PhoneNumber
        };

        /*
         * Locations Mapper 
         * 
         */

        public static PizzaStore.Library.Location Map(Locations loc) => new Location
        {
            StoreID = loc.StoreId, 
            OrderID = (int)loc.OrderId, 
            LocationStore = loc.StoreLocation

        };

        public static PizzaStore.Data.Locations Map(Location loc) => new Data.Locations
        {
            StoreId = loc.StoreID,
            OrderId = loc.OrderID, 
            StoreLocation = loc.LocationStore

        };

        /*
         * Orders Mapper
         */
        public static PizzaStore.Library.Order Map(Orders order) => new Order
        {
            OrderID = order.OrderId,
            Total_Price = order.TotalPrice, 
            OrderTime = order.OrderTimeStamp??DateTime.Now

        };

        public static PizzaStore.Data.Orders Map(Order order) => new Data.Orders
        {
            OrderId = order.OrderID,
            TotalPrice = order.Total_Price,
            OrderTimeStamp = order.OrderTime

        };


        /*
         * Pizza Mapper 
         */
        public static PizzaStore.Library.Pizza Map(PizzasTypes pizza) => new Pizza
        {
            PizzaID = pizza.PizzaId,
            Size = pizza.PizzaSizes,
            Name = pizza.PizzaName,
            P_Quantity = pizza.PizzasQuantity
        };

        public static PizzaStore.Data.PizzasTypes Map(Pizza pizza) => new Data.PizzasTypes
        {
            PizzaId = pizza.PizzaID, 
            PizzaName = pizza.Name, 
            PizzaSizes = pizza.Size,
            PizzasQuantity = pizza.P_Quantity
        };


        public static IEnumerable<PizzaStore.Library.User> Map(IEnumerable<PizzaStore.Data.Users> users) => users.Select(Map);
        public static IEnumerable<PizzaStore.Data.Users> Map(IEnumerable<User> users) => users.Select(Map);


        public static IEnumerable<PizzaStore.Library.Location> Map(IEnumerable<PizzaStore.Data.Locations> locations) => locations.Select(Map);
        public static IEnumerable<PizzaStore.Data.Locations> Map(IEnumerable<Location> locations) => locations.Select(Map);

        public static IEnumerable<PizzaStore.Library.Order> Map(IEnumerable<PizzaStore.Data.Orders> orders) => orders.Select(Map);
        public static IEnumerable<PizzaStore.Data.Orders> Map(IEnumerable<Order> orders) => orders.Select(Map);

        public static IEnumerable<PizzaStore.Library.Pizza> Map(IEnumerable<PizzaStore.Data.PizzasTypes> pizzas) => pizzas.Select(Map);
        public static IEnumerable<PizzaStore.Data.PizzasTypes> Map(IEnumerable<Pizza> pizzas) => pizzas.Select(Map); 
    }
}
