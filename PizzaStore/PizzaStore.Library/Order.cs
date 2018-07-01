using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library
{
    public class Order
    {
        public int PizzaSize { get; set; }
        public int OrderIngredients { get; set; }
        
        public void OrderSize()
        {
           
            Console.WriteLine("Select the size of your Pizza: ");
            Console.WriteLine("1. Small, Price: $6.00");
            Console.WriteLine("2. Medium, Price: $9.00");
            Console.WriteLine("3. Large, $11.00");
            Console.WriteLine("4. X-Large, $15.00");
            PizzaSize = Convert.ToInt32(Console.ReadLine());

            string Size = " ";
            if (PizzaSize == 1)
            {
                Size = "Small";
            }
            else if (PizzaSize == 2)
            {
                Size = "Medium";
            }
            else if (PizzaSize == 3)
            {
                Size = "Large";
            }
            else if (PizzaSize == 4)
            {
                Size = "X-Large";
            }
            else
                Console.WriteLine("Must select a size"); 
        }

       

        public void OrderIngredients()
        {
            int selectingIng;
            Console.WriteLine("Select the ingredients for your pizza: ");
            Console.WriteLine("Max of ingredients: 3");
            Console.WriteLine("1. Cheese");
            Console.WriteLine("2. Pepperoni");
            Console.WriteLine("3. Onions");
            Console.WriteLine("4. Green Peppers");
            Console.WriteLine("5. Pineapple");
            Console.WriteLine("6. Bacon");
            selectingIng = Convert.ToInt32(Console.ReadLine());

            string I = " ";
            if (selectingIng == 1)
            {
                I = "Cheese";
            }
            else if (selectingIng == 2)
            {
                I = "Pepperoni";
            }
            else if (selectingIng == 3)
            {
                I = "Onions";
            }
            else if (selectingIng == 4)
            {
                I = "Green Peppers";
            }
            else if (selectingIng == 5)
            {
                I = "Pineapple";
            }
            else if (selectingIng == 6)
            {
                I = "Bacon";
            }
            else
                Console.WriteLine("Must select a least 3 ingredients: ");
        }

        public void OrderDrink()
        {
            Console.WriteLine("Select your drink: ");
            Console.WriteLine("1. Coca Cola");
            Console.WriteLine("2. Sprite");
            Console.WriteLine("3. Orange Fanta");
            int drinkSelection = Convert.ToInt32(Console.ReadLine());

            string D = " ";

            if (drinkSelection == 1)
            {
                D = " Coca Cola";
            }
            else if (drinkSelection == 2)
            {
                D = "Sprite";
            }
            else if (drinkSelection == 3)
            {
                D = "Fanta Orange";
            }
            else
                Console.WriteLine("Must select a drink");
        }
    }

}
