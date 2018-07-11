using PizzaStore.Data; 
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace PizzaStore.Library
{
    class PizzaStoreMapper
    {
        public static User Map(Data.Users otherUser) => new User
        {
            FirstName = otherUser.FirstName,
            LastName = otherUser.LastName,
            
            //PhoneNumber = otherUser.PhoneNumber
            //OrderTime = Map(otherUser.).SelectingIng(m => m.Id).ToList()
        };

        public static Data.Users Map(User otherUser) => new Data.Users
        {
            FirstName = otherUser.FirstName,
            LastName = otherUser.LastName

        };


        public static Order Map(Data.Orders otherOrder) => new Order
        {
            //ToppingPrice = otherOrder.ToppingPrice

        };
        //public static Location Map(Data.Locations otherLocation) => new Location
        //{
        //    SelectingLocation = otherLocation.StoreId, 
        //    //OrderHistory = Map(otherLocation.Orders).Select(o => o.Id).ToList()
        //};

        //public static Data.Locations Map(Location otherLocation) => new Data.Locations
        //{
        //    StoreId = otherLocation.SelectingLocation; 
        //}; 

        public static IEnumerable<User> Map(IEnumerable<Data.Users> otherUser) => otherUser.Select(Map);
        public static IEnumerable<Data.Users> Map(IEnumerable<User> otherUsers) => otherUsers.Select(Map);
    }

}
