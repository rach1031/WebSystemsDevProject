using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArionDevelopment.Models;

namespace ArionDevelopment.Controllers
{
    public class CalcController : Controller
    {
        // GET: /Home/    

            
        
        [HttpGet]
        public ActionResult Index()
        {

            return View();

        }
        

        [HttpPost]

        public ActionResult Index(Calc model)
        {

            double AIR = model.AnnualIntRate;
            double LT = model.LoanTerm;
            

            double LoanAmount = model.CarCost - model.DownPayment;

            double MIR = (AIR / 12) / 100;

            double MonthlyPayment = LoanAmount * ((MIR * Math.Pow((1 + MIR), LT)) / (Math.Pow((1 + MIR), LT) - 1));

            MonthlyPayment = Math.Floor(MonthlyPayment * 100) / 100;

            model.MonthlyPayment = MonthlyPayment;

           

            return View(model);
        }
    }
}
