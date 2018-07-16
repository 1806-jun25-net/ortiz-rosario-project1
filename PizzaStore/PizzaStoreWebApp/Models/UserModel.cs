using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStoreWebApp.Models
{
    public class UserModel
    {

        //public UserModel() { }

        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength =2)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, MinimumLength = 2)]
        public string LastName{ get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(12, MinimumLength = 10)]
        public string MobileNumber { get; set; }

        //public string PrefLoc { get; set; }
       
        

       
    }
}
