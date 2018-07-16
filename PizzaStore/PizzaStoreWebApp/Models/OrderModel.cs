using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStoreWebApp.Models
{
    public class OrderModel
    {
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        [Display(Name = "Total Price")]
       
        public decimal Total_Price { get; set; }

        [Display(Name = "Date")]
        public DateTime OrderTime { get; set; } = DateTime.Now;

        [Display(Name = "Store ID")]
        public int Store_ID { get; set; }

        [Display(Name = "Store Location")]
        public string Store_Location { get; set; }

        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "Customer First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Customer Last Name")]
        public string LastName { get; set; }



        public OrderModel() { }

        public OrderModel(int store_ID, int user_ID)
        {
            Store_ID = store_ID;
            UserID = user_ID;
        }

        public List<SelectListItem> Store = new List<SelectListItem>
        {
            new SelectListItem{ Value = "1", Text = "San Juan"},
            new SelectListItem{ Value = "2", Text = "Carolina"},
            new SelectListItem{ Value = "3", Text = "Fajardo"}
        };

        

       
    }
}
