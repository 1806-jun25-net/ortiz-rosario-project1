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

        

        public IEnumerable<Users> GetUsersWithNames()
        {
            List<Users> users = _db.Users.Include(u => u.UserIds).AsNoTracking().ToList();
            return users; 
        }

        public void AddUser(string firstName, string lastName, string phoneNumber)
        {
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            };
            _db.Add(user); 
        }

        public void DeleteById(int id)
        {
            var user = _db.Users.Find(id);
            if(user == null)
            {
                throw new ArgumentException("No such user id", nameof(id)); 
            }
            _db.Remove(user); 
        }
        
        public void EditUser(User user)
        {
            _db.Update(user);
        }

        public void SaveChanges()
        {
            _db.SaveChanges(); 
        }
    }

}
