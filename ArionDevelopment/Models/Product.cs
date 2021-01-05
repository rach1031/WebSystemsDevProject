using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ArionDevelopment.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter the color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Please enter the body type")]
        public string BodyType { get; set; }

        [Required(ErrorMessage = "Please enter the vehicle make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter the vehicle model")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please enter the year of the vehicle")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter the mileage")]
        public int Mileage { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter the number of seats")]
        public int NumberOfSeats { get; set; }
        [Required(ErrorMessage = "Please enter the City mpg")]
        public int CityMPG { get; set; }

        [Required(ErrorMessage = "Please enter the Highway mpg")]
        public int HighwayMPG { get; set; }
        [Required(ErrorMessage = "Please enter the store location of the vehicle")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please enter the daily rental rate of the vehicle")]
        public decimal DailyRate { get; set; }

        public string Picture { get; set; }

    }
}
