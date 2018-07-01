using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library
{
    public class Location
    {
        public int SelectingLocation { get; set; }


            /*
            * User select the location to order the pizza
            */

        public void Selection()
        {
           
                Console.WriteLine("Select the location of the Pizza: ");
                Console.WriteLine("1. San Juan");
                Console.WriteLine("2. Carolina");
                Console.WriteLine("3. Trujillo Alto");
                Console.WriteLine("Enter a location: ");
              do
                {
                    SelectingLocation = Convert.ToInt32(Console.ReadLine());

                
                    string L = " ";
                    if (SelectingLocation == 1)
                    {
                        L = " San Juan ";
                    }
                    else if (SelectingLocation == 2)
                    {
                        L = " Carolina ";
                    }
                    else if (SelectingLocation == 3)
                    {
                        L = "Trujillo Alto";
                    }
                    else
                        Console.WriteLine("Location not exist in the list");
                } while (SelectingLocation <=  3); 
        }

    }
}
