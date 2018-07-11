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

            User user = new User(); 
            //Order order = new Order(); 
            // var orderList = new List<Order>();
            //var userList = new List<User>();

            //user.UserInfo(); 
            //SerializeToFile("UserData.xml", userList); 
           
           
            //Console.ReadLine();  //This makes the program to pause. 

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

            var repo = new UserRepository(new PizzaStoreDBContext(optionsBuilder.Options));

            Console.WriteLine("Welcome to Pizza PR");
            user.UserInfo();



            //Serialization
            var userList = new List<User>();
            Task<IEnumerable<User>> desListTask = DeserializeFromFileAsync("users.xml");
            IEnumerable<User> result = new List<User>();

            userList.AddRange(result);
           
            SerializeToFile("users.xml", userList);

            
         
        }


        private static void SerializeToFile(string fileName, List<User> user)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(fileStream, user); 
            }catch(PathTooLongException m)
            {
                Console.WriteLine($"Path {fileName} was too long! {m.Message}");
            }
            catch(IOException m)
            {
                Console.WriteLine(m.Message); 
            }
            catch(Exception m)
            {
                Console.WriteLine(m.Message);
                throw; 
            }
            finally
            {
                if(fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }

        private async static Task<IEnumerable<User>> DeserializeFromFileAsync(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<User>));

            using (var memoryStream = new MemoryStream())
            {
                using (var fileStream = new FileStream(fileName, FileMode.Open))
                {
                    await fileStream.CopyToAsync(memoryStream);
                }
                memoryStream.Position = 0;
                return (List<User>)serializer.Deserialize(memoryStream); 
            }
        }


       
}
