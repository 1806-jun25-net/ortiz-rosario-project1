using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Data;

namespace PizzaStore.Library.Repositories
{
    
    public class UserRepository
    {
        private readonly PizzaStoreDBContext _db;

        public UserRepository(PizzaStoreDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db)); 
        }

       
        public IEnumerable<PizzaStore.Library.User> GetUserFirstName(string search = null)
        {
            if(search == null)
            {
                 return PizzaStoreMapper.Map(_db.Users.Include(o => o.Orders).AsNoTracking());
            }
            else
            {
                return PizzaStoreMapper.Map(_db.Users.Include(o => o.Orders)
                    .AsNoTracking().Where(x => x.FirstName.Contains(search)));
            }
           
        }

        public IEnumerable<PizzaStore.Library.User> GetUserLastName(string search = null)
        {
            if (search == null)
            {
                return PizzaStoreMapper.Map(_db.Users.Include(o => o.Orders).AsNoTracking());
            }
            else
            {
                return PizzaStoreMapper.Map(_db.Users.Include(o => o.Orders)
                    .AsNoTracking().Where(z => z.LastName.Contains(search                                           )));
            }

        }

        public IEnumerable<PizzaStore.Library.User> GetUserPhoneNumber(string search = null)
        {
            if (search == null)
            {
                return PizzaStoreMapper.Map(_db.Users.Include(o => o.Orders).AsNoTracking());
            }
            else
            {
                return PizzaStoreMapper.Map(_db.Users.Include(o => o.Orders)
                    .AsNoTracking().Where(p => p.PhoneNumber.Contains(search)));
            }

        }
        public User GetUsersByID(int id)
        {
            return PizzaStoreMapper.Map(_db.Users.Include(o => o.Orders)
                .AsNoTracking().First(y => y.UserIds == id));
        }


        public void AddUserFirstName(User first_Name)
        {
            
            _db.Add(PizzaStoreMapper.Map(first_Name)); 
        }

        public void AddUserLastName(User last_Name)
        {
            _db.Add(PizzaStoreMapper.Map(last_Name));
        }

        public void AddUserPhoneNumber(User phone_Number)
        {
            _db.Add(PizzaStoreMapper.Map(phone_Number)); 
        }

        public void AddUsertoDB(User user)
        {
            _db.Add(PizzaStoreMapper.Map(user));
        }

        public void DeleteUser(int userId)
        {
            _db.Remove(_db.Users.Find(userId)); 

            //var users = _db.Users; 
            //foreach(var user in users)
            //{
            //    if(firstName == user.FirstName && lastName == user.LastName)
            //    {
            //        _db.Remove(user); 
            //    }
            //}
        }

        //public List<Order> GetUserHistory(User user)
        //{
        //    var orders = _db.Orders;
        //    List<User> ListOfOrders = new List<User>();
        //    foreach (var item in orders)
        //    {
        //        if (user.Id == item.UserIds)
        //        {
        //            ListOfOrders.Add(PizzaStoreMapper.Map(item));
        //        }
        //    }
        //    return ListOfOrders;
        //}

        public void Save()
        {
            _db.SaveChanges(); 
        }
    }

}
