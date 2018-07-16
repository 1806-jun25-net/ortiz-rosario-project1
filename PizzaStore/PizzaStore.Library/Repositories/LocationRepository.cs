using Microsoft.EntityFrameworkCore;
using PizzaStore.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Repositories
{
    class LocationRepository
    {
        private readonly PizzaStoreDBContext _db;

        public LocationRepository(PizzaStoreDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }


        public IEnumerable<PizzaStore.Library.Location> GetLocations(string search = null)
        {
            return PizzaStoreMapper.Map(_db.Locations);

        }

        public void AddLocation(PizzaStore.Library.Location location)
        {
            _db.Add(PizzaStoreMapper.Map(location));
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
