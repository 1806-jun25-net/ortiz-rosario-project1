using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Locations
    {
        public Locations()
        {
            Orders = new HashSet<Orders>();
        }

        public int StoreId { get; set; }
        public int? OrderId { get; set; }
        public string StoreLocation { get; set; }
        public int? UserIds { get; set; }

        public Users UserIdsNavigation { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
