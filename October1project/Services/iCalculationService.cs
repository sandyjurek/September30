using October1project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace October1project.Services
{
    public interface ICalculationService
    {
        CalculatorInputViewModel Calculate(CalculatorInputViewModel model);
    }
}