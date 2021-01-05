using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ArionDevelopment.Models
{
    public class Calc
    {
        [Required(ErrorMessage = "Please enter the cost of the car.")]
        public double CarCost { get; set; }

        [Required(ErrorMessage = "Enter zero if no down payment.")]
        public double DownPayment { get; set; }

        [Required]
        [Range(36, 72, ErrorMessage = "Loan term must be between 36 and 72 months")]
        public double LoanTerm { get; set; }

        [Required]
        [Range(3, 10, ErrorMessage = "Enter Annual Interest Rate between 3 and 10")]
        public double AnnualIntRate { get; set; }

      

        public double MonthlyPayment { get; set; }

       
      


    }
}
