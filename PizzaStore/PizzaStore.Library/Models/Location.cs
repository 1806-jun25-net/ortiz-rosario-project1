using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library
{
    public class Location 
    {
        //public int SelectingLocation { get; set; }
        //public DateTime OrderHistory { get; set; }
        //public int RejectedOrder { get; set; }
        //public int StockDecrease { get; set; }

        public int StoreID { get; set; }
        public int OrderID { get; set; }
        public string LocationStore { get; set; }



        /*
        * User select the location to order the pizza
        */


        //public void Store()
        //{

        //    Console.WriteLine("Select the available location to order: ");
        //    Console.WriteLine("1. San Juan");
        //    Console.WriteLine("2. Carolina");
        //    Console.WriteLine("3. Trujillo Alto");
        //    Console.WriteLine("4. Cancel Order");
        //    Console.WriteLine("Enter a location: ");

        //    try {
        //           int SelectingLocation = Convert.ToInt32(Console.ReadLine());
        //            do
        //            {
        //                switch (SelectingLocation)
        //                {
        //                    case 1:
        //                        HowMany();
        //                        Console.Clear();
        //                        break;
        //                    case 2:
        //                        HowMany();
        //                        Console.Clear();
        //                        break;
        //                    case 3:
        //                        HowMany();
        //                        Console.Clear();
        //                        break;
        //                    case 4:
        //                        System.Environment.Exit(SelectingLocation);
        //                        break;
        //                    default:
        //                        Console.WriteLine("Must select options from 1 to 4");
        //                        break;
        //                }
        //            } while (SelectingLocation <= 5);

        //    }
        //    catch(FormatException m)
        //    { 
        //        Console.WriteLine(m.Message);
        //        Console.WriteLine("Try again");
        //        int SelectingLocation = Convert.ToInt32(Console.ReadLine());
        //    }

    }
}
