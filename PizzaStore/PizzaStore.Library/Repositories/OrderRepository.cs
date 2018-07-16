using Microsoft.EntityFrameworkCore;
using PizzaStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore.Library.Repositories
{
    public class OrderRepository
    {
        private readonly PizzaStoreDBContext _db;

        public OrderRepository(PizzaStoreDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<PizzaStore.Data.Orders> GetOrders(string search = null)
        {
            List<Orders> orders = _db.Orders.AsNoTracking().ToList();
            return orders; 
            //return PizzaStoreMapper.Map(_db.Orders.Include(pz => pz.PizzasTypes).AsNoTracking().ToList());
        }

        public PizzaStore.Library.Order GetOrdersById(int id)
        {
            return PizzaStoreMapper.Map(_db.Orders.Include(o => o.OrderId)
                .AsNoTracking().First(x => x.UserIds == id)); 
        }


        public IEnumerable<Orders> GetLocationOrders(int store_id)
        {
           var orders_store_locations = _db.Orders.Where(l => l.StoreId == store_id).OrderByDescending(t => t.TotalPrice);
            return orders_store_locations; 
        }


        public void AddOrder(Order order)
        {
            _db.Add(PizzaStoreMapper.Map(order)); 
            
        }

        public void DeleteOrder(int orderId)
        {
            _db.Remove(_db.Orders.Find(orderId));
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
