using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStoreWebApp.Models
{
    public class PizzaModel
    {
        [Display(Name = "Pizza ID")]
        public int PizzaId { get; set; }

        [Display(Name = "Pizza Size")]
        public string PizzaSizes { get; set; }

        [Display(Name = "Pizza Name")]
        public string PizzaName { get; set; }

        [Display(Name = "Number of Pizzas")]
        [Range(1, 12)]
        public int Count { get; set; }
        
        [Display(Name = "Pizza Price per Size")]
        public decimal PizzaPriceperSize { get; set; }

        public List<SelectListItem> PizzaName = new List<SelectListItem>
        {
            new SelectListItem{Value = "1", Text = "Cheese"},
            new SelectListItem{Value = "2", Text = "Pepperoni"},
            new SelectListItem{Value = "3", Text = "Sausage" },
            new SelectListItem{Value = "4", Text = "Bacon"},
            new SelectListItem{Value = "5", Text = "Supreme"}
        };

        public List<SelectListItem> PizzaSize = new List<SelectListItem>
        {
            new SelectListItem{Value ="S", Text = "Small"},
            new SelectListItem{Value ="M", Text = "Medium"},
            new SelectListItem{Value ="L", Text = "Large"},
            new SelectListItem{Value ="XL", Text = "X-Large"}
        };


    }
}
