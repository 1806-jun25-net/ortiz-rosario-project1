using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }


        public static string GetCommandLine()
        {
            return "HelloWorld";
        }

        /*
         * Once the program start 
         */
        public void UserInfo()
        {
            int sel;

            Console.WriteLine("Select one of the options: ");
            Console.WriteLine("Step 1: Create Account to Order: ");

            Console.WriteLine("\tFirst Name: ");
            FirstName = Console.ReadLine();

            Console.WriteLine("\tLast Name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("\tPhone Number: ");
            PhoneNumber = Convert.ToString(Console.ReadLine());

            sel = Convert.ToInt32(Console.ReadLine()); 

        }
        
        
    }
}

