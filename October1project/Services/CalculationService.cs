using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using October1project.Models;

namespace October1project.Services
{
    public class CalculationService : ICalculationService
    {
        public CalculatorInputViewModel Calculate(CalculatorInputViewModel model)
        {
            switch (model.Action)
            {
                case CalculatorType.Add:
                    model.Result = (model.InputOne + model.InputTwo).ToString();
                    break;
                case CalculatorType.Subtract:
                    model.Result = (model.InputOne - model.InputTwo).ToString();
                    break;
                case CalculatorType.Multiply:
                    model.Result = (model.InputOne * model.InputTwo).ToString();
                    break;
                case CalculatorType.Divide:
                    model.Result = (model.InputOne / model.InputTwo).ToString();
                    break;
            }
            return model;
        }
    }
}