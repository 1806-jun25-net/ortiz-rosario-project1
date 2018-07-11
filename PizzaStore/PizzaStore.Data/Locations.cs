using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Locations
    {
        public Locations()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int StoreId { get; set; }
        public string StoreLocation { get; set; }
        public int? UserIds { get; set; }

        public Users UserIdsNavigation { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
    }
}
