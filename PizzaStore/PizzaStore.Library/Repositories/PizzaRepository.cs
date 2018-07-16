using Microsoft.EntityFrameworkCore;
using PizzaStore.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Repositories
{
    class PizzaRepository
    {
        private readonly PizzaStoreDBContext _db;

        public PizzaRepository(PizzaStoreDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<PizzasTypes> GetPizzaName()
        {
            return _db.PizzasTypes.Include(p => p.PizzaName).AsNoTracking();
        }

        public IEnumerable<PizzasTypes> GetPizzasSizes()
        {
            return _db.PizzasTypes.Include(p => p.PizzaSizes).AsNoTracking();
        }

        public void AddPizzas(Pizza p)
        {
            _db.Add(PizzaStoreMapper.Map(p));
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
