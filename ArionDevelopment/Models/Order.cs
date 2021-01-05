using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ArionDevelopment.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [BindNever]
        public bool Shipped { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        public bool Pickup { get; set; }


        [Required (ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }

        public string Line2 { get; set; }
        
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set;}
        [Required(ErrorMessage = "Please enter a zip code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter a valid credit card")]
        //[CreditCard] //Had to remove this validation as currently cannot accept true credit cards.
        public string CreditCard { get; set; }

        [Required(ErrorMessage = "Please enter the expiration month")]
        [Range(1, 12, ErrorMessage = "Invalid Month Number")]
        public int ExpireMonth { get; set; }

        [Required(ErrorMessage = "Please enter four digits for the expiration year")]
        [Range(2020, 2024, ErrorMessage = "Invalid Year")]
        public int ExpireYear { get; set; }

        [Required(ErrorMessage = "Please enter the 3 digit Security Code")]
        public int CVC { get; set; }
    }
}
