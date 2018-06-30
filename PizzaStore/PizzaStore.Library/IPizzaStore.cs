using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library
{
    public interface IPizzaStore
    {
        string NamePizza{get; }
        int Ingredient { get; set; } 
    }
}
