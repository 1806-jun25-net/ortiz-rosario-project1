using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Data;
using System.Linq; 

namespace PizzaStore.Library
{
    public class User 
    {
        //public Location location { get; }

        //User's Id
        //Make reference connecting to the objects in the mapper
        //It should be generated with the DB
        public int Id { get; set; }

        //User's first name 
        //backing fields for the "First Name", "Last Name" and "Phone Number" properties
        //Will define and help me in the validation 
        private string _FName;
        //public string FirstName { get; set; }
        private string _LName;
        //public string LastName { get; set; }
        private string _Mobile;


        private string _ExistingUser; 
        //public int Options { get; set; }

       
        //Default Construstor 
        public User() { }

       
        
        public string FName
        {
            get => _FName;
            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException("First Name must not be empty", nameof(value));
                }
                _FName = value; 
            }
        }

        public string LName
        {
            get => _LName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name must not be empty", nameof(value));
                }
                _LName = value;
            }
        }
        public string PhoneNumber {
            get => _Mobile;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Phone number must not be empty", nameof(value));
                }
                _Mobile= value;
            }
        }


        public List<User> Users { get; set; } = new List<User>(); 

        /*
         * Search for existing users
         */
        //public string ExistingUser
        //{
        //    get
        //    {
        //        if()
        //        {

        //        }
        //    }
        //}










        /*
        * Once the program start, the user will be able to enter his info before
        * order. 
        */
    //    public void UserInfo()
    //    {
    //        Console.WriteLine("To order, follow the next steps: ");

    //        Console.WriteLine("Step 1: Create Account to Order: ");

    //        Console.WriteLine("First Name: ");
    //        FirstName = Console.ReadLine();

    //        Console.WriteLine("Last Name: ");
    //        LastName = Console.ReadLine();

    //        Console.WriteLine("Phone Number: ");
    //        PhoneNumber = Convert.ToString(Console.ReadLine());

    //        Console.Clear();
    //        do
    //        {

    //            Console.WriteLine("Select these options: ");
    //            Console.WriteLine("1. Continue with the order");
    //            Console.WriteLine("2. Cancel ");
    //            Options = Convert.ToInt32(Console.ReadLine());


    //            switch (Options)
    //            {
    //                case 1:
    //                    /*
    //                     * Store() 
    //                     * This method permits the user to select the location to continue
    //                     * with the order
    //                     * 
    //                     */
    //                    Store();
    //                    Console.Clear();
    //                    break;
    //                case 2:
    //                    /*
    //                     * Terminates this process and gives the underlying operating system the specified exit code 
    //                     * and close the program. 
    //                     */
    //                    Console.WriteLine("Cancelling Order......");
    //                    System.Environment.Exit(Options);
    //                    Console.Clear();
    //                    break;

    //                /*
    //                 * Validing input more than the 2 options presented 
    //                 */
    //                default:
    //                    Console.WriteLine("Must select Option 1 or Option 2");
    //                    Console.Clear();
    //                    break;
    //            }
    //        } while (Options <= 3);
    //        Console.Clear();
    //    }
    }

    
}

