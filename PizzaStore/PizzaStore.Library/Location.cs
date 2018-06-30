using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library
{
    public class Location : IPizzaStore
    {
        //public Dictionary<IPizzaStore> inventory = new Dictionary<string, int>();

       
       

       
            
        string IPizzaStore.NamePizza => throw new NotImplementedException();

        int IPizzaStore.Ingredient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
