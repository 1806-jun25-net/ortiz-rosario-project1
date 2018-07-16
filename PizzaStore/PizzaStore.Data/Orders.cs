using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Orders
    {
        public Orders()
        {
            PizzasTypes = new HashSet<PizzasTypes>();
        }

        public int OrderId { get; set; }
        public DateTime? OrderTimeStamp { get; set; }
        public decimal TotalPrice { get; set; }
        public int? UserIds { get; set; }
        public int? StoreId { get; set; }

        public Locations Store { get; set; }
        public Users UserIdsNavigation { get; set; }
        public ICollection<PizzasTypes> PizzasTypes { get; set; }
    }
}
