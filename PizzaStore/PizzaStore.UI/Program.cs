using PizzaStore.Library;
using Microsoft.Extensions.Configuration; 
using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Data;
using PizzaStore.Library.Repositories;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

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
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            //Console.WriteLine(configuration.GetConnectionString("PizzaStoreDB"));
            //var configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<PizzaStoreDBContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("PizzaStoreDB"));
            var options = optionsBuilder.Options;

            var dbContext = new PizzaStoreDBContext(options);
            var userRepository = new UserRepository(dbContext);
            var serializer = new XmlSerializer(typeof(List<User>));

            
            Console.WriteLine("Welcome to Puerto Rico Pizza");
            Console.WriteLine();

           
                Console.WriteLine("1. New User ");
                Console.WriteLine("2. Existing User ");
                Console.WriteLine("3. Restaurant Menu "); 
                Console.WriteLine("4. Exit Program ");
                Console.WriteLine("Please, choose an option: "); 
                var selection = Convert.ToInt32(Console.ReadLine());
                Console.Clear(); 
                switch(selection)
                {
                    case 1:
                        Console.WriteLine();
                        var user = new User();
                        Console.WriteLine("Welcome!!!!!");
                        Console.WriteLine("Enter the following information required to create an account");

                        while (user.FName == null)
                        {
                            
                            Console.WriteLine("First Name: ");
                            var input = Console.ReadLine();
                            user.FName = input; 
                            
                        }
                        userRepository.AddUser(user);
                        userRepository.Save(); 

                        while(user.LName == null)
                        {
                            Console.WriteLine("Last Name: ");
                            var input = Console.ReadLine(); 
                        }

                        while (user.PhoneNumber == null)
                        {
                            Console.WriteLine("Phone Number: ");
                            var input = Convert.ToString(Console.ReadLine());
                            
                        }
                        
                    break;
                    case 2:
                        break;


                    case 3:

                    Console.WriteLine("Our crust is hand-tossed with garlic on the border");
                    Console.WriteLine("Convered with high quality Mozzarella Cheese and " +
                        "homemade Marinara Salsa");
                    Console.WriteLine();
                    Console.WriteLine("Make your pizza with our toppings!!!"); 
                    Console.WriteLine("Toppings: ");
                    Console.WriteLine("1. Pepperoni");
                    Console.WriteLine("2. Sausage");
                    Console.WriteLine("3. Chorizo");
                    Console.WriteLine("4. Chicken");
                    Console.WriteLine("5. Bacon");
                    Console.WriteLine();
                    Console.WriteLine("/t/t This menu is for showing. Thank You!!!");
                    Console.WriteLine("Type B/b to go back to menu to place order");
                   
                    var input1 = Console.ReadLine();
                    if(input1 == "B" || input1 == "b")
                    {
                        goto case 1; 
                    }
                    //else
                    //    while(input1 )
                       

                    
                    
                        break;

                case 4:
                    break; 
                    default:
                        break; 
                    
                }
      
            
            Console.Clear(); 

            //var repo = new UserRepository(new PizzaStoreDBContext(optionsBuilder.Options));
            
            //Serialization
            //var userList = new List<User>();
            //Task<IEnumerable<User>> desListTask = DeserializeFromFileAsync("users.xml");
            //IEnumerable<User> result = new List<User>();

            //userList.AddRange(result);

            //SerializeToFile("users.xml", userList);

        }


        

    //    private static void SerializeToFile(string fileName, List<User> user)
    //    {
    //        var serializer = new XmlSerializer(typeof(List<User>));
    //        FileStream fileStream = null;

    //        try
    //        {
    //            fileStream = new FileStream(fileName, FileMode.Create);
    //            serializer.Serialize(fileStream, user);
    //        }
    //        catch (PathTooLongException m)
    //        {
    //            Console.WriteLine($"Path {fileName} was too long! {m.Message}");
    //        }
    //        catch (IOException m)
    //        {
    //            Console.WriteLine(m.Message);
    //        }
    //        catch (Exception m)
    //        {
    //            Console.WriteLine(m.Message);
    //            throw;
    //        }
    //        finally
    //        {
    //            if (fileStream != null)
    //            {
    //                fileStream.Dispose();
    //            }
    //        }
    //    }

    //    private async static Task<IEnumerable<User>> DeserializeFromFileAsync(string fileName)
    //    {
    //        var serializer = new XmlSerializer(typeof(List<User>));

    //        using (var memoryStream = new MemoryStream())
    //        {
    //            using (var fileStream = new FileStream(fileName, FileMode.Open))
    //            {
    //                await fileStream.CopyToAsync(memoryStream);
    //            }
    //            memoryStream.Position = 0;
    //            return (List<User>)serializer.Deserialize(memoryStream);
    //        }
    //    }
    }

       
}
