using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library
{
    public class Order 
    {
        //public int PizzaSize { get; set; }
        //public int SelectingIng { get; set; }
        ////private int DrinkSelection { get; set; }d
        //public int QuantityPizzas { get; set; }
        //public string ToppingName { get; set; }
        //public double PriceTopp { get; set; }
        //public double Total { get; set; }
        //public double TotalWithTax { get; set; }
        //public string Decision { get; set; }
        //Total Value
        //public int PizzaOrderValue { get; set; }

        /*
         * Members and fields for the mapper connection
         */
        public int OrderID { get; set; }
        public decimal  Total_Price{ get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now; //Order Time 

        
       


        //public Location Location { get; set; }
        //public User User { get; set; }
       
        


        public DateTime GetOrderTime() => DateTime.Now;


        //public void HowMany()
        //{
        //    Console.WriteLine("Before to continue");
        //    Console.WriteLine("How many pizzas are in this order: ");

        //    try
        //    {
        //        QuantityPizzas = Convert.ToInt32(Console.ReadLine());

        //        if (QuantityPizzas < 0)
        //        {
        //            Console.WriteLine("Try again, you have to enter at least 1 pizza");
        //            QuantityPizzas = Convert.ToInt32(Console.ReadLine());
        //            Console.Clear();
        //        }
        //        else if (QuantityPizzas > 12)
        //        {
        //            Console.WriteLine("Try again, the order has a maximum of 12 pizzas");
        //            QuantityPizzas = Convert.ToInt32(Console.ReadLine());
        //            Console.Clear();
        //        }
        //        else
        //            CustomizingEachOne();

        //    }
        //    catch (FormatException m)
        //    {
        //        Console.WriteLine(m.Message);
        //        Console.WriteLine("Try again");
        //        QuantityPizzas = Convert.ToInt32(Console.ReadLine());
        //        Console.Clear();

        //    }
        //}



        //public void CustomizingEachOne()
        //{

        //    Console.WriteLine("You want to customize each one of them " +
        //        "or they will be same");
        //    Console.WriteLine("Select Y to customize or N to be the same");
        //    Console.WriteLine("If you enter one pizza, select N/n");
        //    Decision = Console.ReadLine();
        //    if (Decision == "Y" || Decision == "y")
        //    {
        //        for (int i = 1; i <= QuantityPizzas; --QuantityPizzas)
        //        {
        //            Console.WriteLine($"Pizza #{i}");
        //            SelectIngredients();

        //        }
        //    }
        //    else if (Decision == "N" || Decision == "n")
        //    {
        //        SelectIngredients();
        //    }
        //    else
        //        Console.WriteLine("Must select Y/N");

        //}

        ///*
        // * Part of the menu. 
        // * User can observe the pizzas sizes and prices. 
        // */
        //public void OrderSize()
        //{
            
        //    Console.WriteLine("Select the size of your Pizza: ");
        //    Console.WriteLine("1. Small, Price: $6.00");
        //    Console.WriteLine("2. Medium, Price: $9.00");
        //    Console.WriteLine("3. Large, $11.00");
        //    Console.WriteLine("4. X-Large, $15.00");
        //    Console.WriteLine("5. Cancel Order");
        //    PizzaSize = Convert.ToInt32(Console.ReadLine());

        //    do
        //    {
        //        switch (PizzaSize)
        //        {
        //            case 1:
        //                SelectIngredients();
        //                Console.Clear();
        //                break;

        //            case 2:
        //                SelectIngredients();
        //                Console.Clear();
        //                break;

        //            case 3:
        //                SelectIngredients();
        //                Console.Clear();
        //                break;

        //            case 4:
        //                SelectIngredients();
        //                Console.Clear();
        //                break;

        //            case 5:
        //                System.Environment.Exit(PizzaSize);
        //                break;

        //            default:
        //                Console.WriteLine("Must select the options that appear in the menu");
        //                Console.WriteLine("Try again");
        //                break;
        //        }
        //    } while (PizzaSize <= 6);

        //}



        //public void SelectIngredients()
        //{
            
        //    Console.WriteLine("Select the ingredients for your pizza: ");
        //    Console.WriteLine("1. Pepperoni, $1.00");
        //    Console.WriteLine("2. Sausage, $1.00");
        //    Console.WriteLine("3. Chorrizo, $1.00");
        //    Console.WriteLine("4. Chicken, $1.00");
        //    Console.WriteLine("5. Bacon, $1.00");
        //    Console.WriteLine("6. Cancel Order");
        //    try
        //    {
        //        SelectingIng = Convert.ToInt32(Console.ReadLine());
        //        while (SelectingIng < 0)
        //        {
        //            Console.WriteLine("There is no negative number, try again");
        //            SelectingIng = Convert.ToInt32(Console.ReadLine());
        //        }

        //        do
        //        {
                    
        //            switch (SelectingIng)
        //            { 
        //                case 1:
        //                    StockInventorySanJuan(); 
                           

        //                    //try
        //                    //{
        //                    //    for(int index = 0; index <= pizzaIngredients.Count; index++)
        //                    //    {
        //                    //        Console.WriteLine(index);
        //                    //    }
        //                    //    Console.WriteLine("Ingredient selected for your pizza: " + pizzaIngredients[0]);
        //                    //}
        //                    //catch (ArgumentOutOfRangeException m)
        //                    //{
        //                    //    Console.WriteLine(m.Message);
        //                    //    Console.ReadLine(); 
        //                    //}
        //                    //Console.WriteLine("The quantity of ingredients left are: " + pizzaIngredients[0].ToppingQuantity.ToString()); 


        //                    Console.ReadLine(); 
        //                    Console.Clear();
        //                    break;

        //                case 2:

        //                    Console.Clear();
        //                    break;

        //                case 3:

        //                    Console.Clear();
        //                    break;

        //                case 4:

        //                    Console.Clear();
        //                    break;

        //                case 5:

        //                    Console.Clear();
        //                    break;

        //                case 6:
        //                    System.Environment.Exit(SelectingIng);
        //                    Console.Clear();
        //                    break;

        //                default:
        //                    Console.WriteLine("Try again");
        //                    Console.Clear();
        //                    break;
        //            }

        //        } while (SelectingIng <= 7);
        //    }
        //    catch (FormatException m)
        //    {
        //        Console.WriteLine(m.Message);
        //        Console.WriteLine("Try again, must enter a number of the options");
        //        SelectingIng = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //public List<String> pizzaIngredients = new List<String>();
        //public string Topping { get; set; }
        //public int ToppingQuantity { get; set; }


        //public void StockInventorySanJuan()
        //{
        //    pizzaIngredients.InsertRange(0, new String[] { "Pepperoni", "Sausage", "Chorrizo", "Chicken", "Bacon" });

        //    for (int index = 0; index <= pizzaIngredients.Count; index++)
        //    {
        //        Console.WriteLine(index);
        //    }
        //    Console.WriteLine("Ingredient selected for your pizza: " + pizzaIngredients[0]);
        //}
        ////    pizzaIngredients.AddRange(new Order[]
        ////    {
        ////        Topping = "Pepperoni",
        ////        ToppingQuantity = 20
        ////    });

        ////    pizzaIngredients.Add(new Order
        ////    {
        ////        Topping = "Sausage",
        ////        ToppingQuantity = 20
        ////    });

        ////    pizzaIngredients.Add(new Order
        ////    {
        ////        Topping = "Chorrizo",
        ////        ToppingQuantity = 20
        ////    });

        ////    pizzaIngredients.Add(new Order
        ////    {
        ////        Topping = "Chicken",
        ////        ToppingQuantity = 20
        ////    });

        ////    pizzaIngredients.Add(new Order
        ////    {
        ////        Topping = "Bacon",
        ////        ToppingQuantity = 20
        ////    });
        ////}

        
       
        
        //public void ToppPrice()
        //{
        //    ToppingPrice.Add(new Order
        //    {
        //        ToppingName = "Pepperoni",
        //        PriceTopp = 1.00
        //    });

        //    ToppingPrice.Add(new Order
        //    {
        //        ToppingName = "Sausage",
        //        PriceTopp = 1.00
        //    });

        //    ToppingPrice.Add(new Order
        //    {
        //        ToppingName = "Chorrizo",
        //        PriceTopp = 1.00
        //    });

        //    ToppingPrice.Add(new Order
        //    {
        //        ToppingName = "Chicken",
        //        PriceTopp = 1.00
        //    });

        //    ToppingPrice.Add(new Order
        //    {
        //        ToppingName = "Bacon",
        //        PriceTopp = 1.00
        //    });
        //}

        //public void ProcessedPay()
        //{
        //    const double SmallPizza = 6.00;
        //    const double MediumPizza = 9.00;
        //    const double LargePizza = 11.00;
        //    const double XLargePizza = 15.00;
        //    const double PRTax = 11.5 / (double)100;

        //    Console.WriteLine("Final Value of the order: ");
        //    if (Total <= 500.00)
        //    {
        //        if (PizzaSize == 1)
        //        {
        //            Total = (QuantityPizzas * SmallPizza) + PriceTopp;
        //            TotalWithTax = (Total * PRTax) + Total;

        //        }
        //        else if (PizzaSize == 2)
        //        {
        //            Total = (QuantityPizzas * MediumPizza) + PriceTopp;
        //            TotalWithTax = (Total * PRTax) + Total;
        //        }

        //        else if (PizzaSize == 3)
        //        {
        //            Total = (QuantityPizzas * LargePizza) + PriceTopp;
        //            TotalWithTax = (Total * PRTax) + Total;
        //        }
        //        else
        //        {
        //            Total = (QuantityPizzas * XLargePizza) + PriceTopp;
        //            TotalWithTax = (Total * PRTax) + Total;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sorry, order should not exceed over $500");
        //        Console.WriteLine("Recommendations: Reduce the quatity of pizzas");
        //    }
        //}

    }
}
