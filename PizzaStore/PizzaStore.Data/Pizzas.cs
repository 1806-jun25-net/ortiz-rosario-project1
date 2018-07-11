using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Pizzas
    {
        public int PizzaId { get; set; }
        public decimal PizzaPrice { get; set; }
        public string PizzaSizes { get; set; }
        public decimal ToppingPrice { get; set; }
        public int IngredientId { get; set; }
        public int? OrderId { get; set; }

        public Orders Order { get; set; }
    }
}
