using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Users
    {
        public Users()
        {
            Locations = new HashSet<Locations>();
            Orders = new HashSet<Orders>();
        }

        public int UserIds { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int? StoreId { get; set; }

        public ICollection<Locations> Locations { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
