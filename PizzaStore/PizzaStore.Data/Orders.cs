using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Orders
    {
        public Orders()
        {
            Pizzas = new HashSet<Pizzas>();
        }

        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ToppingPrice { get; set; }
        public int PizzaId { get; set; }

        
        public ICollection<Pizzas> Pizzas { get; set; }
    }
}
