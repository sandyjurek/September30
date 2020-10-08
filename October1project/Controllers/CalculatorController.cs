using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using October1project.Models;
using October1project.Services;

namespace October1project.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculationService _calculationService;

        public CalculatorController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }


        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult CalculateResult(CalculatorInputViewModel model)
        {
            //var calcService = new CalculationService();
            var calculatorInputViewModel = _calculationService.Calculate(model);
            //_calculationService.PrintName();
            var viewResult = calculatorInputViewModel.Result;


            //do some work of validating the user input
            //do some work of actually calculating
            //display the results of all the above work somehow???
            //display it in the currrent page?
            //display it in another page?  this is the best choice because 'Result' could have lots of results
            //do we need another model?
            //do we need another view?
            return View(viewResult);
    }
    }
}
