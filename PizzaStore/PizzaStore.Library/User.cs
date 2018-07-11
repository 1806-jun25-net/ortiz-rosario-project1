using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Data;
using System.Linq; 

namespace PizzaStore.Library
{
    public class User : Location
    {
        //public Location location { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Options { get; set; }

       
        //Default Construstor 
        public User() { }

        public User(string first, string last, string mobile)
        {
            FirstName = first;
            LastName = last;
            PhoneNumber = mobile;
        }
        
        /*
        * Once the program start, the user will be able to enter his info before
        * order. 
        */
        public void UserInfo()
        {
            Console.WriteLine("To order, follow the next steps: ");

            Console.WriteLine("Step 1: Create Account to Order: ");

            Console.WriteLine("First Name: ");
            FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            PhoneNumber = Convert.ToString(Console.ReadLine());

            Console.Clear();
            do
            {

                Console.WriteLine("Select these options: ");
                Console.WriteLine("1. Continue with the order");
                Console.WriteLine("2. Cancel ");
                Options = Convert.ToInt32(Console.ReadLine());


                switch (Options)
                {
                    case 1:
                        /*
                         * Store() 
                         * This method permits the user to select the location to continue
                         * with the order
                         * 
                         */
                        Store();
                        Console.Clear();
                        break;
                    case 2:
                        /*
                         * Terminates this process and gives the underlying operating system the specified exit code 
                         * and close the program. 
                         */
                        Console.WriteLine("Cancelling Order......");
                        System.Environment.Exit(Options);
                        Console.Clear();
                        break;

                    /*
                     * Validing input more than the 2 options presented 
                     */
                    default:
                        Console.WriteLine("Must select Option 1 or Option 2");
                        Console.Clear();
                        break;
                }
            } while (Options <= 3);
            Console.Clear();
        }
    }

    
}

