using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class PizzasTypes
    {
        public int PizzaId { get; set; }
        public string PizzaSizes { get; set; }
        public string PizzaName { get; set; }
        public int? OrderId { get; set; }
        public int PizzasQuantity { get; set; }

        public Orders Order { get; set; }
    }
}
