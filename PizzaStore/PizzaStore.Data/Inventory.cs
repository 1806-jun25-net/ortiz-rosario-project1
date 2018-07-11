using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Inventory
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int QuantityIngredients { get; set; }
        public int StoreId { get; set; }

        public Locations Store { get; set; }
    }
}
