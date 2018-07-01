using PizzaStore.Library;
using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Project 1: Puerto Rico Pizza Application 
/// Author: Luis A. Ortiz Rosario 
/// Start Date: June 29, 2018
/// Main Method 
/// </summary>
namespace PizzaStore.UI
{
    public class Program
    {
        
        static void Main(string[] args)
        {
           
            User user = new User();
            Order order = new Order();
            User.GetCommandLine(); 
            Console.WriteLine("Welcome to Puerto Rico Pizza");
            Console.WriteLine("To order, follow the next steps: ");
            user.UserInfo();




            Console.ReadLine(); 

        }
    }
}
